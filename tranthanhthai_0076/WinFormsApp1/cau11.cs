using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class cau11 : Form
    {
        string gt;
        private string imagePath;
        string nameimg;
        PictureBox pb = new PictureBox();
        public cau11()
        {
            InitializeComponent();
        }

        private void cau11_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= test; User Id=sa; Password=11");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvcustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

                }
            }
            conn.Close();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            String manv = id.Text.ToString();
            String ten = name.Text.ToString();
            String tuoi = age.Text.ToString();
            if (manv == "" || ten == "" || tuoi == ""||radionam.Checked==false && radionu.Checked==false)
            {
                MessageBox.Show("cần nhập đủ thông tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= test; User Id=sa; Password=11";
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into customer values(" + id.Text + ",N'" + name.Text + "','" + age.Text + "',N'" + gt + "',N'" + nameimg + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvcustomer.Rows.Add(id.Text, name.Text, age.Text, gt, nameimg);

            }
           
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string t;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= test; User Id=sa; Password=11";
            conn.Open();
            if (nameimg !=null)
            {
                SqlCommand cmd = new SqlCommand("update customer set name=N'" + name.Text + "', tuoi='" + age.Text + "', gioitinh=N'" + gt + "', anh=N'" + nameimg + "'  where id =" + id.Text + "", conn);
                cmd.ExecuteNonQuery();
                t = nameimg;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update customer set name=N'" + name.Text + "', tuoi='" + age.Text + "', gioitinh=N'" + gt + "', anh=N'" + img + "'  where id =" + id.Text + "", conn);
                cmd.ExecuteNonQuery();
                t=img;
            }
           
           


            //dgvcustomer.Rows.Clear();
            //SqlCommand e1 = new SqlCommand("select * from customer", conn);
            //SqlDataReader reader = e1.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        dgvcustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

            //    }
            //}
            conn.Close();
            int idx = dgvcustomer.CurrentCell.RowIndex;
            dgvcustomer.Rows[idx].Cells[0].Value = id.Text;
            dgvcustomer.Rows[idx].Cells[1].Value = name.Text;
            dgvcustomer.Rows[idx].Cells[2].Value = age.Text;
            dgvcustomer.Rows[idx].Cells[3].Value = gt;
            dgvcustomer.Rows[idx].Cells[4].Value = t;

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= test; User Id=sa; Password=11";
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where id=" + id.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dgvcustomer.CurrentCell.RowIndex;
            dgvcustomer.Rows.RemoveAt(idx);
        }

    

        private void radionam_CheckedChanged(object sender, EventArgs e)
        {
            if (radionam.Checked)
            {
                gt = "Nam";
            }
        }

        private void radionu_CheckedChanged(object sender, EventArgs e)
        {
            if(radionu.Checked)
            {
                gt = "Nữ";
            }    
        }

        private void Anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp tin

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh đã chọn
                imagePath = openFileDialog.FileName;
                string selectedImagePath = openFileDialog.FileName;

                // Lưu ảnh vào thư mục chỉ định
                string targetDirectory = @"C:\Users\MSII\Desktop\c#\tranthanhthai_0076\WinFormsApp1\img\"; // Thay đổi đường dẫn tới thư mục mong muốn
                string targetFileName = Path.Combine(targetDirectory, Path.GetFileName(selectedImagePath));

                nameimg = Path.GetFileName(selectedImagePath);


                File.Copy(selectedImagePath, targetFileName, true);
                // Load ảnh từ đường dẫn và thêm vào DataGridViewImageColumn

                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = new Bitmap(openFileDialog.FileName); // Update the pb PictureBox with the selected image
                                                                // Lưu thông tin ảnh vào danh sách


            }
        }
        string img;
        private void dgvcustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvcustomer.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvcustomer.SelectedCells[0].RowIndex;
                id.Text = dgvcustomer.SelectedCells[0].Value.ToString();
                name.Text = dgvcustomer.SelectedCells[1].Value.ToString();
                //age.Text = dgvcustomer.SelectedCells[2].Value.ToString();
                if (dgvcustomer.SelectedCells[4].Value != null)
                {
                     img = dgvcustomer.SelectedCells[4].Value.ToString();
                }
               
                if (File.Exists(@"C:\Users\MSII\Desktop\c#\tranthanhthai_0076\WinFormsApp1\img\"+img))
                {

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBox1.Image = new Bitmap(@"C:\Users\MSII\Desktop\c#\tranthanhthai_0076\WinFormsApp1\img\" + img);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            else
            {
                id.Text = null;
                name.Text = null;
                age.Text = null;
                pictureBox1.Image = null;
            }
        }
    }
}
