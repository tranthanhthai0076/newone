﻿using QLBHST.DALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.BALL
{
    public class NhaCungCapBAL
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            List<NhaCungCapBEL> lstCus = dal.ReadNhaCungCap();
            return lstCus;
        }

        public void AddNhaCungCap(NhaCungCapBEL cus)
        {
            dal.AddNhaCungCap(cus);
        }
        public void EditNhaCungCap(NhaCungCapBEL cus)
        {
            dal.EditNhaCungCap(cus);
        }
        public void DeleteNhaCungCap(NhaCungCapBEL cus)
        {
            dal.DeleteNhaCungCap(cus);
        }


    }
}
