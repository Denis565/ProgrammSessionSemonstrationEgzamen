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
    public partial class FormRegistrationForRace : Form
    {
        Customer customer = new Customer();
        int idRacer;
        int optionKits;
        double typeRaceAmount;

        public DataTable Data_Table
        {
            set
            {
                dataTableImport = value;

                DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[ReceUser_Seartch] ('{dataTableImport.Rows[0][3].ToString() + dataTableImport.Rows[0][4].ToString()}')");
                idRacer = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            }
        }

        SQLManager sqlManager = new SQLManager();
        private DataTable dataTableImport;

        public FormRegistrationForRace()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            sqlManager.AddComboBox(sponsor, "[dbo].[List_SponsorShip]", 1);
            sponsor.SelectedIndex = 0;

            optionKits1.Checked = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FormRacer formRacer = new FormRacer();
            formRacer.Show();
            this.Hide();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            sqlManager.performingProcedure_decimal(
                new string[] {idRacer.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), "1",Convert.ToDouble(registrationFee.Text.ToString()).ToString(),"1",Convert.ToDouble(amount.Text.ToString()).ToString() },
                "[dbo].[Registration2_insert]",
                new string [] { "ID_Racer","Registration_Date","ID_Registration_Status","Cost","ID_Charity","SponsorshipTarget" }
                );

            FormRacer formRacer = new FormRacer
            { 
                Data_Table = dataTableImport
            };
            formRacer.Show();
            this.Hide();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            optionKits = 0;
            if (radioButton.Checked)
            {
                if (radioButton.Text == "Вариант А (0$) Номер пилота + браслет")
                    optionKits += 0;

                if (radioButton.Text == "Вариант В (30$) Номер пилота + Шлем + Браслет")
                    optionKits += 30;

                if (radioButton.Text == "Вариант С (50$) Номер пилота + Экипировка + Браслет")
                    optionKits += 50;
            }

            registrationFee.Text = (Convert.ToInt32(typeRaceAmount) + optionKits).ToString();
        }

        private void typeRace_CheckedChanged(object sender, EventArgs e)
        {
            typeRaceAmount = 0.0;
            CheckBox checkBox =  (CheckBox)sender;
            int i = 0;
            foreach (var cb in panel3.Controls.OfType<CheckBox>())
            {
                if (!cb.Checked)
                {
                    i++;
                }
                else
                {
                    string text = cb.Text;

                    typeRaceAmount += Convert.ToDouble
                        (
                            text.Substring(0, text.LastIndexOf('$')).Split('(')[1].ToString()
                        );
                }
            }

            if (i == 3)
            {
                checkBox.Checked = true;
            }

            registrationFee.Text = (Convert.ToInt32(typeRaceAmount) + optionKits).ToString();
        }

        private void sponsor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[SponsorShip_Seartch] ('{sponsor.Text}')");
            amount.Text = dataTable.Rows[0][2].ToString();
        }
    }
}
