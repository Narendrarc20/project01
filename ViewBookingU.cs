using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvancedRoomBookingSystemCSharp
{
    public partial class ViewBookingU : Form
    {
        public ViewBookingU()
        {
            InitializeComponent();
        }

        private void ViewBookingU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roombookDataSet1.bookr' table. You can move, or remove it, as needed.
            this.bookrTableAdapter1.Fill(this.roombookDataSet1.bookr);
            // TODO: This line of code loads data into the 'roomDataSet2.bookr' table. You can move, or remove it, as needed.
            this.bookrTableAdapter.Fill(this.roomDataSet2.bookr);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM bookr where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM bookr where id='"+textBox1.Text +"'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
