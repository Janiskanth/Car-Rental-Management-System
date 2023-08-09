using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Car_Rental_Managment_System
{
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent();
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            try
            {
                textBox1.Focus();

                //show all data when load the form
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from AddcarTable", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btn_Search_Click(object sender, EventArgs e)
        {           
            try
            {
                if (textBox1.Text != string.Empty)
                {
                    //data show in DataGrid view when enter the CarId
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from AddCartable where CarId ='" + textBox1.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    textBox1.Text = string.Empty;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Data Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter the Car Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty)
                {
                    //delete data from AddCarTable
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete AddCartable where CarId ='" + textBox1.Text + "'", con);
                    textBox1.Text = string.Empty;
                    MessageBox.Show("Sucessfully Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Please Enter the Car Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void btm_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty)
                {
                    //car detail show on edit details
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select CarNumber,ChassisNumber,Brand,Model,Year,Millage,FuelType,GearType,Gategory,Colour,Amount,AC from AddCarTable where CarId='" + textBox1.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {
                        txt_carnumber.Text = dr.GetValue(0).ToString();
                        txt_chassisnumber.Text = dr.GetValue(1).ToString();
                        txt_brand.Text = dr.GetValue(2).ToString();
                        txt_model.Text = dr.GetValue(3).ToString();
                        txt_year.Text = dr.GetValue(4).ToString();
                        txt_millage.Text = dr.GetValue(5).ToString();
                        txt_color.Text = dr.GetValue(9).ToString();
                        txt_annount.Text = dr.GetValue(10).ToString();

                        dr.Close();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No record available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Please Enter the Car Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //button refresh
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                //show all data from AddCarTable
                SqlCommand cmd1 = new SqlCommand("select * from AddCartable", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty)
                {
                    if (txt_carnumber.Text != string.Empty && txt_chassisnumber.Text != string.Empty && txt_annount.Text != string.Empty && txt_brand.Text != string.Empty
                        && txt_color.Text != string.Empty && txt_millage.Text != string.Empty && txt_model.Text != string.Empty && txt_year.Text != string.Empty && txt_gategory.SelectedIndex != -1
                        && txtgear.SelectedIndex != -1 && txt_ac.SelectedIndex != -1 && txt_gategory.SelectedIndex != -1)
                    {
                        //udate the new values to existing records
                        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update AddCarTable set CarNumber = '" + txt_carnumber.Text.ToUpper() + "',ChassisNumber = '" + txt_chassisnumber.Text.ToUpper() + "',Brand = '" + txt_brand.Text.ToUpper() + "',Model='" + txt_model.Text.ToUpper() + "',Year='" + txt_year.Text + "',Millage='" + txt_millage.Text + "',FuelType='" + txt_fuel.Text + "',GearType='" + txtgear.Text + "',Gategory='" + txt_gategory.Text + "',Colour='" + txt_color.Text.ToUpper() + "',Amount='" + txt_annount.Text + "',AC= '" + txt_ac.Text + "' where CarId = '" + textBox1.Text + "'", con); ; ;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Edited Sucessfully", "Scuess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Information are Missing... Please check it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select the CarID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
