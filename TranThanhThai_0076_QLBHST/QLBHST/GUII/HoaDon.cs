using QLBHST.BALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBHST.BALL;

namespace QLBHST.GUII
{
    public partial class HoaDon : Form
    {
        KhachHangBAL cusBAL = new KhachHangBAL();
        NhanVienBAL cusBAL1 = new NhanVienBAL();
        SanPhamBAL cusBAL2 = new SanPhamBAL();
        HoaDonBAL cusBAL3 = new HoaDonBAL();

        SqlConnection connection = new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= QLBHSIEUTHI; User Id=sa; Password=11");

        public HoaDon()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
            
        }

    private void LoadDataIntoComboBox()
        {
            try
            {
                List<KhachHangBEL> lstCus = cusBAL.ReadKhachHang();
                foreach (KhachHangBEL cus in lstCus)
                {

                    cbbmakh.Items.Add(cus.Ma);
                }

                List<NhanVienBEL> lstCus1 = cusBAL1.ReadNV();
                foreach (NhanVienBEL cus in lstCus1)
                {

                    cbbmanv.Items.Add(cus.Ma);
                }
                List<SanPhamBEL> lstCus2 = cusBAL2.ReadSanPham();
                foreach (SanPhamBEL cus in lstCus2)
                {

                    cbbmasp.Items.Add(cus.Ma);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void cbbmakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                KhachHangBEL cus = new KhachHangBEL();
                cus.Ma = int.Parse(cbbmakh.Text);
                List<KhachHangBEL> lstCus = cusBAL.Timkiem(cus);
                foreach (KhachHangBEL c in lstCus)
                {
                    tbtkh.Text = c.Ten;
                    tbsdtkh.Text = c.Sdt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NhanVienBEL cus = new NhanVienBEL();
                cus.Ma = int.Parse(cbbmanv.Text);
                List<NhanVienBEL> lstCus = cusBAL1.timkiem(cus) ;
                foreach (NhanVienBEL c in lstCus)
                {
                    tbtnv.Text = c.Ten;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void cbbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SanPhamBEL cus = new SanPhamBEL();
                cus.Ma = int.Parse(cbbmasp.Text);
                List<SanPhamBEL> lstCus = cusBAL2.Timkiem1(cus);
                foreach (SanPhamBEL c in lstCus)
                {
                    tbtsp.Text = c.Ten;
                    tbgsp.Text = c.Gia.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void ttt(object sender, EventArgs e)
        {
            try
            {
                string slInput = tbsl.Text.Trim(); // Lấy giá trị từ trường tbsl và loại bỏ khoảng trắng ở đầu và cuối
                if (string.IsNullOrEmpty(slInput))
                {
                    tbtt.Text = "";
                    // Trường tbsl rỗng hoặc null, không thực hiện phép tính
                    return;
                }

                int a = int.Parse(slInput);

                if (a <= 0)
                {
                    MessageBox.Show("Giá trị của 'tbsl' phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Ngưng thực hiện khi giá trị không hợp lệ
                }

                int b = int.Parse(tbgsp.Text);
                int kq = a * b;
                tbtt.Text = kq.ToString();
            }
            catch (FormatException)
            {
                // Xử lý lỗi định dạng nếu người dùng nhập không phải là số
                MessageBox.Show("Vui lòng nhập số hợp lệ trong các ô nhập liệu.");
            }
            catch (OverflowException)
            {
                // Xử lý trường hợp số quá lớn để tính toán
                MessageBox.Show("Số quá lớn để tính toán.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvsp.Rows.Add(cbbmasp.Text,tbtsp.Text,tbgsp.Text,tbsl.Text,tbtt.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                HoaDonBEL cus = new HoaDonBEL();
                cus.Makh = int.Parse(cbbmakh.Text);
                cus.Manv = int.Parse(cbbmanv.Text);
                cus.ngaymua = DateTime.Now;
                cus.tongtien = cus.Makh;
                int a=cusBAL3.AddHoaDon(cus);
            dgvhd.Rows.Clear();
                //dgvSanpham.Rows.Add( cus.Ten, cus.Soluong, cus.Gia, cus.Ncc, cus.Anh);
                List<HoaDonBEL> lstCus = cusBAL3.ReadHoaDon();
                foreach (HoaDonBEL c in lstCus)
                {
                    dgvhd.Rows.Add(c.Mahd,c.Makh,c.Manv,c.ngaymua,c.tongtien);
                }
            foreach (DataGridViewRow row in dgvsp.Rows)
            {

                string columnName1 = a.ToString();
                string columnName2 = row.Cells[0].Value.ToString();
                string columnName3 = row.Cells[3].Value.ToString();
                string columnName4 = row.Cells[4].Value.ToString();
                //MessageBox.Show(columnName1);
                //MessageBox.Show(columnName2);
                //MessageBox.Show(columnName3);
                //MessageBox.Show(columnName4);
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo câu lệnh SQL INSERT
                string insertQuery = "INSERT INTO ChiTietHoaDon VALUES (@MaHoaDon, @MaSanPham,@SoLuongMua,@DonGia)";

                // Tạo đối tượng Command
                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@MaHoaDon", int.Parse(columnName1));
                cmd.Parameters.AddWithValue("@MaSanPham", int.Parse(columnName2));
                cmd.Parameters.AddWithValue("@SoLuongMua", int.Parse(columnName3));
                cmd.Parameters.AddWithValue("@DonGia", int.Parse(columnName4));

                // Thực thi câu lệnh INSERT
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();
            }

           
        }

        private void button5_Click(object sender, EventArgs e)
        {

           
        }
    }
}
