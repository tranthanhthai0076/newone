using QLBHST.BALL;
using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHST.GUII
{
    public partial class Gdht : Form
    {
        string nameimg;

        string img;
        string ma1;
        bool bay = false;
        PictureBox pb = new PictureBox();
        SanPhamBAL cusBAL1 = new SanPhamBAL();
        NhaCungCapBAL cusBAL = new NhaCungCapBAL();
        public Gdht()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
            dgvSanpham.RowsDefaultCellStyle.BackColor = Color.LightGray; // Thay đổi màu nền của các hàng trong DataGridView thành LightGray
            dgvSanpham.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // Thay đổi màu nền của các hàng lẻ thành White
            dgvSanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbma.Enabled = false;




        }


        private void LoadDataIntoComboBox()
        {
            try
            {
                List<NhaCungCapBEL> lstCus = cusBAL.ReadNhaCungCap();
                foreach (NhaCungCapBEL cus in lstCus)
                {

                    cbbncc.Items.Add(cus.Ten);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void Gdht_Load(object sender, EventArgs e)
        {
            List<SanPhamBEL> lstCus = cusBAL1.ReadSanPham();
            foreach (SanPhamBEL cus in lstCus)
            {
                dgvSanpham.Rows.Add(cus.Ma, cus.Ten, cus.Soluong, cus.Gia, cus.Ncc, cus.Anh);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (bay == true)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {

                SanPhamBEL cus = new SanPhamBEL();


                cus.Ten = tpten.Text;
                cus.Gia = int.Parse(tbgia.Text);
                cus.Soluong = int.Parse(tbsl.Text);
                cus.Ncc = cbbncc.Text;
                cus.Anh = nameimg;
                cusBAL1.AddSanPham(cus);
                dgvSanpham.Rows.Clear();
                //dgvSanpham.Rows.Add( cus.Ten, cus.Soluong, cus.Gia, cus.Ncc, cus.Anh);
                List<SanPhamBEL> lstCus = cusBAL1.ReadSanPham();
                foreach (SanPhamBEL c in lstCus)
                {
                    dgvSanpham.Rows.Add(c.Ma, c.Ten, c.Soluong, c.Gia, c.Ncc, c.Anh);
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp tin

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh đã chọn
                string imagePath = openFileDialog.FileName;
                string selectedImagePath = openFileDialog.FileName;

                // Lưu ảnh vào thư mục chỉ định
                string targetDirectory = @"C:\Users\MSII\Desktop\c#\TranThanhThai_0076_QLBHST\QLBHST\img\"; // Thay đổi đường dẫn tới thư mục mong muốn
                string targetFileName = Path.Combine(targetDirectory, Path.GetFileName(selectedImagePath));

                nameimg = Path.GetFileName(selectedImagePath);


                File.Copy(selectedImagePath, targetFileName, true);
                // Load ảnh từ đường dẫn và thêm vào DataGridViewImageColumn

                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void dgvSanpham_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvSanpham.SelectedCells.Count > 0)
            {

                tbma.Text = dgvSanpham.SelectedCells[0].Value.ToString();
                ma1 = tbma.Text;
                tpten.Text = dgvSanpham.SelectedCells[1].Value.ToString();
                tbsl.Text = dgvSanpham.SelectedCells[2].Value.ToString();
                tbgia.Text = dgvSanpham.SelectedCells[3].Value.ToString();
                cbbncc.Text = dgvSanpham.SelectedCells[4].Value.ToString();
                //age.Text = dgvcustomer.SelectedCells[2].Value.ToString
                bay = false;
                if (dgvSanpham.SelectedCells[5].Value != null)
                {
                    img = dgvSanpham.SelectedCells[5].Value.ToString();
                }

                if (File.Exists(@"C:\Users\MSII\Desktop\c#\TranThanhThai_0076_QLBHST\QLBHST\img\" + img))
                {

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBox1.Image = new Bitmap(@"C:\Users\MSII\Desktop\c#\TranThanhThai_0076_QLBHST\QLBHST\img\" + img);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            else
            {
                tbma.Text = null;
                tpten.Text = null;
                tbgia.Text = null;
                cbbncc.Text = null;
                tbsl.Text = null;
                pictureBox1.Image = null;
                bay = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bay == true)
            {
                MessageBox.Show("Không thể sửa");
            }
            else
            {
                if (nameimg != null)
                {
                    SanPhamBEL cus = new SanPhamBEL();
                    cus.Ma = int.Parse(tbma.Text);

                    cus.Ten = tpten.Text;
                    cus.Gia = int.Parse(tbgia.Text);
                    cus.Soluong = int.Parse(tbsl.Text);
                    cus.Ncc = cbbncc.Text;
                    cus.Anh = nameimg;
                    cusBAL1.EditSanPham(cus);
                    int idx = dgvSanpham.CurrentCell.RowIndex;
                    dgvSanpham.Rows[idx].Cells[0].Value = tbma.Text;
                    dgvSanpham.Rows[idx].Cells[1].Value = tpten.Text;
                    dgvSanpham.Rows[idx].Cells[2].Value = tbsl.Text;
                    dgvSanpham.Rows[idx].Cells[3].Value = tbgia.Text;
                    dgvSanpham.Rows[idx].Cells[4].Value = cbbncc.Text;
                    dgvSanpham.Rows[idx].Cells[5].Value = nameimg;
                }
                else
                {
                    SanPhamBEL cus = new SanPhamBEL();
                    cus.Ma = int.Parse(tbma.Text);
                    cus.Ten = tpten.Text;
                    cus.Gia = int.Parse(tbgia.Text);
                    cus.Soluong = int.Parse(tbsl.Text);
                    cus.Ncc = cbbncc.Text;
                    cus.Anh = img;
                    cusBAL1.EditSanPham(cus);
                    int idx = dgvSanpham.CurrentCell.RowIndex;
                    dgvSanpham.Rows[idx].Cells[0].Value = tbma.Text;
                    dgvSanpham.Rows[idx].Cells[1].Value = tpten.Text;
                    dgvSanpham.Rows[idx].Cells[2].Value = tbsl.Text;
                    dgvSanpham.Rows[idx].Cells[3].Value = tbgia.Text;
                    dgvSanpham.Rows[idx].Cells[4].Value = cbbncc.Text;
                    dgvSanpham.Rows[idx].Cells[5].Value = img;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bay == true)
            {
                MessageBox.Show("Không thể xóa");
            }
            else
            {
                SanPhamBEL cus = new SanPhamBEL();
                cus.Ma = int.Parse(tbma.Text);
                cusBAL1.DeleteSanPham(cus);
                int idx = dgvSanpham.CurrentCell.RowIndex;
                dgvSanpham.Rows.RemoveAt(idx);
            }

        }

        private void timkiem(object sender, EventArgs e)
        {

            dgvSanpham.Rows.Clear();
            SanPhamBEL cus = new SanPhamBEL();
            cus.Ten = sreach.Text;
            List<SanPhamBEL> lstCus = cusBAL1.Timkiem(cus);
            foreach (SanPhamBEL c in lstCus)
            {
                dgvSanpham.Rows.Add(c.Ma, c.Ten, c.Soluong, c.Gia, c.Ncc, c.Anh);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //// Create a new Excel workbook and worksheet
            //using (var workbook = new XLWorkbook())
            //{
            //    var worksheet = workbook.Worksheets.Add("Sheet1");

            //    // Loop through the DataGridView rows and columns to export the data
            //    // Loop through the DataGridView rows and columns to export the data
            //    for (int rowIndex = 0; rowIndex < dgvcustomer.Rows.Count; rowIndex++)
            //    {
            //        for (int colIndex = 0; colIndex < dgvcustomer.Columns.Count; colIndex++)
            //        {
            //            // Excel uses 1-based indexing for rows and columns
            //            // So we add 1 to rowIndex and colIndex to get the correct cell in Excel
            //            object cellValue = dgvcustomer.Rows[rowIndex].Cells[colIndex].Value;
            //            string cellStringValue = cellValue != null ? cellValue.ToString() : "";
            //            worksheet.Cell(rowIndex + 1, colIndex + 1).Value = cellStringValue;
            //        }
            //    }


            //    // Save the Excel file
            //    SaveFileDialog saveFileDialog = new SaveFileDialog
            //    {
            //        Filter = "Excel Files|*.xlsx",
            //        Title = "Save Excel File",
            //        FileName = "ExportedData.xlsx"
            //    };

            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        workbook.SaveAs(saveFileDialog.FileName);
            //        MessageBox.Show("Xuất dữ liệu thành công!");
            //    }
            //}
        }
    }
}
