using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public class AccountInfo
    {
        DBConnect db = new DBConnect();

        public static string full_name;
        public static string email;
        public static string password;
        public static string date_birth;
        public static string gender;
        public static string country;

        public void getAllInfo(string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            db.openConnection();

            string query = $"SELECT * FROM runners WHERE email = '{email}'";

            SqlCommand command = new SqlCommand(query, db.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            full_name = reader.ToString();
            MessageBox.Show(full_name);

            reader.Close();
            db.closeConnection();
        }
    }
}
