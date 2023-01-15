using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    internal class ManageDB
    {
        public bool modifyDB(MySqlCommand command, StephDatabase stephDatabase)
        {

            stephDatabase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                stephDatabase.closeConnection();
                return true;
            }
            else
            {
                stephDatabase.closeConnection();
                return false;
            }
        }

        public DataTable fillTableWithDBInfo(MySqlCommand command, StephDatabase stephDatabase)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
