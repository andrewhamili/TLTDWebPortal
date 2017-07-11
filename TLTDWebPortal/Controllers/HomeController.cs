using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TLTDWebPortal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Console.WriteLine("3guard");
            if (String.IsNullOrEmpty(Session["user"].ToString()))
            {
                return RedirectToAction("Login", "Default");
            }
            return View();
        }
    }
}