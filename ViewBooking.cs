﻿using System;
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
    public partial class ViewBooking : Form
    {
        public ViewBooking(string st)
 {
            textBox1.Text = st;    // InitializeComponent();
        }
        public ViewBooking()
        {
            InitializeComponent();
        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roombookDataSet4.bookr' table. You can move, or remove it, as needed.
          //  this.bookrTableAdapter3.Fill(this.roombookDataSet4.bookr);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM bookr where name='" + textBox1.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\Narendra23\AdvancedRoomBookingSystemCSharp\AdvancedRoomBookingSystemCSharp\roombook.mdf;Integrated Security=True"))
            {

                string str2 = "delete  FROM bookr where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
