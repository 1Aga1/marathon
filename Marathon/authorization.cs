using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class auth_form : Form
    {
        public auth_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            main_form main = new main_form();
            main.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            reg_form reg = new reg_form();
            reg.Show();
            Hide();
        }
    }
}
