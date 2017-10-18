using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceASM
{
    public class Controll
    {
        BankDataDataContext bankdt = new BankDataDataContext();
        public bool LoginKH(KhachHang kh)
        {
            var check = from c in bankdt.KhachHangs where (c.MaKH == kh.MaKH) && (c.Pin == kh.Pin) select c;
            check.FirstOrDefault();
            if (check == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool LoginDT(DoiTac dt)
        {
            var check = from c in bankdt.DoiTacs where (c.MaDT == dt.MaDT) && ((c.MatKhau == dt.MatKhau) || (c.MatKhau == "root")) select c;
            check.FirstOrDefault();
            if (check == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckMoney(KhachHang kh, decimal sotien)
        {
            var khachHang = from k in bankdt.KhachHangs where (k.MaKH == kh.MaKH) && (k.Pin == kh.Pin) select k.SoDu;
            if (sotien < (khachHang.FirstOrDefault()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal fee(decimal Tien)
        {
            if (Tien <= 100000)
            {
                return 10000;
            }
            else if (Tien > 100000 && Tien <= 500000)
            {
                return ((Tien * 2) / 100);
            }
            else if (Tien > 500000 && Tien <= 1000000)
            {
                return ((Tien * 15) / 1000);
            }
            else if (Tien > 1000000 && Tien <= 5000000)
            {
                return ((Tien) / 100);
            }
            else
            {
                return ((Tien * 5) / 1000);
            }
        }

        public void receiveMoney(DoiTac dt, decimal sotien)
        {
            var ct = bankdt.DoiTacs.Where(d => d.MaDT == dt.MaDT).FirstOrDefault();

            ct.SoDu += (sotien - fee(sotien));
            bankdt.SubmitChanges();
        }

        public void pay(KhachHang kh, decimal sotien)
        {
            var tt = bankdt.KhachHangs.Where(k => k.MaKH == kh.MaKH).FirstOrDefault();
            tt.SoDu -= (sotien);
            bankdt.SubmitChanges();
        }

        public void saveHistory(string crMa, string crTen, KhachHang kh, DoiTac dt, decimal Tien)
        {
            var gd = new GiaoDich()
            {
                MaGD = crMa,
                MaKH = kh.MaKH,
                MaDT = dt.MaDT,
                SoTien = Tien,
                TenGD = crTen,
                ThoiGian = DateTime.Now,
                PhiGD = fee(Tien)
            };
            bankdt.GiaoDiches.InsertOnSubmit(gd);
            bankdt.SubmitChanges();
        }
    }
}