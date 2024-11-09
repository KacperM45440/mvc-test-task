using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Helpers;

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
            List<ComboBoxItem> items = DataHelper.GetYears(DateTime.Now);

            var selectList = items.Select(item => new SelectListItem
            {
                Value = item.ID.ToString(),
                Text = item.FullName
            }).ToList();

            ViewBag.Years = selectList;

            return View();
        }

        [HttpPost]
        public ActionResult FormSave(int years)
        {
            //ViewBag.Message = "Data posted!" + years.ToString();
            ViewBag.Message = "Data posted!";
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        [HttpPost] [ValidateAntiForgeryToken]
        public ActionResult Student(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("StudentSave", model);
        }

        public ActionResult StudentSave(Student model)
        {
            ViewBag.Message = "Student data successfully submitted!";
            return View(model);
        }
    }
}