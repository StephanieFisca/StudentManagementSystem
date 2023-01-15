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
    public partial class UpdateDeleteStudentForm : Form
    {

        public string firstName = "Incomplete_field";
        public string lastName = "Incomplete_field";

        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //Browse images from PC 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        //Create a function to verify data
        bool verify()
        {
            if ((textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxPhone.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBoxStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //Update the selected student
                //Add new student
                int id = Convert.ToInt32(textBoxID.Text);
                firstName = textBoxFirstName.Text;
                lastName = textBoxLastName.Text;
                DateTime birth = dateTimePicker1.Value;
                string phone = textBoxPhone.Text;
                string address = textBoxAddress.Text;
                string gender = "Male";

                if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();

                //We need to check the age of the student.
                //The students age must be between 10-100
                int birth_year = dateTimePicker1.Value.Year;
                int curr_year = DateTime.Now.Year;

                if ((curr_year - birth_year < 10) || (curr_year - birth_year > 100))
                {
                    MessageBox.Show("The students age must be between 10-100.", "Invalid date of birth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verify())
                {
                    pictureBoxStudent.Image.Save(pic, pictureBoxStudent.Image.RawFormat);

                    if (student.updateStudent(id, firstName, lastName, birth, phone, gender, address, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid student id", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //remove the selected student
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                Student student = new Student();

                //show a confirmation message before deleting the student
                if (MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields
                        textBoxID.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxPhone.Text = "";
                        textBoxAddress.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxStudent.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }catch
            {
                MessageBox.Show("Please enter a valid student id", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e){
            try
            {
                //search student by id
                int id = Convert.ToInt32(textBoxID.Text);
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, first_name, last_name, birth, gender, phone, address, picture FROM student WHERE id=" + id);
                DataTable table = student.getStudents(mySqlCommand);

                if (table.Rows.Count > 0)
                {
                    textBoxFirstName.Text = table.Rows[0]["first_name"].ToString();
                    textBoxLastName.Text = table.Rows[0]["last_name"].ToString();
                    textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();

                    dateTimePicker1.Value = (DateTime)table.Rows[0]["birth"];

                    //gender
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }

                    //Image
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxStudent.Image = Image.FromStream(picture);

                }
            }
            catch
            {
                MessageBox.Show("Enter a valid student id", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Allow only numbers on key press
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
