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
    public partial class FormListСharitableOrganizations : Form
    {
        private Customer customer = new Customer();

        public static List<TextBox> TextBoxes = new List<TextBox>();

        public FormListСharitableOrganizations()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            panelBox.AutoScroll = true;

            init();
        }

        private void init() {
            for (int i = 0; i < 100; i++)
            {
                /*TextBox newTextBox = new TextBox();
                TextBox lastOldTextBox = TextBoxes.LastOrDefault();
                if (lastOldTextBox == null)
                {
                    newTextBox.Location = new Point(30, 50);
                    newTextBox.Text = "Hello World!";
                }
                else
                {
                    newTextBox.Location = new Point(lastOldTextBox.Location.X, lastOldTextBox.Location.Y + 30);
                    newTextBox.Text = $"Hello World! ({TextBoxes.Count})";
                }
                TextBoxes.Add(newTextBox);
                panelBox.Controls.Add(newTextBox);*/

                int index = 30 * i;

                if (i == 0) {
                    index = 2;
                }

                PictureBox pictureBox = new PictureBox();
                Bitmap bitmap = Properties.Resources.logotip;
                pictureBox.Image = bitmap;
                pictureBox.Location = new System.Drawing.Point(6, 6);
                pictureBox.Size = new System.Drawing.Size(144, 115);
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox.TabIndex = 18;
                pictureBox.TabStop = false;

                Label labelNameOrg = new Label();
                labelNameOrg.AutoSize = true;
                labelNameOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelNameOrg.Location = new System.Drawing.Point(211, 15);
                labelNameOrg.Size = new System.Drawing.Size(588, 29);
                labelNameOrg.TabIndex = 19;
                labelNameOrg.Text = "Наименование благотворительной оргонизации";

                Label labelInform = new Label();
                labelInform.AutoSize = true;
                labelInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelInform.Location = new System.Drawing.Point(212, 60);
                labelInform.Size = new System.Drawing.Size(620, 48);
                labelInform.TabIndex = 20;
                labelInform.Text = "Описание благотворительности. Описание благотворительности.";

                Panel panelCS = new Panel();
                panelCS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                panelCS.Location = new System.Drawing.Point(25, 22);
                panelCS.Name = "panelCase";
                panelCS.Size = new System.Drawing.Size(1297, 178);
                panelCS.TabIndex = 0;

                panelCS.Controls.AddRange(new Control[] {
                     pictureBox,labelNameOrg,labelInform
                });

                panelBox.Controls.Add(panelCS);*/
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            new FormInformation().Show();
            this.Hide();
        }
    }
}
