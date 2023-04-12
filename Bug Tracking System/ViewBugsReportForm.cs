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

namespace Bug_Tracking_System
{
    public partial class ViewBugsReportForm : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public ViewBugsReportForm()
        {
            InitializeComponent();
        }

        private void ViewBugsReportForm_Load(object sender, EventArgs e)
        {
            string stmt = "";
            if (Login.role == "Manager")
                stmt = "SELECT Bugs.*, Users.Name FROM Bugs INNER JOIN Users ON Bugs.UserID = Users.ID WHERE Users.ID = " + Login.userID;
            else
                stmt = "SELECT Bugs.*, Users.Name FROM Bugs INNER JOIN Users ON Bugs.UserID = Users.ID";
            dt.Clear();
            dt = db.read_data(stmt, "");

            dataGridView.DataSource = dt.DefaultView;
            dataGridView.Columns["UserID"].Visible = false;
        }
    }
}
