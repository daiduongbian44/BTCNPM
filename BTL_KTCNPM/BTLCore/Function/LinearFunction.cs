using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BTLCore.Interfaces;

namespace BTLCore.Function {

    /// <summary>
    /// mx + b
    /// </summary>
    public class LinearFunction : IFunction {
        public double BFactor { get; set; }
        public double MFactor { get; set; }

        public LinearFunction(double mF)
            : this(mF, 1) {
        }

        public LinearFunction(double mF, double bF) {
            BFactor = bF;
            MFactor = mF;
        }

        public double GetValue(double variable) {
            return MFactor * variable + BFactor;
        }
    }
}
