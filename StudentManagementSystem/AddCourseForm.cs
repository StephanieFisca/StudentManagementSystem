using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AddCourseForm : Form
    {

        public string courseLabel = "Incomplete_field";

        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            courseLabel = textBoxLabel.Text;
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
        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
