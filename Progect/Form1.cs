﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progect
{
    public partial class Form1 : Form
    {
        private Customer customer = new Customer();
        public Form1()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void pictureBoxReqgistrationRacer_Click(object sender, EventArgs e)
        {
            FormCheckingEnteredData formCheckingEnteredData = new FormCheckingEnteredData();
            formCheckingEnteredData.Show();
            this.Hide();
        }

        private void pictureBoxRegistrationSponsor_Click(object sender, EventArgs e)
        {
            new FormRegistrationRacer().Show();
            this.Hide();
        }

        private void pictureBoxInformation_Click(object sender, EventArgs e)
        {
            new FormInformation().Show();
            this.Hide();
        }
    }
}
