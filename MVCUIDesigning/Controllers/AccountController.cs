using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Validate()
        {
            string txtName = Request["txtName"];
            string txtPwd = Request["txtPwd"];
            if (txtName == "admin" && txtPwd == "admin")
            {
                Session["User"] = txtName;
                return View("Success");
            }
            else
            {
                ViewBag.Name = txtName;
                return View("Failure");
            }

        }    
    }
}