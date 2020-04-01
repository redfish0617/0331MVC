using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_3.Models;
namespace MVC_3.Controllers
{
    public class ViewSampleController : Controller
    {
        // GET: ViewSample
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SectionTest()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { name = "小明", age = 11, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小王", age = 12, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小李", age = 13, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小每", age = 14, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小白", age = 15, addr = "陽光街", city = "台北", phone = 0900123456 });
            return View(people);
        }
        public ActionResult ModelTest() 
        {
            List<Class> classes = new List<Class>();
            classes.Add(new Class { a = "1", b = "2", c = "3", d = "4", e = "5" });
            classes.Add(new Class { a = "6", b = "7", c = "8", d = "9", e = "10" });
            classes.Add(new Class { a = "1", b = "2", c = "3", d = "4", e = "5" });
            classes.Add(new Class { a = "1", b = "2", c = "3", d = "4", e = "5" });
            classes.Add(new Class { a = "1", b = "2", c = "3", d = "4", e = "5" });

            return View(classes);
        }
        public ActionResult HelperTest()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { name = "小明", age = 11, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小王", age = 12, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小李", age = 13, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小每", age = 14, addr = "陽光街", city = "台北", phone = 0900123456 });
            people.Add(new Person { name = "小白", age = 15, addr = "陽光街", city = "台北", phone = 0900123456 });
            return View(people);
        }
        public ActionResult Template(String UserID, String Password, Boolean IsPersistent = false)
        {
            if (String.IsNullOrEmpty(Request.Form.Get("SignIn")))
            {
                return View();
            }
            else
            {
                return View();
            }
        }
        public ActionResult Login(vmLogin vmLogin)
        {
            if(String.IsNullOrEmpty(Request.Form.Get("SignIn")))
            {
                return View();
            }
            else
            {
                return View(vmLogin);
            }
        }
    }
}