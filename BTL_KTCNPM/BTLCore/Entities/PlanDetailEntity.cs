using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTLCore.Entities {
    public class PlanDetailEntity : BaseEntity
    {
        private TechniqueEntity _technique;
        private double _txFactor;

        public TechniqueEntity Technique {
            get
            {
                return _technique;
            }
            set
            {
                _technique = value;
                NotifyPropertyChanged("Technique");
            }
        }
        public double TxFactor {
            get { return _txFactor; }
            set
            {
                _txFactor = value;
                NotifyPropertyChanged("TxFactor");
            }
        }
    }
}
