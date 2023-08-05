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
    public partial class cau12 : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        public cau12()
        {
            InitializeComponent();
        }

        private void cau12_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach(CustomerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Id,cus.Name);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id= int.Parse(id.Text);
            cus.Name = name.Text;
            cusBAL.AddCustomer(cus);
            dgvCustomer.Rows.Add(cus.Id, cus.Name);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            BindingSource bsCus = new BindingSource();
            bsCus.DataSource = lstCus;
            CustomerBEL cus = (CustomerBEL)bsCus.Current;
            cus.Id = int.Parse(id.Text);
            cus.Name= name.Text;
            cusBAL.EditCustomer(cus);
            DataGridViewRow row = dgvCustomer.CurrentRow;
            row.Cells[0].Value = cus.Id;
            row.Cells[1].Value = cus.Name;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus =new CustomerBEL();
            //cus.Id=int.Parse(id.Text);
            //cus.Name=name.Text;
            cusBAL.DeleteCustomer(cus);
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
