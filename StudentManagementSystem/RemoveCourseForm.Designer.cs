namespace StudentManagementSystem
{
    partial class RemoveCourseForm
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
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the course\'s ID:";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCourseID.Location = new System.Drawing.Point(245, 47);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(84, 35);
            this.textBoxCourseID.TabIndex = 1;
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCourse.Location = new System.Drawing.Point(380, 47);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(207, 35);
            this.buttonRemoveCourse.TabIndex = 25;
            this.buttonRemoveCourse.Text = "Remove";
            this.buttonRemoveCourse.UseVisualStyleBackColor = true;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.buttonRemoveCourse_Click);
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(668, 125);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.label1);
            this.Name = "RemoveCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxCourseID;
        private Button buttonRemoveCourse;
    }
}