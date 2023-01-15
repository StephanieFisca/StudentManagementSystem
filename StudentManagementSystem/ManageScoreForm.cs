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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        Student student = new Student();
        Course course = new Course();
        string data = "score";

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //populate the combobox with courses
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            //populate the datagridview with student score
            dataGridView1.DataSource = score.getStudentsScore();

        }

        //display students data on datagridview
        private void buttonShowStudents_Click(object sender, EventArgs e)
        {
            data = "student";
            MySqlCommand command = new MySqlCommand("SELECT id, first_name, last_name, birth FROM student");
            dataGridView1.DataSource = student.getStudents(command);
        }

        //display scores data on datagridview
        private void buttonShowScores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentsScore();
        }

        //get data from datagridview
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDataGridView();
        }

        //create a function to get data from datagridview
        public void getDataFromDataGridView()
        {
            //if the user selected to show student data then we will show only the student id
            if (data == "student")
            {
                textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            //if the user selected to show scores data then we will show the student id
            // and select the course from the combobox
            else if (data == "score")
            {
                textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }
        }

        //button add score
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
                if (!score.studentScoreExists(studentID, courseID))
                {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //button remove score
        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            //remove the selected score
            int studentID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseID = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Are you sure you want to delete this score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentsScore();

                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //show a new form with the average score by course
        private void buttonAvgScore_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avgScoreByCourseForm = new AvgScoreByCourseForm();
            avgScoreByCourseForm.Show(this);
        }

    }
}
