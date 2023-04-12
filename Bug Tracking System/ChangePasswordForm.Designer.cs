namespace Bug_Tracking_System
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.Change_btn = new System.Windows.Forms.Button();
            this.Old_password_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.New_password_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm_password_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbar_panel.SuspendLayout();
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
            this.navbar_panel.Size = new System.Drawing.Size(487, 74);
            this.navbar_panel.TabIndex = 6;
            // 
            // Change_btn
            // 
            this.Change_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Change_btn.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Change_btn.Location = new System.Drawing.Point(77, 421);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(339, 63);
            this.Change_btn.TabIndex = 10;
            this.Change_btn.Text = "Change";
            this.Change_btn.UseVisualStyleBackColor = true;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Old_password_txt
            // 
            this.Old_password_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Old_password_txt.Location = new System.Drawing.Point(77, 137);
            this.Old_password_txt.Name = "Old_password_txt";
            this.Old_password_txt.PasswordChar = '*';
            this.Old_password_txt.Size = new System.Drawing.Size(339, 35);
            this.Old_password_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(72, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Old Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(72, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password:";
            // 
            // New_password_txt
            // 
            this.New_password_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_password_txt.Location = new System.Drawing.Point(77, 235);
            this.New_password_txt.Name = "New_password_txt";
            this.New_password_txt.PasswordChar = '*';
            this.New_password_txt.Size = new System.Drawing.Size(339, 35);
            this.New_password_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(72, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm Password:";
            // 
            // Confirm_password_txt
            // 
            this.Confirm_password_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_password_txt.Location = new System.Drawing.Point(77, 336);
            this.Confirm_password_txt.Name = "Confirm_password_txt";
            this.Confirm_password_txt.PasswordChar = '*';
            this.Confirm_password_txt.Size = new System.Drawing.Size(339, 35);
            this.Confirm_password_txt.TabIndex = 9;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 524);
            this.Controls.Add(this.Change_btn);
            this.Controls.Add(this.Confirm_password_txt);
            this.Controls.Add(this.New_password_txt);
            this.Controls.Add(this.Old_password_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.navbar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navbar_panel.ResumeLayout(false);
            this.navbar_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel navbar_panel;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.TextBox Old_password_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox New_password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Confirm_password_txt;
    }
}