using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;


namespace StudentManagementSystem
{
    //Inheritance of class ManageDB
    internal class Student : ManageDB
    {
        StephDatabase database = new StephDatabase();

        //Create a function to add a new student to the database
        public bool insertStudent(String firstname,string lastname, DateTime date, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO student (first_name, last_name, birth, " +
                "gender, phone, address, picture) VALUES (@fn, @ln, @b, @gdr, @phn, @adrs, @pic)", database.GetConnection);

            command.Parameters.Add("@fn",MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@b", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            return modifyDB(command, database);
        }

        //Create a function to return a table of students data
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = database.GetConnection;

            return fillTableWithDBInfo(command, database);
        }

        //create a function to update students information
        public bool updateStudent(int id, String firstname, string lastname, DateTime date, string phone, string gender,
            string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("UPDATE student SET first_name=@fn, last_name=@ln, birth=@b, " +
                "gender=@gdr, phone=@phn, address= @adrs, picture=@pic WHERE id=@id", database.GetConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@b", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            return modifyDB(command, database);
        }

        //Create a function to delete the selected student
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM student WHERE id = @studentID",database.GetConnection);
            MySqlCommand command2 = new MySqlCommand("DELETE FROM score WHERE studentID = @studentID", database.GetConnection);
            command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id;
            command2.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id;

            modifyDB(command, database);
            return modifyDB(command2, database);
        }

        //create a function to execute the count queries
        public string execCount(string query)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(query, database.GetConnection);
            database.openConnection();
            string count = mySqlCommand.ExecuteScalar().ToString();
            database.closeConnection();

            return count;
        }

        //get the total students
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM student");
        }

        //get the total male students
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM student WHERE gender = 'Male' ");
        }

        //get the total Female students
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM student WHERE gender = 'Female'");
        }

        
    }
}
