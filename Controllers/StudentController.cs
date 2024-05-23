using MiniProject_StudentPlacement.Models;
using MiniProject_StudentPlacement.Models.validationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject_StudentPlacement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            GHTPlacement dbo = new GHTPlacement();
            List<tblStudent> students = dbo.tblStudents.ToList();
            List<tblPlacement> placements = dbo.tblPlacements.ToList();
            student_placement_combine spc = new student_placement_combine();
            spc.students = students;
            spc.placements= placements;
            return View(spc);
        }
    }
}