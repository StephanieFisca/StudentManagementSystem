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
    public partial class AvgScoreByCourseForm : Form
    {
        public AvgScoreByCourseForm()
        {
            InitializeComponent();
        }

        private void AvgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with average score by course
            Score score = new Score();
            dataGridView1.DataSource = score.avgScoreByCourse();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
