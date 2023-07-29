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
    public partial class cau9 : Form
    {

        public cau9()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11");
        
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            conn.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex != -1)
            {
                int idx = dataGridView1.CurrentCell.RowIndex;
                string s = dataGridView1.SelectedCells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11");
                conn.Open();

                SqlCommand cmd = new SqlCommand("delete from customer where id=" + s, conn);    
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
         
            SqlConnection conn = new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into customer values (5,'nguuyen van c')", conn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into customer values("+ma.Text+", '"+name.Text+"')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
           
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into customer values (5,'nguuyen van c')", conn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update customer set name ='"+name.Text+"' where id="+ma.Text+"";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
