﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4th_sem_proj_beta
{
    public partial class AvailableAreas : Form
    {
        public AvailableAreas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main ok = new Main();
            ok.Show();
            this.Hide();
        }

        private void lblabout_Click(object sender, EventArgs e)
        {
            Aboutus ok = new Aboutus();
            ok.Show();
            this.Hide();
        }

        private void lblareas_Click(object sender, EventArgs e)
        {
            AvailableAreas ok = new AvailableAreas();
            ok.Show();
            this.Hide();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            HowToOrder ok = new HowToOrder();
            ok.Show();
            this.Hide();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            Fqs ok = new Fqs();
            ok.Show();
            this.Hide();
        }

        private void label42_Click(object sender, EventArgs e)
        {
            ContactUs ok = new ContactUs();
            ok.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Red;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Tan;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }
    }
}
