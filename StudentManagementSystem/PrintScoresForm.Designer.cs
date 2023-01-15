namespace StudentManagementSystem
{
    partial class PrintScoresForm
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
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.dataGridViewScores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelReset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses List";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 22;
            this.listBoxCourses.Location = new System.Drawing.Point(13, 177);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(244, 290);
            this.listBoxCourses.TabIndex = 1;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click);
            // 
            // dataGridViewScores
            // 
            this.dataGridViewScores.AllowUserToAddRows = false;
            this.dataGridViewScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScores.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewScores.Location = new System.Drawing.Point(273, 134);
            this.dataGridViewScores.Name = "dataGridViewScores";
            this.dataGridViewScores.RowTemplate.Height = 25;
            this.dataGridViewScores.Size = new System.Drawing.Size(573, 392);
            this.dataGridViewScores.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(333, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 53;
            this.label2.Text = "Scores List";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewStudent.Location = new System.Drawing.Point(863, 177);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowTemplate.Height = 25;
            this.dataGridViewStudent.Size = new System.Drawing.Size(318, 290);
            this.dataGridViewStudent.TabIndex = 54;
            this.dataGridViewStudent.Click += new System.EventHandler(this.dataGridViewStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(863, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 55;
            this.label3.Text = "Students List";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPrint.Location = new System.Drawing.Point(12, 567);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(1169, 45);
            this.buttonPrint.TabIndex = 56;
            this.buttonPrint.Text = "Print to text file";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelReset.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReset.Location = new System.Drawing.Point(13, 525);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(61, 27);
            this.labelReset.TabIndex = 57;
            this.labelReset.Text = "Reset";
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            // 
            // PrintScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 624);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewScores);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PrintScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScoresForm";
            this.Load += new System.EventHandler(this.PrintScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listBoxCourses;
        private DataGridView dataGridViewScores;
        private Label label2;
        private DataGridView dataGridViewStudent;
        private Label label3;
        private Button buttonPrint;
        private Label labelReset;
    }
}