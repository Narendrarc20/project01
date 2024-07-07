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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True");
            con.Open();
            string pay = string.Empty;
            if (radioButton1.Checked)
            {
                pay = "Cash";
            }
            else if (radioButton2.Checked)
            {
                pay = "Online";
            }
            else
            {
                pay = "Card";
            }
            try
            {
                string str = "INSERT INTO payment(c_id,r_id,pay_type) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','"+pay+"'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from bookr;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Room Booking Information Saved Successfully..");
                    textBox2.Text = "";
                    textBox1.Text = "";                 
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = true;
        }
    }
}
