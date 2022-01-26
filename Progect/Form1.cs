using System;
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
        private DateTime timeNow;
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            timeNow = DateTime.Now;

            headDate.Text = $"Москва, Россия {timeNow.ToLongDateString()}";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeEnd = new DateTime(2027,06,20,00,00,00);
            DateTime res = new DateTime((dateTimeEnd - DateTime.Now).Ticks);

            double sec = res.Second - 1;
            double secresult = sec < 0 ? 0 : sec;

            timeEndLable.Text = $"До начала события осталось {res.Year - 1} лет, " +
                $"{res.Month - 1} месяцев, " +
                $"{res.Day - 1} дней, " +
                $"{res.Hour - 1} часов, " +
                $"{res.Minute - 1} минут и " +
                $"{secresult} секунд";

            if (res.Second < 0) {
                timer1.Stop();
            }

            
        }

        private void pictureBoxReqgistrationRacer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRegistrationSponsor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxInformation_Click(object sender, EventArgs e)
        {
            new FormInformation().Show();
            this.Hide();
        }

        private void pictureBoxEntrance_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headDate_Click(object sender, EventArgs e)
        {

        }

        private void headText_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeEndLable_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
