using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntiXssTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult XSS() //有放測試資料
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult XssTest(string userInput)
        {
            ViewData["dangerousData"] = userInput; // ⚠️ ViewData 可能被輸出到 HTML
            return View();
        }
    }
}