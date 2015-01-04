using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTLCore.Entities {
    public class TechniqueEntity : BaseEntity
    {
        private double _uFactor;
        private string _name;

        private static int _counter = 1;

        public int STT { get; set; }

        public TechniqueEntity()
        {
            STT = _counter;
            _counter++;
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
