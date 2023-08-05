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
    public partial class cau13 : Form
    {
        public cau13()
        {
            InitializeComponent();
            string input = "Hello world vn";
            char result = GetCharacterAfterSpace(input);
            MessageBox.Show(""+result);
        }

        private void cau13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public static char GetCharacterAfterSpace(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == ' ')
                {
                    // Trả về kí tự đầu tiên sau khoảng trắng
                    return input[i + 1];
                }
            }
            // Nếu không tìm thấy kí tự sau khoảng trắng, bạn có thể xử lý tùy ý ở đây.
            // Ví dụ: return '\0'; // Trả về kí tự null
            throw new ArgumentException("Không tìm thấy khoảng trắng trong chuỗi.");
        }
    }
}
