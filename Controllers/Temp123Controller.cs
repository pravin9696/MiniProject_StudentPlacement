using MiniProject_StudentPlacement.Models;
using MiniProject_StudentPlacement.Models.validationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject_StudentPlacement.Controllers
{
    public class Temp123Controller : Controller
    {
        // GET: Temp123
        public ActionResult Index()
        {
            GHTPlacement gthobj = new GHTPlacement();
            var stud = gthobj.tblStudents.FirstOrDefault();
            return View(stud);
        }
        public ActionResult ShowAll()
        {
            GHTPlacement gthobj = new GHTPlacement();
            List<tblStudent> studs = gthobj.tblStudents.ToList();
            List<tblPlacement> placements = gthobj.tblPlacements.ToList();

            student_placement_combine spc = new student_placement_combine();
            spc.students = studs;
            spc.placements = placements;
            return View(spc);  
        }
    }
}