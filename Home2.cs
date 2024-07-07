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
    public partial class Home2 : Form
    {
        public Home2(string us)
        {
            string mt = us;
           // lb1.Text = mt;
            InitializeComponent();

        }

        public Home2()
        {
            InitializeComponent();
        }
      //  string mst=textBox1.Text.ToString();

        private void bookRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRoom obj = new AdvancedRoomBookingSystemCSharp.BookRoom();
            obj.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment obj1 = new Payment();
            obj1.ShowDialog();
        }

        private void viewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ViewBooking obj2 = new AdvancedRoomBookingSystemCSharp.ViewBooking();
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
