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

namespace Car_Rental_Managment_System
{
    public partial class viewBooking : Form
    {
        public viewBooking()
        {
            InitializeComponent();
            
        }

        private void viewBooking_Load(object sender, EventArgs e)
        {
            lbl_cusID.Hide();
            lbl_carID.Hide();
            lbl_id.Hide();
            lbl_name.Hide();
            lbl_return.Hide();
            lbl_bal.Hide();
            inputlbl_bal.Hide();
            inputlbl_carID.Hide();
            inputlbl_cusID.Hide();
            inputlbl_ID.Hide();
            inputlbl_name.Hide();
            dateTimePicker1.Hide();
            button2.Enabled = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();

                

                SqlCommand cmd = new SqlCommand("select * from BookingTable ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt = dt.AsEnumerable().Reverse().CopyToDataTable();
                dataGridView1.DataSource = dt;
                con.Close();

                SqlCommand cmd1 = new SqlCommand("select BookingID from BookingTable where [Return] = 'NO'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt2 = new DataTable();
                da1.Fill(dt2);
                inputtxt_bID.DataSource = dt2;
                inputtxt_bID.DisplayMember = "BookingID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from BookingTable where BookingId = '" + txt_search.Text + "'",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from BookingTable ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd1 = new SqlCommand("select BookingID from BookingTable where [Return] = 'NO'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt2 = new DataTable();
                da1.Fill(dt2);
                inputtxt_bID.DataSource = dt2;
                inputtxt_bID.DisplayMember = "BookingID";

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //button for select
        {
            try
            {
                if (inputtxt_bID.Text != string.Empty)
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select CarID, Balance, CustomerID from BookingTable where BookingID = '" + inputtxt_bID.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {


                        inputlbl_cusID.Text = dr.GetValue(2).ToString().ToUpper();
                        inputlbl_cusID.Show();
                        lbl_cusID.Show();

                        inputlbl_carID.Text = dr.GetValue(0).ToString().ToUpper();
                        inputlbl_carID.Show();
                        lbl_carID.Show();

                        inputlbl_bal.Text = dr.GetValue(1).ToString().ToUpper();
                        inputlbl_bal.Show();
                        lbl_bal.Show();

                        lbl_return.Show();
                        dateTimePicker1.Show();
                        dr.Close();


                        SqlCommand cmd1 = new SqlCommand("select CustomerName , Proof from CustomerTable where CustomerID = '" + inputlbl_cusID.Text + "' ", con);
                        SqlDataReader dr1 = cmd1.ExecuteReader();

                        if (dr1.Read())
                        {


                            inputlbl_ID.Text = dr1.GetValue(1).ToString();
                            inputlbl_ID.Show();
                            lbl_id.Show();

                            inputlbl_name.Text = dr1.GetValue(0).ToString();
                            inputlbl_name.Show();
                            lbl_name.Show();

                            button2.Enabled = true;

                            dr1.Close();
                        }
                        else
                        {
                            MessageBox.Show("No Record Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }                    
                }
                else
                {
                    MessageBox.Show("Please Select the Booking ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // button for return
        {
            try
            {
                if (inputtxt_bID.SelectedIndex != -1)
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("update AddCarTable set Available='YES' where CarId ='" + inputlbl_carID.Text + "' ", con);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("UPDATE BookingTable SET ReturnDate = '" + dateTimePicker1.Text + "', [Return] = 'YES', Balance = '0', Paid = 'YES' WHERE BookingID = '" + inputtxt_bID.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("insert into ReturnTable values(@BookingID,@CustomerID,@CarID,@ReturnDate)", con);
                    cmd2.Parameters.AddWithValue("BookingID",inputtxt_bID.Text);
                    cmd2.Parameters.AddWithValue("CustomerID",inputlbl_cusID.Text);
                    cmd2.Parameters.AddWithValue("CarID", inputlbl_carID.Text);
                    cmd2.Parameters.AddWithValue("ReturnDate", dateTimePicker1.Text);
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car Sucessfully returned", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_cusID.Hide();
                    lbl_carID.Hide();
                    lbl_id.Hide();
                    lbl_name.Hide();
                    lbl_return.Hide();
                    lbl_bal.Hide();
                    inputlbl_bal.Hide();
                    inputlbl_carID.Hide();
                    inputlbl_cusID.Hide();
                    inputlbl_ID.Hide();
                    inputlbl_name.Hide();
                    dateTimePicker1.Hide();
                    button2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Select the Booking ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
