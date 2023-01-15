namespace StudentManagementSystem
{
    partial class ManageStudentsForm
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTotalStudents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Thistle;
            this.buttonRemove.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.Location = new System.Drawing.Point(288, 665);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(103, 45);
            this.buttonRemove.TabIndex = 33;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.Thistle;
            this.buttonAddStudent.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddStudent.Location = new System.Drawing.Point(16, 665);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(109, 45);
            this.buttonAddStudent.TabIndex = 32;
            this.buttonAddStudent.Text = "Add";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpload.Location = new System.Drawing.Point(134, 588);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(89, 38);
            this.buttonUpload.TabIndex = 31;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 27);
            this.label7.TabIndex = 30;
            this.label7.Text = "Picture:";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.BackColor = System.Drawing.Color.Thistle;
            this.pictureBoxStudent.Location = new System.Drawing.Point(134, 434);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(243, 134);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 29;
            this.pictureBoxStudent.TabStop = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(134, 332);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(243, 92);
            this.textBoxAddress.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(134, 277);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(243, 29);
            this.textBoxPhone.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(157, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 44);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Gender:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 23);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date Of Birth:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(134, 109);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(243, 29);
            this.textBoxLastName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.Location = new System.Drawing.Point(134, 57);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(243, 29);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(134, 15);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(243, 29);
            this.textBoxID.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID:";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDownload.Location = new System.Drawing.Point(288, 588);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(89, 38);
            this.buttonDownload.TabIndex = 36;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(710, 539);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(410, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(423, 59);
            this.label9.TabIndex = 38;
            this.label9.Text = "Enter the specific value you are searching for: (ex: \'John\')";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(827, 19);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(293, 25);
            this.textBoxSearch.TabIndex = 39;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Thistle;
            this.buttonEdit.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEdit.Location = new System.Drawing.Point(157, 665);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(99, 45);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Thistle;
            this.buttonReset.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(410, 665);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(103, 45);
            this.buttonReset.TabIndex = 41;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Thistle;
            this.buttonSearch.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(1017, 52);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(103, 29);
            this.buttonSearch.TabIndex = 42;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTotalStudents
            // 
            this.labelTotalStudents.BackColor = System.Drawing.Color.Thistle;
            this.labelTotalStudents.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalStudents.Location = new System.Drawing.Point(827, 641);
            this.labelTotalStudents.Name = "labelTotalStudents";
            this.labelTotalStudents.Size = new System.Drawing.Size(293, 40);
            this.labelTotalStudents.TabIndex = 43;
            this.labelTotalStudents.Text = "Total students: 100";
            this.labelTotalStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1164, 735);
            this.Controls.Add(this.labelTotalStudents);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonRemove);
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
            this.Name = "ManageStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentsForm";
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonRemove;
        private Button buttonAddStudent;
        private Button buttonUpload;
        private Label label7;
        private PictureBox pictureBoxStudent;
        private TextBox textBoxAddress;
        private Label label6;
        private TextBox textBoxPhone;
        private Label label5;
        private RadioButton radioButtonFemale;
        private GroupBox groupBox1;
        private RadioButton radioButtonMale;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBoxLastName;
        private Label label2;
        private TextBox textBoxFirstName;
        private Label label1;
        private TextBox textBoxID;
        private Label label8;
        private Button buttonDownload;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox textBoxSearch;
        private Button buttonEdit;
        private Button buttonReset;
        private Button buttonSearch;
        private Label labelTotalStudents;
    }
}