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
using static System.Windows.Forms.AxHost;

namespace Bug_Tracking_System
{
    public partial class ViewUsersForm : Form
    {
        Database db = new Database();
        DataTable tbl = new DataTable();
        BindingSource bs = new BindingSource();
        public class users
        {
            public int id { get; set; }
            public int actualID { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string role { get; set; }
            public int gender { get; set; }
            public string dateOfBirth { get; set; }
        }
        public ViewUsersForm()
        {
            InitializeComponent();
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            List<users> lst = new List<users>();
            tbl.Clear();
            tbl = db.read_data("select * from Users", "");

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                lst.Add(new users()
                {
                    id = i + 1,
                    actualID = Convert.ToInt32(tbl.Rows[i][0]),
                    name = tbl.Rows[i][1].ToString(),
                    email = tbl.Rows[i][2].ToString(),
                    gender = Convert.ToInt32(tbl.Rows[i][5]),
                    role = tbl.Rows[i][4].ToString(),
                    dateOfBirth = tbl.Rows[i][6].ToString(),
                });

            }

            bs.DataSource = lst;
            dataGridView.DataSource = bs;
        }
    }
}
