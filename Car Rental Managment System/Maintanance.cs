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
    public partial class Maintanance : Form
    {
        public Maintanance()
        {
            InitializeComponent();
        }

        private void Maintanance_Load(object sender, EventArgs e)
        {
            try
            {
                label10.Hide();
                label8.Hide();

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from MaintananceTable", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd1 = new SqlCommand("select CarId from AddCarTable where Available = 'YES'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                //dt1 = dt1.AsEnumerable().Reverse().CopyToDataTable();
                txtCarID.DataSource = dt1;
                txtCarID.DisplayMember = "CarId";

                
                SqlCommand cmd2 = new SqlCommand("select MaintanceID from MaintananceTable where Status = 'PROCESS'", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                txtMainID.DataSource = dt2;
                txtMainID.DisplayMember = "MaintanceID";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCarID.SelectedIndex != -1)
                {
                    //add details on Maintanance database
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into MaintananceTable (CarID,Date) values ('" + txtCarID.Text + "', '" + dateTimePicker1.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    
                    SqlCommand cmd1 = new SqlCommand("update AddCarTable set Available='NO' where CarId = '" + txtCarID.Text + "' ", con);
                    cmd1.ExecuteNonQuery();                        
                    MessageBox.Show("Updating Record on Maintanance", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlCommand cmd2 = new SqlCommand("select CarId from AddCarTable where Available = 'YES'", con);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    txtCarID.DataSource = dt1;
                    txtCarID.DisplayMember = "CarId";


                    con.Close();
                    txtCarID.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Try again... Input Informations are Incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //maintanance details search by carid


                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from MaintananceTable where  CarID= '" + txtCarID.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("No Maintanance Car record Available...", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMainID.SelectedIndex != -1 && txtCost.Text != string.Empty) 
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update MaintananceTable set ReturnDate = '" + dateTimePicker2.Text + "', Cost='" + txtCost.Text + "', Status='FINISH' where MaintanceID='" + txtMainID.Text + "' ", con);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("select CarID from maintananceTable where MaintanceID= '" + txtMainID.Text + "'", con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        label10.Text = dr.GetValue(0).ToString();
                        label10.Show();
                        label8.Show();
                        dr.Close();

                        SqlCommand cmd2 = new SqlCommand("update AddCarTable set Available='YES' where CarId = '" + label10.Text + "' ", con);
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Car Returned from Maintanance", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlCommand cmd3 = new SqlCommand("select MaintanceID from MaintananceTable where Status = 'PROCESS'", con);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd3);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    txtMainID.DataSource = dt2;
                    txtMainID.DisplayMember = "MaintanceID";
                    con.Close();

                    txtMainID.Text = string.Empty;
                    txtCost.Text = string.Empty;                                                                                      
                }
                else
                {
                    MessageBox.Show("Try again... Input Informations are Incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                label10.Hide();
                label8.Hide();

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from MaintananceTable", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd1 = new SqlCommand("select CarId from AddCarTable where Available = 'YES'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                txtCarID.DataSource = dt1;
                txtCarID.DisplayMember = "CarId";


                SqlCommand cmd2 = new SqlCommand("select MaintanceID from MaintananceTable where Status = 'PROCESS'", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                txtMainID.DataSource = dt2;
                txtMainID.DisplayMember = "MaintanceID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRetSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //maintanance details search by maintananceid
              
                
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from MaintananceTable where  MaintanceID= '" + txtMainID.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Maintanance Record not Available...", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                con.Close();
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
