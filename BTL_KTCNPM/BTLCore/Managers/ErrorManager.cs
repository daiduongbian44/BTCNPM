using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLCore.Entities;

namespace BTLCore.Managers {
    public class ErrorManager {
        public static ObservableCollection<ErrorEntity> ListErrors { get; set; }

        static ErrorManager()
        {
            ListErrors = new ObservableCollection<ErrorEntity>();
        }
    }
}
