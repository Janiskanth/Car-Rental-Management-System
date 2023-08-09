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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
            con.Open();
            //adding all CarAddTable data to dataGridView1
            SqlCommand cmd = new SqlCommand("select * from AddCartable where Available='YES'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();

            //adding CarID to the booking CarID combobox
            SqlCommand cmd1 = new SqlCommand("select CarId from AddCartable where Available='YES'", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();

            da1.Fill(dt1);
            cBox_SelectCus.DataSource = dt1;
            cBox_SelectCus.DisplayMember = "CarId";
            cmd1.ExecuteNonQuery();

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e) //booking button
        {
            

            if (txt_advance.Text != string.Empty && txt_Cus.Text != string.Empty && txt_days.Text != string.Empty && txt_ID.Text != string.Empty &&
                  txt_Lic.Text != string.Empty && txt_renDate.Text != string.Empty && cBox_SelectCus.SelectedIndex != -1 && txtCity.Text != string.Empty && txtPhNo.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select CustomerName,Proof,LicenceNumber,City,PhoneNumber from CustomerTable where Proof='" + txt_ID.Text.ToUpper() + "'", con);
                       
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();
                        SqlCommand cmd2 = new SqlCommand("insert into CustomerTable values (@CustomerName, @Proof, @LicenceNumber, @City, @PhoneNumber)", con);
                        cmd2.Parameters.AddWithValue("CustomerName", txt_Cus.Text.ToUpper());
                        cmd2.Parameters.AddWithValue("Proof", txt_ID.Text.ToUpper());
                        cmd2.Parameters.AddWithValue("LicenceNumber", txt_Lic.Text.ToUpper());
                        cmd2.Parameters.AddWithValue("City", txtCity.Text.ToUpper());
                        cmd2.Parameters.AddWithValue("PhoneNumber", txtPhNo.Text);

                        cmd2.ExecuteNonQuery();  
                    }

                    //update details on BookingTable
                    SqlCommand cmd3 = new SqlCommand("insert into BookingTable (CustomerID, CarID, RentalDate, Advance , Amount,Day,Balance) " +
                                                        "select CustomerTable.CustomerID, @CarID, @RentalDate, @Advance, AddCarTable.Amount * '"+int.Parse(txt_days.Text)+ "', @Day,(AddCarTable.Amount * '"+int.Parse(txt_days.Text)+"') - @Advance from CustomerTable,AddCarTable " +
                                                        "where CustomerTable.Proof = '" + txt_ID.Text+ "'and AddCarTable.CarId = '" + cBox_SelectCus.Text+"'", con);
                    cmd3.Parameters.AddWithValue("@CarID", cBox_SelectCus.Text);
                    cmd3.Parameters.AddWithValue("@RentalDate", txt_renDate.Text);
                    cmd3.Parameters.AddWithValue("@Advance", txt_advance.Text);
                    cmd3.Parameters.AddWithValue("@Day", txt_days.Text);                   
                    cmd3.ExecuteNonQuery();
                    

                    //change availablity when booked the car                    
                    SqlCommand cmd1 = new SqlCommand("update AddCarTable set Available='NO' where CarId = '" + cBox_SelectCus.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand("update bookingTable set Paid = 'YES' where Balance < 1",con);
                    cmd4.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Booking Sucessfully", "Scuess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_advance.Text = string.Empty;
                    txt_ID.Text = string.Empty;
                    txt_Cus.Text = string.Empty;
                    txt_days.Text = string.Empty;
                    txt_Lic.Text = string.Empty;
                    cBox_SelectCus.Text = string.Empty;
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inputs are Invalid, Please Check...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e) //Button for refresh car details
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                //adding all CarAddTable data to dataGridView1
                SqlCommand cmd = new SqlCommand("select * from AddCartable where Available='YES'", con);          
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd.ExecuteNonQuery();

                //adding CarID to the booking CarID combobox
                SqlCommand cmd1 = new SqlCommand("select CarId from AddCartable where Available='YES'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                
                da1.Fill(dt1);
                cBox_SelectCus.DataSource= dt1;
                cBox_SelectCus.DisplayMember = "CarId";
                cmd1.ExecuteNonQuery();          

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if (cBox_SelectGat.SelectedIndex != -1 && cBox_selGear.SelectedIndex != -1 && cbox_ac.SelectedIndex != -1)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from AddCarTable where GearType='" + cBox_selGear.Text + "' and Gategory='" + cBox_SelectGat.Text + "'and AC='"+cbox_ac.Text+ "' and Available='YES'", con);
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
                    dr.Close();
                    MessageBox.Show("No car Available", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }

                //adding CarID to the booking CarID combobox
                SqlCommand cmd1 = new SqlCommand("select CarId from AddCartable where Available='YES'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                cBox_SelectCus.DataSource = dt1;
                cBox_SelectCus.DisplayMember = "CarId";
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select Gear Type, Gategory and AC","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);             }
            
        }

        private void btn_checkcusDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select CustomerName,Proof,LicenceNumber,City,PhoneNumber from CustomerTable where Proof='" + txt_ID.Text.ToUpper()+"'", con) ;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_Cus.Text = dr.GetValue(0).ToString().ToUpper();
                    txt_ID.Text = dr.GetValue(1).ToString().ToUpper();
                    txt_Lic.Text = dr.GetValue(2).ToString().ToUpper();
                    txtCity.Text = dr.GetValue(3).ToString().ToUpper();
                    txtPhNo.Text = dr.GetValue(4).ToString().ToUpper();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("This Customer not in Record");
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
