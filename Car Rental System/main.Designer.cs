namespace Car_Rental_System
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.new_user = new System.Windows.Forms.Button();
            this.exist = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.staff = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.new_user);
            this.groupBox1.Controls.Add(this.exist);
            this.groupBox1.Location = new System.Drawing.Point(10, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // new_user
            // 
            this.new_user.Location = new System.Drawing.Point(6, 100);
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(188, 72);
            this.new_user.TabIndex = 3;
            this.new_user.Text = "New User";
            this.new_user.UseVisualStyleBackColor = true;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // exist
            // 
            this.exist.Location = new System.Drawing.Point(6, 22);
            this.exist.Name = "exist";
            this.exist.Size = new System.Drawing.Size(188, 72);
            this.exist.TabIndex = 2;
            this.exist.Text = "Existing User";
            this.exist.UseVisualStyleBackColor = true;
            this.exist.Click += new System.EventHandler(this.exist_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.staff);
            this.groupBox2.Location = new System.Drawing.Point(216, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff";
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(6, 22);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(188, 150);
            this.staff.TabIndex = 3;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(404, 333);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 539);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button new_user;
        private Button exist;
        private GroupBox groupBox2;
        private Button staff;
        private PictureBox pictureBox;
    }
}