using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject_StudentPlacement.Models.validationModels
{
    public class StudentModel
    {
        public int Sid { get; set; }
        public string student_name { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> contact { get; set; }
        public string Address { get; set; }

      
        public virtual ICollection<tblCSJoin> tblCSJoins { get; set; }
    }
}