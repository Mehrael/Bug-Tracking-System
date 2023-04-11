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
    public partial class ViewBugsForm : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        List<details> type_list = new List<details>();
        List<details> pri_list = new List<details>();
        List<details> sev_list = new List<details>();
        List<details> sts_list = new List<details>();
        public class details
        {
            public int Id { get; set; }
            public int ActualID { get; set; }
            public string About { get; set; }
            public string Description { get; set; }
        }                                    

        public ViewBugsForm()
        {
            InitializeComponent();
        }

        private void ViewBugsForm_Load(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugType", "");

            for (int i = 0; i < dt.Rows.Count; i++)
                type_list.Add(new details
                {
                    Id = i+1,
                    ActualID = Convert.ToInt32(dt.Rows[i][0]),
                    About = dt.Rows[i][1].ToString(),
                    Description = dt.Rows[i][2].ToString(),
                });
            ///////////////////////////////////////////////////////
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugPriority", "");

            for (int i = 0; i < dt.Rows.Count; i++)
                pri_list.Add(new details
                {
                    Id = i+1,
                    ActualID = Convert.ToInt32(dt.Rows[i][0]),
                    About = dt.Rows[i][1].ToString(),
                    Description = dt.Rows[i][2].ToString(),
                });                     
            ///////////////////////////////////////////////////////      
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugSeverity", "");

            for (int i = 0; i < dt.Rows.Count; i++)
                sev_list.Add(new details
                {
                    Id = i+1,
                    ActualID = Convert.ToInt32(dt.Rows[i][0]),
                    About = dt.Rows[i][1].ToString(),
                    Description = dt.Rows[i][2].ToString(),
                });
            ///////////////////////////////////////////////////////      
            dt.Clear();
            dt = db.read_data("SELECT * FROM BugStatus", "");

            for (int i = 0; i < dt.Rows.Count; i++)
                sts_list.Add(new details
                {
                    Id = i+1,
                    ActualID = Convert.ToInt32(dt.Rows[i][0]),
                    About = dt.Rows[i][1].ToString(),
                    Description = dt.Rows[i][2].ToString(),
                });
            ///////////////////////////////////////////////////////
        }

        private void View_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (View_cmbx.SelectedIndex == 0)
                bs.DataSource = type_list;
            else if (View_cmbx.SelectedIndex == 1)
                bs.DataSource = sev_list;
            else if (View_cmbx.SelectedIndex == 2)
                bs.DataSource = pri_list;
            else if (View_cmbx.SelectedIndex == 3)
                bs.DataSource = sts_list;

            dataGridView.DataSource = bs;
            dataGridView.Columns["ActualID"].Visible = false;
        }

    }
}
