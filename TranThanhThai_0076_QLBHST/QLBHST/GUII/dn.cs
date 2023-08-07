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
    public partial class dn : Form
    {
        public dn()
        {
            InitializeComponent();
        }
        TaiKhoanBAL cusBAL = new TaiKhoanBAL();
        private void btndn_Click(object sender, EventArgs e)
        {
            string tk1 = tk.Text;
            string mk1 = mk.Text;
            bool dn = false;
            bool kktk = false;
            bool kkmk = false;

            int length = tk1.Length;
            int length1 = mk1.Length;
            if (length < 5 || length >= 15)
            {
                MessageBox.Show("Tài khoản phải từ 5-15 ký tự");
            }
            else
            {
                kktk = true;
            }
            if (length1 < 5)
            {
                MessageBox.Show("Mật khẩu ít nhất 5 ký tự");
            }
            else
            {
                kkmk = true;
            }

            if (kktk == true && kkmk == true)
            {
                List<TaiKhoanBEL> lstCus = cusBAL.ReadTaiKhoan();
                foreach (TaiKhoanBEL cus in lstCus)
                {
                    if (cus.Tentk == tk1 && cus.Matkhau == mk1)
                    {
                        this.Hide();
                        var form2 = new Gdht();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                        dn = true;
                        break;
                    }

                }
                if (!dn)
                {
                    MessageBox.Show("Sai tk hoặc mk", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form2 = new quenmk();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            
        }

        private void btnDki(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new dk();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            
        }
    }
}

