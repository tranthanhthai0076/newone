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
    public partial class dk : Form
    {
        TaiKhoanBAL cusBAL = new TaiKhoanBAL();
        public dk()
        {
            InitializeComponent();
        }

        private void btnDk(object sender, EventArgs e)
        {
            TaiKhoanBEL cus = new TaiKhoanBEL();
            cus.Tentk = ttk.Text;
            cus.Matkhau = tmk.Text;
            cus.Email = temail.Text;
            cusBAL.NewTaiKhoan(cus);
            MessageBox.Show("Đăng ký Thành công", "Thông báo");
        }
    }
}
