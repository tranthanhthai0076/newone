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
    public partial class cau10 : Form
    {
        public cau10()
        {
            InitializeComponent();
        }

        private void cau10_Load(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11");
            conn.Open();
            SqlCommand cmd=new SqlCommand("select * from customer",conn);
            SqlDataReader reader=cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    drvcustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                }
            }
            conn.Close();

        }

        private void drvcustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            lbId.Text = drvcustomer.Rows[idx].Cells[0].Value.ToString();
            lbName.Text = drvcustomer.Rows[idx].Cells[1].Value.ToString();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11";
            conn.Open();
            SqlCommand cmd =new SqlCommand("insert into customer values("+lbId.Text+",'"+lbName.Text+"')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            drvcustomer.Rows.Add(lbId.Text,lbName.Text);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11";
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set name='" + lbName.Text + "'where id =" + lbId.Text+"", conn);
            cmd.ExecuteNonQuery();
            

            drvcustomer.Rows.Clear();
            SqlCommand e1 = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = e1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    drvcustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                }
            }
            conn.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11";
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where id="+lbId.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = drvcustomer.CurrentCell.RowIndex;
            drvcustomer.Rows.RemoveAt(idx);
        }
    }
}
