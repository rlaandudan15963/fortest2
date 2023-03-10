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
    public partial class Form1 : Form
    {
        public int red = 0;
        public int green = 0;
        public int blue = 0;
        int i = 1;
        Point[] pt = new Point[1];
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            red = trackBar1.Value;
            label1.ForeColor = Color.FromArgb(red, 0, 0);
            label2.ForeColor = Color.FromArgb(red, green, blue);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.FromArgb(red, green, blue));
            if(i > 2)
                g.DrawLines(p, pt);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Array.Resize(ref pt, i);
            pt[i-1] = e.Location;
            i++;
            Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar2.Value.ToString();
            green = trackBar2.Value;
            label3.ForeColor = Color.FromArgb(0, green, 0);
            label2.ForeColor = Color.FromArgb(red, green, blue);
            Invalidate();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar3.Value.ToString();
            blue = trackBar3.Value;
            label4.ForeColor = Color.FromArgb(0, 0, blue);
            label2.ForeColor = Color.FromArgb(red, green, blue);
            Invalidate();
        }
    }
}
