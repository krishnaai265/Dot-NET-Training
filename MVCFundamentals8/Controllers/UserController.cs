using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFundamentals8.Models;

namespace MVCFundamentals8.Controllers
{
    public class UserController : Controller
    {
        IList<User> users = new List<User>()
        {
            new User { Id=101, Name="Krishna Kumar", Age ="23"},
            new User { Id=102, Name="Abhi", Age ="20"},
            new User { Id=103, Name="Arjun", Age ="18"},
            new User { Id=104, Name="Kartik", Age ="9"},
            new User { Id=105, Name="John", Age ="49"},
        };
        // GET: User
        public ActionResult Index()
        {
            ViewBag.Message = "Index Page Here...OK";
            ViewBag.TotalUsers = users.Count();
            ViewBag.UserList = users;
            return View();
        }
        public ActionResult GetUsers() {
            ViewData["message"] = "User List Here...";
            ViewData["userlist"] = users;
            return View();
        }
        public ActionResult MethodA() {
            TempData["name"] = "Krishna Kumar Singh";
            return View();
                
        }
        public ActionResult MethodB() {
            string name;
            if (TempData["name"] != null) {
                name = TempData["name"].ToString();
            }
            return View();
        }
    }
}