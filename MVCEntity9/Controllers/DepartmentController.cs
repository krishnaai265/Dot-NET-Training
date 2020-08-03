using MVCEntity9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEntity9.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Department
        public ActionResult Index()
        {
            ViewBag.departments = context.Departments.ToList();
            return View();
        }
        public ActionResult Details(int id) {//Url
            ViewBag.Department = context.Departments.Where(d => d.DepartmentId == id).SingleOrDefault();//Single, Multiple ToList
            return View();
        }
        [HttpGet]//FormOpen
        public ActionResult Create() {
            return View();
        }
        [HttpPost]//Form Submit
        public ActionResult Create(Department department) {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id) {
            var department = context.Departments.Find(id);
            return View(department);
        }
        [HttpPost]
        public ActionResult Delete(int id, Department department)
        {
            var dept = context.Departments.Find(id);
            context.Departments.Remove(dept);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id) {
            var department = context.Departments.Find(id);
            return View(department);
        }
        [HttpPost]
        public ActionResult Edit(int id, Department department) {
            var dept = context.Departments.Find(id);
            dept.DepartmentName = department.DepartmentName;
            dept.DepartmentLocation = department.DepartmentLocation;
            dept.DepartmentAddedDate = department.DepartmentAddedDate;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}