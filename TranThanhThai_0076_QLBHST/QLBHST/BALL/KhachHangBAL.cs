using QLBHST.DALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClosedXML.Excel;
namespace QLBHST.BALL
{
    public class KhachHangBAL
    {
        KhachHangDAL dal = new KhachHangDAL();
        public List<KhachHangBEL> ReadKhachHang()
        {
            List<KhachHangBEL> lstCus = dal.ReadKhachHang();
            return lstCus;
        }
        public List<KhachHangBEL> Timkiem(KhachHangBEL cus)
        {
            List<KhachHangBEL> lstCus = dal.ReadKhachHang1(cus);
            return lstCus;
        }

    }
}
