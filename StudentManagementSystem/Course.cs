using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    //Inheritance of ManageDB class
    internal class Course : ManageDB
    {
        StephDatabase stephDatabase = new StephDatabase();

        //create a function to insert course
        public bool insertCourse(string courseName, int hours, string description) {
            MySqlCommand command = new MySqlCommand("INSERT INTO course(label, hours, description) VALUES (@name,@hrs,@dscpt)", stephDatabase.GetConnection);
            
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hours;
            command.Parameters.Add("@dscpt", MySqlDbType.Text).Value = description;

            return modifyDB(command, stephDatabase);
        }

        //Create a function to check if the course name alreadt exsists in the db
        //when we edit a course we need to exclude the current course from the name verification
        //using the course id. Bu default we will set the course id to 0
        public bool checkCourse(string courseName, int courseID = 0)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM course WHERE label=@cName AND id <> @cid",stephDatabase.GetConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = courseName;

            DataTable table = fillTableWithDBInfo(command, stephDatabase);

            if (table.Rows.Count > 0)
            {
                stephDatabase.closeConnection();
                // return false if this course name already exsists
                return false;
            }
            else{
                stephDatabase.closeConnection();
                return true;
            }
        }

        //function to remove course by ID
        public bool deleteCourse(int courseID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM course WHERE id=@cID", stephDatabase.GetConnection);
            MySqlCommand command2 = new MySqlCommand("DELETE FROM score WHERE courseID=@cID", stephDatabase.GetConnection);
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = courseID;
            command2.Parameters.Add("@cID", MySqlDbType.Int32).Value = courseID;

            modifyDB(command, stephDatabase);
            return modifyDB(command2, stephDatabase);
        }

        //Create a function to get a course bu id
        public DataTable getCourseById(int courseID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM course WHERE id=@cid",stephDatabase.GetConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID;

            return fillTableWithDBInfo(command, stephDatabase);
        }

        //Create a function to get all course
        public DataTable getAllCourses()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM course", stephDatabase.GetConnection);

            return fillTableWithDBInfo(command, stephDatabase);
        }

        //create a function to edit the selected course
        public bool updateCourse(int courseID, string courseName,int duration,string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE course SET label=@name, hours=@hrs, description=@dscpt WHERE id=@cid", stephDatabase.GetConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = duration;
            command.Parameters.Add("@dscpt", MySqlDbType.Text).Value = description;

            return modifyDB(command, stephDatabase);
        }

        public string execCount(string query)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(query, stephDatabase.GetConnection);

            stephDatabase.openConnection();
            string count = mySqlCommand.ExecuteScalar().ToString();
            stephDatabase.closeConnection();

            return count;
        }

        //get the total students
        public string totalCourses()
        {
            return execCount("SELECT COUNT(*) FROM course");         
        }
    }
}
