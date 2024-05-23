using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject_StudentPlacement.Models.validationModels
{
    public class CoursModel
    {
        public int crId { get; set; }
        public string Course_name { get; set; }
        public int fees { get; set; }
        public virtual ICollection<tblCSJoin> tblCSJoins { get; set; }
    }
}