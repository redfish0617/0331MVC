using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_3.Models;

namespace MVC_3.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index(ValidTest valid)
        {
            if (String.IsNullOrEmpty(Request.Form.Get("SignIn")))
            {
                //List<ValidTest> validTests = new List<ValidTest>();
                //validTests.Add(new ValidTest { StudentName = "小王", StudentID = "1" });
                return View();
            }
            else
            {
                return View(valid);
            }
           
        }
    }
}