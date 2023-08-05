using bai05.BAL;
using bai05.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai05
{
    public partial class Form1 : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        AreaBAL areBAL = new AreaBAL();
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
            List<AreaBEL> lstArea = areBAL.ReadAreaList();
            foreach (AreaBEL area in lstArea)
            {
                cbKv.Items.Add(area);
            }
            cbKv.DisplayMember = "name";
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvCustomer.Rows[idx];
            if(row.Cells[0].Value!=null)
            {
                tbMa.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                cbKv.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbMa.Text);
            cus.Name = tbName.Text;
            cus.Area = (AreaBEL)cbKv.SelectedItem;
            cusBAL.NewCustomer(cus);

            dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.AreaName);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCustomer.CurrentRow;
            if (row != null)
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(tbMa.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbKv.SelectedItem;
                cusBAL.NewCustomer(cus);

                row.Cells[0].Value = cus.Id;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.AreaName;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCustomer.CurrentRow;
            if (row != null)
            {
                int customerId = int.Parse(row.Cells[0].Value.ToString());

                // Delete the customer from the database
                CustomerBEL customerToDelete = cusBAL.GetCustomerById(customerId);
                if (customerToDelete != null)
                {
                    cusBAL.DeleteCustomer(customerToDelete);
                }

                // Remove the customer from the DataGridView
                dgvCustomer.Rows.RemoveAt(row.Index);
            }
        }
        

        
    }
}
