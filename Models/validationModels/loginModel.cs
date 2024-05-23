using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject_StudentPlacement.Models.validationModels
{
    public class loginModel
    {
        public int id { get; set; }
        public string userID { get; set; }
        public string password { get; set; }
        public Nullable<bool> isActive { get; set; }

        public virtual ICollection<tblRoleMgt> tblRoleMgts { get; set; }
    }
}