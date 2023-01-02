using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void staff_Click(object sender, EventArgs e)
        {
            Form staff = new Form1();
            staff.Show();
        }

        private void exist_Click(object sender, EventArgs e)
        {
            Form exist_user = new exist_user();
            exist_user.Show();
        }

        private void new_user_Click(object sender, EventArgs e)
        {
            Form new_user = new new_user();
            new_user.Show();
        }
    }
}
