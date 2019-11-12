using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Controller
{
    public partial class Controller : UserControl
    {
        public Controller()
        {
            InitializeComponent();
        }

        static string[] str = new string[] { "C#1", "C#2", "C#3", "C#4" };
        ArrayList arrayList = new ArrayList();
        static int Index = 0;
        int c;

        private void Controller_Load(object sender, EventArgs e)//控件初始加载
        {
            for (int i = 0; i < str.Length; i++)
            {
                arrayList.Add(str[i]);
            }
            c = arrayList.Count;
            this.label1.Text = str[0];
            this.label2.Text = str[1];
            this.label3.Text = str[2];

            

        }



        //public void GetStr()
        //{

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        arrayList.Add(str[i]);
        //    }
        //    c = arrayList.Count;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ++Index;
            if (Index >= c) Index -= c;
            label1.Text = (string)arrayList[Index < c ? Index : Index - c];
            label2.Text = (string)arrayList[Index + 1 < c ? Index + 1 : Index + 1 - c];
            label3.Text = (string)arrayList[Index + 2 < c ? Index + 2 : Index + 2 - c];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            --Index;
            if (Index <= 0) Index += c;
            label1.Text = (string)arrayList[Index < c ? Index : Index - c];
            label2.Text = (string)arrayList[Index + 1 < c ? Index + 1 : Index + 1 - c];
            label3.Text = (string)arrayList[Index + 2 < c ? Index + 2 : Index + 2 - c];
        }

        private void Controller_Resize(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(ClientRectangle.Left, ClientRectangle.Top);
            button1.Size = new System.Drawing.Size(ClientRectangle.Height, ClientRectangle.Height);

            label1.Location = new System.Drawing.Point(ClientRectangle.Left + 40, ClientRectangle.Top + 3);
            label1.Size = new System.Drawing.Size((int)((ClientRectangle.Width - 100) * 0.3), ClientRectangle.Height - 6);

            label2.Location = new System.Drawing.Point(label1.Left + label1.Width + 10, ClientRectangle.Top + 1);
            label2.Size = new System.Drawing.Size((int)((ClientRectangle.Width - 100) * 0.4), ClientRectangle.Height - 2);

            label3.Location = new System.Drawing.Point(label2.Left + label2.Width + 10, ClientRectangle.Top + 3);
            label3.Size = new System.Drawing.Size((int)((ClientRectangle.Width - 100) * 0.3), ClientRectangle.Height - 6);

            button2.Location = new System.Drawing.Point(ClientRectangle.Left + ClientRectangle.Width - ClientRectangle.Height, ClientRectangle.Top);
            button2.Size = new System.Drawing.Size(ClientRectangle.Height, ClientRectangle.Height);
        }
    }
}
