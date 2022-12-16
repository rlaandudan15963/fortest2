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
            this.BackColor = Color.FromArgb(245, 132, 233);
            label1.Text = "this is test  ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
