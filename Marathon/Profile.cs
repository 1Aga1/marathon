using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class Profile : Form
    {
        DBConnect db = new DBConnect();

        public Profile()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            full_name_txtbox.Text = AccountInfo.full_name;
            birthday_txtbox.Text = AccountInfo.date_birth;
            gender_txtbox.Text = AccountInfo.gender;
            email_txtbox.Text = AccountInfo.email_acc;
            weight_txtbox.Value = AccountInfo.weight;
            height_txtbox.Value = AccountInfo.height;
        }

        private void load_img_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox profile_avatar = new PictureBox();

                    profile_avatar.Image = Image.FromFile(dlg.FileName);
                    profile_avatar.Invalidate();
                }
            }
        }

        private void save_profile_btn_Click(object sender, EventArgs e)
        {
            AccountInfo.weight = weight_txtbox.Value;
            AccountInfo.height = height_txtbox.Value;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"UPDATE runners SET weight = '{AccountInfo.weight}', height = '{AccountInfo.height}' WHERE id = '{AccountInfo.id}'";

            SqlCommand command = new SqlCommand(query, db.getConnection());

            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }

        private void to_main_Click(object sender, EventArgs e)
        {
            main_form main = new main_form();
            main.Show();
            this.Hide();
        }
    }
}
