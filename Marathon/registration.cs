using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Marathon
{
    public partial class reg_form : Form
    {

        DBConnect db = new DBConnect();
        Check check = new Check();

        public reg_form()
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

        private void to_log_in_Click(object sender, EventArgs e)
        {
            auth_form auth = new auth_form();
            auth.Show();
            this.Hide();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            var full_name = full_name_txtbox.Text;
            var email = email_txtbox.Text;
            var password = password_txtbox.Text;
            var confirm_password = confirm_password_txtbox.Text;
            var date_birth = date_birth_txtbox.Text;
            var gender = gender_txtbox.Text;
            var country = country_txtbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            if (password == confirm_password && !check.checkUser(email))
            {
                string query = $"INSERT INTO runners (full_name, email, password, date_birth, gender, country) VALUES ('{full_name}', '{email}', '{password}', '{date_birth}', '{gender}', '{country}')";

                SqlCommand command = new SqlCommand(query, db.getConnection());

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    auth_form auth = new auth_form();
                    auth.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка в данных!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка в данных!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            db.closeConnection();
        }
    }
}
