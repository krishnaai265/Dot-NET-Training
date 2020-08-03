using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC10.Controllers
{
    public class ActionController : Controller
    {
        // GET: Action
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password) {
            if (username.Equals("admin") && password.Equals("123"))
            {
                Session["username"] = username;
                return View("Success");
            }
            else {
                ViewBag.error = "Invalid Account";
                return View("Index");
            }
        }

        [HttpGet]
        public ActionResult LogOut() {
            Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}