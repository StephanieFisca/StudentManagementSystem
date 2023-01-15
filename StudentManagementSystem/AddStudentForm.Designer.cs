namespace StudentManagementSystem
{
    partial class AddStudentForm
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonCancelStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.Location = new System.Drawing.Point(133, 38);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(243, 29);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(133, 90);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(243, 29);
            this.textBoxLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Of Birth:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(124, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(110, 17);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(63, 19);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(21, 17);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(51, 19);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(133, 258);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(243, 29);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(133, 313);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(243, 92);
            this.textBoxAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Location = new System.Drawing.Point(133, 450);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(243, 134);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 12;
            this.pictureBoxStudent.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Picture:";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpload.Location = new System.Drawing.Point(133, 604);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(243, 38);
            this.buttonUpload.TabIndex = 14;
            this.buttonUpload.Text = "Upload Image";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddStudent.Location = new System.Drawing.Point(256, 675);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(207, 45);
            this.buttonAddStudent.TabIndex = 15;
            this.buttonAddStudent.Text = "Add";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonCancelStudent
            // 
            this.buttonCancelStudent.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelStudent.Location = new System.Drawing.Point(15, 675);
            this.buttonCancelStudent.Name = "buttonCancelStudent";
            this.buttonCancelStudent.Size = new System.Drawing.Size(207, 45);
            this.buttonCancelStudent.TabIndex = 16;
            this.buttonCancelStudent.Text = "Cancel";
            this.buttonCancelStudent.UseVisualStyleBackColor = true;
            this.buttonCancelStudent.Click += new System.EventHandler(this.buttonCancelStudent_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(489, 732);
            this.Controls.Add(this.buttonCancelStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label label5;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private Label label6;
        private PictureBox pictureBoxStudent;
        private Label label7;
        private Button buttonUpload;
        private Button buttonAddStudent;
        private Button buttonCancelStudent;
    }
}