namespace StudentManagementSystem
{
    partial class AddCourseForm
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
            this.labelnrhour = new System.Windows.Forms.Label();
            this.labeldescript = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnrhour
            // 
            this.labelnrhour.AutoSize = true;
            this.labelnrhour.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelnrhour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelnrhour.Location = new System.Drawing.Point(45, 121);
            this.labelnrhour.Name = "labelnrhour";
            this.labelnrhour.Size = new System.Drawing.Size(220, 35);
            this.labelnrhour.TabIndex = 28;
            this.labelnrhour.Text = "Number of Hours:";
            // 
            // labeldescript
            // 
            this.labeldescript.AutoSize = true;
            this.labeldescript.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldescript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldescript.Location = new System.Drawing.Point(85, 204);
            this.labeldescript.Name = "labeldescript";
            this.labeldescript.Size = new System.Drawing.Size(153, 35);
            this.labeldescript.TabIndex = 27;
            this.labeldescript.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(245, 204);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(302, 121);
            this.textBoxDescription.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(136, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 35);
            this.label2.TabIndex = 25;
            this.label2.Text = "Label:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownHours.Location = new System.Drawing.Point(245, 119);
            this.numericUpDownHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numericUpDownHours.Size = new System.Drawing.Size(137, 42);
            this.numericUpDownHours.TabIndex = 24;
            this.numericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLabel.Location = new System.Drawing.Point(245, 29);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(302, 42);
            this.textBoxLabel.TabIndex = 23;
            this.textBoxLabel.TextChanged += new System.EventHandler(this.textBoxLabel_TextChanged);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCourse.Location = new System.Drawing.Point(45, 372);
            this.buttonAddCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(503, 60);
            this.buttonAddCourse.TabIndex = 29;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(590, 460);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelnrhour);
            this.Controls.Add(this.labeldescript);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelnrhour;
        private Label labeldescript;
        private TextBox textBoxDescription;
        private Label label2;
        private NumericUpDown numericUpDownHours;
        private TextBox textBoxLabel;
        private Button buttonAddCourse;
    }
}