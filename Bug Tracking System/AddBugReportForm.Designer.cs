namespace Bug_Tracking_System
{
    partial class AddBugReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBugReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.birthday_dtm = new System.Windows.Forms.DateTimePicker();
            this.Status_cmbx = new System.Windows.Forms.ComboBox();
            this.Type_cmbx = new System.Windows.Forms.ComboBox();
            this.Bug_title_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Severity_cmbx = new System.Windows.Forms.ComboBox();
            this.Priority_cmbx = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Project_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.Fixed_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Fixed_radioButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Description_txt);
            this.groupBox1.Controls.Add(this.add_user_btn);
            this.groupBox1.Controls.Add(this.birthday_dtm);
            this.groupBox1.Controls.Add(this.Priority_cmbx);
            this.groupBox1.Controls.Add(this.Status_cmbx);
            this.groupBox1.Controls.Add(this.Severity_cmbx);
            this.groupBox1.Controls.Add(this.Project_cmbx);
            this.groupBox1.Controls.Add(this.Type_cmbx);
            this.groupBox1.Controls.Add(this.Bug_title_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(18, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1492, 620);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug Report";
            // 
            // add_user_btn
            // 
            this.add_user_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_user_btn.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.add_user_btn.Location = new System.Drawing.Point(1072, 537);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(339, 63);
            this.add_user_btn.TabIndex = 4;
            this.add_user_btn.Text = "Add user";
            this.add_user_btn.UseVisualStyleBackColor = true;
            // 
            // birthday_dtm
            // 
            this.birthday_dtm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday_dtm.Location = new System.Drawing.Point(1070, 337);
            this.birthday_dtm.Name = "birthday_dtm";
            this.birthday_dtm.Size = new System.Drawing.Size(336, 35);
            this.birthday_dtm.TabIndex = 3;
            // 
            // Status_cmbx
            // 
            this.Status_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_cmbx.FormattingEnabled = true;
            this.Status_cmbx.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Developer / Tester"});
            this.Status_cmbx.Location = new System.Drawing.Point(574, 224);
            this.Status_cmbx.Name = "Status_cmbx";
            this.Status_cmbx.Size = new System.Drawing.Size(341, 34);
            this.Status_cmbx.TabIndex = 2;
            // 
            // Type_cmbx
            // 
            this.Type_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_cmbx.FormattingEnabled = true;
            this.Type_cmbx.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.Type_cmbx.Location = new System.Drawing.Point(574, 116);
            this.Type_cmbx.Name = "Type_cmbx";
            this.Type_cmbx.Size = new System.Drawing.Size(341, 34);
            this.Type_cmbx.TabIndex = 2;
            // 
            // Bug_title_txt
            // 
            this.Bug_title_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bug_title_txt.Location = new System.Drawing.Point(67, 116);
            this.Bug_title_txt.Name = "Bug_title_txt";
            this.Bug_title_txt.Size = new System.Drawing.Size(341, 35);
            this.Bug_title_txt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1065, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Comments/Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(569, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1065, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bug Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(62, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bug Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(569, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(62, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description:";
            // 
            // Description_txt
            // 
            this.Description_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_txt.Location = new System.Drawing.Point(67, 239);
            this.Description_txt.Multiline = true;
            this.Description_txt.Name = "Description_txt";
            this.Description_txt.Size = new System.Drawing.Size(341, 138);
            this.Description_txt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(569, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Severity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(569, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Priority:";
            // 
            // Severity_cmbx
            // 
            this.Severity_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Severity_cmbx.FormattingEnabled = true;
            this.Severity_cmbx.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.Severity_cmbx.Location = new System.Drawing.Point(574, 340);
            this.Severity_cmbx.Name = "Severity_cmbx";
            this.Severity_cmbx.Size = new System.Drawing.Size(341, 34);
            this.Severity_cmbx.TabIndex = 2;
            // 
            // Priority_cmbx
            // 
            this.Priority_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Priority_cmbx.FormattingEnabled = true;
            this.Priority_cmbx.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Developer / Tester"});
            this.Priority_cmbx.Location = new System.Drawing.Point(574, 448);
            this.Priority_cmbx.Name = "Priority_cmbx";
            this.Priority_cmbx.Size = new System.Drawing.Size(341, 34);
            this.Priority_cmbx.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1070, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 142);
            this.textBox1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(62, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Project Name:";
            // 
            // Project_cmbx
            // 
            this.Project_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Project_cmbx.FormattingEnabled = true;
            this.Project_cmbx.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.Project_cmbx.Location = new System.Drawing.Point(67, 447);
            this.Project_cmbx.Name = "Project_cmbx";
            this.Project_cmbx.Size = new System.Drawing.Size(341, 34);
            this.Project_cmbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bug Tracking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // navbar_panel
            // 
            this.navbar_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.navbar_panel.Controls.Add(this.label1);
            this.navbar_panel.Controls.Add(this.pictureBox1);
            this.navbar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar_panel.Location = new System.Drawing.Point(0, 0);
            this.navbar_panel.Name = "navbar_panel";
            this.navbar_panel.Size = new System.Drawing.Size(1524, 74);
            this.navbar_panel.TabIndex = 4;
            // 
            // Fixed_radioButton
            // 
            this.Fixed_radioButton.AutoSize = true;
            this.Fixed_radioButton.ForeColor = System.Drawing.Color.Black;
            this.Fixed_radioButton.Location = new System.Drawing.Point(1070, 452);
            this.Fixed_radioButton.Name = "Fixed_radioButton";
            this.Fixed_radioButton.Size = new System.Drawing.Size(109, 30);
            this.Fixed_radioButton.TabIndex = 7;
            this.Fixed_radioButton.TabStop = true;
            this.Fixed_radioButton.Text = "Fixed?";
            this.Fixed_radioButton.UseVisualStyleBackColor = true;
            // 
            // AddBugReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 757);
            this.Controls.Add(this.navbar_panel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddBugReportForm";
            this.Text = "AddBugReportForm";
            this.Load += new System.EventHandler(this.AddBugReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navbar_panel.ResumeLayout(false);
            this.navbar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.DateTimePicker birthday_dtm;
        private System.Windows.Forms.ComboBox Status_cmbx;
        private System.Windows.Forms.ComboBox Type_cmbx;
        private System.Windows.Forms.TextBox Bug_title_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Description_txt;
        private System.Windows.Forms.ComboBox Priority_cmbx;
        private System.Windows.Forms.ComboBox Severity_cmbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Project_cmbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel navbar_panel;
        private System.Windows.Forms.RadioButton Fixed_radioButton;
    }
}