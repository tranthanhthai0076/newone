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
        public cau5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String manv = textBox1.Text.ToString();
            String ten = textBox2.Text.ToString();
            String tuoi = textBox3.Text.ToString();
            if (manv=="" || ten=="" || tuoi=="") {
                MessageBox.Show("cần nhập đủ thông tin");
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, checkBox1.Checked);
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
        private void dataGridView(object sender,DataGridViewCellCancelEventArgs e)
        {
            int idx = e.RowIndex;
            textBox1.Text=dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textBox2.Text=dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            checkBox1.Checked= bool.Parse(dataGridView1.Rows[idx].Cells[3].Value.ToString());
        }

   

        private void button4_Click(object sender, EventArgs e)
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
                int idx = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[idx].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[idx].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[idx].Cells[2].Value = textBox3.Text;
                dataGridView1.Rows[idx].Cells[3].Value = checkBox1.Checked;
            }
        }

        private void cau5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
