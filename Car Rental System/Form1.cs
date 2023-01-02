namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form car = new car();
            car.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form car_type = new car_type();
            car_type.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form rental = new rental();
            rental.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form customer = new customer();
            customer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form report = new report();
            report.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form branch = new branch();
            branch.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}