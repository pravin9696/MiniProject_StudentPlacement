using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject_StudentPlacement.Models.validationModels
{
    public class RoleMgtModel
    {
        public int id { get; set; }
        public Nullable<int> loginID { get; set; }
        public string role { get; set; }

        public virtual tblLogin tblLogin { get; set; }
    }
}