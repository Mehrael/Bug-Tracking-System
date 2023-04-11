namespace Bug_Tracking_System
{
    partial class AddProjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProjectsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.Add_project_btn = new System.Windows.Forms.Button();
            this.Submission_date_dtm = new System.Windows.Forms.DateTimePicker();
            this.Project_lead_cmbx = new System.Windows.Forms.ComboBox();
            this.Project_name_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Client_name_txt = new System.Windows.Forms.TextBox();
            this.client_address_txt = new System.Windows.Forms.TextBox();
            this.Client_phone_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbar_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.navbar_panel.Size = new System.Drawing.Size(991, 74);
            this.navbar_panel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Description_txt);
            this.groupBox1.Controls.Add(this.Add_project_btn);
            this.groupBox1.Controls.Add(this.Submission_date_dtm);
            this.groupBox1.Controls.Add(this.Project_lead_cmbx);
            this.groupBox1.Controls.Add(this.Client_phone_txt);
            this.groupBox1.Controls.Add(this.client_address_txt);
            this.groupBox1.Controls.Add(this.Client_name_txt);
            this.groupBox1.Controls.Add(this.Project_name_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(18, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 637);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Project";
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
            // Add_project_btn
            // 
            this.Add_project_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Add_project_btn.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_project_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Add_project_btn.Location = new System.Drawing.Point(314, 537);
            this.Add_project_btn.Name = "Add_project_btn";
            this.Add_project_btn.Size = new System.Drawing.Size(339, 63);
            this.Add_project_btn.TabIndex = 4;
            this.Add_project_btn.Text = "Add project";
            this.Add_project_btn.UseVisualStyleBackColor = true;
            this.Add_project_btn.Click += new System.EventHandler(this.Add_project_btn_Click);
            // 
            // Submission_date_dtm
            // 
            this.Submission_date_dtm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Submission_date_dtm.Location = new System.Drawing.Point(574, 444);
            this.Submission_date_dtm.Name = "Submission_date_dtm";
            this.Submission_date_dtm.Size = new System.Drawing.Size(341, 35);
            this.Submission_date_dtm.TabIndex = 3;
            // 
            // Project_lead_cmbx
            // 
            this.Project_lead_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Project_lead_cmbx.FormattingEnabled = true;
            this.Project_lead_cmbx.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.Project_lead_cmbx.Location = new System.Drawing.Point(67, 447);
            this.Project_lead_cmbx.Name = "Project_lead_cmbx";
            this.Project_lead_cmbx.Size = new System.Drawing.Size(341, 34);
            this.Project_lead_cmbx.TabIndex = 2;
            // 
            // Project_name_txt
            // 
            this.Project_name_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project_name_txt.Location = new System.Drawing.Point(67, 116);
            this.Project_name_txt.Name = "Project_name_txt";
            this.Project_name_txt.Size = new System.Drawing.Size(341, 35);
            this.Project_name_txt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(569, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Client address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(569, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Submission Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(569, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Client phone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(62, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Project Lead:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(569, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Client name:";
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
            // Client_name_txt
            // 
            this.Client_name_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_name_txt.Location = new System.Drawing.Point(574, 116);
            this.Client_name_txt.Name = "Client_name_txt";
            this.Client_name_txt.Size = new System.Drawing.Size(341, 35);
            this.Client_name_txt.TabIndex = 1;
            // 
            // client_address_txt
            // 
            this.client_address_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_address_txt.Location = new System.Drawing.Point(574, 223);
            this.client_address_txt.Name = "client_address_txt";
            this.client_address_txt.Size = new System.Drawing.Size(341, 35);
            this.client_address_txt.TabIndex = 1;
            // 
            // Client_phone_txt
            // 
            this.Client_phone_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_phone_txt.Location = new System.Drawing.Point(574, 337);
            this.Client_phone_txt.Name = "Client_phone_txt";
            this.Client_phone_txt.Size = new System.Drawing.Size(341, 35);
            this.Client_phone_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(62, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Project Name:";
            // 
            // AddProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navbar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Project";
            this.Load += new System.EventHandler(this.AddProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navbar_panel.ResumeLayout(false);
            this.navbar_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel navbar_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Description_txt;
        private System.Windows.Forms.Button Add_project_btn;
        private System.Windows.Forms.DateTimePicker Submission_date_dtm;
        private System.Windows.Forms.ComboBox Project_lead_cmbx;
        private System.Windows.Forms.TextBox Project_name_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Client_phone_txt;
        private System.Windows.Forms.TextBox client_address_txt;
        private System.Windows.Forms.TextBox Client_name_txt;
    }
}