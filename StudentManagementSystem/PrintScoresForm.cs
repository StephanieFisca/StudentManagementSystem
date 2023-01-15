using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace StudentManagementSystem
{
    public partial class PrintScoresForm : Form
    {
        public PrintScoresForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        Course course = new Course();
        Student student = new Student();

        private void PrintScoresForm_Load(object sender, EventArgs e)
        {
            //populate datagridview with students data 
            dataGridViewStudent.DataSource = student.getStudents(new MySqlCommand("SELECT id, first_name, last_name FROM student"));

            //populate datagridview with scores data 
            dataGridViewScores.DataSource = score.getStudentsScore();

            //populate listbox with courses data 
            listBoxCourses.DataSource = course.getAllCourses();
            listBoxCourses.DisplayMember = "label";
            listBoxCourses.ValueMember = "id";
        }

        //when you select a course from the listbox 
        //all scores asigned to this course will be displayed in the datagridview
        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            dataGridViewScores.DataSource = score.getCourseScores(int.Parse(listBoxCourses.SelectedValue.ToString()));
        }


        //display the selected student scores 
        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            dataGridViewScores.DataSource = score.getStudentScores(int.Parse(dataGridViewStudent.CurrentRow.Cells[0].Value.ToString()));
        }


        //populate datagridview with all scores data 
        private void labelReset_Click(object sender, EventArgs e)
        {
            
            dataGridViewScores.DataSource = score.getStudentsScore();
        }


        //print scores data from datagridview to text file
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //file path
            //the file name = scores_list.txt
            //location = desktop

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\scores_list.txt";

            using (var write = new StreamWriter(path))
            {
                //checks if the file exists
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //Rows
                for (int i = 0; i < dataGridViewScores.Rows.Count; i++)
                {
                    //Columns
                    for (int j = 0; j < dataGridViewScores.Columns.Count - 1; j++)
                    {
                        write.Write("\t" + dataGridViewScores.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    //new line
                    write.WriteLine("");

                    //make a seperation
                    write.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
                }

                write.Close();
                MessageBox.Show("Data exported");
            }
        }
    
    }
}

