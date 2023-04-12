using Bug_Tracking_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracking_System
{
    public partial class Bug_Tracker : Form
    {
        string role = Login.role;
        public Bug_Tracker()
        {
            InitializeComponent();
        }

        private void Add_user_btn_Click(object sender, EventArgs e)
        {
            AddUsersForm frm = new AddUsersForm();
            frm.ShowDialog();
        }

        private void View_users_btn_Click(object sender, EventArgs e)
        {
            ViewUsersForm frm = new ViewUsersForm();
            frm.ShowDialog();
        }

        private void Add_bug_btn_Click(object sender, EventArgs e)
        {
             AddBugForm frm = new AddBugForm();
            frm.ShowDialog();
        }

        private void Bug_Tracker_Load(object sender, EventArgs e)
        {
            if (role == "Manager")
            {
                add_user_btn.Visible = false;
                add_bug_btn.Enabled = false;
            }
            else if (role == "Developer / Tester")
            {
                add_user_btn.Visible = false;
                view_users_btn.Visible = false;
            }
        }

        private void Add_bug_report_btn_Click(object sender, EventArgs e)
        {
            AddBugReportForm frm = new AddBugReportForm();
            frm.ShowDialog();
        }

        private void Add_project_btn_Click(object sender, EventArgs e)
        {
            AddProjectsForm frm = new AddProjectsForm();
            frm.ShowDialog();
        }

        private void View_bugs_btn_Click(object sender, EventArgs e)
        {
             ViewBugsForm frm = new ViewBugsForm();
            frm.ShowDialog();
        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm();
            frm.ShowDialog();
        }

        private void view_project_btn_Click(object sender, EventArgs e)
        {
            ViewProjectsForm frm = new ViewProjectsForm();
            frm.ShowDialog();
        }

        private void View_bug_report_btn_Click(object sender, EventArgs e)
        {
            ViewBugsReportForm frm = new ViewBugsReportForm();
            frm.ShowDialog();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}
