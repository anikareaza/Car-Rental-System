using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class customer : Form

    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        
        public void refresh()
        {
            // Refresh data grid with updated data
            DateTime birth;
            myCommand.CommandText = "select * from customer";
            try
            {
                myReader = myCommand.ExecuteReader();
                display.Rows.Clear();
                display.ColumnCount = 14;
                display.Columns[0].Name = "Customer ID";
                display.Columns[1].Name = "First Name";
                display.Columns[2].Name = "Middle Name";
                display.Columns[3].Name = "Last Name";
                display.Columns[4].Name = "Street Address 1";
                display.Columns[5].Name = "Street Address 2";
                display.Columns[6].Name = "City";
                display.Columns[7].Name = "Province";
                display.Columns[8].Name = "Postal Code";
                display.Columns[9].Name = "Date of Birth";
                display.Columns[10].Name = "Phone Number";
                display.Columns[11].Name = "Insurance Number";
                display.Columns[12].Name = "Driving License";
                display.Columns[13].Name = "Membership Status";
                while (myReader.Read())
                {
                    birth = DateTime.Parse(myReader["DateofBirth"].ToString());
                    display.Rows.Add(myReader["Customer_ID"].ToString(), myReader["FirstName"], myReader["MiddleName"],
                        myReader["LastName"].ToString(), myReader["Street_address1"].ToString(), myReader["Street_address2"],
                        myReader["City"].ToString(), myReader["province"].ToString(), myReader["postalCode"].ToString(),
                        birth.ToString("yyyy-MM-dd"), myReader["Phonenumber"].ToString(), myReader["InsuranceNo"].ToString(),
                        myReader["Driving_License"].ToString(), myReader["Membership_Status"].ToString());
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        
        public customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Command and Execute
            myCommand.CommandText = "insert into Customer values (" + customer_id.Text + ",'" + first_name.Text + "','" +
                middle_name.Text + "','" + last_name.Text + "','" + street_add_1.Text + "','" + street_add_2.Text + "','" +
                city.Text + "','" + province.Text + "','" + postal_code.Text + "','" + date_of_birth.Value.ToShortDateString() + "','" +
                phone_no.Text + "','" + insurance.Text + "','" + driving_license.Text + "'," + membership.Text + ")";
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Customer Added!", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();       
        }

        private void dailyRatebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            // Modify tuple with given values
            if (first_name.Text != "")
            {
                myCommand.CommandText = "update Customer SET FirstName = '" + first_name.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (middle_name.Text != "")
            {
                myCommand.CommandText = "update Customer SET MiddleName = '" + middle_name.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (last_name.Text != "")
            {
                myCommand.CommandText = "update Customer SET LastName = '" + last_name.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (street_add_1.Text != "")
            {
                myCommand.CommandText = "update Customer SET Street_address1 = '" + street_add_1.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (street_add_2.Text != "")
            {
                myCommand.CommandText = "update Customer SET Street_address2 = '" + street_add_2.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (city.Text != "")
            {
                myCommand.CommandText = "update Customer SET City = '" + city.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (province.Text != "")
            {
                myCommand.CommandText = "update Customer SET Province = '" + province.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (postal_code.Text != "")
            {
                myCommand.CommandText = "update Customer SET PostalCode = '" + postal_code.Text + "'where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }

            if (phone_no.Text != "")
            {
                myCommand.CommandText = "update Customer SET Phonenumber = " + phone_no.Text + " where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (insurance.Text != "")
            {
                myCommand.CommandText = "update Customer SET Insurance = " + insurance.Text + " where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (driving_license.Text != "")
            {
                myCommand.CommandText = "update Customer SET Driving_License = " + driving_license.Text +  " where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            if (membership.Text != "")
            {
                myCommand.CommandText = "update Customer SET Membership_Status = " + membership.Text + "where Customer_ID =" + customer_id.Text;
                myCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Customer Modified!", "Successful");
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete tuple with given Customer_ID
            myCommand.CommandText = "delete from Customer where Customer_ID =" + customer_id.Text;
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted!", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();
        }

        private void customer_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
