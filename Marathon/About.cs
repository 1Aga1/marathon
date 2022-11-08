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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void to_main_Click(object sender, EventArgs e)
        {
            main_form main = new main_form();
            main.Show();
            this.Hide();
        }

        private void marathon_time_btn_Click(object sender, EventArgs e)
        {

        }

        private void bmr_btn_Click(object sender, EventArgs e)
        {

        }

        private void bmi_btn_Click(object sender, EventArgs e)
        {
            Bmi_calculator bmi = new Bmi_calculator();
            bmi.Show();
            this.Hide();
        }

        private void charity_organizations_Click(object sender, EventArgs e)
        {

        }
    }
}
