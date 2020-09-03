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
        public Form1()
        {
            InitializeComponent();
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            bool pien = false;

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
