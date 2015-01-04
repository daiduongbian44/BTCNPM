using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTLCore.Interfaces {
    public interface IFunction {
        double GetValue(double variable);
        string Name { get; }
    }
}
