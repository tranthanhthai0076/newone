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
    public class HoaDonBAL
    {
        HoaDonDAL dal = new HoaDonDAL();
        public List<HoaDonBEL> ReadHoaDon()
        {
            List<HoaDonBEL> lstCus = dal.ReadHoaDon();
            return lstCus;
        }
       

        public int AddHoaDon(HoaDonBEL cus)
        {
           int a= dal.AddHoaDon(cus);
            return a;
        }

        public void EditHoaDon(HoaDonBEL cus)
        {
            dal.EditHoaDon(cus);
        }
        //public List<HoaDonBEL> Timkiem(HoaDonBEL cus)
        //{
        //    List<HoaDonBEL> lstCus = dal.ReadKhachHang1(cus);
        //    return lstCus;
        //}

    }
}
