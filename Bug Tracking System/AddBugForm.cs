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
    public partial class AddBugForm : Form
    {
        Database db = new Database();
        public AddBugForm()
        {
            InitializeComponent();
        }

        private void About_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bug_detail_label.Text = About_cmbx.SelectedItem.ToString() + ":";
            About_txt.Text = "";
            Description_txt.Text = "";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string table = "Bug" + About_cmbx.SelectedItem.ToString();
            string stmt = "INSERT INTO " + table + " VALUES('" + About_txt.Text + "','" + Description_txt.Text + "');";

            Description_txt.Text = stmt;
            db.execute_data(stmt, "Added Successfully");
        }
    }
}
