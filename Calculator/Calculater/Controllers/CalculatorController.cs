using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculater.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Cong(float a, float b)
        {
            var client = new ServiceReference1.WebService1SoapClient();
            var ketqua = client.Cong(a, b);
            ViewBag.ketqua = Convert.ToString(ketqua);
            return View("Index");
        }

        public ActionResult Tru(float a, float b)
        {
            var client = new ServiceReference1.WebService1SoapClient();
            var ketqua = client.Tru(a, b);
            ViewBag.ketqua = Convert.ToString(ketqua);
            return View("Index");
        }
    }
}