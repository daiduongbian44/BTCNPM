using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLCore.Entities;
using BTLCore.Managers;

namespace BTLViewRibbon.ViewModels
{
    public class PlanDetailCreateViewModel : BaseViewModel
    {
        public ObservableCollection<PlanDetailEntity> ListItemPlan { get; set; }

    }
}
