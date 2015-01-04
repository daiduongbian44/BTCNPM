using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLCore.Entities;
using BTLCore.Managers;

namespace BTLCore.Formulars
{
    public class Plan
    {
        public ObservableCollection<PlanDetailEntity> ListItemPlan;

        // labourRate: $/hour.
        public double labourRate = 3;

        // Get Direct Cost(Dx)
        public double GetDirectCost()
        {
            double directCost = 0;
            for (int i = 0; i < ListItemPlan.Count; i++)
            {
                TechniqueEntity techniqueX = ListItemPlan[i].Technique;
                double tx = ListItemPlan[i].TxFactor;
                directCost += ListItemPlan[i].Technique.UFactor;
                directCost += tx * labourRate;

                // check all error type
                foreach (ErrorEntity error in ErrorManager.ListErrors)
                {
                    double sumTheta = 1 - TERelationshipManager.FindEntity(error, techniqueX).Function.GetValue(tx);
                    for (int j = 0; j < i; j++)
                    {
                        TechniqueEntity techniqueY = ListItemPlan[j].Technique;
                        double ty = ListItemPlan[j].TxFactor;
                        sumTheta *= TERelationshipManager.FindEntity(error, techniqueY).Function.GetValue(ty);
                    }
                    double vx = TERelationshipManager.FindEntity(error, techniqueX).Vx;
                    directCost += sumTheta * vx * error.Count;
                }
            }
            return directCost;
        }

        // get Future Cost (Df)
        public double GetFutureCost()
        {
            double futureCost = 0;
            foreach (ErrorEntity error in ErrorManager.ListErrors)
            {
                double pi = error.PiFactor;
                double vcf = error.VfFactor + error.CfFactor;
                double sumTheta = 0;
                foreach (PlanDetailEntity plan in ListItemPlan)
                {
                    TechniqueEntity technique = plan.Technique;
                    double tx = plan.TxFactor;
                    sumTheta += TERelationshipManager.FindEntity(error, technique).Function.GetValue(tx);
                }
                futureCost += pi * sumTheta * vcf * error.Count;
            }
            return futureCost;
        }

        // get Benefit (Revenue)
        public double GetBenefit()
        {
            double benefit = 0;
            for (int i = 0; i < ListItemPlan.Count; i++)
            {
                TechniqueEntity techniqueX = ListItemPlan[i].Technique;
                double tx = ListItemPlan[i].TxFactor;

                // check all error type
                foreach (ErrorEntity error in ErrorManager.ListErrors)
                {
                    double pi = error.PiFactor;
                    double tmp1 = 1 - TERelationshipManager.FindEntity(error, techniqueX).Function.GetValue(tx);
                    for (int j = 0; j < i; j++)
                    {
                        TechniqueEntity techniqueY = ListItemPlan[j].Technique;
                        double ty = ListItemPlan[j].TxFactor;
                        tmp1 *= TERelationshipManager.FindEntity(error, techniqueY).Function.GetValue(ty);
                    }
                    double vcf = error.VfFactor + error.CfFactor;
                    benefit += pi * tmp1 * vcf * error.Count;
                }
            }
            return benefit;
        }
    }
}
