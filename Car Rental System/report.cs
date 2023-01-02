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
    public partial class report : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Option 1
            if (userOption.Text == "1.) Get names of all customers who only rented from branches in their city")
            {
                myCommand.CommandText = "SELECT distinct C.Customer_ID, C.FirstName, C.MiddleName, C.LastName " +
                    "FROM Customer C, Branch B, Rentals R " +
                    "WHERE C.Customer_ID = R.Customer_ID and R.PickupBID = B.BID and C.City = B.City and C.Customer_ID not in " +
                    "(SELECT distinct C.Customer_ID FROM Customer C, Branch B, Rentals R " +
                    "WHERE C.Customer_ID = R.Customer_ID and R.PickupBID = B.BID and C.City != B.City)";
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();
                    tableview.Rows.Clear();
                    tableview.ColumnCount = 4;
                    tableview.Columns[0].Name = "Customer ID";
                    tableview.Columns[1].Name = "First Name";
                    tableview.Columns[2].Name = "Middle Name";
                    tableview.Columns[3].Name = "Last Name";
                    tableview.Columns[0].Name = "Customer ID";
                    while (myReader.Read())
                    {          
                        tableview.Rows.Add(myReader["Customer_ID"].ToString(),myReader["FirstName"].ToString(), myReader["MiddleName"].ToString(),
                            myReader["LastName"].ToString(), myReader["Customer_ID"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }

            // Option 2
            if (userOption.Text == "2.) Find the total amount of revenue a branch made in a given period of time(please select dates and branch below)")
            {
                myCommand.CommandText = "SELECT DISTINCT R.PickupBID as [Branch ID], B.Description as [Description], " +
                    "B.City as [City], B.province as [Province], " +
                    "B.Phonenumber as [Phone Number], SUM(R.total_rentValue) as Total_RentValue " +
                    "FROM Rentals R, Branch B WHERE R.PickupBID = " + BranchBox.Text + " " +
                    "AND R.PickupBID=B.BID AND (R.PickupdateDate between '" + userdate1.Value.ToString("MM-dd-yyyy") + 
                    "' and '" + userdate2.Value.ToString("MM-dd-yyyy") + "' OR R.returnDate between '" + userdate1.Value.ToString("MM-dd-yyyy") + 
                    "' and '" + userdate2.Value.ToString("MM-dd-yyyy") + "') GROUP BY R.PickupBID, B.Description, B.City, B.province, B.Phonenumber;";
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();
                    tableview.Rows.Clear();
                    tableview.ColumnCount = 6;
                    tableview.Columns[0].Name = "Branch ID";
                    tableview.Columns[1].Name = "Description";
                    tableview.Columns[2].Name = "City";
                    tableview.Columns[3].Name = "Province";
                    tableview.Columns[4].Name = "Phone Number";
                    tableview.Columns[5].Name = "Total Rent value";
                    while (myReader.Read())
                    {
                        tableview.Rows.Add(myReader["Branch ID"].ToString(),
                            myReader["Description"].ToString(), myReader["City"].ToString(),
                            myReader["Province"].ToString(), myReader["Phone Number"].ToString(),
                            myReader["total_rentValue"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }

            // Option 3
            if (userOption.Text == "3.) Find the branch with the most rentals within the given period of time (please select dates from below)")
            {
                myCommand.CommandText = "SELECT TOP 1 PickupBID as [Branch ID], B.[Description], " +
                    "B.Street_address1 as [Street Address 1], B.Street_address2 as [Street Address 2], " +
                    "B.City, B.province as [Province], B.postalCode as [Postal Code], B.Phonenumber as [Phone Number] " +
                    "FROM Rentals R, Branch B WHERE R.PickupBID = B.BID and R.PickupdateDate between " +
                    "'" + userdate1.Value.ToString("MM-dd-yyyy") + "' and '" + userdate2.Value.ToString("MM-dd-yyyy") + "'";
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();
                    tableview.Rows.Clear();
                    tableview.ColumnCount = 8;
                    tableview.Columns[0].Name = "Most Rented Branch ID";
                    tableview.Columns[1].Name = "Description";
                    tableview.Columns[2].Name = "Street Address 1";
                    tableview.Columns[3].Name = "Street Address 2";
                    tableview.Columns[4].Name = "City";
                    tableview.Columns[5].Name = "Province";
                    tableview.Columns[6].Name = "Postal Code";
                    tableview.Columns[7].Name = "Phone Number";
                    while (myReader.Read())
                    {
                        tableview.Rows.Add(myReader["Branch ID"].ToString(), myReader["Description"].ToString(), 
                            myReader["Street Address 1"].ToString(),
                            myReader["Street Address 2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(),
                            myReader["Postal Code"].ToString(), myReader["Phone Number"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            // Option 4
            if (userOption.Text == "4.) Find the branches that do not have any rentals within the given period of time (please select dates from below)")
            {
                myCommand.CommandText = "SELECT DISTINCT R.PickupBID as [Branch ID], B.[Description], " +
                    "B.Street_address1 as [Street Address 1], B.Street_address2 as [Street Address 2], " +
                    "B.City, B.province as [Province], B.postalCode as [Postal Code], B.Phonenumber as [Phone Number] " +
                    "FROM Rentals R, Branch B WHERE B.BID = R.PickupBID AND B.BID NOT IN " +
                    "(SELECT B.BID FROM Branch B, Rentals R " +
                    "WHERE B.BID = R.PickupBID AND (R.pickupdateDate between " +
                    "'" + userdate1.Value.ToString("MM-dd-yyyy") + "' and '" + userdate2.Value.ToString("MM-dd-yyyy") + "' " +
                    "OR R.returnDate between '" + userdate1.Value.ToString("MM-dd-yyyy") + "' and '" + userdate2.Value.ToString("MM-dd-yyyy") + "'))";
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();
                    tableview.Rows.Clear();
                    tableview.ColumnCount = 8;
                    tableview.Columns[0].Name = "Branch ID";
                    tableview.Columns[1].Name = "Description";
                    tableview.Columns[2].Name = "Street Address 1";
                    tableview.Columns[3].Name = "Street Address 2";
                    tableview.Columns[4].Name = "City";
                    tableview.Columns[5].Name = "Province";
                    tableview.Columns[6].Name = "Postal Code";
                    tableview.Columns[7].Name = "Phone Number";
                    while (myReader.Read())
                    {   
                        tableview.Rows.Add(myReader["Branch ID"].ToString(), myReader["Description"].ToString(),
                            myReader["Street Address 1"].ToString(),
                            myReader["Street Address 2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(),
                            myReader["Postal Code"].ToString(), myReader["Phone Number"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e4)
                {
                    MessageBox.Show(e4.ToString(), "Error");
                }
            }

            // Option 5
            if (userOption.Text == "5.) Find names of all customers who rented from the same branch more than once")
            {
                myCommand.CommandText = "select C.FirstName, C.MiddleName, C.LastName from Customer C where C.Customer_ID IN (select R.Customer_ID From Rentals R GROUP by R.Customer_ID having count(PickupBID) > 1 EXCEPT SELECT R.Customer_ID from Rentals R group by R.Customer_ID having count(distinct PickupBID) > 1)";
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();
                    tableview.Rows.Clear();
                    tableview.ColumnCount = 3;
                    tableview.Columns[0].Name = "First Name";
                    tableview.Columns[1].Name = "Middle Name";
                    tableview.Columns[2].Name = "Last Name";
                    while (myReader.Read())
                    {
                        tableview.Rows.Add(myReader["FirstName"].ToString(), myReader["MiddleName"].ToString(),
                            myReader["LastName"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e5)
                {
                    MessageBox.Show(e5.ToString(), "Error");
                }
            }
        }


        private void report_Load(object sender, EventArgs e)
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

        private void userOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userdate1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
