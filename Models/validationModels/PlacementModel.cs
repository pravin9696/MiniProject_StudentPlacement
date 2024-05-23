using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject_StudentPlacement.Models.validationModels
{
    public class PlacementModel
    {
        public int pid { get; set; }
        public string company_name { get; set; }
        public Nullable<int> package { get; set; }
        public Nullable<System.DateTime> Placement_date { get; set; }
        public virtual ICollection<tblCSJoin> tblCSJoins { get; set; }
    }
}