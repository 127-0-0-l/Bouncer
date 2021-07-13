using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncer
{
    public partial class Form1 : Form
    {
        int mouseX;
        int mouseY;
        double bouncerX;
        double bouncerY;
        int speed = 1;
        int tickNum;
        double distance;
        double stepX;
        double stepY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            bouncerX = Bouncer.Location.X + 11;
            bouncerY = Bouncer.Location.Y + 11;
            distance = Math.Sqrt(Math.Pow(bouncerX - mouseX, 2) + Math.Pow(bouncerY - mouseY, 2));
            tickNum = Convert.ToInt32(distance / speed);
            stepX = Math.Abs(bouncerX - mouseX) / tickNum;
            stepY = Math.Abs(bouncerY - mouseY) / tickNum;

            if (bouncerX - mouseX > 0)
                stepX *= -1;

            if (bouncerY - mouseY > 0)
                stepY *= -1;

            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Bouncer.Location.X < 0 || Bouncer.Location.X > 279)
            {
                stepX *= -1;

            }

            if (Bouncer.Location.Y < 0 || Bouncer.Location.Y > 179)
            {
                stepY *= -1;
            }

            bouncerX += stepX;
            bouncerY += stepY;
            Bouncer.Location = new Point(Convert.ToInt32(bouncerX - 11), Convert.ToInt32(bouncerY - 11));
        }
    }
}
