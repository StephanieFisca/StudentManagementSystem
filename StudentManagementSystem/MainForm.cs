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
    public partial class MainForm : Form
    {
        //Default Constructor
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm studentListForm = new StudentListForm();
            studentListForm.Show(this);
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            updateDeleteStudentForm.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm manageStudentsForm = new ManageStudentsForm();
            manageStudentsForm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentsForm printStudentsForm = new PrintStudentsForm();
            printStudentsForm.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeCourseForm = new RemoveCourseForm();
            removeCourseForm.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show(this);
        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoursesForm manageCoursesForm = new ManageCoursesForm();
            manageCoursesForm.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourseForm = new PrintCourseForm();
            printCourseForm.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScoreForm = new AddScoreForm();
            addScoreForm.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScoreForm = new RemoveScoreForm();
            removeScoreForm.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            manageScoreForm.Show(this);
        }

        private void averageScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avgScoreByCourseForm = new AvgScoreByCourseForm();
            avgScoreByCourseForm.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoresForm printScoresForm = new PrintScoresForm();
            printScoresForm.Show(this);
        }
    }
}
