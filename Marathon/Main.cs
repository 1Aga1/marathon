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
    public partial class main_form : Form
    {

        DBConnect db = new DBConnect();

        public main_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (AccountInfo.isAuth)
            {
                new_runner_btn.Visible = false;
                profile_btn.Visible = true;
            }
        }

        private void new_runner_btn_Click(object sender, EventArgs e)
        {
            reg_form new_runner = new reg_form();
            new_runner.Show();
            this.Hide();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }
    }
}
