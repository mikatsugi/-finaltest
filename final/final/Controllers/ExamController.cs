using final.ViewModels;
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

        public ActionResult Week()
        {
            return View(new WeekData());
        }
        [HttpPost]
        public ActionResult Week(WeekData week)
        {
            if (week.Number == 1) {
                week.NumberMessage = "星期一";
            } else if (week.Number == 2) {
                week.NumberMessage = "星期二";
            } else if (week.Number == 3) {
                week.NumberMessage = "星期三";
            } else if (week.Number == 4) {
                week.NumberMessage = "星期四";
            } else if (week.Number == 5) {
                week.NumberMessage = "星期五";
            } else if (week.Number == 6) {
                week.NumberMessage = "星期六";
            } else if (week.Number == 7) {
                week.NumberMessage = "星期日";
            } else {
                week.NumberMessage = "錯誤輸入";
            }

            return View(week);
        }
    }
}