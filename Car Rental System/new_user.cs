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
    public partial class new_user : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public new_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get ID for new user
            int id;
            myCommand.CommandText = "select max(Customer_ID) as max from customer";
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            id = Int32.Parse(myReader["MAX"].ToString()) + 1;
            myReader.Close();

            // Create Command and Execute
            myCommand.CommandText = "insert into Customer values (" + id.ToString() + ",'" + first_name.Text + "','" +
                middle_name.Text + "','" + last_name.Text + "','" + street_add_1.Text + "','" + street_add_2.Text + "','" +
                city.Text + "','" + province.Text + "','" + postal_code.Text + "','" + date_of_birth.Value.ToShortDateString() + "','" +
                phone_no.Text + "','" + insurance.Text + "','" + driving_license.Text + "', 0)";
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Your Profile has been added successfully. Your ID is " + id.ToString());
                Form exist_user = new exist_user();
                exist_user.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void new_user_Load(object sender, EventArgs e)
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
