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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            //Populate the datagridview with students data
            MySqlCommand command = new MySqlCommand("SELECT * FROM student");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn pImageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            //column 7 is the image column index
            pImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
            pImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //display the selected student in a new form to edit/remove
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();    
            updateDeleteStudentForm.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStudentForm.textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStudentForm.textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStudentForm.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            //gender
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                updateDeleteStudentForm.radioButtonFemale.Checked = true;
            }
            updateDeleteStudentForm.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStudentForm.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //the image
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStudentForm.pictureBoxStudent.Image = Image.FromStream(picture);
            updateDeleteStudentForm.Show();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //refresh the datagridview data
            MySqlCommand command = new MySqlCommand("SELECT * FROM student");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn pImageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            //column 7 is the image column index
            pImageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
            pImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
