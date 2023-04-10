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
    public partial class AddUsersForm : Form
    {
        Database db = new Database();
        public AddUsersForm()
        {
            InitializeComponent();
        }

        private void Add_user_btn_Click(object sender, EventArgs e)
        {
            bool checker = true;

            string name = name_txt.Text;
            string email = "";
            string password = "";

            if (name == "")
            {
                MessageBox.Show("Enter a name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checker = false;
            }

            if (!email_txt.Text.Contains("@"))
            {
                MessageBox.Show("Enter a valid email", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checker = false;
            }
            else
                email = email_txt.Text;

            if (password_txt.Text == "")
            {
                MessageBox.Show("Enter a password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checker = false;
            }

            if (password_txt.Text != confirm_password_txt.Text)
            {
                MessageBox.Show("Confirm password doesn't match the password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checker = false;
            }
            else
                password = password_txt.Text;

            string role = "";
            if (role_cmbx.SelectedItem == null)
            {
                MessageBox.Show("You must choose a role", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checker = false;
            }
            else
                role = role_cmbx.SelectedItem.ToString();

            string gender = "";
            if (gender_cmbx.SelectedItem == null) 
                gender = "0";
            else if (gender_cmbx.SelectedItem.ToString() == "Female")
                gender = "1";

            string dateOfBirth = birthday_dtm.Value.ToShortDateString();

            if (checker)
            {
                string stmt = "INSERT INTO Users VALUES ('" + name + "', '" + email + "', '" + password + "', '" + role + "'," + gender + ", '" + dateOfBirth + "');";
                db.execute_data(stmt, "User added successfully");
            }
        }
    }
}
