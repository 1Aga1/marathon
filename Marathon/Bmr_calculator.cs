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
    public partial class Bmr_calculator : Form
    {
        private void CalculateBMR()
        {
            var bmr = 0.0;
            var weight = Convert.ToDouble(weight_txtbox.Value);
            var height = Convert.ToDouble(height_txtbox.Value);
            var age = Convert.ToDouble(age_txtbox.Value);
            if (male_btn.CausesValidation)
            {
                bmr = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);
            }
            else
            {
                bmr = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);
            }

            bmr_txt.Text = bmr.ToString();

            sit_activity.Text = Convert.ToString(weight * 1.2 * 24);
            min_activity.Text = Convert.ToString(weight * 1.375 * 24);
            avg_activity.Text = Convert.ToString(weight * 1.4625 * 24);
            high_activity.Text = Convert.ToString(weight * 1.55 * 24);
            max_activity.Text = Convert.ToString(weight * 1.6375 * 24);
        }

        public Bmr_calculator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (AccountInfo.isAuth)
            {
                height_txtbox.Value = AccountInfo.height;
                height_txtbox.ReadOnly = true;
                weight_txtbox.Value = AccountInfo.weight;
                weight_txtbox.ReadOnly = true;
                age_txtbox.Value = DateTime.Now.Year - Convert.ToInt32(AccountInfo.date_birth.Split('.')[2]);
                age_txtbox.ReadOnly = true;

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

                CalculateBMR();
            }
        }

        private void to_main_Click(object sender, EventArgs e)
        {
            main_form main = new main_form();
            main.Show();
            this.Hide();
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

        private void calc_btn_Click(object sender, EventArgs e)
        {
            if ((male_btn.CausesValidation == true || female_btn.CausesValidation == true) && height_txtbox.Value != 0 && weight_txtbox.Value != 0 && age_txtbox.Value != 0)
            {
                CalculateBMR();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
