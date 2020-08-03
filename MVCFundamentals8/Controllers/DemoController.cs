using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFundamentals8.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo

        /*public ActionResult Index()
        {
            return View();
        }*/
        public ViewResult Index() {

            return View();
        }
        public ViewResult About() {

            return View();
        }
        public string Message(){
            return "Message here";
        }
        public ViewResult Contact() {
            return View("ContactPageView");
        }
        public ViewResult ABC() {
            return View("ABC");
        }
    }
}