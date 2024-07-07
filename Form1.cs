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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string us;
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterUser obj = new RegisterUser();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text == "Narendra" || textBox2.Text == "1234")
                {
                    MessageBox.Show("You are logged in successfully..");
                    this.Visible = false;
                    Home obj1 = new Home();
                    obj1.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password.");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True");
                con.Open();
                string str = "SELECT id FROM user1 WHERE name = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                us=textBox1.Text;
                if (dr.Read())
                {

                    this.Visible = false;
                    Home2 obj2 = new Home2(us);
                    obj2.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
            }
        }
    }
}
