using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceASM
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BankService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BankService.svc or BankService.svc.cs at the Solution Explorer and start debugging.
    public class BankService : IBankService
    {
        BankDataDataContext bankdt = new BankDataDataContext();
        Controll ct = new Controll();

        public List<GiaoDich> LSDT()
        {
            var lichsu = from g in bankdt.GiaoDiches select g;
            return lichsu.ToList();
        }

        public List<GiaoDich> LSKH()
        {
            var lichsu = from g in bankdt.GiaoDiches select g;
            return lichsu.ToList();
        }

        public bool ThanhToan(DoiTac dt, KhachHang kh, decimal soTien)
        {
            if ( ct.LoginDT(dt) == true && ct.LoginKH(kh) == true && ct.CheckMoney(kh, soTien) == true)
            {
                ct.receiveMoney(dt, soTien);
                ct.pay(kh, soTien);
                ct.saveHistory(kh.MaKH.ToString() + "_" + DateTime.Now.Second.ToString(), kh.MaKH.ToString() + "_" + dt.MaDT.ToString() + "_" + DateTime.Now.Second.ToString(), kh, dt, soTien);
                return true;
            }
            else {
                return false;
            }
        }
    }
}
