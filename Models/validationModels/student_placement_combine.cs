using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject_StudentPlacement.Models.validationModels
{
    public class student_placement_combine
    {
        public List<tblStudent> students { get; set; }
        public List<tblPlacement> placements { get; set; }
    }
}