using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多个panel拖动变化
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Isdragging = false;

        private void GoDragging(object sender, MouseEventArgs e)
        {
            Isdragging = true;
        }
        private void OutDragging(object sender, MouseEventArgs e)
        {
            Isdragging = false;
        }

        

        private void OnDragging(object sender, MouseEventArgs e)
        {
            var selectedLabel = (Label)sender;
            if (Isdragging)
            {
                double locationRatio;
                switch (selectedLabel.Name)
                {
                    case "label1":
                        locationRatio = (double)(label1.Left + e.X) / (panel1.Width + panel2.Width);
                        if (locationRatio > 0.2 && locationRatio < 0.8)
                        {
                            label1.Left += e.X;

                            panel1.Width += e.X;

                            panel2.Left += e.X;
                            panel2.Width -= e.X;

                        }
                        break;
                    case "label2":
                        locationRatio = (double)(label2.Top + e.Y) / (panel1.Height + panel3.Height);
                        if (locationRatio > 0.2 && locationRatio < 0.8)
                        {
                            panel1.Height += e.Y;
                            panel2.Height += e.Y;

                            panel3.Top += e.Y;
                            panel3.Height -= e.Y;
                            panel4.Top += e.Y;
                            panel4.Height -= e.Y;

                            label2.Top += e.Y;
                            label1.Height += e.Y;
                            label3.Top += e.Y;
                            label3.Height -= e.Y;
                        }
                        break;
                    case "label3":
                        locationRatio = (double)(label3.Left + e.X) / (panel3.Width + panel4.Width);
                        if (locationRatio > 0.2 && locationRatio < 0.8)
                        {
                            label3.Left += e.X;

                            panel3.Width += e.X;
                            panel4.Left += e.X;
                            panel4.Width -= e.X;
                        }
                        break;
                }
            }
        }
        
    }

}
