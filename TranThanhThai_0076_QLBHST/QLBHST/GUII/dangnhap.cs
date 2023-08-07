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
    public partial class dangnhap : Form
    {
        TaiKhoanBAL cusBAL = new TaiKhoanBAL();

        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            List<TaiKhoanBEL> lstCus = cusBAL.ReadTaiKhoan();
            foreach (TaiKhoanBEL cus in lstCus)
            {
                dataGridView1.Rows.Add(cus.Id, cus.Tentk);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dn objForm01 = new dn();
            objForm01.ShowDialog();
        }
    }
}
