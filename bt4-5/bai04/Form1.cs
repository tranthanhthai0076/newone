using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai04
{
    public partial class Form1 : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach (CustomerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.AreaName);
            }
          
            
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbMa.Text);
            cus.Name = tbName.Text;

            cusBAL.NewCustomer(cus);
            dgvCustomer.Rows.Add(cus.Id, cus.Name);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbMa.Text);
            cus.Name = tbName.Text;

            cusBAL.DeleteCustomer(cus);

            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            BindingSource bsCus = new BindingSource();
            bsCus.DataSource = lstCus;
            CustomerBEL cus = (CustomerBEL)bsCus.Current;
            cus.Id = int.Parse(tbMa.Text);
            cus.Name = tbName.Text;
            cusBAL.EditCustomer(cus);

            DataGridViewRow row = dgvCustomer.CurrentRow;
            row.Cells[0].Value = cus.Id;
            row.Cells[1].Value = cus.Name;
        }



        internal CustomerBEL bsCus { get; set; }

        private void btRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI ; Initial Catalog=sale1; User Id=sa; Password=sa");

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }

            conn.Close();
        }
    }
}
