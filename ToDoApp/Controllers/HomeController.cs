using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPageContent()
        {
            return PartialView("Content/ContentPartialView");
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }
    }
}