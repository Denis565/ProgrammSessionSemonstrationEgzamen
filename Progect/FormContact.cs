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
    public partial class FormContact : Form
    {
        public FormContact(string phoneStr,string emailStr)
        {
            InitializeComponent();

            phone.Text = phoneStr;
            email.Text = emailStr;
        }
    }
}
