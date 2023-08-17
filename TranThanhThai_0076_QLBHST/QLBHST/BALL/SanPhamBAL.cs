
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
    public class SanPhamBAL
    {
        SanPhamDAL dal = new SanPhamDAL();
        public List<SanPhamBEL> ReadSanPham()
        {
            List<SanPhamBEL> lstCus = dal.ReadSanPham();
            return lstCus;
        }

        public void AddSanPham(SanPhamBEL cus)
        {
            dal.AddSanPham(cus);
        }
        public void DeleteSanPham(SanPhamBEL cus)
        {
            dal.DeleteSanPham(cus);
        }
        public void EditSanPham(SanPhamBEL cus)
        {
            dal.EditSanPham(cus);
        }
        public void capnhatsl(SanPhamBEL cus)
        {
            dal.capnhatsl(cus);
        }
        public List<SanPhamBEL> Timkiem(SanPhamBEL cus)
        {
            List<SanPhamBEL> lstCus = dal.Timkiem(cus);
            return lstCus;
        }
        public List<SanPhamBEL> Timkiem1(SanPhamBEL cus)
        {
            List<SanPhamBEL> lstCus = dal.Timkiem1(cus);
            return lstCus;
        }

    }
}
