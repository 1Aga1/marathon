using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Marathon
{
    internal class Check
    {
        DBConnect db = new DBConnect();
        public Boolean checkUser(string email)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT full_name FROM runners WHERE email = '{email}'";

            SqlCommand command = new SqlCommand(query, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                query = $"SELECT MAX(id) FROM runners";

                command = new SqlCommand(query, db.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                Console.WriteLine(command.ToString(), table);

                return false;
            }
        }
    }
}
