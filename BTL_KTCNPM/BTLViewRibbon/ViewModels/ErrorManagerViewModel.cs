using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

using BTLViewRibbon.Helpers;
using BTLCore.Entities;
using BTLCore.Managers;
using System.Windows.Input;
using BTLCore.Function;

namespace BTLViewRibbon.ViewModels
{
    public class ErrorManagerViewModel : BaseViewModel
    {
        #region IsGridBoxNewEnable
        private bool _isGridBoxNewEnable;
        public bool IsGridBoxNewEnable
        {
            get { return _isGridBoxNewEnable; }
            set
            {
                _isGridBoxNewEnable = value;
                NotifyPropertyChanged("IsGridBoxNewEnable");
            }
        }
        #endregion

        #region IsGridBoxUpdateEnable
        private bool _isGridBoxUpdateEnable;
        public bool IsGridBoxUpdateEnable
        {
            get { return _isGridBoxUpdateEnable; }
            set
            {
                _isGridBoxUpdateEnable = value;
                NotifyPropertyChanged("IsGridBoxUpdateEnable");
            }
        }
        #endregion

        #region IsGridBoxEnable
        private bool _isGridBoxEnable;
        public bool IsGridBoxEnable
        {
            get { return _isGridBoxEnable; }
            set
            {
                _isGridBoxEnable = value;
                NotifyPropertyChanged("IsGridBoxEnable");
            }
        }
        #endregion

        #region IsGridListEnable
        private bool _isGridListEnable;
        public bool IsGridListEnable
        {
            get { return _isGridListEnable; }
            set
            {
                _isGridListEnable = value;
                NotifyPropertyChanged("IsGridListEnable");
            }
        }
        #endregion

        #region TextNewName
        private String _textNewName;
        public String TextNewName
        {
            get { return _textNewName; }
            set
            {
                _textNewName = value;
                NotifyPropertyChanged("TextNewName");
            }
        }
        #endregion

        #region TextNewVf
        private String _textNewVf;
        public String TextNewVf
        {
            get { return _textNewVf; }
            set
            {
                _textNewVf = value;
                NotifyPropertyChanged("TextNewVf");
            }
        }
        #endregion

        #region TextNewCf
        private String _textNewCf;
        public String TextNewCf
        {
            get { return _textNewCf; }
            set
            {
                _textNewCf = value;
                NotifyPropertyChanged("TextNewCf");
            }
        }
        #endregion

        #region TextNewPi
        private String _textNewPi;
        public String TextNewPi
        {
            get { return _textNewPi; }
            set
            {
                _textNewPi = value;
                NotifyPropertyChanged("TextNewPi");
            }
        }
        #endregion

        #region IsReceiveCommand

        private bool _isReceiveCommand;
        public bool IsReceiveCommand
        {
            get { return _isReceiveCommand; }
            set
            {
                _isReceiveCommand = value;
                if (_isReceiveCommand)
                {
                    IsGridListEnable = true;
                }
                else
                {
                    IsGridListEnable = false;
                }
            }
        }

        #endregion

        #region ICommand
        public ICommand AddButtonCommand
        {
            get
            {
                return new DelegateCommand(ExeAddButtonCommand, CanAddButtonCommand);
            }
        }
        
        public ICommand AddCommand
        {
            get
            {
                return new DelegateCommand(ExeAddCommand, CanAddCommand);
            }
        }
        
        public ICommand UpdateButtonCommand
        {
            get
            {
                return new DelegateCommand(ExeUpdateButtonCommand, CanUpdateButtonCommand);
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                return new DelegateCommand(ExeUpdateCommand, CanUpdateCommand);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new DelegateCommand(ExeDeleteCommand, CanDeleteCommand);
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                return new DelegateCommand(ExeCancelCommand, CanCancelCommand);
            }
        }

