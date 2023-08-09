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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            txt_CarRegNo.Select();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CarRegNo.Text != string.Empty && txt_CarChaNo.Text != string.Empty && txt_Brd.Text != string.Empty &&
                    txt_Amo.Text != string.Empty && txt_Col.Text != string.Empty && txt_Mill.Text != string.Empty && txt_Mod.Text != string.Empty && txt_Year.Text != string.Empty && 
                    cbox_Fuel.SelectedIndex != -1 && cbox_Gat.SelectedIndex != -1 && cbox_Gear.SelectedIndex != -1 && cBox_SetectAC.SelectedIndex != -1)
                {
                    string carnumber = txt_CarRegNo.Text.ToUpper();
                    string chassisnumber =txt_CarChaNo.Text.ToUpper();
                    string carbrand = txt_Brd.Text.ToUpper();
                    string carcolor = txt_Col.Text.ToUpper();
                    string carmodel=txt_Mod.Text.ToUpper();
                   

                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AddCarTable values (@CarNumber, @ChassisNumber, @Brand, @Model, @Year, @Millage,@FuelType, @GearType, @Gategory, @Colour, @Amount, @Available,@AC)", con);
                    cmd.Parameters.AddWithValue("@CarNumber", carnumber);
                    cmd.Parameters.AddWithValue("@ChassisNumber", chassisnumber);
                    cmd.Parameters.AddWithValue("@Brand", carbrand);
                    cmd.Parameters.AddWithValue("@Model", carmodel);
                    cmd.Parameters.AddWithValue("@Year", txt_Year.Text);
                    cmd.Parameters.AddWithValue("@Millage", txt_Mill.Text);
                    cmd.Parameters.AddWithValue("@FuelType", cbox_Fuel.Text);
                    cmd.Parameters.AddWithValue("@GearType", cbox_Gear.Text);
                    cmd.Parameters.AddWithValue("@Gategory", cbox_Gat.Text);
                    cmd.Parameters.AddWithValue("@Colour", carcolor);
                    cmd.Parameters.AddWithValue("@Amount", txt_Amo.Text);
                    cmd.Parameters.AddWithValue("@Available", "YES");
                    cmd.Parameters.AddWithValue("@AC",cBox_SetectAC.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Added Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Inputs are Invalid, Please check...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Col.Text = string.Empty;
            txt_CarChaNo.Text = string.Empty;
            txt_CarRegNo.Text = string.Empty;
            txt_Brd.Text = string.Empty;
            txt_Amo.Text = string.Empty;
            txt_Mill.Text = string.Empty;
            txt_Mod.Text = string.Empty;
            txt_Year.Text = string.Empty;
            cbox_Fuel.Text = string.Empty;
            cbox_Gat.Text = string.Empty;
            cbox_Gear.Text = string.Empty;
            cBox_SetectAC.Text = string.Empty;
        }
    }
}
