using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TestMvvmBinding.Helpers;
using TestMvvmBinding.Models;
using System.Windows;

namespace TestMvvmBinding.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Properties

        #region MyDateTime

        private DateTime _myDateTime;
        public DateTime MyDateTime
        {
            get { return _myDateTime; }
            set
            {
                if (_myDateTime != value)
                {
                    _myDateTime = value;
                    RaisePropertyChanged(() => MyDateTime);
                }
            }
        }

        #endregion

        #region PersonsCollection

        private ObservableCollection<Person> _personsCollection;
        public ObservableCollection<Person> PersonsCollection
        {
            get { return _personsCollection; }
            set
            {
                if (_personsCollection != value)
                {
                    _personsCollection = value;
                    RaisePropertyChanged(() => PersonsCollection);
                }
            }
        }

        #endregion

        public int ValueSlider { get; set; }

        #endregion

        #region Commands

        public ICommand RefreshDateCommand { get { return new DelegateCommand(OnRefreshDate); } }
        public ICommand RefreshPersonsCommand { get { return new DelegateCommand(OnRefreshPersons); } }
        public ICommand DoNothingCommand { get { return new DelegateCommand(OnDoNothing, CanExecuteDoNothing); } }

        public ICommand ParammeterCommand { get; set; }
       
        #endregion

        #region Ctor
        public MainWindowViewModel()
        {
            RandomizeData();
            ParammeterCommand = new TestCommand();
        }

        class TestCommand : ICommand
        {

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                Person person = parameter as Person;
                if (person != null)
                {
                    MessageBox.Show(person.Name);
                }
                else
                {
                    MessageBox.Show("Null");
                }
            }
        }

        #endregion

        #region Command Handlers

        private void OnRefreshDate()
        {
            MyDateTime = DateTime.Now; 
            MessageBox.Show(ValueSlider.ToString());
        }

        private void OnRefreshPersons()
        {
            RandomizeData();
        }

        private void OnDoNothing()
        {
        }

        private bool CanExecuteDoNothing()
        {
            return false;
        }

        #endregion

        private void RandomizeData()
        {
            PersonsCollection = new ObservableCollection<Person>();

            for (var i = 0; i < 10; i++)
            {
                PersonsCollection.Add(new Person(
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomInt(1, 43),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomNumber(50, 180, 1),
                    RandomHelper.RandomDate(new DateTime(1980, 1, 1), DateTime.Now),
                    RandomHelper.RandomColor()
                    ));
            }
        }
    }
}