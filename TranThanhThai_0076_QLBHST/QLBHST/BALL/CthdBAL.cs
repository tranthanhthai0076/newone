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
    public class CthdBAL
    {
        CthdDAL dal = new CthdDAL();
        public List<CthdBEL> timkiem(CthdBEL cus1)
        {
            List<CthdBEL> lstCus = dal.timkiem(cus1);
            return lstCus;
        }
       

        //public void AddHoaDon(CthdBEL cus)
        //{
        //    dal.AddHoaDon(cus);
        //}
        //public List<HoaDonBEL> Timkiem(HoaDonBEL cus)
        //{
        //    List<HoaDonBEL> lstCus = dal.ReadKhachHang1(cus);
        //    return lstCus;
        //}

    }
}
