using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class cau5 : Form
    {
        ArrayList lstEm;
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;

        List<ImageData> imageList = new List<ImageData>();
        private string imagePath;
        private object opnfd;

        public cau5()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("aaaa", "tran thai", "tuoi", false, @"C:\Users\MSII\Desktop\c#\tranthanhthai_0076\WinFormsApp1\img\2.jpg");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String manv = textBox1.Text.ToString();
            String ten = textBox2.Text.ToString();
            String tuoi = textBox3.Text.ToString();
            if (manv == "" || ten == "" || tuoi == "" || imagePath == "")
            {
                MessageBox.Show("cần nhập đủ thông tin");
            }
            else
            {
                Image image = Image.FromFile(imagePath);

                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, checkBox1.Checked, imagePath);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex != -1)
            {
                int idx = dataGridView1.CurrentCell.RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[idx];
                if (!selectedRow.Cells.Cast<DataGridViewCell>().Any(cell => !string.IsNullOrEmpty(cell.Value?.ToString())))
                {
                    MessageBox.Show("Không thể xóa", "Thông báo");
                    return;
                }

                dataGridView1.Rows.RemoveAt(idx);

            }
        }
        private void dataGridView(object sender, DataGridViewCellCancelEventArgs e)
        {
            int idx = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            checkBox1.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[3].Value.ToString());


        }



        private void button4_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[idx].Cells[0].Value != null)
            {
                String manv = textBox1.Text.ToString();
                String ten = textBox2.Text.ToString();
                String tuoi = textBox3.Text.ToString();
                if (manv == "" || ten == "" || tuoi == "")
                {
                    MessageBox.Show("cần nhập đủ thông tin");
                }
                else
                {

                    dataGridView1.Rows[idx].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[idx].Cells[1].Value = textBox2.Text;
                    dataGridView1.Rows[idx].Cells[2].Value = textBox3.Text;
                    dataGridView1.Rows[idx].Cells[3].Value = checkBox1.Checked;
                    dataGridView1.Rows[idx].Cells[4].Value = imagePath;
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp tin

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh đã chọn
                imagePath = openFileDialog.FileName;

                // Load ảnh từ đường dẫn và thêm vào DataGridViewImageColumn

                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = new Bitmap(openFileDialog.FileName); // Update the pb PictureBox with the selected image
                // Lưu thông tin ảnh vào danh sách
                imageList.Add(new ImageData { ImagePath = imagePath });

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (dataGridView1.Rows[selectedRowIndex].Cells[4].Value != null)
                {
                    // Lấy đường dẫn hình ảnh từ cột "ImagePath"
                    string imagePath = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBox1.Image = new Bitmap(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}