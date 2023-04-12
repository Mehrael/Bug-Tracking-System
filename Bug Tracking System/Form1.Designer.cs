namespace Bug_Tracking_System
{
    partial class Bug_Tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bug_Tracker));
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_bug_btn = new System.Windows.Forms.Button();
            this.add_bug_report_btn = new System.Windows.Forms.Button();
            this.view_bugs_btn = new System.Windows.Forms.Button();
            this.add_project_btn = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.view_users_btn = new System.Windows.Forms.Button();
            this.View_bug_report_btn = new System.Windows.Forms.Button();
            this.view_project_btn = new System.Windows.Forms.Button();
            this.change_password_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.navbar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar_panel
            // 
            this.navbar_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.navbar_panel.Controls.Add(this.Logout_btn);
            this.navbar_panel.Controls.Add(this.label1);
            this.navbar_panel.Controls.Add(this.pictureBox1);
            this.navbar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar_panel.Location = new System.Drawing.Point(0, 0);
            this.navbar_panel.Name = "navbar_panel";
            this.navbar_panel.Size = new System.Drawing.Size(1746, 74);
            this.navbar_panel.TabIndex = 0;
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
            // add_bug_btn
            // 
            this.add_bug_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_bug_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_bug_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bug_btn.Location = new System.Drawing.Point(138, 145);
            this.add_bug_btn.Name = "add_bug_btn";
            this.add_bug_btn.Size = new System.Drawing.Size(227, 146);
            this.add_bug_btn.TabIndex = 1;
            this.add_bug_btn.Text = "Add Bugs";
            this.add_bug_btn.UseVisualStyleBackColor = true;
            this.add_bug_btn.Click += new System.EventHandler(this.Add_bug_btn_Click);
            // 
            // add_bug_report_btn
            // 
            this.add_bug_report_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.add_bug_report_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_bug_report_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_bug_report_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.add_bug_report_btn.Location = new System.Drawing.Point(138, 376);
            this.add_bug_report_btn.Name = "add_bug_report_btn";
            this.add_bug_report_btn.Size = new System.Drawing.Size(227, 146);
            this.add_bug_report_btn.TabIndex = 1;
            this.add_bug_report_btn.Text = "Add Bug Report";
            this.add_bug_report_btn.UseVisualStyleBackColor = true;
            this.add_bug_report_btn.Click += new System.EventHandler(this.Add_bug_report_btn_Click);
            // 
            // view_bugs_btn
            // 
            this.view_bugs_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.view_bugs_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.view_bugs_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.view_bugs_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.view_bugs_btn.Location = new System.Drawing.Point(739, 145);
            this.view_bugs_btn.Name = "view_bugs_btn";
            this.view_bugs_btn.Size = new System.Drawing.Size(227, 146);
            this.view_bugs_btn.TabIndex = 1;
            this.view_bugs_btn.Text = "View Bugs";
            this.view_bugs_btn.UseVisualStyleBackColor = true;
            this.view_bugs_btn.Click += new System.EventHandler(this.View_bugs_btn_Click);
            // 
            // add_project_btn
            // 
            this.add_project_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_project_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_project_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_project_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.add_project_btn.Location = new System.Drawing.Point(739, 376);
            this.add_project_btn.Name = "add_project_btn";
            this.add_project_btn.Size = new System.Drawing.Size(227, 146);
            this.add_project_btn.TabIndex = 1;
            this.add_project_btn.Text = "Add Project";
            this.add_project_btn.UseVisualStyleBackColor = true;
            this.add_project_btn.Click += new System.EventHandler(this.Add_project_btn_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_user_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_user_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_user_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.add_user_btn.Location = new System.Drawing.Point(1331, 145);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(227, 146);
            this.add_user_btn.TabIndex = 1;
            this.add_user_btn.Text = "Add User";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.Add_user_btn_Click);
            // 
            // view_users_btn
            // 
            this.view_users_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.view_users_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.view_users_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.view_users_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.view_users_btn.Location = new System.Drawing.Point(1331, 376);
            this.view_users_btn.Name = "view_users_btn";
            this.view_users_btn.Size = new System.Drawing.Size(227, 146);
            this.view_users_btn.TabIndex = 1;
            this.view_users_btn.Text = "View Users";
            this.view_users_btn.UseVisualStyleBackColor = true;
            this.view_users_btn.Click += new System.EventHandler(this.View_users_btn_Click);
            // 
            // View_bug_report_btn
            // 
            this.View_bug_report_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.View_bug_report_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.View_bug_report_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.View_bug_report_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.View_bug_report_btn.Location = new System.Drawing.Point(138, 607);
            this.View_bug_report_btn.Name = "View_bug_report_btn";
            this.View_bug_report_btn.Size = new System.Drawing.Size(227, 146);
            this.View_bug_report_btn.TabIndex = 1;
            this.View_bug_report_btn.Text = "View Bug Reports";
            this.View_bug_report_btn.UseVisualStyleBackColor = true;
            this.View_bug_report_btn.Click += new System.EventHandler(this.View_bug_report_btn_Click);
            // 
            // view_project_btn
            // 
            this.view_project_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.view_project_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.view_project_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.view_project_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.view_project_btn.Location = new System.Drawing.Point(739, 607);
            this.view_project_btn.Name = "view_project_btn";
            this.view_project_btn.Size = new System.Drawing.Size(227, 146);
            this.view_project_btn.TabIndex = 1;
            this.view_project_btn.Text = "View Projects";
            this.view_project_btn.UseVisualStyleBackColor = true;
            this.view_project_btn.Click += new System.EventHandler(this.view_project_btn_Click);
            // 
            // change_password_btn
            // 
            this.change_password_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.change_password_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.change_password_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.change_password_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.change_password_btn.Location = new System.Drawing.Point(1331, 607);
            this.change_password_btn.Name = "change_password_btn";
            this.change_password_btn.Size = new System.Drawing.Size(227, 146);
            this.change_password_btn.TabIndex = 1;
            this.change_password_btn.Text = "Change Password";
            this.change_password_btn.UseVisualStyleBackColor = true;
            this.change_password_btn.Click += new System.EventHandler(this.Change_password_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Logout_btn.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.Location = new System.Drawing.Point(1560, 16);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(157, 38);
            this.Logout_btn.TabIndex = 5;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Bug_Tracker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1746, 834);
            this.Controls.Add(this.change_password_btn);
            this.Controls.Add(this.view_project_btn);
            this.Controls.Add(this.view_users_btn);
            this.Controls.Add(this.add_project_btn);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.View_bug_report_btn);
            this.Controls.Add(this.view_bugs_btn);
            this.Controls.Add(this.add_bug_report_btn);
            this.Controls.Add(this.add_bug_btn);
            this.Controls.Add(this.navbar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bug_Tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bug_Tracker_Load);
            this.navbar_panel.ResumeLayout(false);
            this.navbar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_bug_btn;
        private System.Windows.Forms.Button add_bug_report_btn;
        private System.Windows.Forms.Button view_bugs_btn;
        private System.Windows.Forms.Button add_project_btn;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Button view_users_btn;
        private System.Windows.Forms.Button View_bug_report_btn;
        private System.Windows.Forms.Button view_project_btn;
        private System.Windows.Forms.Button change_password_btn;
        private System.Windows.Forms.Button Logout_btn;
    }
}

