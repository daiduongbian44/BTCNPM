using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTLCore.Entities {
    public class ErrorEntity : BaseEntity
    {
        private double _vfFactor;
        private double _cfFactor;
        private double _piFactor;
        private string _name;

        private static int Counter = 1;

        public int STT { get; set; }

        public ErrorEntity()
        {
            STT = Counter;
            Counter++;
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


        public double VfFactor
        {
            get { return _vfFactor; }
            set
            {
                _vfFactor = value;
                NotifyPropertyChanged("VfFactor");
            }
        }
        public double CfFactor {
            get { return _cfFactor; }
            set
            {
                _cfFactor = value;
                NotifyPropertyChanged("CfFactor");
            }
        }
        public double PiFactor {
            get { return _piFactor; }
            set
            {
                _piFactor = value;
                NotifyPropertyChanged("PiFactor");
            }
        }
    }
}
