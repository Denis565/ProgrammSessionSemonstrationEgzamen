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
    public partial class FormConfirmation : Form
    {
        private DateTime timeNow;

        public FormConfirmation(string nameRacer,string sum)
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            timeNow = DateTime.Now;

            headDate.Text = $"Москва, Россия {timeNow.ToLongDateString()}";

            donationAmount.Text = sum;
            this.nameRacer.Text = $"{nameRacer} из Russia";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeEnd = new DateTime(2027, 06, 20, 00, 00, 00);
            DateTime res = new DateTime((dateTimeEnd - DateTime.Now).Ticks);

            double sec = res.Second - 1;
            double secresult = sec < 0 ? 0 : sec;

            timeEndLable.Text = $"До начала события осталось {res.Year - 1} лет, " +
                $"{res.Month - 1} месяцев, " +
                $"{res.Day - 1} дней, " +
                $"{res.Hour - 1} часов, " +
                $"{res.Minute - 1} минут и " +
                $"{secresult} секунд";

            if (res.Second < 0)
            {
                timer1.Stop();
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
