using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random();

        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);
        int vx2 = rand.Next(-20, 21);
        int vy2 = rand.Next(-20, 21);
        int vx3 = rand.Next(-20, 21);
        int vy3 = rand.Next(-20, 21);

        public Form1()
        {
            InitializeComponent();


            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label2.Left = rand.Next(ClientSize.Width - label1.Width);
            label2.Top = rand.Next(ClientSize.Height - label1.Height);
            label3.Left = rand.Next(ClientSize.Width - label1.Width);
            label3.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool pien = false;

            label1.Left += vx;
            label1.Top += vy;

            if(label1.Left <= 0)
            {
                vx = Math.Abs(vx);
                label1.Text = "(／・ω・)／";
            }
            if(label1.Top <= 0)
            {
                vy = Math.Abs(vy);
                label1.Text = "／(・ω・)＼";
            }
            if(label1.Right >= ClientSize.Width)
            {
                vx = -Math.Abs(vx);
                label1.Text = "＼(・ω・＼)";
            }
            if(label1.Bottom >= ClientSize.Height)
            {
                vy = -Math.Abs(vy);
                label1.Text = "＼(・ω・)／";
            }

            label2.Left += vx2;
            label2.Top += vy2;

            if (label2.Left <= 0)
            {
                vx2 = Math.Abs(vx2);
                label2.Text = "(／・ω・)／";
            }
            if (label2.Top <= 0)
            {
                vy2 = Math.Abs(vy2);
                label2.Text = "／(・ω・)＼";
            }
            if (label2.Right >= ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
                label2.Text = "＼(・ω・＼)";
            }
            if (label2.Bottom >= ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
                label2.Text = "＼(・ω・)／";
            }

            label3.Left += vx3;
            label3.Top += vy3;

            if (label3.Left <= 0)
            {
                vx3 = Math.Abs(vx3);
                label3.Text = "(／・ω・)／";
            }
            if (label3.Top <= 0)
            {
                vy3 = Math.Abs(vy3);
                label3.Text = "／(・ω・)＼";
            }
            if (label3.Right >= ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
                label3.Text = "＼(・ω・＼)";
            }
            if (label3.Bottom >= ClientSize.Height)
            {
                vy3 = -Math.Abs(vy3);
                label3.Text = "＼(・ω・)／";
            }

            Point mp = MousePosition;
            mp = PointToClient(mp);
            if(     mp.X > label1.Left 
                &&  mp.X < label1.Right
                &&  mp.Y > label1.Top
                &&  mp.Y < label1.Bottom)
            {
                if (!pien)
                {
                    timer1.Enabled = false;
                    label1.Text = "(´；ω；`)ｳｩｩ";
                    pien = true;
                    MessageBox.Show("ぴえん");
                    timer1.Enabled = true;
                    vx = rand.Next(-20, 21);
                    vy = rand.Next(-20, 21);
                    label1.Left = rand.Next(ClientSize.Width - label1.Width);
                    label1.Top = rand.Next(ClientSize.Height - label1.Height);
                    label1.Text = "＼(・ω・)／";
                }
            }
        }
    }
}
