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

namespace Bug_Tracking_System.Properties
{
    public partial class ViewProjectsForm : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public ViewProjectsForm()
        {
            InitializeComponent();
        }

        private void ViewProjectsForm_Load(object sender, EventArgs e)
        {
            string stmt = "";
            if (Login.role == "Manager")
                stmt = "SELECT * FROM Projects WHERE ProjectLead = '" + Login.username + "'";
            else
                stmt = "SELECT * FROM Projects";
            dt.Clear();
            dt = db.read_data(stmt, "");

            dataGridView.DataSource = dt.DefaultView;
        }
    }
}
