using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BTLViewRibbon.Models
{
    public class SelectionService
    {
        public ObservableCollection<ISelectable> ListSelections { get; set; }

        public SelectionService()
        {
            ListSelections = new ObservableCollection<ISelectable>();
        }

        public void SetSelection(ISelectable item)
        {
            ClearListSelection();
            AddSelection(item);
        }

        public void AddSelection(ISelectable item)
        {
            item.IsSelected = true;
            ListSelections.Add(item);
        }

        public void ClearListSelection()
        {
            foreach (var item in ListSelections)
            {
                item.IsSelected = false;
            }
            ListSelections.Clear();
        }
    }
}
