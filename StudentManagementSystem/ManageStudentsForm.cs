using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class ManageStudentsForm : Form
    {

        //Default constructor
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private Student student = new Student();
        public string firstName = "Incomplete_field";
        public string lastname = "Incomplete_field";

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with students data
            FillDGV(new MySqlCommand("SELECT * FROM student"));
        }

        //create a function to populate the datagridview
        public void FillDGV(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn pImageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            //column 7 is the image column index
            pImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
            pImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;
            
            //show the total students depending on dgv
            labelTotalStudents.Text = "Total Students: "+ dataGridView1.Rows.Count;
        }

        
        //Display student data on dataviewgrid click
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }

            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxStudent.Image = Image.FromStream(picture);
        }

        //clear all fields
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxFirstName.Text = "";
            textBoxAddress.Text = "";
            radioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBoxStudent.Image= null;
        }

        //search and display students in datagridview
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            string query = "Select * from student WHERE CONCAT(first_name,last_name,address) LIKE '%"+textBoxSearch.Text+"%'";
            MySqlCommand command = new MySqlCommand(query);
            FillDGV(command);
        }

        //browse and display image from your computer to the picturebox
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

        //save the image in your computer
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            //set the file name 
            save.FileName = "Student_" + textBoxID.Text;

            //check if the picturebox is empty
            if (pictureBoxStudent.Image == null)
            {
                MessageBox.Show("No image in the picture box");
            }else if(save.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image.Save(save.FileName + ("." + ImageFormat.Jpeg.ToString()));
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

        //Add a new student
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //Add new student
            firstName = textBoxFirstName.Text;
            lastname = textBoxLastName.Text;
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

                if (student.insertStudent(firstName, lastname, birth, phone, gender, address, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDGV(new MySqlCommand("SELECT * FROM student"));
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

        //Edit the selected student
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Update the selected student
                //Add new student
                int id = Convert.ToInt32(textBoxID.Text);
                string firstName = textBoxFirstName.Text;
                string lastname = textBoxLastName.Text;
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

                    if (student.updateStudent(id, firstName, lastname, birth, phone, gender, address, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDGV(new MySqlCommand("SELECT * FROM student"));
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

        //remove the selected student
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
                        FillDGV(new MySqlCommand("SELECT * FROM student"));
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
            }
            catch
            {
                MessageBox.Show("Please enter a valid student id", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
