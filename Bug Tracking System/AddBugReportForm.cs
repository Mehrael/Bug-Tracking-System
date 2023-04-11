using Bug_Tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Bug_Tracking_System
{
    public partial class AddBugReportForm : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public AddBugReportForm()
        {
            InitializeComponent();
        }


        private void Add_project_btn_Click(object sender, EventArgs e)
        {
            bool checker = true;

            string title = "";
            if(Bug_title_txt.Text.Length > 0 )
                title = Bug_title_txt.Text;
            else
            {
                checker = false;
                MessageBox.Show("You must enter a Bug Title","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            string des = Description_txt.Text;
            string project = "";
            if(Project_cmbx.SelectedItem != null)
                project = Project_cmbx.SelectedItem.ToString();
            else
            {
                checker = false;
                MessageBox.Show("You must enter project's name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string type = "";
            if(Type_cmbx.SelectedItem != null)
                type = Type_cmbx.SelectedItem.ToString();
            else
            {
                checker = false;
                MessageBox.Show("You must choose bug's type", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string status = "";
            if (Status_cmbx.SelectedItem != null)
                status = Status_cmbx.SelectedItem.ToString();
            else
            {
                checker = false;
                MessageBox.Show("You must choose bug's status", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string severity = "";
            if (Severity_cmbx.SelectedItem != null)
                severity = Severity_cmbx.SelectedItem.ToString();
            else
            {
                checker = false;
                MessageBox.Show("You must choose bug's severity", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string priority = "";
            if (Priority_cmbx.SelectedItem != null)
                priority = Priority_cmbx.SelectedItem.ToString();
            else
            {
                checker = false;
                MessageBox.Show("You must choose bug's priority", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string notes = comments_txt.Text;
            string bugDate = bug_date_dtm.Value.ToShortDateString();

            string isFixed = "";
            bool isChecked = Fixed_checkBox.Checked;

            if (isChecked)
                isFixed = "1";
            else
                isFixed = "0";

            if(checker)
            {
                string stmt = "INSERT INTO Bugs VALUES('" + title + "','" + project + "','" + status + "','" + type + "','" + severity + "','" + priority + "','" + bugDate + "'," + Login.userID.ToString() + ",'" + des + "','" + notes + "'," + isFixed + ");";
                db.execute_data(stmt, "Bug Report Added Successfully");
            }
        }

        private void AddBugReportForm_Load(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugType", "");

            Type_cmbx.Items.Clear();
            for(int i =0;i<dt.Rows.Count;i++) 
                Type_cmbx.Items.Add(dt.Rows[i][1]);

            /////////////////////////////////////////////////////////
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugPriority", "");

            Priority_cmbx.Items.Clear();
            for(int i =0;i<dt.Rows.Count;i++)
                Priority_cmbx.Items.Add(dt.Rows[i][1]);

            /////////////////////////////////////////////////////////
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugSeverity", "");

            Severity_cmbx.Items.Clear();
            for(int i =0;i<dt.Rows.Count;i++)
                Severity_cmbx.Items.Add(dt.Rows[i][1]);

            /////////////////////////////////////////////////////////
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugStatus", "");

            Status_cmbx.Items.Clear();
            for(int i =0;i<dt.Rows.Count;i++)
                Status_cmbx.Items.Add(dt.Rows[i][1]);

            /////////////////////////////////////////////////////////
        }
    }
}
