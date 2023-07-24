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
    public partial class cau8 : Form
    {
        PictureBox pbBasket =new PictureBox();
        int xBasket = 300;
        int yBasket = 500;
        int xDelta = 30;
        public cau8()
        {
            InitializeComponent();
        }

        private void cau8_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100,100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.Image = Image.FromFile("../../../img/3.jpg");

        }

        private void cau8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 & (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDelta;
            if(e.KeyValue ==37 & xBasket>0)
                xBasket -= xDelta;
            pbBasket.Location =new Point(xBasket, yBasket);

        }
    }
}
