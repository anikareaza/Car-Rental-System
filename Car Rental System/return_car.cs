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


namespace Car_Rental_System
{
    public partial class return_car : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public return_car()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            int late_days;
            float dailyRate, actual_cost;
            string est_cost, pickup_bid, cust_id, rate, returnDate, VIN, summary;
            bool status;
            DateTime planned_return;
            TimeSpan tspan;

            try
            {
                // Get returnDate, pickup BID, Customer ID, Membership Status
                myCommand.CommandText = "select * from return_car where TID = " + textBox1.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                returnDate = myReader["returnDate"].ToString();
                planned_return = DateTime.Parse(returnDate).Date;
                pickup_bid = myReader["PickupBID"].ToString();
                cust_id = myReader["Customer_ID"].ToString();
                est_cost = myReader["total_rentValue"].ToString();
                actual_cost = float.Parse(est_cost);
                VIN = myReader["VIN"].ToString();
                if (myReader["Membership_Status"].ToString() == "True")
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                myReader.Close();

                // Get daily rate
                myCommand.CommandText = "select dailyRate from price_VIN, rentals where price_VIN.VIN = rentals.VIN and TID = " + textBox1.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                rate = myReader["dailyRate"].ToString();
                dailyRate = float.Parse(rate);
                myReader.Close();

                // Calculate time in dates
                tspan = actual_return.Value.Date - planned_return;
                late_days = tspan.Days;

                //Calculate late fees and different drop off branch 
                if (late_days > 0)
                {
                    actual_cost += dailyRate * late_days;
                }
                if (textBox2.Text != pickup_bid && status == false)
                {
                    actual_cost += 100;
                }

                // Update Transaction details
                myCommand.CommandText = "update Rentals set returnDate = '" + actual_return.Value.ToString("yyyy-MM-dd") + "'";
                myCommand.CommandText += ", returnTime = '" + dropTimebox.Text + "', ReturnBID = " + textBox2.Text;
                myCommand.CommandText += ", total_rentValue = " + actual_cost.ToString() + " where TID = " + textBox1.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Close();

                // Add Car to return Branch
                myCommand.CommandText = "update car set BID = " + textBox2.Text + " where VIN = '" + VIN + "'";
                myReader = myCommand.ExecuteReader();
                myReader.Close();

                // Display Transaction Details
                summary = "Transaction ID: " + textBox1.Text + "\n";
                summary += "Customer ID: " + cust_id + "\n";
                summary += "VIN: " + VIN + "\n";
                summary += "Drop Off Branch ID: " + textBox2.Text + "\n";
                summary += "Drop Off Date: " + actual_return.Value.ToString("yyyy-MM-dd") + "\n";
                summary += "Drop Off Time: " + dropTimebox.Text + "\n";
                summary += "Cost: " + actual_cost.ToString();
                MessageBox.Show(summary, "Transaction Summary");
                MessageBox.Show("Car Returned!", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error"); 
            }
            
        }

        private void return_car_Load(object sender, EventArgs e)
        {
            // Connect to database
            String connectionString = "Server = LAPTOP-KLSST8B8; Database = Car_Rental; Trusted_Connection = yes; user id = salah;";
            myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                this.Close();
            }
        }
    }
}
