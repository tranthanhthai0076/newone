using System;
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

    public partial class cau4 : Form
    {

        List<ImageData> imageList = new List<ImageData>();
        private string imagePath;

        public cau4()
        {
            InitializeComponent();
            // Thêm một DataGridViewImageColumn vào DataGridView (nếu chưa có)
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.Name = "ImageColumn";
            dataGridView1.Columns.Add(imageColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            // Mở OpenFileDialog để người dùng chọn hình ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp tin

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh đã chọn
                imagePath = openFileDialog.FileName;

                // Load ảnh từ đường dẫn và thêm vào DataGridViewImageColumn
             

                // Lưu thông tin ảnh vào danh sách
                imageList.Add(new ImageData { ImagePath = imagePath });
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath);
            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells["ImageColumn"].Value = image;
        }

        private void cau4_Load(object sender, EventArgs e)
        {

        }
    }
}
public class ImageData
{
    public string ImagePath { get; set; }
}