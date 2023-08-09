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
    public partial class create_account : Form
    {
        public create_account()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //login button
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.ShowDialog();
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();

                if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && txtCpassword.Text !=string.Empty)
                {
                    if (txtPassword.TextLength > 7) 
                    {
                        if (txtPassword.Text == txtCpassword.Text)
                        {
                            SqlCommand cmd = new SqlCommand("select * from AccountTable where username = '"+txtUsername.Text+"'",con);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if(dr.Read())
                            {
                                dr.Close();
                                MessageBox.Show("The Username "+txtUsername.Text+" already taken...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();
                                SqlCommand cmd1 = new SqlCommand("insert into AccountTable values(@username, @password)  ", con);
                                cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
                                cmd1.Parameters.AddWithValue("@password",txtPassword.Text);
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Account Created sucessfully...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Check the password... Password shoud be same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must have minimum 8 letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please check.. Inputs are Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somethig Wrong, Please Contact the Support Team... "+ ex.Message);
            }
        }

        private void create_account_Load(object sender, EventArgs e)
        {

        }
    }
}
