namespace StudentManagementSystem
{
    partial class StatisticsForm
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
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(12, 12);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(1246, 258);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(1246, 258);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total students: 100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.Location = new System.Drawing.Point(12, 276);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(582, 300);
            this.panelMale.TabIndex = 1;
            // 
            // labelMale
            // 
            this.labelMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMale.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMale.Location = new System.Drawing.Point(0, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(582, 300);
            this.labelMale.TabIndex = 1;
            this.labelMale.Text = "Male: 50%";
            this.labelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMale.MouseEnter += new System.EventHandler(this.labelMale_MouseEnter);
            this.labelMale.MouseLeave += new System.EventHandler(this.labelMale_MouseLeave);
            // 
            // panelFemale
            // 
            this.panelFemale.AutoSize = true;
            this.panelFemale.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.Location = new System.Drawing.Point(600, 276);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(658, 300);
            this.panelFemale.TabIndex = 2;
            // 
            // labelFemale
            // 
            this.labelFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFemale.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFemale.Location = new System.Drawing.Point(0, 0);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(658, 300);
            this.labelFemale.TabIndex = 2;
            this.labelFemale.Text = "Female: 50%";
            this.labelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFemale.MouseEnter += new System.EventHandler(this.labelFemale_MouseEnter);
            this.labelFemale.MouseLeave += new System.EventHandler(this.labelFemale_MouseLeave);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1267, 589);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.panelFemale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTotal;
        private Label labelTotal;
        private Panel panelMale;
        private Panel panelFemale;
        private Label labelMale;
        private Label labelFemale;
    }
}