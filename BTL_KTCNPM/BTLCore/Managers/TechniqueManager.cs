using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLCore.Entities;

namespace BTLCore.Managers {
    public class TechniqueManager {
        public static ObservableCollection<TechniqueEntity> ListTechniques { get; set; }

        static TechniqueManager()
        {
            ListTechniques = new ObservableCollection<TechniqueEntity>();
        }
    }
}
