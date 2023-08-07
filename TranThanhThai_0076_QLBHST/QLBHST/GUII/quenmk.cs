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
    public partial class quenmk : Form
    {
        TaiKhoanBAL cusBAL = new TaiKhoanBAL();
        public quenmk()
        {
            InitializeComponent();
        }

        private void btn_qmk(object sender, EventArgs e)
        {
            string dk = qtk.Text;
            string dk1 = qemail.Text;
            bool a = false;
            List<TaiKhoanBEL> lstCus = cusBAL.ReadTaiKhoan();
            foreach (TaiKhoanBEL c in lstCus)
            {
                if (c.Tentk == dk && c.Email == dk1)
                {
                    TaiKhoanBEL cus = new TaiKhoanBEL();
                    cus.Tentk = qtk.Text;
                    cus.Matkhau = qmk.Text;
                    cus.Email = qemail.Text;
                    if (qmk.Text == qnlmk.Text)
                    {
                        cusBAL.EditTaiKhoan(cus);
                        a = true;
                        MessageBox.Show("Lấy mk Thành công", "Thông báo");
                        break;
                    }
                    else
                    {
                        a = true;
                        MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo");
                    }
                  
                 }
               
             }
            if (a == false)
            {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu koong tồn tại trong hệ thống ", "Thông báo");    
            }
          
        }

    }
}