        public ICommand SelectionErrorChangeCommand
        {
            get
            {
                return new PrimativeCommand(ExeSelectionErrorChangeCommand, CanSelectionErrorChangeCommand);
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

        public ErrorEntity ErrorEntitySelected { get; set; }

        public ErrorManagerViewModel()
        {
            IsReceiveCommand = true;
            IsGridBoxEnable = true;
            IsGridBoxNewEnable = false;
            IsGridBoxUpdateEnable = false;
        }

        #region AddButtonCommand
        public bool CanAddButtonCommand()
        {
            return !IsReceiveCommand;
        }

        public void ExeAddButtonCommand()
        {
            if (String.IsNullOrEmpty(TextNewName)
                || String.IsNullOrEmpty(TextNewVf)
                || String.IsNullOrEmpty(TextNewCf)
                || String.IsNullOrEmpty(TextNewPi))
            {
                MessageBox.Show("Không được để trống các trường cần nhập!", "Thông báo", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // check name
            var items = ListErrors.Where(p => p.Name.ToLower().
                Equals(TextNewName.Trim().ToLower())).ToList();
            if (items.Count > 0)
            {
                MessageBox.Show("Tên đã được sử dụng, vui lòng dùng tên khác!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // casting type
            double vf, cf, pi;
            try
            {
                vf = double.Parse(TextNewVf);
                cf = double.Parse(TextNewCf);
                pi = double.Parse(TextNewPi);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi dữ liệu với các trường số liệu!", "Thông báo",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            ErrorEntity entity = new ErrorEntity();
            entity.Name = TextNewName.Trim();
            entity.VfFactor = vf;
            entity.CfFactor = cf;
            entity.PiFactor = pi;

            ListErrors.Add(entity);

            // create relationship with all other techniques
            foreach (var item in TechniqueManager.ListTechniques)
            {
                TERelationshipManager.ListTERelationship.Add(new TERelationshipEntity()
                {
                    Error = entity,
                    Technique = item,
                    Vx = 0,
                    Function = new LinearFunction(1)
                });
            }

            TextNewCf = "";
            TextNewName = "";
            TextNewPi = "";
            TextNewVf = "";

            IsGridBoxNewEnable = false;
            IsGridBoxEnable = true;
            IsReceiveCommand = true;
        }
        #endregion

        #region AddCommand
        public bool CanAddCommand()
        {
            return IsReceiveCommand;
        }

        public void ExeAddCommand()
        {
            IsReceiveCommand = false;
            IsGridBoxEnable = false;
            IsGridBoxNewEnable = true;
        }
        #endregion

        #region UpdateButtonCommand
        public bool CanUpdateButtonCommand()
        {
            return !IsReceiveCommand;
        }
        public void ExeUpdateButtonCommand()
        {
            if (String.IsNullOrEmpty(TextNewName)
                || String.IsNullOrEmpty(TextNewVf)
                || String.IsNullOrEmpty(TextNewCf)
                || String.IsNullOrEmpty(TextNewPi))
            {
                MessageBox.Show("Không được để trống các trường cần nhập!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // check name
            var item = ListErrors.Where(p => p.Name.ToLower().
                Equals(TextNewName.Trim().ToLower()) && !
                p.Name.ToLower().Equals(ErrorEntitySelected.Name.ToLower())).ToList();

            if (item.Count > 0)
            {
                MessageBox.Show("Tên đã được sử dụng, vui lòng dùng tên khác!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // casting type
            double vf, cf, pi;
            try
            {
                vf = double.Parse(TextNewVf);
                cf = double.Parse(TextNewCf);
                pi = double.Parse(TextNewPi);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi dữ liệu với các trường số liệu!", "Thông báo",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            ErrorEntity entity = ErrorEntitySelected;
            entity.Name = TextNewName.Trim();
            entity.VfFactor = vf;
            entity.CfFactor = cf;
            entity.PiFactor = pi;

            //ListErrors.Add(entity);

            IsGridBoxUpdateEnable = false;
            IsGridBoxEnable = true;
            IsReceiveCommand = true;
        }
        #endregion

        #region UpdateCommand
        public bool CanUpdateCommand()
        {
            return IsReceiveCommand && ErrorEntitySelected != null;
        }

        public void ExeUpdateCommand()
        {
            IsReceiveCommand = false;
            IsGridBoxEnable = false;
            IsGridBoxUpdateEnable = true;
        }
        #endregion

        #region CancelCommand
        public bool CanCancelCommand()
        {
            return !IsReceiveCommand;
        }
        public void ExeCancelCommand()
        {
            IsReceiveCommand = true;
            IsGridBoxNewEnable = false;
            IsGridBoxEnable = true;
            IsGridBoxUpdateEnable = false;
        }
        #endregion

        #region DeleteCommand
        public bool CanDeleteCommand()
        {
            return IsReceiveCommand && ErrorEntitySelected != null;
        }

        public void ExeDeleteCommand()
        {
            
            var items = TERelationshipManager.ListTERelationship
                .Where(p => p.Error == ErrorEntitySelected).ToList();
            for (int i = items.Count() - 1; i >= 0; --i )
            {
                var item = items[i];
                TERelationshipManager.ListTERelationship.Remove(item);
            }

            ListErrors.Remove(ErrorEntitySelected);
            ErrorEntitySelected = null;
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
                if (ErrorEntitySelected != null)
                {
                    TextNewName = ErrorEntitySelected.Name;
                    TextNewCf = ErrorEntitySelected.CfFactor.ToString();
                    TextNewVf = ErrorEntitySelected.VfFactor.ToString();
                    TextNewPi = ErrorEntitySelected.PiFactor.ToString();
                }
            }
            else
            {
                ErrorEntitySelected = null;
            }
        }

        #endregion
    }
}
