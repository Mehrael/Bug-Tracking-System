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
            public int Id { get; set; }
            public int ActualID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
            public string Gender { get; set; }
            public string DateOfBirth { get; set; }
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
                if(Convert.ToInt32(tbl.Rows[i][5]) == 1)
                    lst.Add(new users()
                    {
                        Id = i + 1,
                        ActualID = Convert.ToInt32(tbl.Rows[i][0]),
                        Name = tbl.Rows[i][1].ToString(),
                        Email = tbl.Rows[i][2].ToString(),
                        Gender = "Female",
                        Role = tbl.Rows[i][4].ToString(),
                        DateOfBirth = tbl.Rows[i][6].ToString(),
                    });
                else
                    lst.Add(new users()
                    {
                        Id = i + 1,
                        ActualID = Convert.ToInt32(tbl.Rows[i][0]),
                        Name = tbl.Rows[i][1].ToString(),
                        Email = tbl.Rows[i][2].ToString(),
                        Gender = "Male",
                        Role = tbl.Rows[i][4].ToString(),
                        DateOfBirth = tbl.Rows[i][6].ToString(),
                    });

            }

            bs.DataSource = lst;
            dataGridView.DataSource = bs;
            dataGridView.Columns["ActualID"].Visible = false;   
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string stmt;
            bool good = false;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                stmt = "UPDATE Users SET Name = '" + dataGridView.Rows[i].Cells["Name"].Value + "', Email = '" + dataGridView.Rows[i].Cells["Email"].Value + "', DateOfBirth = '" + dataGridView.Rows[i].Cells["DateOfBirth"].Value + "'WHERE ID = " + dataGridView.Rows[i].Cells["ActualID"].Value + ";";

                if (db.execute_data(stmt, ""))
                    good = true;
                else
                    good = false;
            }

            if (good)
                MessageBox.Show("Data Saved");
        }
    }
}
