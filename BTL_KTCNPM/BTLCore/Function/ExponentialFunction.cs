﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTLCore.Interfaces;
using System.ComponentModel;

namespace BTLCore.Function
{
    public class ExponentialFunction : IFunction, INotifyPropertyChanged
    {
        public ExponentialFunction()
        {
            ImageFunction = new Uri("pack://application:,,,/Images/Exponent.png");
        }

        private double _lambda;
        public double LambdaFactor
        {
            get { return _lambda; }
            set
            {
                _lambda = value;
                NotifyPropertyChanged("LambdaFactor");
            }
        }

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

        public double ParamFactor
        {
            get
            {
                return LambdaFactor;
            }
            set
            {
                LambdaFactor = value;
            }
        }

        public string Name
        {
            get { return GetName(); }
        }

        public double GetValue(double variable)
        {
            return 1;
        }

        public string GetName()
        {
            return "Exponential function";
        }

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
