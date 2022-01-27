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
    public partial class FormRosterСharitableOrganizations : Form
    {
        private Customer customer = new Customer();

        public static List<PictureBox> PictureBoxList = new List<PictureBox>();
        public static List<Label> LableNameOrganizationList = new List<Label>();
        public static List<Label> LableInformationList = new List<Label>();

        public FormRosterСharitableOrganizations()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            panelBox.AutoScroll = true;
            init_list_сharity();
        }

        private async void init() 
        {
            await Task.Run(() => init_list_сharity());
        }

        private async void init_list_сharity()
        {
            for (int i = 0; i < 10; i++)
            {
                PictureBox pictureBox = new PictureBox();
                Label labelNameOrg = new Label();
                Label labelInform = new Label();

                PictureBox lastOldPictureBox = PictureBoxList.LastOrDefault();
                Label lastOldLableNameOrganization = LableNameOrganizationList.LastOrDefault();
                Label lastOldLableInformation = LableInformationList.LastOrDefault();

                pictureBox.Image = Properties.Resources.logotip_charity;
                pictureBox.Size = new System.Drawing.Size(100, 100);
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox.TabIndex = 18;
                pictureBox.TabStop = false;


                labelNameOrg.AutoSize = true;
                labelNameOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelNameOrg.Size = new System.Drawing.Size(588, 29);
                labelNameOrg.TabIndex = 19;
                labelNameOrg.Text = "Наименование благотворительной оргонизации";

                labelInform.AutoSize = true;
                labelInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelInform.Size = new System.Drawing.Size(620, 48);
                labelInform.TabIndex = 20;
                labelInform.Text = "Описание благотворительности. Описание благотворительности.";


                if (lastOldPictureBox == null)
                {
                    pictureBox.Location = new System.Drawing.Point(4, 0);
                    labelNameOrg.Location = new System.Drawing.Point(160, 10);
                    labelInform.Location = new System.Drawing.Point(160, 40);
                }
                else
                {
                    pictureBox.Location = new System.Drawing.Point(lastOldPictureBox.Location.X, lastOldPictureBox.Location.Y + 120);
                    labelNameOrg.Location = new System.Drawing.Point(lastOldLableNameOrganization.Location.X, lastOldLableNameOrganization.Location.Y + 120);
                    labelInform.Location = new System.Drawing.Point(lastOldLableInformation.Location.X, lastOldLableInformation.Location.Y + 120);
                }

                PictureBoxList.Add(pictureBox);
                LableNameOrganizationList.Add(labelNameOrg);
                LableInformationList.Add(labelInform);

                panelBox.Controls.AddRange(new Control[] {
                    pictureBox,labelNameOrg,labelInform
                });
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            new FormInformation().Show();
            this.Hide();
        }
    }
}
