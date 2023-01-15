namespace StudentManagementSystem
{
    partial class PrintStudentsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGO = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.radioButtonYES = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 528);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrint.Location = new System.Drawing.Point(12, 668);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(1076, 45);
            this.buttonPrint.TabIndex = 16;
            this.buttonPrint.Text = "Print to text file";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGO);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 116);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // buttonGO
            // 
            this.buttonGO.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGO.Location = new System.Drawing.Point(816, 31);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(207, 71);
            this.buttonGO.TabIndex = 17;
            this.buttonGO.Text = "GO";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButtonNO);
            this.groupBox2.Controls.Add(this.radioButtonYES);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(334, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(355, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(78, 23);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(304, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "and";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of birth between";
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Checked = true;
            this.radioButtonNO.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNO.Location = new System.Drawing.Point(279, 11);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(55, 29);
            this.radioButtonNO.TabIndex = 3;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "No";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            this.radioButtonNO.CheckedChanged += new System.EventHandler(this.radioButtonNO_CheckedChanged);
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonYES.Location = new System.Drawing.Point(171, 10);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(57, 29);
            this.radioButtonYES.TabIndex = 2;
            this.radioButtonYES.Text = "Yes";
            this.radioButtonYES.UseVisualStyleBackColor = true;
            this.radioButtonYES.CheckedChanged += new System.EventHandler(this.radioButtonYES_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Data Range:";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFemale.Location = new System.Drawing.Point(231, 49);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(90, 29);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMale.Location = new System.Drawing.Point(127, 50);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(72, 29);
            this.radioButtonMale.TabIndex = 1;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAll.Location = new System.Drawing.Point(19, 49);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(52, 29);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // PrintStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1113, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintStudentsForm";
            this.Load += new System.EventHandler(this.PrintStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonPrint;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private RadioButton radioButtonNO;
        private RadioButton radioButtonYES;
        private Label label1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonAll;
        private Button buttonGO;
    }
}