namespace StudentManagementSystem
{
    partial class ManageScoreForm
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
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldescript = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.buttonAvgScore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            this.buttonShowScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddScore.Location = new System.Drawing.Point(109, 308);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(119, 45);
            this.buttonAddScore.TabIndex = 61;
            this.buttonAddScore.Text = "Add";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(488, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(602, 509);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelStudentID.Location = new System.Drawing.Point(29, 23);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(114, 27);
            this.labelStudentID.TabIndex = 59;
            this.labelStudentID.Text = "Student ID:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentID.Location = new System.Drawing.Point(173, 15);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(133, 35);
            this.textBoxStudentID.TabIndex = 58;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.AllowDrop = true;
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(172, 63);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(266, 35);
            this.comboBoxCourse.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "Select Course:";
            // 
            // labeldescript
            // 
            this.labeldescript.AutoSize = true;
            this.labeldescript.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldescript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldescript.Location = new System.Drawing.Point(33, 183);
            this.labeldescript.Name = "labeldescript";
            this.labeldescript.Size = new System.Drawing.Size(120, 27);
            this.labeldescript.TabIndex = 55;
            this.labeldescript.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(173, 183);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 92);
            this.textBoxDescription.TabIndex = 54;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelScore.Location = new System.Drawing.Point(78, 125);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(65, 27);
            this.labelScore.TabIndex = 53;
            this.labelScore.Text = "Score:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxScore.Location = new System.Drawing.Point(173, 117);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(265, 35);
            this.textBoxScore.TabIndex = 52;
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveScore.Location = new System.Drawing.Point(251, 308);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(119, 45);
            this.buttonRemoveScore.TabIndex = 62;
            this.buttonRemoveScore.Text = "Remove";
            this.buttonRemoveScore.UseVisualStyleBackColor = true;
            this.buttonRemoveScore.Click += new System.EventHandler(this.buttonRemoveScore_Click);
            // 
            // buttonAvgScore
            // 
            this.buttonAvgScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAvgScore.Location = new System.Drawing.Point(109, 378);
            this.buttonAvgScore.Name = "buttonAvgScore";
            this.buttonAvgScore.Size = new System.Drawing.Size(261, 45);
            this.buttonAvgScore.TabIndex = 63;
            this.buttonAvgScore.Text = "Average Score by Course";
            this.buttonAvgScore.UseVisualStyleBackColor = true;
            this.buttonAvgScore.Click += new System.EventHandler(this.buttonAvgScore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "To edit a score you have to delete it and re-add it with the values you want";
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowStudents.Location = new System.Drawing.Point(488, 10);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(299, 35);
            this.buttonShowStudents.TabIndex = 65;
            this.buttonShowStudents.Text = "Show Students";
            this.buttonShowStudents.UseVisualStyleBackColor = true;
            this.buttonShowStudents.Click += new System.EventHandler(this.buttonShowStudents_Click);
            // 
            // buttonShowScores
            // 
            this.buttonShowScores.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowScores.Location = new System.Drawing.Point(793, 10);
            this.buttonShowScores.Name = "buttonShowScores";
            this.buttonShowScores.Size = new System.Drawing.Size(297, 35);
            this.buttonShowScores.TabIndex = 66;
            this.buttonShowScores.Text = "Show Scores";
            this.buttonShowScores.UseVisualStyleBackColor = true;
            this.buttonShowScores.Click += new System.EventHandler(this.buttonShowScores_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1115, 609);
            this.Controls.Add(this.buttonShowScores);
            this.Controls.Add(this.buttonShowStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAvgScore);
            this.Controls.Add(this.buttonRemoveScore);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeldescript);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxScore);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddScore;
        private DataGridView dataGridView1;
        private Label labelStudentID;
        private TextBox textBoxStudentID;
        private ComboBox comboBoxCourse;
        private Label label1;
        private Label labeldescript;
        private TextBox textBoxDescription;
        private Label labelScore;
        private TextBox textBoxScore;
        private Button buttonRemoveScore;
        private Button buttonAvgScore;
        private Label label2;
        private Button buttonShowStudents;
        private Button buttonShowScores;
    }
}