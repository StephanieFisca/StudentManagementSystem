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
    public partial class AddStudentForm : Form
    {

        private Student student = new Student();

        //First and last name can be accessed from anywhere
        public string firstName = "Incomplete_field";
        public string lastname = "Incomplete_field";

        //Default constructor
        public AddStudentForm()
        {
            InitializeComponent();
        }

        //Action when uploading an image
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //Browse images from PC 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Only going to select file types of jpg,png,gif.
            openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        public void AddStudent()
        {
            //Add new student
            firstName = textBoxFirstName.Text;
            lastname = textBoxLastName.Text;
            DateTime birth = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";

            //Change gender if female radio button is checked
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

                if (student.insertStudent(firstName, lastname, birth, phone, gender, address, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Adding a new student
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        //Create a function to verify data
        bool verify()
        {
            //Makes sure all fields contain values
            if((textBoxFirstName.Text.Trim() == "") ||
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

        //button close
        private void buttonCancelStudent_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
