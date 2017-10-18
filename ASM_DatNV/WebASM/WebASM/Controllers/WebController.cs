using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebASM.Models;
using WebASM.ServiceReference1;

namespace WebASM.Controllers
{
    public class WebController : Controller
    {
        BankServiceClient br = new BankServiceClient();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(thanhtoanModel th)
        {
            var kh = new KhachHang() { MaKH=th.maKH,Pin=th.pin};
            var dt = new DoiTac() {MaDT=th.maDT,MatKhau= "root" };
            var rs = br.ThanhToan(dt, kh, th.sotien);
            ViewBag.RS = rs;
            return View();
        }
        public ActionResult History()
        {
            var lsKH = br.LSKH().ToList();
            ViewBag.LSDT = br.LSDT().ToList();
            return View(lsKH);
        }
    }
}