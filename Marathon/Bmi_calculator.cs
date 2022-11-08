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
    public partial class Bmi_calculator : Form
    {
        private void CalculateBMI()
        {
            var bmi = (double)weight_txtbox.Value / Math.Pow((double)height_txtbox.Value / 100, 2);
            bmi_txtbox.Text = bmi.ToString();

            if (bmi < 16)
            {
                result_txtbox.Text = "Дефицит";
            }
            else if (bmi >= 16 && bmi < 18.5)
            {
                result_txtbox.Text = "Недостаточный";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                result_txtbox.Text = "Норма";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                result_txtbox.Text = "Избыточный";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                result_txtbox.Text = "Ожирение 1";
            }
            else if (bmi >= 35 && bmi < 40)
            {
                result_txtbox.Text = "Ожирение 2";
            }
            else if (bmi >= 40)
            {
                result_txtbox.Text = "Ожирение 3";
            }
        }

        public Bmi_calculator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (AccountInfo.isAuth)
            {
                height_txtbox.Value = AccountInfo.height;
                height_txtbox.ReadOnly = true;
                weight_txtbox.Value = AccountInfo.weight;
                weight_txtbox.ReadOnly = true;

                if (AccountInfo.gender == "Мужской")
                {
                    male_btn.CausesValidation = true;
                    female_btn.CausesValidation = false;
                    female_btn.Enabled = false;
                }
                else
                {
                    male_btn.CausesValidation = false;
                    female_btn.CausesValidation = true;
                    male_btn.Enabled = false;
                }

                CalculateBMI();
            }
        }

        private void to_main_Click(object sender, EventArgs e)
        {
            main_form main = new main_form();
            main.Show();
            this.Hide();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            if (male_btn.CausesValidation == true || female_btn.CausesValidation == true)
            {
                CalculateBMI();
            }
            else
            {
                MessageBox.Show("Выберите пол!");
            }
        }

        private void male_btn_Click(object sender, EventArgs e)
        {
            male_btn.CausesValidation = true;
            female_btn.CausesValidation = false;
        }

        private void female_btn_Click(object sender, EventArgs e)
        {
            male_btn.CausesValidation = false;
            female_btn.CausesValidation = true;
        }
    }
}
