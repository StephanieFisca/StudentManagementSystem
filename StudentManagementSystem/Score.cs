using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    //Inheritance of class ManageDB
    internal class Score : ManageDB
    {
        StephDatabase stephDatabase = new StephDatabase();

        //create a function to insert a new score
        public bool insertScore(int studentID, int courseID, double score, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO score (studentID, courseID, score, description) VALUES (@sid, @cid, @scr, @dscr)", stephDatabase.GetConnection);
            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID;
            command.Parameters.Add("@scr", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@dscr", MySqlDbType.VarChar).Value = description;

            return modifyDB(command, stephDatabase);
        }
        //function that checks if a score is already assigned to this student in this course
        public bool studentScoreExists(int studentID, int courseID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM score WHERE studentID= @sid AND courseID = @cid", stephDatabase.GetConnection);

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID;

            DataTable table = fillTableWithDBInfo(command, stephDatabase);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //create a function to get students score
        public DataTable getStudentsScore()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = stephDatabase.GetConnection;
            command.CommandText = ("SELECT score.studentID, student.first_name, student.last_name, score.courseID, " +
            "course.label, score.score FROM student INNER JOIN score ON student.id = score.studentID INNER JOIN " +
            "course ON score.courseID = course.id");
            return fillTableWithDBInfo(command, stephDatabase);

        }

        public DataTable ConvertToDataTable(IEnumerable data)
        {
            List<IDataRecord> list = data.Cast<IDataRecord>().ToList();

            PropertyDescriptorCollection props = null;
            DataTable table = new DataTable();
            if (list != null && list.Count > 0)
            {
                props = TypeDescriptor.GetProperties(list[0]);
                for (int i = 0; i < props.Count; i++)
                {
                    PropertyDescriptor prop = props[i];
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
            }
            if (props != null)
            {
                object[] values = new object[props.Count];
                foreach (string item in data)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        values[i] = props[i].GetValue(item) ?? DBNull.Value;
                    }
                    table.Rows.Add(values);
                }
            }
            return table;
        }


        //function to remove score by student and course id
        public bool deleteScore(int studentID,int courseID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM score WHERE studentID = @sid AND courseID = @cid", stephDatabase.GetConnection);
            command.Parameters.Add("sid", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("cid", MySqlDbType.Int32).Value = courseID;

            return modifyDB(command, stephDatabase);
        }

        //create a function to get the average score by course
        public DataTable avgScoreByCourse()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = stephDatabase.GetConnection;
            command.CommandText = ("SELECT course.label, avg(score.score) as 'Average Score' FROM course, score WHERE " +
                "course.id = score.courseID GROUP BY course.label");

            return fillTableWithDBInfo(command, stephDatabase);
        }

        //get course scores 
        public DataTable getCourseScores(int courseID)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = stephDatabase.GetConnection;
            command.CommandText = ("SELECT score.studentID, student.first_name, student.last_name, score.courseID, " +
                "course.label, score.score FROM student INNER JOIN score ON student.id = score.studentID INNER JOIN " +
                "course ON score.courseID = course.id WHERE score.courseID ="+courseID);

            return fillTableWithDBInfo(command, stephDatabase);
        }

        //get student scores 
        public DataTable getStudentScores(int studentID)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = stephDatabase.GetConnection;
            command.CommandText = ("SELECT score.studentID, student.first_name, student.last_name, score.courseID, " +
                "course.label, score.score FROM student INNER JOIN score ON student.id = score.studentID INNER JOIN " +
                "course ON score.courseID = course.id WHERE score.studentID =" + studentID);

            return fillTableWithDBInfo(command, stephDatabase);
        }

    }
}
