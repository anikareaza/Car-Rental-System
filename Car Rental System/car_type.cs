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
    public partial class car_type : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public void refresh()
        {
            // Refresh data grid with the most updated data
            myCommand.CommandText = "select * from cartype";
            try
            {
                myReader = myCommand.ExecuteReader();
                display.Rows.Clear();
                display.ColumnCount = 5;
                display.Columns[0].Name = "Car Type ID";
                display.Columns[1].Name = "Description";
                display.Columns[2].Name = "Daily Rate";
                display.Columns[3].Name = "Weekly Rate";
                display.Columns[4].Name = "Monthly Rate";
                while (myReader.Read())
                {
                    display.Rows.Add(myReader["CarTypeID"].ToString(), myReader["Description"], myReader["dailyRate"],
                        myReader["weeklyRate"].ToString(), myReader["monthlyRate"].ToString());
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public car_type()
        {
            InitializeComponent();
        }

        private void car_type_Load(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carTypeIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarType_Click(object sender, EventArgs e)
        {
            // Create Command and Execute
            myCommand.CommandText = "insert into CarType values (" + carTypeIDbox.Text + ",'" + descriptionbox.Text + "'," +
                            dailyRatebox.Text + "," + weeklyRatebox.Text + "," + monthlyRatebox.Text +")";
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Car Type Added!", "Successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();
        }

        private void DeleteCarType_Click(object sender, EventArgs e)
        {
            // Delete tuple of given CarTypeID
            myCommand.CommandText = "delete from CarType where CarTypeID =" + carTypeIDbox.Text;
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Car Type Deleted!", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();
        }

        private void UpdateCarType_Click(object sender, EventArgs e)

        {
            // Modify tuple with given values
            if (descriptionbox.Text != "")
            {
                myCommand.CommandText = "update CarType SET Description = '" + descriptionbox.Text + "'where CarTypeID =" + carTypeIDbox.Text;
                myCommand.ExecuteNonQuery();
            }

            if (dailyRatebox.Text != "")
            {
                myCommand.CommandText = "update CarType SET dailyRate = " + dailyRatebox.Text + "where CarTypeID =" + carTypeIDbox.Text;
                myCommand.ExecuteNonQuery();
            }

            if (weeklyRatebox.Text != "")
            {
                myCommand.CommandText = "update CarType SET weeklyRate = " + weeklyRatebox.Text + "where CarTypeID =" + carTypeIDbox.Text;
                myCommand.ExecuteNonQuery();
            }

            if (monthlyRatebox.Text != "")
            {
                myCommand.CommandText = "update CarType SET monthlyRate = " + monthlyRatebox.Text + "where CarTypeID =" + carTypeIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Car Type Modified!", "Successful");
            refresh();
        }
    }
}
