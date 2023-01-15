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
    public partial class EditCourseForm : Form
    {
        public string name = "Incomplete_field";

        public EditCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            //populate the combo box with courses
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            //set the selected combo item to nothing
            comboBoxCourse.SelectedItem = null;
        }

        //Create a function to populate the combobox
        //and select the current course
        public void fillCombo(int index)
        {
            //index is the combobox item index
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            comboBoxCourse.SelectedIndex = index;
        }
        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                //update the selected course
                name = textBoxLabel.Text;
                int hrs = (int)numericUpDownHours.Value;
                string descr = textBoxDescription.Text;
                int id = (int)comboBoxCourse.SelectedValue;

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
                        fillCombo(comboBoxCourse.SelectedIndex);
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
            
        }

            private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display the selected course gata
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                textBoxLabel.Text = table.Rows[0][1].ToString();
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch{}
        }
    }
}
