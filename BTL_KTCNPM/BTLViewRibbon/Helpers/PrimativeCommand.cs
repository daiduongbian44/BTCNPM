using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace BTLViewRibbon.Helpers
{
    public class PrimativeCommand : ICommand
    {
        public Func<object, bool> CanExecuteAction { get; set; }
        public Action<object> ExecuteAction { get; set; }

        public PrimativeCommand(Action<object> ExecuteAction, Func<object, bool> CanExecuteAction)
        {
            this.CanExecuteAction = CanExecuteAction;
            this.ExecuteAction = ExecuteAction;
        }

        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteAction != null) return this.CanExecuteAction(parameter);
            return false;
        }

        public void Execute(object parameter)
        {
            if (this.ExecuteAction != null) this.ExecuteAction(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
