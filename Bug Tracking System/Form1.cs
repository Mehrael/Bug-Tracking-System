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
    }
}
