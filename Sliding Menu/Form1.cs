using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isShow;
        bool isShowP;
        int requiredHeight = 6;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Height = 3;
            panel1.Height = requiredHeight; 
            button1.Text = "Show";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel2.Height.Equals(3))  //this will hide the panal
            {
                isShow = false;
                isShowP = false;
                button1.Text = "Show";
                timer1.Start();
            }
            else   ////this will show the panal
            {
                isShow = true;
                button1.Text = "Hide";
               // panel2.Show();
                timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isShow) //true
            {
                if (panel2.Height >= 63)
                    timer1.Stop();
                panel2.Height += 3;
            }

            else //false
            {
                panel2.Height -= 3;

                if (panel2.Height.Equals(3))
                    timer1.Stop();  
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Corsor on button control";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Cursor leave the button";
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            if (panel1.Height.Equals(requiredHeight))   ////this will show the panal
            {
                isShowP = true;
                panel1.Show();
                timer2.Start();

            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (!panel1.Height.Equals(requiredHeight))  //this will hide the panal
            {
                isShowP = false;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isShowP) //true
            {
                if (panel1.Height >= 94)
                    timer2.Stop();
                panel1.Height += requiredHeight;
            }

            else //false
            {
                panel1.Height -= requiredHeight;

                if (panel1.Height.Equals(requiredHeight))
                    timer2.Stop();
            }

        }
    }
}
