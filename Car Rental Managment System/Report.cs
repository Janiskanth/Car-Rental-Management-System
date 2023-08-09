using iText.StyledXmlParser.Jsoup.Select;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Managment_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
            btnPDF.Enabled = false;
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            try
            {               

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\BIT\\semi 2\\ITE 1942 ICT Project 2022S1\\Project\\Car Rental Managment System\\Car Rental Managment System\\CRMS_Database.mdf\";Integrated Security=True");
                con.Open();
                if (txtReport.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("select * from AddCarTable", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    btnPDF.Enabled = true;
                    con.Close();
                }
                else if (txtReport.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select * from CustomerTable", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    btnPDF.Enabled = true;
                    con.Close();
                }
                else if (txtReport.SelectedIndex == 2)
                {
                    SqlCommand cmd = new SqlCommand("select * from BookingTable", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    btnPDF.Enabled = true;
                    con.Close();
                }
                else if (txtReport.SelectedIndex == 3)
                {
                    SqlCommand cmd = new SqlCommand("select * from ReturnTable", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    btnPDF.Enabled = true;
                    con.Close();
                }
                else if (txtReport.SelectedIndex == 4)
                {
                    SqlCommand cmd = new SqlCommand("select * from MaintananceTable", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    btnPDF.Enabled = true;
                    con.Close();
                }
                else if (txtReport.SelectedIndex == 5)
                {
                    SqlCommand cmd = new SqlCommand("select * from AccountTable", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    btnPDF.Enabled = true;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Try Again... Input Information are Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = txtReport.Text + " Report";
                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("Unable to write data to disk: " + ex.Message);
                            }
                        }
                        if (!ErrorMessage)
                        {
                            try
                            {
                                Document document = new Document();
                                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(save.FileName, FileMode.Create));
                                document.Open();
                                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;

                                // Add column headers
                                foreach (DataGridViewColumn col in dataGridView1.Columns)
                                {
                                    if (col.HeaderText != null)
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                        pTable.AddCell(pCell);
                                    }
                                }

                                // Add data cells
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    foreach (DataGridViewCell dcell in row.Cells)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell(string.Empty);
                                        }
                                    }
                                }

                                document.Add(pTable);
                                document.Close();
                                writer.Close();
                                MessageBox.Show("Data exported to PDF successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while exporting data: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No records available", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
