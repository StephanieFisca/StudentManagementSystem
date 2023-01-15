using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace StudentManagementSystem
{
    //Connecting the application to my mysql database

    class StephDatabase
    {
        //Connecting the db to the app
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=student_db_csharp");

        //Creating a function to retrieve the connection
        public MySqlConnection GetConnection { 
            get { 
                return conn; 
            }
        }

        //Creating a function that opens the connection
        public void openConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //Creating a function that closes the connection
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
