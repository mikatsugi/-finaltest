using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.name = "劉紘維";
            ViewBag.number = "410603901";
            return View();
        }
    }
}