using StudentEmployeeWeb.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentEmployeeWeb.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentServiceClient client = new StudentServiceClient();
        public ActionResult Index()
        {
            return View(client.getAllStudent().ToList());
        }
        
    }
}