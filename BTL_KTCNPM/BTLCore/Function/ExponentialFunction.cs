using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTLCore.Interfaces;

namespace BTLCore.Function
{
    public class ExponentialFunction : IFunction
    {
        public string Name
        {
            get { return GetName(); }
        }

        public double GetValue(double variable)
        {
            return 0;
        }

        public string GetName()
        {
            return "Exponential function";
        }
    }
}
