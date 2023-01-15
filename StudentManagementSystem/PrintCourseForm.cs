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
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            //populate datagridview with courses
            Course course = new Course();
            dataGridView1.DataSource = course.getAllCourses();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //file path
            //the file name = courses_list.txt
            //location = desktop

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\courses_list.txt";

            using (var write = new StreamWriter(path))
            {
                //checks if the file exists
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //Rows
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //Columns
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        write.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
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
