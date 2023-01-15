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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with students score
            dataGridView1.DataSource = score.getStudentsScore();
        }

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            //remove the selected score
            int studentID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseID = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Are you sure you want to delete this score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentID,courseID))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentsScore();

                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
