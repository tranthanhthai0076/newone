﻿using System;
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
    public partial class cau1 : Form
    {
        public cau1()
        {
            InitializeComponent();
        }

        private void a(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
        }

        private void a1(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() +" - "+ height.ToString(); 
        }
    }
}
