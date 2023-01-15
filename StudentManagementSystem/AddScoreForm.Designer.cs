namespace StudentManagementSystem
{
    partial class AddScoreForm
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
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldescript = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.AllowDrop = true;
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(197, 59);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(266, 35);
            this.comboBoxCourse.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "Select Course:";
            // 
            // labeldescript
            // 
            this.labeldescript.AutoSize = true;
            this.labeldescript.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldescript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldescript.Location = new System.Drawing.Point(58, 179);
            this.labeldescript.Name = "labeldescript";
            this.labeldescript.Size = new System.Drawing.Size(120, 27);
            this.labeldescript.TabIndex = 43;
            this.labeldescript.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(198, 179);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 92);
            this.textBoxDescription.TabIndex = 42;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelScore.Location = new System.Drawing.Point(103, 121);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(65, 27);
            this.labelScore.TabIndex = 41;
            this.labelScore.Text = "Score:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxScore.Location = new System.Drawing.Point(198, 113);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(265, 35);
            this.textBoxScore.TabIndex = 39;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelStudentID.Location = new System.Drawing.Point(54, 19);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(114, 27);
            this.labelStudentID.TabIndex = 49;
            this.labelStudentID.Text = "Student ID:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentID.Location = new System.Drawing.Point(198, 11);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(133, 35);
            this.textBoxStudentID.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(440, 474);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddScore.Location = new System.Drawing.Point(12, 448);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(440, 45);
            this.buttonAddScore.TabIndex = 51;
            this.buttonAddScore.Text = "Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(951, 524);
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
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxCourse;
        private Label label1;
        private Label labeldescript;
        private TextBox textBoxDescription;
        private Label labelScore;
        private TextBox textBoxScore;
        private Label labelStudentID;
        private TextBox textBoxStudentID;
        private DataGridView dataGridView1;
        private Button buttonAddScore;
    }
}