using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["var1"] = "data comes from ViewData";
            ViewBag.var2 = "data comes from  viewdata";
            TempData["var3"] = "data comes from Tempdata";
            Session["var4"] = "data comes comes from Session";

            string[] student = { "Nilesh", "Kunal", "pratik", "amol " };
            Session["var4"] = student;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();

        }
    }
}