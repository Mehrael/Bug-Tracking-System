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

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            string email = "";
            string password = "";

            if (name == "")
                MessageBox.Show("Enter a name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!email_txt.Text.Contains("@"))
                MessageBox.Show("Enter a valid email", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                email = email_txt.Text;

            if(password_txt.Text == "")
                MessageBox.Show("Enter a password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (password_txt.Text == confirm_password_txt.Text)
                password = password_txt.Text;
            else
                MessageBox.Show("Confirm password doesn't match the password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string role = role_cmbx.SelectedText.ToString();
            if (role == "")
                MessageBox.Show("You must choose a role", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string gender = "0";

            if(gender_cmbx.SelectedText.ToString() == "Female")
                gender = "1";

            string dateOfBirth = birthday_dtm.Value.ToShortDateString();

            string stmt = "INSERT INTO Users VALUES ('" + name + "', '" + email + "', '" + password + "', '" + role + "'," + gender + ", '" + dateOfBirth + "');";
            db.execute_data(stmt, "User added successfully");
        }
    }
}
