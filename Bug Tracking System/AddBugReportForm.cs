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
    public partial class AddBugReportForm : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public AddBugReportForm()
        {
            InitializeComponent();
        }

        private void AddBugReportForm_Load(object sender, EventArgs e)
        {
            dt = db.read_data("SELECT * from Users WHERE ID = "+Login.userID.ToString(), "");

        }
    }
}
