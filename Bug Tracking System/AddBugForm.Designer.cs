namespace Bug_Tracking_System
{
    partial class AddBugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBugForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.About_cmbx = new System.Windows.Forms.ComboBox();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.About_txt = new System.Windows.Forms.TextBox();
            this.Bug_detail_label = new System.Windows.Forms.Label();
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
            this.navbar_panel.Size = new System.Drawing.Size(659, 74);
            this.navbar_panel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.About_cmbx);
            this.groupBox1.Controls.Add(this.Description_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.About_txt);
            this.groupBox1.Controls.Add(this.Bug_detail_label);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 576);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug Details";
            // 
            // add_btn
            // 
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_btn.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.add_btn.Location = new System.Drawing.Point(140, 480);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(341, 63);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // About_cmbx
            // 
            this.About_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.About_cmbx.FormattingEnabled = true;
            this.About_cmbx.Items.AddRange(new object[] {
            "Type",
            "Status",
            "Severity",
            "Priority"});
            this.About_cmbx.Location = new System.Drawing.Point(140, 106);
            this.About_cmbx.Name = "About_cmbx";
            this.About_cmbx.Size = new System.Drawing.Size(341, 34);
            this.About_cmbx.TabIndex = 2;
            this.About_cmbx.SelectedIndexChanged += new System.EventHandler(this.About_cmbx_SelectedIndexChanged);
            // 
            // Description_txt
            // 
            this.Description_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_txt.Location = new System.Drawing.Point(140, 314);
            this.Description_txt.Multiline = true;
            this.Description_txt.Name = "Description_txt";
            this.Description_txt.Size = new System.Drawing.Size(341, 138);
            this.Description_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(135, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(135, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "About:";
            // 
            // About_txt
            // 
            this.About_txt.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_txt.Location = new System.Drawing.Point(140, 214);
            this.About_txt.Name = "About_txt";
            this.About_txt.Size = new System.Drawing.Size(341, 35);
            this.About_txt.TabIndex = 1;
            // 
            // Bug_detail_label
            // 
            this.Bug_detail_label.AutoSize = true;
            this.Bug_detail_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bug_detail_label.Location = new System.Drawing.Point(135, 185);
            this.Bug_detail_label.Name = "Bug_detail_label";
            this.Bug_detail_label.Size = new System.Drawing.Size(0, 26);
            this.Bug_detail_label.TabIndex = 0;
            // 
            // AddBugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navbar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddBugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bug";
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
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ComboBox About_cmbx;
        private System.Windows.Forms.TextBox Description_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox About_txt;
        private System.Windows.Forms.Label Bug_detail_label;
    }
}