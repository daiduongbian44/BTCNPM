using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using BTLCore.Entities;

namespace BTLCore.Managers
{
    public class TERelationshipManager
    {
        public static ObservableCollection<TERelationshipEntity> ListTERelationship { get; set; }

        static TERelationshipManager()
        {
            ListTERelationship = new ObservableCollection<TERelationshipEntity>();
        }
    }
}
