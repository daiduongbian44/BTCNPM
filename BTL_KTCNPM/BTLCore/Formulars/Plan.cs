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
        public static ObservableCollection<PlanDetailEntity> ListItemPlans = new ObservableCollection<PlanDetailEntity>();

        // labourRate: $/hour.
        public static double LaborRate { get; set; }

        // Get Direct Cost(Dx)
        public static double GetDirectCost()
        {
            double directCost = 0;
            for (int i = 0; i < ListItemPlans.Count; i++)
            {
                TechniqueEntity techniqueX = ListItemPlans[i].Technique;
                double tx = ListItemPlans[i].TxFactor;
                directCost += ListItemPlans[i].Technique.UFactor;
                directCost += tx * LaborRate;

                // check all error type
                foreach (ErrorEntity error in ErrorManager.ListErrors)
                {
                    double sumTheta = 1 - TERelationshipManager.FindEntity(error, techniqueX).Function.GetValue(tx);
                    for (int j = 0; j < i; j++)
                    {
                        TechniqueEntity techniqueY = ListItemPlans[j].Technique;
                        double ty = ListItemPlans[j].TxFactor;
                        sumTheta *= TERelationshipManager.FindEntity(error, techniqueY).Function.GetValue(ty);
                    }
                    double vx = TERelationshipManager.FindEntity(error, techniqueX).Vx;
                    directCost += sumTheta * vx * error.Count;
                }
            }
            return directCost;
        }

        // get Future Cost (Df)
        public static double GetFutureCost()
        {
            double futureCost = 0;
            foreach (ErrorEntity error in ErrorManager.ListErrors)
            {
                double pi = error.PiFactor;
                double vcf = error.VfFactor + error.CfFactor;
                double sumTheta = 0;
                foreach (PlanDetailEntity plan in ListItemPlans)
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
        public static double GetBenefit()
        {
            double benefit = 0;
            for (int i = 0; i < ListItemPlans.Count; i++)
            {
                TechniqueEntity techniqueX = ListItemPlans[i].Technique;
                double tx = ListItemPlans[i].TxFactor;

                // check all error type
                foreach (ErrorEntity error in ErrorManager.ListErrors)
                {
                    double pi = error.PiFactor;
                    double tmp1 = 1 - TERelationshipManager.FindEntity(error, techniqueX).Function.GetValue(tx);
                    for (int j = 0; j < i; j++)
                    {
                        TechniqueEntity techniqueY = ListItemPlans[j].Technique;
                        double ty = ListItemPlans[j].TxFactor;
                        tmp1 *= TERelationshipManager.FindEntity(error, techniqueY).Function.GetValue(ty);
                    }
                    double vcf = error.VfFactor + error.CfFactor;
                    benefit += pi * tmp1 * vcf * error.Count;
                }
            }
            return benefit;
        }

        public static double GetTotalCost()
        {
            return GetDirectCost() + GetFutureCost();
        }

        public static double GetProfit()
        {
            return GetBenefit() - GetTotalCost();
        }

        public static double GetRoi()
        {
            return GetProfit() / GetTotalCost();
        }
    }
}
