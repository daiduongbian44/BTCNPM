using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BTLCore.Interfaces;
using System.ComponentModel;

namespace BTLCore.Function {

    /// <summary>
    /// mx + b
    /// </summary>
    [Serializable]
    public class LinearFunction : IFunction, INotifyPropertyChanged {
        private double _bFactor;
        private double _mFactor;

        #region ImageFunction
        private Uri _imageFunction;
        public Uri ImageFunction
        {
            get { return _imageFunction; }
            set
            {
                _imageFunction = value;
                NotifyPropertyChanged("ImageFunction");
            }
        }
        #endregion

        public double BFactor {
            get { return _bFactor; }
            set
            {
                _bFactor = value;
                NotifyPropertyChanged("BFactor");
            }
        }
        public double MFactor
        {
            get { return _mFactor; }
            set
            {
                _mFactor = value;
                NotifyPropertyChanged("MFactor");
            }
        }

        public double ParamFactor
        {
            get { return MFactor; }
            set
            {
                MFactor = value;
            }
        }

        public string Name
        {
            get { return GetName(); }
        }

        public LinearFunction(double mF)
            : this(mF, 1) {
        }

        public LinearFunction(double mF, double bF) {
            BFactor = bF;
            MFactor = mF;
            ImageFunction = new Uri("pack://application:,,,/Images/linear.png");
        }

        // set up function
        public double GetValue(double variable)
        {
            if (-0.00001 < MFactor && MFactor < 0.00001)
            {
                return 1;
            }
            if (variable >= 0 && variable <= (-1 / MFactor))
            {
                return MFactor * variable + 1;
            }
            else if (variable > (-1 / MFactor))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public string GetName()
        {
            return "Linear function";
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
