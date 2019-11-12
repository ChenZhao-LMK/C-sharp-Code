using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图表左右移动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Location.Y > 10)
            {
                this.pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width - (pictureBox1.Location.X + pictureBox1.Width) > 10)
            {
                this.pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel1.Height - (pictureBox1.Location.Y + pictureBox1.Height) > 10)
            {
                this.pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 10)
            {
                this.pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }
        }
        
        private void button5_Click(object sender, EventArgs e)//放大
        {
            if (pictureBox1.Location.X+ pictureBox1.Width * 1.2 < panel1.Width && pictureBox1.Location.Y+pictureBox1.Height * 1.2 < panel1.Height)
            {
                pictureBox1.Width = (int)(pictureBox1.Width * 1.2);
                pictureBox1.Height = (int)(pictureBox1.Height * 1.2);
            }
            else
            {
                double r = (double)pictureBox1.Height / pictureBox1.Width;
                pictureBox1.Width = panel1.Width - pictureBox1.Location.X;
                pictureBox1.Height = (int)(pictureBox1.Width * r);
            }
        }

        private void button6_Click(object sender, EventArgs e)//缩小
        {
            if (pictureBox1.Width > 200)
            {
                pictureBox1.Width = (int)(pictureBox1.Width * 0.8);
                pictureBox1.Height = (int)(pictureBox1.Height * 0.8);
            }
        }
    }
}
