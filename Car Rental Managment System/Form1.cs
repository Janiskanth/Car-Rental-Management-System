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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Application.Exit();                                              
        }

        private void button2_Click(object sender, EventArgs e) //Signup button
        {
            this.Hide();
            create_account Create_Account = new create_account();
            Create_Account.ShowDialog();      


        }

        private void button1_Click(object sender, EventArgs e) //Login button
        {
            try
            {
                if (txtUsername.Text != string.Empty && txtpassword.Text != string.Empty)
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from AccountTable where username = '" + txtUsername.Text + "' and password = '" + txtpassword.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        this.Hide();
                        main Main = new main();
                        Main.cusName = txtUsername.Text;
                        Main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("username password are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please check.. Inputs are Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somethig Wrong, Please Contact the Support Team... " + ex.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
