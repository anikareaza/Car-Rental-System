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
    public partial class car : Form
    {

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public void refresh()
        {
            // Refresh data grid with the most updated data
            myCommand.CommandText = "select * from car";
            try
            {
                myReader = myCommand.ExecuteReader();
                display.Rows.Clear();
                display.ColumnCount = 10;
                display.Columns[0].Name = "VIN";
                display.Columns[1].Name = "Make";
                display.Columns[2].Name = "Model";
                display.Columns[3].Name = "Year";
                display.Columns[4].Name = "Seats";
                display.Columns[5].Name = "Colour";
                display.Columns[6].Name = "Insurance Number";
                display.Columns[7].Name = "Odometer Number";
                display.Columns[8].Name = "Branch ID";
                display.Columns[9].Name = "Car Type ID";
                while (myReader.Read())
                {
                    display.Rows.Add(myReader["VIN"].ToString(), myReader["Make"], myReader["Model"],
                        myReader["year"].ToString(), myReader["noOfSeats"].ToString(), myReader["colour"],
                        myReader["InsuranceNo"].ToString(), myReader["odometernumber"].ToString(),
                        myReader["BID"].ToString(), myReader["CarTypeID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public car()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create Command and Execute
            myCommand.CommandText = "insert into car values ('" + VINbox.Text + "','" + makebox.Text + "','" + modelbox
                    .Text + "'," + yearbox.Text + "," + NoOfSeatsbox.Text + ",'" + colourbox.Text + "','" +
                    insurancenobox.Text + "'," + odometerNumberbox.Text + "," + branchIDbox.Text + "," +
                    carTypeIDbox.Text + ")";
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Car Added!", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();
        }

        private void NO2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NO3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void car_Load(object sender, EventArgs e)
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
            refresh();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            // Modify tuple with given values
            if (makebox.Text != "")
            {
                myCommand.CommandText = "update car SET Make = '" + makebox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (modelbox.Text != "")
            {
                myCommand.CommandText = "update car SET Model = '" + modelbox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (yearbox.Text != "")
            {
                myCommand.CommandText = "update car SET year = '" + yearbox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (NoOfSeatsbox.Text != "")
            {
                myCommand.CommandText = "update car SET noOfSeats = '" + NoOfSeatsbox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (colourbox.Text != "")
            {
                myCommand.CommandText = "update car SET colour = '" + colourbox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (insurancenobox.Text != "")
            {
                myCommand.CommandText = "update car SET InsuranceNo = '" + insurancenobox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (odometerNumberbox.Text != "")
            {
                myCommand.CommandText = "update car SET odometernumber = '" + odometerNumberbox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (branchIDbox.Text != "")
            {
                myCommand.CommandText = "update car SET BID = '" + branchIDbox.Text + "'where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
                
            if (carTypeIDbox.Text != "")
            {
                myCommand.CommandText = "update car SET CarTypeID = " + carTypeIDbox.Text + " where VIN =" + VINbox.Text;
                myCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Car Modified!", "Successful");
            refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Delete tuple of given VIN
            myCommand.CommandText = "delete from car where VIN =" + VINbox.Text;
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Car Deleted!", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();
        }
    }
}
