using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TLTDWebPortal.Models;

namespace TLTDWebPortal.Controllers
{
    public class DefaultController : Controller
    {

        ceutltdschedulerEntities db;
        // GET: Default
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            Session.Abandon();
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginParam param)
        {
            db = new ceutltdschedulerEntities();
            user_login_Result result = new user_login_Result();
            result= db.user_login(param.username, param.password).First();

            if((!String.IsNullOrEmpty(result.staff_fname) & !String.IsNullOrEmpty(result.staff_surname))){
                Session["user"] = result.staff_fname + " " + result.staff_surname;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}