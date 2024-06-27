using MVCUIDesigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }
        /*[HttpPost] //using primitives
        public ViewResult AddEmp(int? id,string name,string job, double? salary)
        {
            ViewData["Id"] = id;
            ViewData["Name"] = name;
            ViewData["Job"] = job;
            ViewData["Salary"] = salary;
            return View("DisplayEmp1"); 
        }*/
        /*[HttpPost]
        public ViewResult AddEmp(FormCollection formCollection)
        {
            ViewData["Id"]=formCollection["id"];
            ViewData["Name"] = formCollection["name"];
            ViewData["Job"] = formCollection["job"];
            ViewData["Salary"] = formCollection["salary"];
            return View("DisplayEmp1");
        }*/
        [HttpPost] //using model class
        public ViewResult AddEmp(Employee employee)
        {
            return View("DisplayEmp2",employee);
        }
    }
}