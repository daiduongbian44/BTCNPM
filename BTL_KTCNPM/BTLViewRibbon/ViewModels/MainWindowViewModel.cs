using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLCore.Managers;
using BTLViewRibbon.Views;
using System.Windows.Input;
using BTLViewRibbon.Helpers;
using BTLCore.Entities;
using BTLCore.Interfaces;
using BTLCore.Function;
using System.Windows;
using BTLCore.Formulars;

namespace BTLViewRibbon.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region ShowErrorManagerCommand
        public bool CanShowErrorManagerCommand()
        {
            return true;
        }

        public void ExeShowErrorManagerCommand()
        {
            ErrorManagerView view = new ErrorManagerView();
            view.ShowDialog();
        }
        #endregion

        #region ShowTechniqueManagerCommand
        public bool CanShowTechniqueManagerCommand()
        {
            return true;
        }

        public void ExeShowTechniqueManagerCommand()
        {
            TechniqueManagerView view = new TechniqueManagerView();
            view.ShowDialog();
        }
        #endregion

        #region ShowPlanManagerCommand
        public bool CanShowPlanManagerCommand()
        {
            return true;
        }

        public void ExeShowPlanManagerCommand()
        {
            PlanDetailCreateView view = new PlanDetailCreateView();
            view.ShowDialog();
        }
        #endregion

        #region EstimateProjectCommand

        public bool CanEstimateProjectCommand()
        {
            return Plan.ListItemPlans.Count > 0;
        }

        public void ExeEstimateProjectCommand()
        {
            // casting labor cost
            double laborcost;
            try
            {
                laborcost = double.Parse(LaborCost);
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại trường LaborCost, xảy ra lỗi dữ liệu!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // estimate
            Plan.LaborRate = laborcost;
            DirectCost = Plan.GetDirectCost().ToString() ;
            FutureCost = Plan.GetFutureCost().ToString();
            TotalCost = Plan.GetTotalCost().ToString();
            Revenue = Plan.GetBenefit().ToString();
            Profit = Plan.GetProfit().ToString();
            ROI = Plan.GetRoi().ToString();
        }

        #endregion

        #region ClearCurrentProjectCommand

        public bool CanClearCurrentProjectCommand()
        {
            return Plan.ListItemPlans.Count > 0;
        }

        public void ExeClearCurrentProjectCommand()
        {
            Plan.ListItemPlans.Clear();
            DirectCost = "";
            FutureCost = "";
            TotalCost = "";
            Revenue = "";
            Profit = "";
            ROI = "";
        }

        #endregion

        #region ICommand

        public ICommand ShowErrorManagerCommand
        {
            get
            {
                return new DelegateCommand(ExeShowErrorManagerCommand, CanShowErrorManagerCommand);
            }
        }
        public ICommand ShowTechniqueManagerCommand
        {
            get
            {
                return new DelegateCommand(ExeShowTechniqueManagerCommand, CanShowTechniqueManagerCommand);
            }
        }
        public ICommand ShowPlanManagerCommand
        {
            get
            {
                return new DelegateCommand(ExeShowPlanManagerCommand, CanShowPlanManagerCommand);
            }
        }

        public ICommand SelectionErrorChangeCommand
        {
            get
            {
                return new PrimativeCommand(ExeSelectionErrorChangeCommand, CanSelectionErrorChangeCommand);
            }
        }
        public ICommand SelectionTechniqueChangeCommand
        {
            get
            {
                return new PrimativeCommand(ExeSelectionTechniqueChangeCommand, CanSelectionTechniqueChangeCommand);
            }
        }

        public ICommand ComboboxFunctionSelectionChangeCommand
        {
            get
            {
                return new PrimativeCommand(ExeComboboxFunctionSelectionChangeCommand,
                    CanComboboxFunctionSelectionChangeCommand);
            }
        }

        public ICommand EstimateProjectCommand
        {
            get
            {
                return new DelegateCommand(ExeEstimateProjectCommand, CanEstimateProjectCommand);
            }
        }

        public ICommand ClearCurrentProjectCommand
        {
            get
            {
                return new DelegateCommand(ExeClearCurrentProjectCommand, CanClearCurrentProjectCommand);
            }
        }

        #endregion

        public ObservableCollection<ErrorEntity> ListErrors
        {
            get
            {
                return ErrorManager.ListErrors;
            }
        }
        public ObservableCollection<TechniqueEntity> ListTechniques
        {
            get
            {
                return TechniqueManager.ListTechniques;
            }
        }

        public ObservableCollection<PlanDetailEntity> ListItemPlans
        {
            get
            {
                return Plan.ListItemPlans;
            }
        }

        #region ListFunctions
        private ObservableCollection<IFunction> _listFunctions;
        public ObservableCollection<IFunction> ListFunctions
        {
            get { return _listFunctions; }
            set
            {
                _listFunctions = value;
            }
        }
        #endregion

        #region ErrorEntitySelected
        private ErrorEntity _errorEntitySelected;
        public ErrorEntity ErrorEntitySelected
        {
            get { return _errorEntitySelected; }
            set
            {
                _errorEntitySelected = value;
                NotifyPropertyChanged("ErrorEntitySelected");
            }
        }
        #endregion

        #region TERelationshipEntitySelected
        private TERelationshipEntity _teRelationshipEntitySelected;
        public TERelationshipEntity TERelationshipEntitySelected
        {
            get { return _teRelationshipEntitySelected; }
            set
            {
                _teRelationshipEntitySelected = value;
                NotifyPropertyChanged("TERelationshipEntitySelected");
            }
        }

        #endregion

        #region TechniqueEntitySelected

        private TechniqueEntity _techniqueEntitySelected;
        public TechniqueEntity TechniqueEntitySelected {
            get { return _techniqueEntitySelected; }
            set
            {
                _techniqueEntitySelected = value;
                NotifyPropertyChanged("TechniqueEntitySelected");
            }
        }

        #endregion

        public MainWindowViewModel()
        {
            ListFunctions = new ObservableCollection<IFunction>
                (new IFunction[] { new LinearFunction(0), new ExponentialFunction() });
        }

        #region KLOC
        private String _kLoc;
        public String KLOC
        {
            get { return _kLoc; }
            set
            {
                _kLoc = value;
                NotifyPropertyChanged("KLOC");

                if (String.IsNullOrEmpty(KLOC) || String.IsNullOrEmpty(ErrorPerKLOC))
                {
                    NumberOfErrors = 0;
                    return;
                }
                try
                {
                    double vKloc = double.Parse(KLOC);
                    double vErorKloc = double.Parse(ErrorPerKLOC);

                    double error = vKloc * vErorKloc;

                    NumberOfErrors = (int)error;
                }
                catch (Exception)
                {
                    NumberOfErrors = 0;
                }
            }
        }
        #endregion

        #region ErrorPerKLOC
        private String _errorPerKloc;
        public String ErrorPerKLOC
        {
            get { return _errorPerKloc; }
            set
            {
                _errorPerKloc = value;
                NotifyPropertyChanged("ErrorPerKLOC");

                if (String.IsNullOrEmpty(KLOC) || String.IsNullOrEmpty(ErrorPerKLOC))
                {
                    NumberOfErrors = 0;
                    return;
                }
                try
                {
                    double vKloc = double.Parse(KLOC);
                    double vErorKloc = double.Parse(ErrorPerKLOC);

                    double error = vKloc * vErorKloc;

                    NumberOfErrors = (int)error;
                }
                catch (Exception)
                {
                    NumberOfErrors = 0;
                }
            }
        }
        #endregion

        #region NumberOfErrors
        private int _numberOfErrors;
        public int NumberOfErrors
        {
            get { return _numberOfErrors; }
            set
            {
                _numberOfErrors = value;
                Plan.NumberOfErrors = value;
                foreach (var item in ErrorManager.ListErrors)
                {
                    item.Count = (int)(Plan.NumberOfErrors * item.PercentError) / (ErrorManager.ListErrors.Count * 100);
                }
                NotifyPropertyChanged("NumberOfErrors");
            }
        }
        #endregion

        #region LaborCost
        private String _laborCost;
        public String LaborCost
        {
            get { return _laborCost; }
            set
            {
                _laborCost = value;
                NotifyPropertyChanged("LaborCost");
            }
        }
        #endregion

        #region DirectCost
        private String _directCost;
        public String DirectCost
        {
            get { return _directCost; }
            set
            {
                _directCost = value;
                NotifyPropertyChanged("DirectCost");
            }
        }
        #endregion

        #region FutureCost
        private String _futureCost;
        public String FutureCost
        {
            get { return _futureCost; }
            set
            {
                _futureCost = value;
                NotifyPropertyChanged("FutureCost");
            }
        }
        #endregion

        #region TotalCost
        private String _totalCost;
        public String TotalCost
        {
            get { return _totalCost; }
            set
            {
                _totalCost = value;
                NotifyPropertyChanged("TotalCost");
            }
        }
        #endregion

        #region Revenue
        private String _revenue;
        public String Revenue
        {
            get { return _revenue; }
            set
            {
                _revenue = value;
                NotifyPropertyChanged("Revenue");
            }
        }
        #endregion

        #region Profit
        private String _profit;
        public String Profit
        {
            get { return _profit; }
            set
            {
                _profit = value;
                NotifyPropertyChanged("Profit");
            }
        }
        #endregion

        #region ROI
        private String _roi;
        public String ROI
        {
            get { return _roi; }
            set
            {
                _roi = value;
                NotifyPropertyChanged("ROI");
            }
        }
        #endregion

        #region VxFactor
        private String _vxFactor;
        public String VxFactor
        {
            get { return _vxFactor; }
            set
            {
                _vxFactor = value;
                NotifyPropertyChanged("VxFactor");
            }
        }
        #endregion

        #region ParamFunction
        private String _paramFunction;
        public String ParamFunction
        {
            get { return _paramFunction; }
            set
            {
                _paramFunction = value;
                NotifyPropertyChanged("ParamFunction");
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
                if (TechniqueEntitySelected != null && ErrorEntitySelected != null)
                {
                    TERelationshipEntitySelected = TERelationshipManager.FindEntity(ErrorEntitySelected, TechniqueEntitySelected);
                }
            }
            else
            {
                TechniqueEntitySelected = null;
            }
        }

        #endregion

        #region SelectionErrorChangeCommand

        public bool CanSelectionErrorChangeCommand(object ob)
        {
            return true;
        }

        public void ExeSelectionErrorChangeCommand(object parameter)
        {
            if (parameter != null)
            {
                ErrorEntitySelected = parameter as ErrorEntity;

                if (TechniqueEntitySelected != null && ErrorEntitySelected != null)
                {
                    TERelationshipEntitySelected = TERelationshipManager.FindEntity(ErrorEntitySelected, TechniqueEntitySelected);
                }
            }
            else
            {
                ErrorEntitySelected = null;
            }
        }

        #endregion

        #region ComboboxFunctionSelectionChange

        public bool CanComboboxFunctionSelectionChangeCommand(object ob)
        {
            return true;
        }

        public void ExeComboboxFunctionSelectionChangeCommand(object parameter)
        {
            if (parameter != null)
            {
                string nameType = parameter as string;

                if (nameType.Equals((new LinearFunction(0)).Name))
                {
                    if (TERelationshipEntitySelected != null)
                    {
                        TERelationshipEntitySelected.Function = new LinearFunction(1);
                    }
                }
                else if (nameType.Equals((new ExponentialFunction()).Name))
                {
                    if (TERelationshipEntitySelected != null)
                    {
                        TERelationshipEntitySelected.Function = new ExponentialFunction();
                    }
                }
            }
        }

        #endregion
    }
}
