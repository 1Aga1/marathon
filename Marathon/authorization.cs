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
        Check check = new Check();
        AccountInfo account = new AccountInfo();
        DBConnect db = new DBConnect();

        public auth_form()
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

        private void to_sign_in_Click(object sender, EventArgs e)
        {
            reg_form reg = new reg_form();
            reg.Show();
            this.Hide();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            var email = email_txtbox.Text;
            var password = password_txtbox.Text;

            if (check.validationUser(email, password))
            {
                account.getAllInfo(email);

                main_form main = new main_form();
                main.Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }
    }
}
