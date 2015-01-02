using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTLCore.Interfaces;

namespace BTLCore.Entities {
    public class TERelationshipEntity : BaseEntity
    {
        private TechniqueEntity _technique;
        private ErrorEntity _error;
        private double _vx;
        private IFunction _function;

        public TechniqueEntity Technique
        {
            get { return _technique; }
            set
            {
                _technique = value;
                NotifyPropertyChanged("Technique");
            }
        }
        public ErrorEntity Error {
            get { return _error; }
            set
            {
                _error = value;
                NotifyPropertyChanged("Error");
            }
        }
        public double Vx {
            get { return _vx; }
            set
            {
                _vx = value;
                NotifyPropertyChanged("Vx");
            }
        }
        public IFunction Function {
            get { return _function; }
            set
            {
                _function = value;
                NotifyPropertyChanged("Function");
            }
        }
    }
}
