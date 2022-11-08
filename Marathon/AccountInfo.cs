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

        public static string id = null;
        public static string full_name = null;
        public static string email_acc = null;
        public static string password = null;
        public static string date_birth = null;
        public static string gender = null;
        public static string country = null;
        public static decimal weight = 0;
        public static decimal height = 0;
        public static bool isAuth = false;

        public void getAllInfo(string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            db.openConnection();

            string query = $"SELECT * FROM runners WHERE email = '{email}'";

            SqlCommand command = new SqlCommand(query, db.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                id = reader["id"].ToString();
                full_name = reader["full_name"].ToString();
                email_acc = reader["email"].ToString();
                password = reader["password"].ToString();
                date_birth = reader["date_birth"].ToString();
                gender = reader["gender"].ToString();
                country = reader["country"].ToString();
                weight = Convert.ToDecimal(reader["weight"].ToString());
                height = Convert.ToDecimal(reader["height"].ToString());
                isAuth = true;
            }

            reader.Close();
            db.closeConnection();
        }
    }
}
