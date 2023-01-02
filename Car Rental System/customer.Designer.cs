namespace Car_Rental_System
{
    partial class customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.middle_name = new System.Windows.Forms.TextBox();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.province = new System.Windows.Forms.TextBox();
            this.street_add_2 = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street_add_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.insurance = new System.Windows.Forms.TextBox();
            this.phone_no = new System.Windows.Forms.TextBox();
            this.postal_code = new System.Windows.Forms.TextBox();
            this.date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.membership = new System.Windows.Forms.TextBox();
            this.driving_license = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = "Delete Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Update Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(163, 105);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(194, 23);
            this.last_name.TabIndex = 21;
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(163, 43);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(194, 23);
            this.first_name.TabIndex = 20;
            // 
            // middle_name
            // 
            this.middle_name.Location = new System.Drawing.Point(163, 76);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(194, 23);
            this.middle_name.TabIndex = 19;
            this.middle_name.TextChanged += new System.EventHandler(this.dailyRatebox_TextChanged);
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(163, 11);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(194, 23);
            this.customer_id.TabIndex = 18;
            this.customer_id.TextChanged += new System.EventHandler(this.customer_id_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Street Address 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(163, 230);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(194, 23);
            this.province.TabIndex = 29;
            // 
            // street_add_2
            // 
            this.street_add_2.Location = new System.Drawing.Point(163, 166);
            this.street_add_2.Name = "street_add_2";
            this.street_add_2.Size = new System.Drawing.Size(194, 23);
            this.street_add_2.TabIndex = 28;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(163, 199);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(194, 23);
            this.city.TabIndex = 27;
            // 
            // street_add_1
            // 
            this.street_add_1.Location = new System.Drawing.Point(163, 134);
            this.street_add_1.Name = "street_add_1";
            this.street_add_1.Size = new System.Drawing.Size(194, 23);
            this.street_add_1.TabIndex = 26;
            this.street_add_1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Date of Birth";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Postal Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Province";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Street Address 2";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // insurance
            // 
            this.insurance.Location = new System.Drawing.Point(163, 356);
            this.insurance.Name = "insurance";
            this.insurance.Size = new System.Drawing.Size(194, 23);
            this.insurance.TabIndex = 38;
            // 
            // phone_no
            // 
            this.phone_no.Location = new System.Drawing.Point(163, 325);
            this.phone_no.Name = "phone_no";
            this.phone_no.Size = new System.Drawing.Size(194, 23);
            this.phone_no.TabIndex = 36;
            this.phone_no.TextChanged += new System.EventHandler(this.phone_no_TextChanged);
            // 
            // postal_code
            // 
            this.postal_code.Location = new System.Drawing.Point(163, 260);
            this.postal_code.Name = "postal_code";
            this.postal_code.Size = new System.Drawing.Size(194, 23);
            this.postal_code.TabIndex = 35;
            // 
            // date_of_birth
            // 
            this.date_of_birth.Location = new System.Drawing.Point(163, 296);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(194, 23);
            this.date_of_birth.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 41;
            this.label11.Text = "Insurance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Phone No.";
            // 
            // membership
            // 
            this.membership.Location = new System.Drawing.Point(163, 416);
            this.membership.Name = "membership";
            this.membership.Size = new System.Drawing.Size(194, 23);
            this.membership.TabIndex = 43;
            // 
            // driving_license
            // 
            this.driving_license.Location = new System.Drawing.Point(163, 385);
            this.driving_license.Name = "driving_license";
            this.driving_license.Size = new System.Drawing.Size(194, 23);
            this.driving_license.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(11, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Membership Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(11, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 21);
            this.label14.TabIndex = 44;
            this.label14.Text = "Driving License";
            // 
            // display
            // 
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Location = new System.Drawing.Point(375, 9);
            this.display.Name = "display";
            this.display.RowTemplate.Height = 25;
            this.display.Size = new System.Drawing.Size(885, 559);
            this.display.TabIndex = 46;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 583);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.membership);
            this.Controls.Add(this.driving_license);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.insurance);
            this.Controls.Add(this.phone_no);
            this.Controls.Add(this.postal_code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.province);
            this.Controls.Add(this.street_add_2);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street_add_1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.middle_name);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customer";
            this.Text = "Customer (Staff)";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox last_name;
        private TextBox first_name;
        private TextBox middle_name;
        private TextBox customer_id;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox province;
        private TextBox street_add_2;
        private TextBox city;
        private TextBox street_add_1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox insurance;
        private TextBox phone_no;
        private TextBox postal_code;
        private DateTimePicker date_of_birth;
        private Label label11;
        private Label label12;
        private TextBox membership;
        private TextBox driving_license;
        private Label label13;
        private Label label14;
        private DataGridView display;
    }
}