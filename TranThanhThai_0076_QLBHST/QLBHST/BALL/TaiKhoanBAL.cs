using QLBHST.DALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.BALL
{
    public class TaiKhoanBAL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();
        public List<TaiKhoanBEL> ReadTaiKhoan()
        {
            List<TaiKhoanBEL> lstCus = dal.ReadTaiKhoan();
            return lstCus;
        }

        public void NewTaiKhoan(TaiKhoanBEL cus)
        {
            dal.NewTaiKhoan(cus);
        }
        public void EditTaiKhoan(TaiKhoanBEL cus)
        {
            dal.EditTaikhoan(cus);
        }


    }
}
