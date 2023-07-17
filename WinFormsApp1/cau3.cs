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
    public partial class cau3 : Form
    {
        string path = @"D:\form.xml";
        public cau3()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }
        public InfoWindows Read()
        {
            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path); 
            InfoWindows iw = (InfoWindows)reader.Deserialize(file);
            file.Close();
            return iw;
        }
        
    }
}
