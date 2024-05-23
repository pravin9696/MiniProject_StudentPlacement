using MiniProject_StudentPlacement.Models;
using MiniProject_StudentPlacement.Models.validationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject_StudentPlacement.Controllers
{
    public class HomeController : Controller
    {
        GHTPlacement _dbContext = new GHTPlacement();
        public ActionResult signup()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Login(loginModel lgm)
        {
            var lg = _dbContext.tblLogins.FirstOrDefault(x => x.userID == lgm.userID && x.password == lgm.password);
            if (lg != null)
            {
                if (lg.isActive == false)
                {
                    ViewBag.ActiveError = "User not activated yet!!! please contact Admin...";
                    return View();
                }
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult combineView()
        {
            return View();
        }
    }
}