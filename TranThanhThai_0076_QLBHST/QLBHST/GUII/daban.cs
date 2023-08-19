using QLBHST.BALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHST.GUII
{
    public partial class daban : Form
    {
        spdabanBAL cusBAL1 = new spdabanBAL();
        public daban()
        {
            InitializeComponent();
        }

        private void daban_Load(object sender, EventArgs e)
        {
            List<spdabanBEL> lstCus = cusBAL1.ReadNhaCungCap();
            foreach (spdabanBEL cus in lstCus)
            {
                spdaban.Rows.Add(cus.Ma, cus.Ten, cus.sl);
            }
        }
    }
}
