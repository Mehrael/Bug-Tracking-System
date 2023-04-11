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
    public partial class ChangePasswordForm : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.read_data("SELECT Password FROM Users WHERE ID = " + Login.userID, "");
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            string password = "";
            bool checker = true;

            if(Old_password_txt.Text != dt.Rows[0][0].ToString())
            {
                MessageBox.Show("Old Password is incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checker = false;
            }
            else
            {
                if (New_password_txt.Text == "")
                {
                    MessageBox.Show("Enter a password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker = false;
                }

                if (New_password_txt.Text != Confirm_password_txt.Text)
                {
                    MessageBox.Show("Confirm password doesn't match the new password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker = false;
                }
                else
                    password = New_password_txt.Text;
            }

            if(checker)
            {
                string stmt = "UPDATE Users SET Password ='" + password + "' WHERE ID = " + Login.userID;
                db.execute_data(stmt, "Password Changed");
            }
        }
    }
}
