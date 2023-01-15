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

namespace StudentManagementSystem
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        Course course = new Course();
        Student student = new Student();

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            //add a new score 
            try
            {
                int studentID = Convert.ToInt32(textBoxStudentID.Text);
                int courseID = Convert.ToInt32(comboBoxCourse.SelectedValue);
                double scoreValue = Convert.ToDouble(textBoxScore.Text);
                string description = textBoxDescription.Text;

                //checks if a score is already assigned to this student in this course
                if (!score.studentScoreExists(studentID, courseID)) {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Is Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //On form load
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            //populate the combobox with courses name
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            //populate the datagridview with students data (id,first_name,last_name)
            MySqlCommand command = new MySqlCommand("SELECT id, first_name, last_name FROM student");
            dataGridView1.DataSource = student.getStudents(command);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //get the id of the selected student 
            textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
