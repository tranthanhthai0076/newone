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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cau1 objForm01 = new cau1();
            objForm01.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cau2 objForm01 = new cau2();
            objForm01.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cau3 objForm01 = new cau3();
            objForm01.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cau4 objForm01 = new cau4();
            objForm01.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cau5 objForm01 = new cau5();
            objForm01.ShowDialog();
        }
    }
}
