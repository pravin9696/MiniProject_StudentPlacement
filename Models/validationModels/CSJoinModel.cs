using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject_StudentPlacement.Models.validationModels
{
    public class CSJoinModel
    {
        public int id { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> placementID { get; set; }

        public virtual tblCours tblCours { get; set; }
        public virtual tblPlacement tblPlacement { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}