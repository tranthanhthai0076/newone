using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class cau7 : Form
    {
        PictureBox pbBasket=new PictureBox();
        PictureBox pbEgg=new PictureBox();
        PictureBox pbChicken =new PictureBox();
        Timer tmEgg =  new Timer();
        Timer tmChicken = new Timer();
        int a = 0;

        int xBasket = 300;
        int yBasket = 550;
        int xDeltaBasket = 30;

        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 5;

        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 3;
        public cau7()
        {
            InitializeComponent();
        }

        private void cau7_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            tmEgg.Interval = 10;
            tmEgg.Tick += TmEgg_Tick;
            tmEgg.Start();

         

            tmChicken.Interval = 10;
            tmChicken.Tick += TmChicken_Tick;
            tmChicken.Start();

            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(70, 70);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.Image = Image.FromFile("../../../img/2.jpg");

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50,50);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.Image = Image.FromFile("../../../img/3.jpg");

            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);
            pbChicken.Image = Image.FromFile("../../../img/4.jpg");

        }


        private void TmChicken_Tick(object sender, EventArgs e)
        {
            

            yEgg += yDeltaEgg;
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0 || yEgg >yBasket)
            {
                
                pbEgg.Image = Image.FromFile("../../../img/1.jpg");
        
            }
            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (unionRect.IsEmpty == false)
            {
                a += 1;
                diem.Text=a.ToString();
                yEgg = 30;
                xEgg=pbChicken.Location.X;
            }
            pbEgg.Location= new Point(xEgg,yEgg);
          
        }

        private void TmEgg_Tick(object sender, EventArgs e)
        {
         
            xChicken += xDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
                xDeltaChicken = -xDeltaChicken;
            pbChicken.Location= new Point(xChicken,yChicken);

        }
        private void cau7_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 & (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDeltaBasket;
            if (e.KeyValue == 37 & xBasket > 0)
                xBasket -= xDeltaBasket;
            pbBasket.Location = new Point(xBasket, yBasket);

        }
    }
}
