namespace StudentManagementSystem
{
    partial class EditCourseForm
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
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.labelnrhour = new System.Windows.Forms.Label();
            this.labeldescript = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditCourse.Location = new System.Drawing.Point(25, 339);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(440, 45);
            this.buttonEditCourse.TabIndex = 36;
            this.buttonEditCourse.Text = "Edit Course";
            this.buttonEditCourse.UseVisualStyleBackColor = true;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // labelnrhour
            // 
            this.labelnrhour.AutoSize = true;
            this.labelnrhour.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelnrhour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelnrhour.Location = new System.Drawing.Point(73, 149);
            this.labelnrhour.Name = "labelnrhour";
            this.labelnrhour.Size = new System.Drawing.Size(98, 27);
            this.labelnrhour.TabIndex = 35;
            this.labelnrhour.Text = "Duration:";
            // 
            // labeldescript
            // 
            this.labeldescript.AutoSize = true;
            this.labeldescript.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldescript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldescript.Location = new System.Drawing.Point(60, 213);
            this.labeldescript.Name = "labeldescript";
            this.labeldescript.Size = new System.Drawing.Size(120, 27);
            this.labeldescript.TabIndex = 34;
            this.labeldescript.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(200, 213);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 92);
            this.textBoxDescription.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(105, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Label:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownHours.Location = new System.Drawing.Point(200, 149);
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
            this.numericUpDownHours.TabIndex = 31;
            this.numericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLabel.Location = new System.Drawing.Point(200, 82);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(265, 35);
            this.textBoxLabel.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "Select Course:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.AllowDrop = true;
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(199, 28);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(266, 35);
            this.comboBoxCourse.TabIndex = 38;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(526, 417);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.labelnrhour);
            this.Controls.Add(this.labeldescript);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxLabel);
            this.Name = "EditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditCourse;
        private Label labelnrhour;
        private Label labeldescript;
        private TextBox textBoxDescription;
        private Label label2;
        private NumericUpDown numericUpDownHours;
        private TextBox textBoxLabel;
        private Label label1;
        private ComboBox comboBoxCourse;
    }
}