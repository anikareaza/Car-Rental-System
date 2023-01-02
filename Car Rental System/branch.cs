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
    public partial class branch : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public void refresh()
        {
            // Refresh the data grid with the most updated data
            myCommand.CommandText = "select * from branch";
            try
            {
                myReader = myCommand.ExecuteReader();
                display.Rows.Clear();
                display.ColumnCount = 8;
                display.Columns[0].Name = "Branch ID";
                display.Columns[1].Name = "Description";
                display.Columns[2].Name = "Street Address 1";
                display.Columns[3].Name = "Street Address 2";
                display.Columns[4].Name = "City";
                display.Columns[5].Name = "Province";
                display.Columns[6].Name = "Postal Code";
                display.Columns[7].Name = "Phone Number";
                while (myReader.Read())
                {
                    

                    display.Rows.Add(myReader["BID"].ToString(), myReader["Description"], myReader["Street_address1"].ToString(), myReader["Street_address2"],
                        myReader["City"].ToString(), myReader["province"].ToString(), myReader["postalCode"].ToString(),
                        myReader["Phonenumber"].ToString());
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public branch()
        {
            InitializeComponent();
        }

        private void Add_Branch_Click(object sender, EventArgs e)
        {
            // Create command and execute
            myCommand.CommandText = "insert into Branch values (" + BranchIDbox.Text + ",'" + Descriptionbox.Text + "','" +
                Streetaddress1box.Text + "','" + Streetaddress2box.Text + "','" + Citybox.Text + "','" + provincebox.Text + "','" +
                postalCodebox.Text + "','" + phonenumberbox.Text + "')";
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Branch Added!", "Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void branch_Load(object sender, EventArgs e)
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

        private void BranchIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modify_Branch_Click(object sender, EventArgs e)
        {
            // Modify tuple with given values
            if (Descriptionbox.Text != "")
            {
                myCommand.CommandText = "update Branch SET Description = '" + Descriptionbox.Text + "' where BID =" + BranchIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (Streetaddress1box.Text != "")
            {
                myCommand.CommandText = "update Branch SET Street_address1 = '" + Streetaddress1box.Text + "' where BID =" + BranchIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (Streetaddress2box.Text != "")
            {
                myCommand.CommandText = "update Branch SET Street_address2 = '" + Streetaddress2box.Text + "'where BID =" + BranchIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (Citybox.Text != "")
            {
                myCommand.CommandText = "update Branch SET City = '" + Citybox.Text + "'where BID =" + BranchIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (provincebox.Text != "")
            {
                myCommand.CommandText = "update Branch SET province = '" + provincebox.Text + "'where BID =" + BranchIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (postalCodebox.Text != "")
            {
                myCommand.CommandText = "update Branch SET postalCode = '" + postalCodebox.Text + "'where BID =" + BranchIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            if (phonenumberbox.Text != "")
            {
                myCommand.CommandText = "update Branch SET Phonenumber = " + phonenumberbox.Text + "where BID =" + BranchIDbox.Text;
                myCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Branch Modified!", "Successful");
            refresh();
        }

        private void Delete_Branch_Click(object sender, EventArgs e)
        {
            // Delete tuple given the Branch ID
            myCommand.CommandText = "delete from Branch where BID =" + BranchIDbox.Text;
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Branch Deleted!", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
            refresh();
        }
    }
}
