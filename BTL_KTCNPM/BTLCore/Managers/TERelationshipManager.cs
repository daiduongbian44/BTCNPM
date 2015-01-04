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

        public static TERelationshipEntity FindEntity(ErrorEntity error, TechniqueEntity technique)
        {
            var items = ListTERelationship.
                Where(p => p.Error == error && p.Technique == technique).ToList();
            if (items.Count() <= 0)
            {
                throw new Exception("Can't find this entity");
            }
            return items[0];
        }
    }
}
