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
    public partial class BookRoom : Form
    {
        public BookRoom()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True");

            con.Open();
            if (textBox7.Text != "")
            {
                try
                {
                    string getCust = "select name,contact,addr from user1 where id=" + Convert.ToInt32(textBox7.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox9.Text = dr.GetValue(0).ToString();
                        textBox8.Text = dr.GetValue(1).ToString();
                        textBox10.Text = dr.GetValue(2).ToString();
                       
                    }
                    else
                    {
                        MessageBox.Show(" Thid Id's Customer is not recorded...  ");
                        textBox7.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True");
            con.Open();
            string gen = string.Empty;
           
            try
            {
                string str = "INSERT INTO bookr(fromd,tod,roomno,nopeople,amnt,c_id,name,contact,addr) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox10.Text + "'); ";

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
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";                                        
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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select fromd,tod,roomno,nopeople,amnt,c_id,name,contact,addr from bookr where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox2.Text = dr.GetValue(0).ToString();
                        textBox3.Text = dr.GetValue(1).ToString();
                        textBox5.Text = dr.GetValue(2).ToString();
                        textBox4.Text = dr.GetValue(3).ToString();
                        textBox6.Text = dr.GetValue(4).ToString();
                        textBox7.Text = dr.GetValue(5).ToString();
                        textBox9.Text = dr.GetValue(6).ToString();
                        textBox8.Text = dr.GetValue(7).ToString();
                        textBox10.Text = dr.GetValue(8).ToString();
                        
                       
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " Booking Room Record is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string str = " Update bookr set fromd='" + textBox2.Text + "',tod='" + textBox3.Text + "',roomno='" + textBox5.Text + "',nopeople='" + textBox4.Text + "',amnt='" + textBox6.Text + "',c_id='" + textBox7.Text + "',name='" + textBox9.Text + "',contact='" + textBox8.Text + "',addr='" + textBox10.Text + "' where id='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from bookr;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox1.Text + "'s Details is Updated Successfully.. ", "Important Message");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                   
                  
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void BookRoom_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from bookr;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {

            int fd = Convert.ToInt32(textBox2.Text.ToString());
            int td = Convert.ToInt32(textBox3.Text.ToString());
            int df = td - fd;
            int pr = 1000;
            int tot = df * pr;
            textBox6.Text = tot.ToString();
        }
    }
}