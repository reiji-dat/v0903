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

        int nin = 100;
        int score;

        int [] vx = new int[100];
        int [] vy = new int[100];
        Label[] labels = new Label[100];

        public Form1()
        {
            InitializeComponent();
            score = nin;

            for (int i = 0; i < nin; i++)
            {
                vx[i] = rand.Next(-10,11);
                vy[i] = rand.Next(-20,21);
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "＼(・ω・)／";
                Controls.Add(labels[i]);
                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < nin; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
                if (labels[i].Left <= 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                    labels[i].Text = "(／・ω・)／";
                }
                if (labels[i].Top <= 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                    labels[i].Text = "／(・ω・)＼";
                }
                if (labels[i].Right >= ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                    labels[i].Text = "＼(・ω・＼)";
                }
                if (labels[i].Bottom >= ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                    labels[i].Text = "＼(・ω・)／";
                }
            }

            Point mp = MousePosition;
            mp = PointToClient(mp);

            for (int i = 0; i < nin; i++)
            {
                if (mp.X > labels[i].Left
                    && mp.X < labels[i].Right
                    && mp.Y > labels[i].Top
                    && mp.Y < labels[i].Bottom)
                {
                    labels[i].Visible = false;
                    score--;
                }
            }
        }
    }
}
