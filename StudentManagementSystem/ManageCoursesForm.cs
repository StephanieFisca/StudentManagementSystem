using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
//Using created class library
using ProjectClassLibrary;

namespace StudentManagementSystem
{
    public partial class ManageCoursesForm : Form
    {
        Algebra algebra = new Algebra();

        public ManageCoursesForm()
        {
            InitializeComponent();
        }

        Course course = new Course();
        int pos;

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        //create a function to load the listbox with courses
        public void reloadListBoxData()
        {
            listBoxCourses.DataSource = course.getAllCourses();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";

            //unselect the item from listbox
            listBoxCourses.SelectedItem = null;

            ArrayList array = new ArrayList();
            array.Add(course.totalCourses());

            //display the total courses
            labelTotalCourses.Text = "Total Courses: " + array[0];
        }

        //create a function to display courses data depending on the index
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBoxCourses.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxLabel.Text = dr.ItemArray[1].ToString();
            numericUpDownHours.Value= Int32.Parse(dr.ItemArray[2].ToString());
            
            textBoxDescription.Text = dr.ItemArray[3].ToString();
        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            pos = listBoxCourses.SelectedIndex;
            showData(pos);
        }

        //button first
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(0);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                //Using function from my class library
                pos = (int)algebra.Addition(pos, 1);
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = (int)algebra.Subtraction(pos, 1);
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count-1;
            showData(pos);
        }

        //button add course
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            string courseLabel = textBoxLabel.Text;
            int hours = (int)numericUpDownHours.Value;
            string description = textBoxDescription.Text;

            Course course = new Course();


            if (courseLabel.Trim() == "")
            {
                MessageBox.Show("Add a Course name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourse(courseLabel))
            {
                if (course.insertCourse(courseLabel, hours, description))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This course name already exsists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        //button edit course
        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                //update the selected course
                string name = textBoxLabel.Text;
                int hrs = (int)numericUpDownHours.Value;
                string descr = textBoxDescription.Text;
                int id = Convert.ToInt32(textBoxID.Text);

                if (name.Trim() != "")
                {

                    //check if this course name already exists and is not the current course using the id
                    if (!course.checkCourse(name, id))
                    {
                        MessageBox.Show("This course name already exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.updateCourse(id, name, hrs, descr))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course NOT UPDATED", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the courses name", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("No Course Selected", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pos = 0;
        }

        //button remove course
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(textBoxID.Text);

                Course course = new Course();

                if (MessageBox.Show("Are you sure you want to remove this course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                        //clear fields
                        textBoxID.Text = "";
                        numericUpDownHours.Value = 10;
                        textBoxLabel.Text = "";
                        textBoxDescription.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            pos = 0;
        }
    }
}
