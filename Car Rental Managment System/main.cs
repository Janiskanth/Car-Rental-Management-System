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
    public partial class main : Form
    {

        public String cusName { get; set; }

        public main()
        {
            InitializeComponent();
            btn_addcar.Focus();
        }

        private void main_Load(object sender, EventArgs e)
        {
            btn_addcar.Focus();
            
            lbl_Welcome.Text = "Welcome : "+cusName;
            

            //show data to main DataGridview when page load
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select top 10 BookingTable.BookingID, CustomerTable.CustomerName,BookingTable.RentalDate from BookingTable,CustomerTable where CustomerTable.CustomerID = BookingTable.CustomerID order by BookingTable.BookingID desc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);            
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btn_ViewReturn_Click(object sender, EventArgs e)
        {

        }

        private void btn_ViewBooking_Click(object sender, EventArgs e)
        {
            viewBooking vBook = new viewBooking();
            vBook.ShowDialog();
        }

        private void btn_ViewCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btn_ViewMaintenance_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_addcar_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();   
            addCar.ShowDialog();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // refresh recent data to main-system DataGridview
        {

            //show data to main DataGridview when page load
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select top 10 BookingTable.BookingID, CustomerTable.CustomerName,BookingTable.RentalDate from BookingTable,CustomerTable where CustomerTable.CustomerID = BookingTable.CustomerID order by BookingTable.BookingID desc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_ViewInventory_Click(object sender, EventArgs e)
        {
            ViewInventory viewinv = new ViewInventory();
            viewinv.ShowDialog();
        }

        private void Maintanance_Click(object sender, EventArgs e)
        {
            Maintanance maintanance = new Maintanance();
            maintanance.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }
    }
}
