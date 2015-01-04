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
            TechniqueManagerView view = new TechniqueManagerView();
            view.ShowDialog();
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


        public ErrorEntity ErrorEntitySelected { get; set; }
        public TechniqueEntity TechniqueEntitySelected { get; set; }

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
            }
            else
            {
                ErrorEntitySelected = null;
            }
        }

        #endregion
    }
}
