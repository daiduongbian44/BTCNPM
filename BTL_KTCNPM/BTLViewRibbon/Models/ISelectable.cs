using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTLViewRibbon.Models
{
    public interface ISelectable
    {
        bool IsSelected { get; set; }
    }
}
