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
    public class NhanVienBAL
    {
        NhanVienDAL dal = new NhanVienDAL();
        public List<NhanVienBEL> ReadNV()
        {
            List<NhanVienBEL> lstCus = dal.ReadNV();
            return lstCus;
        }
        public List<NhanVienBEL> timkiem(NhanVienBEL cus)
        {
            List<NhanVienBEL> lstCus = dal.ReadNV1(cus);
            return lstCus;
        }
       

    }
}
