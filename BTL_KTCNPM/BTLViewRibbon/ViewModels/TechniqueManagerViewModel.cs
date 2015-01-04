using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLViewRibbon.Helpers;
using BTLCore.Entities;
using BTLCore.Managers;
using System.Windows;
using System.Windows.Input;
using BTLCore.Function;

namespace BTLViewRibbon.ViewModels
{
    public class TechniqueManagerViewModel : BaseViewModel
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

        #region TextNewUx
        private String _textNewUx;
        public String TextNewUx
        {
            get { return _textNewUx; }
            set
            {
                _textNewUx = value;
                NotifyPropertyChanged("TextNewUx");
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

        public ICommand SelectionTechniqueChangeCommand
        {
            get
            {
                return new PrimativeCommand(ExeSelectionTechniqueChangeCommand, CanSelectionTechniqueChangeCommand);
            }
        }

        #endregion

        public ObservableCollection<TechniqueEntity> ListTechniques
        {
            get
            {
                return TechniqueManager.ListTechniques;
            }
        }

        public TechniqueEntity TechniqueEntitySelected { get; set; }

        public TechniqueManagerViewModel()
        {
            IsReceiveCommand = true;
            IsGridBoxEnable = true;
            IsGridBoxNewEnable = false;
            IsGridBoxUpdateEnable = false;
        }

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

        #region UpdateCommand
        public bool CanUpdateCommand()
        {
            return IsReceiveCommand && TechniqueEntitySelected != null;
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
            return IsReceiveCommand && TechniqueEntitySelected != null;
        }

        public void ExeDeleteCommand()
        {
            var items = TERelationshipManager.ListTERelationship
                .Where(p => p.Technique == TechniqueEntitySelected).ToList();
            for (int i = items.Count - 1; i >= 0; --i)
            {
                var item = items[i];
                TERelationshipManager.ListTERelationship.Remove(item);
            }

            ListTechniques.Remove(TechniqueEntitySelected);
            TechniqueEntitySelected = null;
        }
        #endregion

        #region AddButtonCommand
        public bool CanAddButtonCommand()
        {
            return !IsReceiveCommand;
        }

        public void ExeAddButtonCommand()
        {
            if (String.IsNullOrEmpty(TextNewName)
                || String.IsNullOrEmpty(TextNewUx))
            {
                MessageBox.Show("Không được để trống các trường cần nhập!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // check name
            var items = ListTechniques.Where(p => p.Name.ToLower().
                Equals(TextNewName.Trim().ToLower())).ToList();
            if (items.Count > 0)
            {
                MessageBox.Show("Tên đã được sử dụng, vui lòng dùng tên khác!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // casting type
            double ux;
            try
            {
                ux = double.Parse(TextNewUx);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi dữ liệu với các trường số liệu!", "Thông báo",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            TechniqueEntity entity = new TechniqueEntity();
            entity.Name = TextNewName.Trim();
            entity.UFactor = ux;
            ListTechniques.Add(entity);

            // create relationship with all other errors
            foreach (var item in ErrorManager.ListErrors)
            {
                TERelationshipManager.ListTERelationship.Add(new TERelationshipEntity()
                {
                    Error = item,
                    Function = new LinearFunction(1),
                    Technique = entity,
                    Vx = 0
                });
            }

            TextNewName = "";
            TextNewUx = "";

            IsGridBoxNewEnable = false;
            IsGridBoxEnable = true;
            IsReceiveCommand = true;
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
                || String.IsNullOrEmpty(TextNewUx))
            {
                MessageBox.Show("Không được để trống các trường cần nhập!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // check name
            var item = ListTechniques.Where(p => p.Name.ToLower().
                Equals(TextNewName.Trim().ToLower()) && !
                p.Name.ToLower().Equals(TechniqueEntitySelected.Name.ToLower())).ToList();
            if (item.Count > 0)
            {
                MessageBox.Show("Tên đã được sử dụng, vui lòng dùng tên khác!", "Thông báo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // casting type
            double ux;
            try
            {
                ux = double.Parse(TextNewUx);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi dữ liệu với các trường số liệu!", "Thông báo",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            TechniqueEntity entity = TechniqueEntitySelected;
            entity.Name = TextNewName.Trim();
            entity.UFactor = ux;

            IsGridBoxUpdateEnable = false;
            IsGridBoxEnable = true;
            IsReceiveCommand = true;
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
                if (TechniqueEntitySelected != null)
                {
                    TextNewName = TechniqueEntitySelected.Name;
                    TextNewUx = TechniqueEntitySelected.UFactor.ToString();
                }
            }
            else
            {
                TechniqueEntitySelected = null;
            }
        }

        #endregion
    }
}
