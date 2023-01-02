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
    public partial class all_transactions : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public void refresh()
        {
            // Refreshes the data grid with the most updated data
            DateTime pickup, dropoff;
            myCommand.CommandText = "select * from rentals";
            try
            {
                myReader = myCommand.ExecuteReader();
                display.Rows.Clear();
                display.ColumnCount = 10;
                display.Columns[0].Name = "Transaction ID";
                display.Columns[1].Name = "Pick Up Date";
                display.Columns[2].Name = "Return Date";
                display.Columns[3].Name = "Pick Up Time";
                display.Columns[4].Name = "Return Time";
                display.Columns[5].Name = "Customer ID";
                display.Columns[6].Name = "VIN";
                display.Columns[7].Name = "Pick Up Branch ID";
                display.Columns[8].Name = "Return Branch ID";
                display.Columns[9].Name = "Total Cost";
                while (myReader.Read())
                {
                    pickup = DateTime.Parse(myReader["pickUpdateDate"].ToString());
                    dropoff = DateTime.Parse(myReader["returnDate"].ToString());

                    display.Rows.Add(myReader["TID"].ToString(), pickup.ToString("yyyy-MM-dd"), dropoff.ToString("yyyy-MM-dd"), myReader["PickupTime"].ToString(),
                        myReader["returnTime"].ToString(), myReader["Customer_ID"].ToString(), myReader["VIN"].ToString(),
                        myReader["PickUpBID"].ToString(), myReader["ReturnBID"].ToString(), myReader["total_rentValue"].ToString());
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public all_transactions()
        {
            InitializeComponent();
        }

        private void all_transactions_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
