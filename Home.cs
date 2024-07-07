using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedRoomBookingSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void viewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooking obj = new ViewBooking();
            obj.ShowDialog();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser obj1 = new ViewUser();
            obj1.ShowDialog();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaff obj2 = new AddStaff();
            obj2.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 obj3 = new AdvancedRoomBookingSystemCSharp.Form1();
            obj3.ShowDialog();
        }
    }
}
