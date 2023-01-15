namespace StudentManagementSystem
{
    partial class ManageCoursesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.labelnrhour = new System.Windows.Forms.Label();
            this.labeldescript = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.labelTotalCourses = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID:";
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditCourse.Location = new System.Drawing.Point(202, 431);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(127, 45);
            this.buttonEditCourse.TabIndex = 45;
            this.buttonEditCourse.Text = "Edit Course";
            this.buttonEditCourse.UseVisualStyleBackColor = true;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // labelnrhour
            // 
            this.labelnrhour.AutoSize = true;
            this.labelnrhour.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelnrhour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelnrhour.Location = new System.Drawing.Point(62, 133);
            this.labelnrhour.Name = "labelnrhour";
            this.labelnrhour.Size = new System.Drawing.Size(98, 27);
            this.labelnrhour.TabIndex = 44;
            this.labelnrhour.Text = "Duration:";
            // 
            // labeldescript
            // 
            this.labeldescript.AutoSize = true;
            this.labeldescript.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldescript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldescript.Location = new System.Drawing.Point(49, 197);
            this.labeldescript.Name = "labeldescript";
            this.labeldescript.Size = new System.Drawing.Size(120, 27);
            this.labeldescript.TabIndex = 43;
            this.labeldescript.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(189, 197);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 92);
            this.textBoxDescription.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(94, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Label:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownHours.Location = new System.Drawing.Point(189, 133);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownHours.TabIndex = 40;
            this.numericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLabel.Location = new System.Drawing.Point(189, 66);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(265, 35);
            this.textBoxLabel.TabIndex = 39;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(189, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(265, 35);
            this.textBoxID.TabIndex = 47;
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 25;
            this.listBoxCourses.Location = new System.Drawing.Point(601, 12);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(451, 329);
            this.listBoxCourses.TabIndex = 48;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click);
            // 
            // labelTotalCourses
            // 
            this.labelTotalCourses.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelTotalCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTotalCourses.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalCourses.Location = new System.Drawing.Point(812, 355);
            this.labelTotalCourses.Name = "labelTotalCourses";
            this.labelTotalCourses.Size = new System.Drawing.Size(240, 37);
            this.labelTotalCourses.TabIndex = 49;
            this.labelTotalCourses.Text = "Total Courses:";
            this.labelTotalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCourse.Location = new System.Drawing.Point(67, 431);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(129, 45);
            this.buttonAddCourse.TabIndex = 50;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.Location = new System.Drawing.Point(339, 431);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(170, 45);
            this.buttonRemove.TabIndex = 51;
            this.buttonRemove.Text = "Remove Course";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFirst.Location = new System.Drawing.Point(12, 319);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(129, 45);
            this.buttonFirst.TabIndex = 52;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.Location = new System.Drawing.Point(147, 319);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(129, 45);
            this.buttonNext.TabIndex = 53;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrevious.Location = new System.Drawing.Point(284, 319);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(129, 45);
            this.buttonPrevious.TabIndex = 54;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLast.Location = new System.Drawing.Point(428, 319);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(129, 45);
            this.buttonLast.TabIndex = 55;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // ManageCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1064, 504);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelTotalCourses);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.labelnrhour);
            this.Controls.Add(this.labeldescript);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxLabel);
            this.Name = "ManageCoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCoursesForm";
            this.Load += new System.EventHandler(this.ManageCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonEditCourse;
        private Label labelnrhour;
        private Label labeldescript;
        private TextBox textBoxDescription;
        private Label label2;
        private NumericUpDown numericUpDownHours;
        private TextBox textBoxLabel;
        private TextBox textBoxID;
        private ListBox listBoxCourses;
        private Label labelTotalCourses;
        private Button buttonAddCourse;
        private Button buttonRemove;
        private Button buttonFirst;
        private Button buttonNext;
        private Button buttonPrevious;
        private Button buttonLast;
    }
}