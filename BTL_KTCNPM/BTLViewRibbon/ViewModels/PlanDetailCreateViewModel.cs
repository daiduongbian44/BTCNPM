using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLCore.Entities;
using BTLCore.Managers;
using System.Windows.Input;
using BTLViewRibbon.Helpers;
using BTLCore.Formulars;

namespace BTLViewRibbon.ViewModels
{
    public class PlanDetailCreateViewModel : BaseViewModel
    {
        public ObservableCollection<PlanDetailEntity> ListItemPlans { get; set; }

        public ObservableCollection<TechniqueEntity> ListTechniques
        {
            get
            {
                return TechniqueManager.ListTechniques;
            }
        }

        public TechniqueEntity TechniqueEntitySelected { get; set; }

        public PlanDetailEntity PlanDetailEntitySelected { get; set; }

        public PlanDetailCreateViewModel()
        {
            ListItemPlans = Plan.ListItemPlans;
        }

        #region ICommand
        
        public ICommand SelectionTechniqueChangeCommand
        {
            get
            {
                return new PrimativeCommand(ExeSelectionTechniqueChangeCommand, CanSelectionTechniqueChangeCommand);
            }
        }

        public ICommand SelectionPlanDetailChangeCommand
        {
            get
            {
                return new PrimativeCommand(ExeSelectionPlanDetailChangeCommand, CanSelectionPlanDetailChangeCommand);
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return new DelegateCommand(ExeAddCommand, CanAddCommand);
            }
        }

        public ICommand MoveUpCommand
        {
            get
            {
                return new DelegateCommand(ExeMoveUpCommand, CanMoveUpCommand);
            }
        }

        public ICommand MoveDownCommand
        {
            get
            {
                return new DelegateCommand(ExeMoveDownCommand, CanMoveDownCommand);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new DelegateCommand(ExeDeleteCommand, CanDeleteCommand);
            }
        }

        public ICommand CloseWindowCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Plan.ListItemPlans = ListItemPlans;
                }, null);
            }
        }

        #endregion

        #region SelectionTechniqueChangeCommand

        public bool CanSelectionTechniqueChangeCommand(object ob)
        {
            return true;
        }

        public void ExeSelectionTechniqueChangeCommand(object parameter)
        {
            if (parameter != null)
            {
                TechniqueEntitySelected = parameter as TechniqueEntity;
            }
            else
            {
                TechniqueEntitySelected = null;
            }
        }

        #endregion

        #region SelectionPlanDetailChangeCommand

        public bool CanSelectionPlanDetailChangeCommand(object ob)
        {
            return true;
        }

        public void ExeSelectionPlanDetailChangeCommand(object parameter)
        {
            if (parameter != null)
            {
                PlanDetailEntitySelected = parameter as PlanDetailEntity;
            }
            else
            {
                PlanDetailEntitySelected = null;
            }
        }

        #endregion

        #region AddCommand
        public bool CanAddCommand()
        {
            if (TechniqueEntitySelected != null)
            {
                foreach (var item in ListItemPlans)
                {
                    if (item.Technique == TechniqueEntitySelected)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void ExeAddCommand()
        {
            ListItemPlans.Add(new PlanDetailEntity()
            {
                Technique = TechniqueEntitySelected,
                TxFactor = 0
            });
        }
        #endregion

        #region MoveUpCommand
        public bool CanMoveUpCommand()
        {
            return PlanDetailEntitySelected != null;
        }

        public void ExeMoveUpCommand()
        {
            int selectedIndex = 0;
            for (int i = 0; i < ListItemPlans.Count; ++i)
            {
                if (ListItemPlans[i] == PlanDetailEntitySelected)
                {
                    selectedIndex = i;
                    break;
                }
            }
            if (selectedIndex + 1 < ListItemPlans.Count)
            {
                var itemToMoveDown = ListItemPlans[selectedIndex];
                ListItemPlans.RemoveAt(selectedIndex);
                ListItemPlans.Insert(selectedIndex + 1, itemToMoveDown);
            }
        }
        #endregion

        #region MoveDownCommand
        public bool CanMoveDownCommand()
        {
            return PlanDetailEntitySelected != null;
        }

        public void ExeMoveDownCommand()
        {
            int selectedIndex = ListItemPlans.Count-1;
            for (int i = 0; i < ListItemPlans.Count; ++i)
            {
                if (ListItemPlans[i] == PlanDetailEntitySelected)
                {
                    selectedIndex = i;
                    break;
                }
            }
            if (selectedIndex > 0)
            {
                var itemToMoveUp = PlanDetailEntitySelected;
                ListItemPlans.RemoveAt(selectedIndex);
                ListItemPlans.Insert(selectedIndex - 1, itemToMoveUp);
            }
            
        }
        #endregion

        #region DeleteCommand
        public bool CanDeleteCommand()
        {
            return PlanDetailEntitySelected != null;
        }

        public void ExeDeleteCommand()
        {
            ListItemPlans.Remove(PlanDetailEntitySelected);
            PlanDetailEntitySelected = null;
        }
        #endregion
    }
}
