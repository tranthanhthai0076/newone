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


namespace QLBHST.GUII
{
    public partial class HoaDon : Form
    {
        KhachHangBAL cusBAL = new KhachHangBAL();
        NhanVienBAL cusBAL1 = new NhanVienBAL();
        SanPhamBAL cusBAL2 = new SanPhamBAL();
        HoaDonBAL cusBAL3 = new HoaDonBAL();
        CthdBAL cusBAL4 = new CthdBAL();

        SqlConnection connection = new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= QLBHSIEUTHI; User Id=sa; Password=11");

        public HoaDon()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
            // Gắn các sự kiện xử lý sự thay đổi dữ liệu
            dgvsp.CellValueChanged += DataGridView_CellValueChanged;
            dgvsp.RowsAdded += DataGridView_RowsAdded;
            dgvsp.RowsRemoved += DataGridView_RowsRemoved;


        }
        bool IsDataGridViewEmpty(DataGridView dataGridView)
        {
            return dataGridView.Rows.Count == 0;
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
                MessageBox.Show("Đã xảy ra lỗi 1: " + ex.Message);
            }
        }

        private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NhanVienBEL cus = new NhanVienBEL();
            cus.Ma = int.Parse(cbbmanv.Text);
            List<NhanVienBEL> lstCus = cusBAL1.timkiem(cus);
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
                tbtk.Text=c.Soluong.ToString();

            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
}


        int tt,ttcn;
        private bool CheckIfValueExistsInDataGridView(string valueToCheck)
        {
            foreach (DataGridViewRow row in dgvsp.Rows)
            {
                string columnName = row.Cells[2].Value.ToString(); // Chỉ số cột chứa giá trị cần kiểm tra (cbbmasp.Text)
                if (columnName == valueToCheck)
                {
                    return true; // Giá trị đã tồn tại
                }
            }
            return false; // Không tìm thấy giá trị
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string atam = TrimLeadingSpaces(tbsl.Text);
            string btam = ProcessSpaces(atam);
            tbsl.Text = btam;
            string a1 = tbsl.Text;

            if (cbbmasp.Text!="") {
                if (CheckContainsAlphaOrDigit(a1)
                              || string.IsNullOrEmpty(a1) || int.Parse(a1) < 1)

                {
                    MessageBox.Show("Kiem tra lại sl");
                    tbsl.Text = "";
                }

                else
                {
                    string cbbmaspValue = cbbmasp.Text;
                    int a = int.Parse(tbtk.Text);
                    int b = int.Parse(tbsl.Text);
                    if (a < b)
                    {
                        MessageBox.Show("Không đủ hàng");
                        tbsl.Text = "1"; // Xóa giá trị không hợp lệ
                    }
                    else
                    {


                        if (!CheckIfValueExistsInDataGridView(cbbmaspValue))
                        {
                            dgvsp.Rows.Add("", "", cbbmaspValue, tbtsp.Text, tbsl.Text, tbgsp.Text, intValue);
                            // Cập nhật tổng tiền
                            tt =tt+ intValue;
                        


                            tbtongtien.Text = tt.ToString();

                            dataChanged = true; // Đã có thay đổi dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Đã có sản phẩm trong bảng.");
                        }
                    }

                }
            }

            else {
                MessageBox.Show("Kiểm tra mã sản phẩm.");
            }

               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty(dgvsp))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trong hóa đơn");
            }
            else
            {
                if (cbbmakh.Text !="" && cbbmanv.Text != "")
                {

                    HoaDonBEL cus = new HoaDonBEL();
                    cus.Makh = int.Parse(cbbmakh.Text);
                    cus.Manv = int.Parse(cbbmanv.Text);
                    cus.ngaymua = DateTime.Now;
                    cus.tongtien = intValue2;
                    int a = cusBAL3.AddHoaDon(cus);

                    foreach (DataGridViewRow row in dgvsp.Rows)
                    {

                        string columnName1 = a.ToString();
                        string columnName2 = row.Cells[2].Value.ToString();
                        string columnName3 = row.Cells[4].Value.ToString();
                        string columnName4 = row.Cells[5].Value.ToString();
                        //MessageBox.Show(columnName1);
                        //MessageBox.Show(columnName2);
                        //MessageBox.Show(columnName3);
                        //MessageBox.Show(columnName4);
                        //Mở kết nối đến cơ sở dữ liệu
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
                        SanPhamBEL tk = new SanPhamBEL();
                        tk.Ma = int.Parse(columnName2);
                        tk.Soluong = int.Parse(columnName3);
                        cusBAL2.capnhatsl(tk);
                    }
                    dgvhd.Rows.Clear();
                    dgvsp.Rows.Clear();
                    //dgvSanpham.Rows.Add( cus.Ten, cus.Soluong, cus.Gia, cus.Ncc, cus.Anh);
                    List<HoaDonBEL> lstCus = cusBAL3.ReadHoaDon();
                    foreach (HoaDonBEL c in lstCus)
                    {
                        dgvhd.Rows.Add(c.Mahd, c.Makh, c.Manv, c.ngaymua, c.tongtien);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
            }
            
            
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty(dgvsp))
            {
                MessageBox.Show("Không có dữ liệu trong hóa đơn để sửa");
            }
            else
            {
                string atam = TrimLeadingSpaces(tbsl.Text);
                string btam = ProcessSpaces(atam);
                tbsl.Text = btam;
                string a1 = tbsl.Text;


                if (CheckContainsAlphaOrDigit(a1)
                           || string.IsNullOrEmpty(a1) || int.Parse(a1) < 1)

                {
                    MessageBox.Show("Kiem tra lại sl");
                    tbsl.Text = "";
                }

                else
                {

                    int a = int.Parse(tbtk.Text);
                    int b = int.Parse(tbsl.Text);
                    if (a < b)
                    {
                        MessageBox.Show("Không đủ hàng");
                        tbsl.Text = "1"; // Xóa giá trị không hợp lệ
                    }
                    else
                    {
                        int idx = dgvsp.CurrentCell.RowIndex;
                        dgvsp.Rows[idx].Cells[0].Value = tbid.Text;
                        dgvsp.Rows[idx].Cells[1].Value = tbhd.Text;
                        dgvsp.Rows[idx].Cells[2].Value = cbbmasp.Text;
                        dgvsp.Rows[idx].Cells[3].Value = tbtsp.Text;
                        dgvsp.Rows[idx].Cells[4].Value = tbsl.Text;
                        dgvsp.Rows[idx].Cells[5].Value = tbgsp.Text;
                        dgvsp.Rows[idx].Cells[6].Value = intValue;


                        // Cập nhật tổng tiền
                        ttcn = tt - tam + intValue;
                        tbtongtien.Text = ttcn.ToString();

                        dataChanged = true; // Đã có thay đổi dữ liệu


                    }

                }
            }

           
        }
        private bool dataChanged = false; // Biến để ghi nhận sự thay đổi




        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataChanged = true;
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataChanged = true;
        }

        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dataChanged = true;
        }

        private bool textBox1Changed = false;
        private bool textBox2Changed = false;
        int sltk;
       
        static bool CheckContainsAlphaOrDigit(string inputString)
        {
            return inputString.Any(c => char.IsLetter(c));
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

        private void ttt(object sender, EventArgs e)
        {
            textBox2Changed = true;
            CheckChanges();
            
        

        //sltk = int.Parse(tbtk.Text)-int.Parse(tbsl.Text);
        //MessageBox.Show( sltk.ToString());
        }

        private void tdg(object sender, EventArgs e)
        {
            textBox1Changed = true;
            CheckChanges();

          

        }
        private void CheckChanges()
        {

            if (textBox1Changed || textBox2Changed)
            {
                if (int.TryParse(tbsl.Text, out int quantity) && int.TryParse(tbgsp.Text, out int price))
                {
                    int totalPrice = quantity * price;
                    tbtt.Text = totalPrice.ToString();

                    // Hiển thị tổng tiền với 2 chữ số thập phân
                }
                else
                {
                    tbtt.Text = "Invalid Input"; // Hiển thị thông báo nếu dữ liệu không hợp lệ
                }
            }
            else
            {
                MessageBox.Show("aaa");
            }
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDonBEL> lstCus = cusBAL3.ReadHoaDon();
            foreach (HoaDonBEL cus in lstCus)
            {
                dgvhd.Rows.Add(cus.Mahd, cus.Makh, cus.Manv, cus.ngaymua, cus.tongtien);
            }

        }

        private void dgvslectchange(object sender, EventArgs e)
        {

            if (dgvhd.SelectedCells.Count > 0)
            {
                string a = dgvhd.SelectedCells[0].Value.ToString();
                string a1 = dgvhd.SelectedCells[1].Value.ToString();
                string a2 = dgvhd.SelectedCells[2].Value.ToString();
                string a3 = dgvhd.SelectedCells[3].Value.ToString();
                string a4 = dgvhd.SelectedCells[4].Value.ToString();
               
                if (int.TryParse(a, out int id)
                && int.TryParse(a1, out int makh)
                && int.TryParse(a2, out int manv))
                {
                    tbhd.Text = id.ToString(); // Gán số nguyên đã chuyển đổi cho tbhd
                    cbbmakh.Text = makh.ToString();
                    cbbmanv.Text = manv.ToString();
                    tbnm.Text = a3.ToString();
                    tbtongtien.Text = a4.ToString();

                }


                else
                {
                    tbhd.Text = null;
                    cbbmakh.Text = null;
                    cbbmanv.Text = null;
                    tbnm.Text = null;
                    tbtongtien.Text = null;
                }
            }
        


        }

        private void tbhd_TextChanged(object sender, EventArgs e)
        {
            dgvsp.Rows.Clear();
            CthdBEL cus = new CthdBEL();
            cus.mahd = int.Parse(tbhd.Text);
            List<CthdBEL> lstCus = cusBAL4.timkiem(cus);
            foreach (CthdBEL c in lstCus)
            {
                dgvsp.Rows.Add(c.id, c.mahd, c.masp, c.tensp, c.sl, c.dg, c.tt);
            }


        }
        int tam;
        private void dgvsp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsp.SelectedCells.Count > 0)
            {

                tbid.Text  = dgvsp.SelectedCells[0].Value.ToString();
                cbbmasp.Text = dgvsp.SelectedCells[2].Value.ToString();
                tbtsp.Text= dgvsp.SelectedCells[3].Value.ToString();
                 tbsl.Text = dgvsp.SelectedCells[4].Value.ToString();
                tbgsp.Text = dgvsp.SelectedCells[5].Value.ToString();
                tbtt.Text= dgvsp.SelectedCells[6].Value.ToString();
                tam = int.Parse(dgvsp.SelectedCells[6].Value.ToString());

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dgvsp.Rows.Clear();
            tbtongtien.Clear();
            intValue2 = 0;
            tt = 0;
        }
        int intValue;
        private void tbtt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbtt.Text, out int value))
            {
                // Successfully parsed the text as a decimal value
                tbtt.Text = value.ToString("N0"); // Format the value as desired
                tbtt.Select(tbtt.Text.Length, 0);

                // Convert the decimal value to an integer (possible loss of precision)
                intValue = (int)value;

            }
        }
        int intValue2;

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvsp.CurrentCell != null && dgvsp.CurrentCell.RowIndex != -1)
            {
                int idx = dgvsp.CurrentCell.RowIndex;

                DataGridViewRow selectedRow = dgvsp.Rows[idx];
                if (!selectedRow.Cells.Cast<DataGridViewCell>().Any(cell => !string.IsNullOrEmpty(cell.Value?.ToString())))
                {
                    MessageBox.Show("Không thể xóa", "Thông báo");
                    return;
                }

                dgvsp.Rows.RemoveAt(idx);

            }
        }

        private void Edithd_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty(dgvsp))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trong hóa đơn");
            }
            else
            {
                if (cbbmakh.Text != "" && cbbmanv.Text != "")
                {

                    HoaDonBEL cus = new HoaDonBEL();
                    cus.Makh = int.Parse(cbbmakh.Text);
                    cus.Manv = int.Parse(cbbmanv.Text);
                    cus.ngaymua = DateTime.Now;
                    cus.tongtien = intValue2;
                    int a = cusBAL3.AddHoaDon(cus);

                    foreach (DataGridViewRow row in dgvsp.Rows)
                    {

                        string columnName1 = a.ToString();
                        string columnName2 = row.Cells[2].Value.ToString();
                        string columnName3 = row.Cells[4].Value.ToString();
                        string columnName4 = row.Cells[5].Value.ToString();
                        //MessageBox.Show(columnName1);
                        //MessageBox.Show(columnName2);
                        //MessageBox.Show(columnName3);
                        //MessageBox.Show(columnName4);
                        //Mở kết nối đến cơ sở dữ liệu
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
                        SanPhamBEL tk = new SanPhamBEL();
                        tk.Ma = int.Parse(columnName2);
                        tk.Soluong = int.Parse(columnName3);
                        cusBAL2.capnhatsl(tk);
                    }
                    dgvhd.Rows.Clear();
                    dgvsp.Rows.Clear();
                    //dgvSanpham.Rows.Add( cus.Ten, cus.Soluong, cus.Gia, cus.Ncc, cus.Anh);
                    List<HoaDonBEL> lstCus = cusBAL3.ReadHoaDon();
                    foreach (HoaDonBEL c in lstCus)
                    {
                        dgvhd.Rows.Add(c.Mahd, c.Makh, c.Manv, c.ngaymua, c.tongtien);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
            }
        }

        private void tbtongtien_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbtongtien.Text, out decimal value))
            {
                // Successfully parsed the text as a decimal value
                tbtongtien.Text = value.ToString("N0"); // Format the value as desired
                tbtongtien.Select(tbtongtien.Text.Length, 0);

                // Convert the decimal value to an integer (possible loss of precision)
                intValue2 = (int)value;

            }
        }

   
    }
  

}

