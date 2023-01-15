namespace StudentManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageScoreByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(2564, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(93, 31);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.editRemoveToolStripMenuItem.Text = "Edit/Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            this.manageStudentFormToolStripMenuItem.Click += new System.EventHandler(this.manageStudentFormToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageCoursesToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(87, 31);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.addCourseToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.removeCourseToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.removeCourseToolStripMenuItem.Text = "Remove Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.editCourseToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageCoursesToolStripMenuItem
            // 
            this.manageCoursesToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.manageCoursesToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manageCoursesToolStripMenuItem.Name = "manageCoursesToolStripMenuItem";
            this.manageCoursesToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.manageCoursesToolStripMenuItem.Text = "Manage Courses";
            this.manageCoursesToolStripMenuItem.Click += new System.EventHandler(this.manageCoursesToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.BackColor = System.Drawing.Color.LavenderBlush;
            this.printToolStripMenuItem1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(231, 32);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.averageScoreByCourseToolStripMenuItem,
            this.printToolStripMenuItem2});
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(72, 31);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // averageScoreByCourseToolStripMenuItem
            // 
            this.averageScoreByCourseToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.averageScoreByCourseToolStripMenuItem.Name = "averageScoreByCourseToolStripMenuItem";
            this.averageScoreByCourseToolStripMenuItem.Size = new System.Drawing.Size(308, 32);
            this.averageScoreByCourseToolStripMenuItem.Text = "Average Score By Course";
            this.averageScoreByCourseToolStripMenuItem.Click += new System.EventHandler(this.averageScoreByCourseToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem2
            // 
            this.printToolStripMenuItem2.BackColor = System.Drawing.Color.Thistle;
            this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
            this.printToolStripMenuItem2.Size = new System.Drawing.Size(308, 32);
            this.printToolStripMenuItem2.Text = "Print";
            this.printToolStripMenuItem2.Click += new System.EventHandler(this.printToolStripMenuItem2_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 46);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(2564, 1013);
            this.panelMain.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1061);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem studentListToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem editRemoveToolStripMenuItem;
        private ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem scoreToolStripMenuItem;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem removeCourseToolStripMenuItem;
        private ToolStripMenuItem editCourseToolStripMenuItem;
        private ToolStripMenuItem manageCoursesToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem1;
        private ToolStripMenuItem addScoreToolStripMenuItem;
        private ToolStripMenuItem removeScoreToolStripMenuItem;
        private ToolStripMenuItem manageScoreToolStripMenuItem;
        private ToolStripMenuItem averageScoreByCourseToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem2;
        private Panel panelMain;
    }
}