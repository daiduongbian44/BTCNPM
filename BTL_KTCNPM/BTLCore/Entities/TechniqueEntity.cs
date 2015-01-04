using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTLCore.Managers;

namespace BTLCore.Entities {

    [Serializable]
    public class TechniqueEntity : BaseEntity
    {
        private double _uFactor;
        private string _name;

        public int STT { get; set; }

        public TechniqueEntity()
        {
            STT = TechniqueManager.ListTechniques.Count + 1;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public double UFactor { 
            get { return _uFactor; }
            set
            {
                _uFactor = value;
                NotifyPropertyChanged("UFactor");
            }
        }
    }
}
