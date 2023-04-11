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
    public partial class AddProjectsForm : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public AddProjectsForm()
        {
            InitializeComponent();
        }

        private void AddProjectsForm_Load(object sender, EventArgs e)
        {

            dt.Clear();
            dt = db.read_data("SELECT * FROM Users WHERE Role = 'Developer / Tester' OR Role ='Manager'", "");

            Project_lead_cmbx.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                Project_lead_cmbx.Items.Add(dt.Rows[i][1]);
        }

        private void Add_project_btn_Click(object sender, EventArgs e)
        {
            bool checker = true;

            string name = "";
            if(Project_name_txt.Text.Length > 0)
                name = Project_name_txt.Text;
            else
            {
                checker = false;
                MessageBox.Show("You must enter the project's name","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string des = Description_txt.Text;
            string project_lead = "";
            if(Project_lead_cmbx.SelectedItem != null)
                project_lead = Project_lead_cmbx.SelectedItem.ToString();
            else
            {
                checker = false;
                MessageBox.Show("You must choose the project's leader", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string client_name = "";
            if(Client_name_txt.Text.Length > 0)
                client_name = Client_name_txt.Text;
            else
            {
                checker = false;
                MessageBox.Show("You must enter the client's name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string client_address = client_address_txt.Text;
            string client_phone = "";
            if(Client_phone_txt.Text.Length > 0)
                client_phone = Client_phone_txt.Text;
            else
            {
                checker = false;
                MessageBox.Show("You must enter the client's phone number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string submission_date = Submission_date_dtm.Value.ToShortDateString();

            if(checker)
            {
                string stmt = "INSERT INTO Projects VALUES ('" + name + "','" + des + "','" + submission_date + "','" + client_name + "','" + client_address + "','" + client_phone + "','" + project_lead + "');";
                Project_name_txt.Text = "";
                Client_name_txt.Text = "";
                Client_phone_txt.Text = "";
                Client_phone_txt.Text = "";
                Project_lead_cmbx.SelectedIndex = -1;

                db.execute_data(stmt, "Project Added Seccessfully");
            }
        }
    }
}
