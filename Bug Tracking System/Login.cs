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
    public partial class Login : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public static string role = "";
        public static int userID = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            dt = db.read_data("SELECT * from Users WHERE Email = '" + email_txt.Text + "'AND Password = '" + password_txt.Text + "'", "");
            if(dt.Rows.Count > 0) 
            {     
                userID = (int)dt.Rows[0][0];
                role = dt.Rows[0][4].ToString();
                Bug_Tracker bug_Tracker = new Bug_Tracker();
                bug_Tracker.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Email or password may be incorrect","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
