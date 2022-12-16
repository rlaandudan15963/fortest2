using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Image image = new Bitmap(@"C:\Users\limm1\Desktop\2-2학기\3D프린팅\KakaoTalk_20221110_150049076.jpg");
            this.BackgroundImage = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
