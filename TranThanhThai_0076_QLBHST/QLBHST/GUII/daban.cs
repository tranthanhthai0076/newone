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
            //List<spdabanBEL> lstCus = cusBAL1.ReadNhaCungCap();
            //foreach (spdabanBEL cus in lstCus)
            //{
            //    spdaban.Rows.Add(cus.Ma, cus.Ten, cus.sl);
            //}

        }

        private void tim_Click(object sender, EventArgs e)
        {
            spdaban.Rows.Clear();
            DateTime selectedDate = ngaybd.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");


            DateTime selectedDate1 = ngaykt.Value;
            string formattedDate1 = selectedDate1.ToString("yyyy-MM-dd");
     
            spdabanBEL cus = new spdabanBEL();
            cus.ngaybd= DateTime.Parse(formattedDate);
            cus.ngaykt =DateTime.Parse( formattedDate1);
            List<spdabanBEL> lstCus = cusBAL1.ReadNhaCungCap(cus);
            foreach (spdabanBEL c in lstCus)
            {
                spdaban.Rows.Add(c.Ma, c.Ten,c.sl,c.giaban,c.tongtien);
            }
            int mony1 = 0; // Khởi tạo giá trị ban đầu cho biến mony1

            foreach (DataGridViewRow row in spdaban.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    int mony = 0;
                    if (int.TryParse(row.Cells[4].Value.ToString(), out mony))
                    {
                        mony1 += mony;
                    }
                }
            }
            dt.Text =mony1.ToString();

        }

        private void dt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(dt.Text, out decimal value))
                {

                    dt.Text = value.ToString("N0");
                    dt.Select(dt.Text.Length, 0);



                }
            }
            catch
            {
                MessageBox.Show("Thử lại sau");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Menu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
