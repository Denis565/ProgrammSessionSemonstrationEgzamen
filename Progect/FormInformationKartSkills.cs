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
    public partial class FormInformationKartSkills : Form
    {
        private Customer customer = new Customer();

        public FormInformationKartSkills()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void mapMin_Click(object sender, EventArgs e)
        {
            new FormMapMax().Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }
    }
}
