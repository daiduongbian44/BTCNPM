using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;
using System.Diagnostics;

namespace BTLViewRibbon.Views
{
    /// <summary>
    /// Interaction logic for ErrorManagerView.xaml
    /// </summary>
    public partial class ErrorManagerView : RibbonWindow
    {
        public ErrorManagerView()
        {
            InitializeComponent();
            this.CommandBindings.Add(new CommandBinding(AddCommand, Add_Executed, Add_CanExecuted));
            this.CommandBindings.Add(new CommandBinding(UpdateCommand, Update_Executed, Update_CanExecuted));
            this.CommandBindings.Add(new CommandBinding(DeleteCommand, Delete_Executed, Delete_CanExecuted));
        }

        public static RoutedCommand AddCommand = new RoutedCommand();
        public static RoutedCommand UpdateCommand = new RoutedCommand();
        public static RoutedCommand DeleteCommand = new RoutedCommand();

        #region AddCommand
        private void Add_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Add");
        }
        private void Add_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        #endregion

        #region UpdateCommand
        private void Update_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("UPdate");
        }
        private void Update_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        #endregion

        #region DeleteCommand
        private void Delete_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Delete");
        }
        private void Delete_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        #endregion
    }
}
