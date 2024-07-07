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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roombookDataSet.user1' table. You can move, or remove it, as needed.
            this.user1TableAdapter1.Fill(this.roombookDataSet.user1);
            // TODO: This line of code loads data into the 'roomDataSet3.user1' table. You can move, or remove it, as needed.
            this.user1TableAdapter.Fill(this.roomDataSet3.user1);

        }
    }
}
