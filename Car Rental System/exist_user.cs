﻿using System;
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
    public partial class exist_user : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public exist_user()
        {
            InitializeComponent();
        }

        private void addTransbutton_Click(object sender, EventArgs e)
        {
            // Get Transaction ID
            int tid;
            myCommand.CommandText = "select max(TID) as max from rentals";
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            tid = Int32.Parse(myReader["MAX"].ToString()) + 1;
            myReader.Close();

            // Create Command and Execute
            string trans_num;
            bool status;
            TimeSpan tspan = dropDatebox.Value.Date - pickDatebox.Value.Date;
            int days = tspan.Days + 1;
            string daily, weekly, monthly, summary;
            float dailyRate, weeklyRate, monthlyRate, estimated;
            int total_day, total_week, total_month;
            DateTime one_year_ago = DateTime.Today.AddYears(-1);

            try
            {
                // Calculate Number of Transactions in the past year
                myCommand.CommandText = "select count (*) as trans_num from rentals where Customer_ID = " + custIDbox.Text;
                myCommand.CommandText += " and PickupdateDate >= '" + one_year_ago.ToString("yyyy-MM-dd") + "'";
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                trans_num = myReader["trans_num"].ToString();
                myReader.Close();

                // Update Membership Status
                if (Int32.Parse(trans_num) >= 3)
                {
                    status = true;
                    myCommand.CommandText = "update Customer set Membership_Status = 1 where Customer_ID = " + custIDbox.Text;
                    myReader = myCommand.ExecuteReader();
                    myReader.Close();
                }
                else
                {
                    status = false;
                    myCommand.CommandText = "update Customer set Membership_Status = 0 where Customer_ID = " + custIDbox.Text;
                    myReader = myCommand.ExecuteReader();
                    myReader.Close();
                }

                // Retrive Prices + Parsing
                myCommand.CommandText = "select dailyRate, weeklyRate, monthlyRate from price_VIN where VIN = '" + Vbox.Text + "'";
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                daily = myReader["dailyRate"].ToString();
                weekly = myReader["weeklyRate"].ToString();
                monthly = myReader["monthlyRate"].ToString();
                dailyRate = float.Parse(daily);
                weeklyRate = float.Parse(weekly);
                monthlyRate = float.Parse(monthly);
                myReader.Close();

                // Calculate Total Price based on rates and Membership Status
                total_month = days / 30;
                days -= total_month * 30;
                total_week = days / 7;
                days -= total_week * 7;
                estimated = total_month * monthlyRate + total_week * weeklyRate + dailyRate * days;
                if (PUBID.Text != DOBID.Text && status == false)
                {
                    estimated += 150;
                }

                // Add Transaction to Rentals table
                myCommand.CommandText = "insert into Rentals values ";
                myCommand.CommandText += "(" + tid.ToString() + ", '" + pickDatebox.Value.ToShortDateString() + "', '" +
                    dropDatebox.Value.ToShortDateString() + "', '" + pickTimebox.Text + "', '" + dropTimebox.Text + "', " +
                    custIDbox.Text + ", '" + Vbox.Text + "', " + PUBID.Text + "," + DOBID.Text + ", " + estimated + ")";
                myCommand.ExecuteNonQuery();
                myReader.Close();

                // Display Transaction Details
                summary = "Transaction ID: " + tid.ToString() + "\n";
                summary += "Pick Up Date: " + pickDatebox.Value.ToShortDateString() + "\n";
                summary += "Pick Up Time: " + pickTimebox.Text + "\n";
                summary += "Drop Off Date: " + dropDatebox.Value.ToShortDateString() + "\n";
                summary += "Drop Off Time: " + dropTimebox.Text + "\n";
                summary += "Customer ID: " + custIDbox.Text + "\n";
                summary += "VIN: " + Vbox.Text + "\n";
                summary += "Pick Up Branch ID: " + PUBID.Text + "\n";
                summary += "Drop Off Branch ID: " + DOBID.Text + "\n";
                summary += "Cost: " + estimated.ToString();
                MessageBox.Show(summary, "Transaction Summary");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                myReader.Close();
            }
        }

        private void exist_user_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieving Available Cars
            myCommand.CommandText = "select distinct * from all_car_info where VIN NOT IN (select distinct all_car_info.VIN from rentals, all_car_info where rentals.VIN = all_car_info.VIN and returnDate >= ";
            myCommand.CommandText += "'" + startdate.Value.ToString("yyyyMMdd") + "' and PickupdateDate <= '" + enddate.Value.ToString("yyyyMMdd") + "')";
            
            if (filterbranch.Text != "")
            {
                myCommand.CommandText += " and BID = " + filterbranch.Text;
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                display.Rows.Clear();
                display.ColumnCount = 13;
                display.Columns[0].Name = "VIN"; display.Columns[0].Width = 160;
                display.Columns[1].Name = "Make"; display.Columns[1].Width = 70;
                display.Columns[2].Name = "Model"; display.Columns[2].Width = 70;
                display.Columns[3].Name = "Year"; display.Columns[3].Width = 60;
                display.Columns[4].Name = "Seats"; display.Columns[4].Width = 60;
                display.Columns[5].Name = "Colour"; display.Columns[5].Width = 70;
                display.Columns[6].Name = "Odometer"; display.Columns[6].Width = 80;
                display.Columns[7].Name = "Car Description"; display.Columns[7].Width = 100;
                display.Columns[8].Name = "Daily Rate"; display.Columns[8].Width = 60;
                display.Columns[9].Name = "Weekly Rate"; display.Columns[9].Width = 60;
                display.Columns[10].Name = "Monthly Rate"; display.Columns[10].Width = 60;
                display.Columns[11].Name = "Branch"; display.Columns[11].Width = 90;
                display.Columns[12].Name = "Branch ID"; display.Columns[12].Width = 60;
                while (myReader.Read())
                {
                    display.Rows.Add(myReader["VIN"].ToString(), myReader["Make"], myReader["Model"],
                        myReader["Year"].ToString(), myReader["Seats"].ToString(), myReader["Colour"],
                        myReader["Odometer"].ToString(), myReader["Car Description"].ToString(),
                        myReader["Daily Rate"].ToString(), myReader["Weekly Rate"].ToString(),
                        myReader["Monthly Rate"].ToString(),
                        myReader["Branch"].ToString(), myReader["BID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
