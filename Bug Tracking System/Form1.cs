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
    public partial class Bug_Tracker : Form
    {
        public Bug_Tracker()
        {
            InitializeComponent();
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            AddUsersForm frm = new AddUsersForm();
            frm.ShowDialog();
        }
    }
}
