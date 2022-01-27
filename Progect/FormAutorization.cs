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
    public partial class FormAutorization : Form
    {
        private Customer customer = new Customer();
        public FormAutorization()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            switch (email.Text) 
            {
                case "racer":
                    new FormRacer().Show();
                    this.Hide();
                    break;

                case "coordinator":
                    new FormCoordinatorcs().Show();
                    this.Hide();
                    break;

                case "admin":
                    new FormAdmin().Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Авторизация не пройдена.");
                    break;
            }
        }
    }
}
