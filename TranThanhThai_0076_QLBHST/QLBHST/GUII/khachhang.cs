using QLBHST.BALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHST.GUII
{
    public partial class khachhang : Form
    {
        KhachHangBAL cusBAL1 = new KhachHangBAL();
        public khachhang()
        {
            InitializeComponent();
        }

        static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(0|84)\d{9,10}$"; // Số điện thoại bắt đầu bằng 0 hoặc 84 và có 9-10 chữ số

            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
        private bool IsValidInput(string input)
        {
            // Kiểm tra nếu chuỗi bỏ trống hoặc chỉ toàn khoảng trắng
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            bool containsLetter = false;
            bool containsDigit = false;
            bool containsWhitespace = false;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    containsLetter = true;
                }
                else if (char.IsDigit(c))
                {
                    containsDigit = true;
                }
                else if (char.IsWhiteSpace(c))
                {
                    containsWhitespace = true;
                }
                else
                {
                    return (containsLetter && (containsDigit || containsWhitespace)) || (containsWhitespace && !containsDigit);
                }
            }

            // Trả về hợp lệ nếu có chữ và số hoặc toàn khoảng trắng
            return (containsLetter && (containsDigit || containsWhitespace)) || (containsWhitespace && !containsDigit);
        }

        private string TrimLeadingSpaces(string input)
        {
            int index = 0;
            while (index < input.Length && char.IsWhiteSpace(input[index]))
            {
                index++;
            }
            return input.Substring(index);
        }
        static string ProcessSpaces(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (i < words.Length - 1 && string.IsNullOrWhiteSpace(words[i + 1]))
                {
                    words[i] = words[i].TrimEnd();
                }
            }

            return string.Join(" ", words);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool sdt = false;
                if (IsValidPhoneNumber(tbsdt.Text))
                {
                    sdt = true;
                }
                //else
                //{
                //    MessageBox.Show("vui lòng kiểm tra lại thông tin sdt");
                //}
                string a = tbt.Text + " ";
                string a1 = tbdc.Text + " ";
                if (!tbemail.Text.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Email phải có đuôi '@gmail.com'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsValidInput(a) && sdt == true && IsValidInput(a1))
                {
                    KhachHangBEL cus = new KhachHangBEL();
                    cus.Ten = a;
                    cus.Dc = a1;
                    cus.Sdt = tbsdt.Text;
                    cus.Email = tbemail.Text;
                    cusBAL1.Addkh(cus);
                    dgvNcc.Rows.Clear();
                    //dgvSanpham.Rows.Add( cus.Ten, cus.Soluong, cus.Gia, cus.Ncc, cus.Anh);
                    List<KhachHangBEL> lstCus = cusBAL1.ReadKhachHang();
                    foreach (KhachHangBEL c in lstCus)
                    {
                        dgvNcc.Rows.Add(c.Ma, c.Ten, c.Dc, c.Sdt, c.Email);
                    }
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thể thêm. Vui lòng kiểm tra lại thông tin");
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm. Vui lòng kiểm tra lại thông tin");
            }
        }

        private void tbt_TextChanged(object sender, EventArgs e)
        {
            string a = TrimLeadingSpaces(tbt.Text);
            string b = ProcessSpaces(a);
            tbt.Text = b;
        }

        private void tbdc_TextChanged(object sender, EventArgs e)
        {
            string a = TrimLeadingSpaces(tbdc.Text);
            string b = ProcessSpaces(a);
            tbdc.Text = b;
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            List<KhachHangBEL> lstCus = cusBAL1.ReadKhachHang();
            foreach (KhachHangBEL c in lstCus)
            {
                dgvNcc.Rows.Add(c.Ma, c.Ten, c.Dc, c.Sdt, c.Email);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangBEL cus = new KhachHangBEL();
                cus.Ma = int.Parse(tbma.Text);
                cusBAL1.DeleteKhachHang(cus);
                int idx = dgvNcc.CurrentCell.RowIndex;
                dgvNcc.Rows.RemoveAt(idx);
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Khong the xoa. Tồn tai khách hàng trong hóa đơn");
            }
        }
        private void dgvkh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNcc.SelectedCells.Count > 0)
            {

                tbma.Text = dgvNcc.SelectedCells[0].Value.ToString();
                tbt.Text = dgvNcc.SelectedCells[1].Value.ToString();
                tbdc.Text = dgvNcc.SelectedCells[2].Value.ToString();
                tbsdt.Text = dgvNcc.SelectedCells[3].Value.ToString();
                tbemail.Text = dgvNcc.SelectedCells[4].Value.ToString();
                //age.Text = dgvcustomer.SelectedCells[2].Value.ToString

            }
            else
            {
                tbma.Text = null;
                tbt.Text = null;
                tbdc.Text = null;
                tbsdt.Text = null;
                tbemail.Text = null;

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool sdt = false;
                if (IsValidPhoneNumber(tbsdt.Text))
                {
                    sdt = true;
                }
                //else
                //{
                //    MessageBox.Show("vui lòng kiểm tra lại thông tin sdt");
                //}
                string a = tbt.Text + " ";
                string a1 = tbdc.Text + " ";
                if (IsValidInput(a) && sdt == true && IsValidInput(a1))
                {
                    KhachHangBEL cus = new KhachHangBEL();
                    cus.Ma = int.Parse(tbma.Text);

                    cus.Ten = tbt.Text;
                    cus.Dc = tbdc.Text;
                    cus.Sdt = tbsdt.Text;
                    cus.Email = tbemail.Text;
                    cusBAL1.EditKhachhang(cus);
                    int idx = dgvNcc.CurrentCell.RowIndex;
                    dgvNcc.Rows[idx].Cells[0].Value = tbma.Text;
                    dgvNcc.Rows[idx].Cells[1].Value = tbt.Text;
                    dgvNcc.Rows[idx].Cells[2].Value = tbdc.Text;
                    dgvNcc.Rows[idx].Cells[3].Value = tbsdt.Text;
                    dgvNcc.Rows[idx].Cells[4].Value = tbemail.Text;
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không thể sửa. Vui lòng kiểm tra lại thông tin");
                }
            }
            catch
            {
                MessageBox.Show("Không thể sửa. Vui lòng kiểm tra lại thông tin");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Menu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
