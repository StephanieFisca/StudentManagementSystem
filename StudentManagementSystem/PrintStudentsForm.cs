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
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void PrintStudentsForm_Load(object sender, EventArgs e)
        {
            FillDGV(new MySqlCommand("SELECT * FROM student"));

            if (radioButtonNO.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
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

        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            //Display data on the datagridview depending on what the user has selected

            MySqlCommand command;
            string query;

            //check if the radiobuttonYES is selected
            //That means the user wants to use a date range
            if (radioButtonYES.Checked)
            {
                //get the date values
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM student WHERE birth BETWEEN '" + date1 + "' AND '"+ date2 +"' AND gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM student WHERE birth BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM student WHERE birth BETWEEN '" + date1 + "' AND '" + date2+"'";
                }

                command = new MySqlCommand(query);
                FillDGV(command);

            }
            else //display data without a date of birth range
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM student";
                }

                command = new MySqlCommand(query);
                FillDGV(command);
            }
        }


        //print data from datagridview to text file
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //file path
            //the file name = students_list.txt
            //location = desktop

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt";

            using(var write = new StreamWriter(path))
            {
                //checks if the file exists
                if (!File.Exists(path)) {
                    File.Create(path);
                }

                DateTime dateTime;

                //Rows
                for (int i = 0; i< dataGridView1.Rows.Count; i++)
                {
                    //Columns
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        //The date of birth column
                        if (j == 3)
                        {
                            dateTime = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());

                            write.Write("\t" + dateTime.ToString("yyyy-MM-dd")+ "\t" + "|");
                        }
                        //the last column
                        else if (j== dataGridView1.Columns.Count - 2)
                        {
                            write.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            write.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
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
