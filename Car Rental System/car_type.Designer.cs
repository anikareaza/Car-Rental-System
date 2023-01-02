namespace Car_Rental_System
{
    partial class car_type
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carTypeIDbox = new System.Windows.Forms.TextBox();
            this.dailyRatebox = new System.Windows.Forms.TextBox();
            this.weeklyRatebox = new System.Windows.Forms.TextBox();
            this.monthlyRatebox = new System.Windows.Forms.TextBox();
            this.AddCarType = new System.Windows.Forms.Button();
            this.UpdateCarType = new System.Windows.Forms.Button();
            this.DeleteCarType = new System.Windows.Forms.Button();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.display = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Type ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daily Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weekly Rate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monthly Rate";
            // 
            // carTypeIDbox
            // 
            this.carTypeIDbox.Location = new System.Drawing.Point(131, 12);
            this.carTypeIDbox.Name = "carTypeIDbox";
            this.carTypeIDbox.Size = new System.Drawing.Size(194, 23);
            this.carTypeIDbox.TabIndex = 5;
            this.carTypeIDbox.TextChanged += new System.EventHandler(this.carTypeIDbox_TextChanged);
            // 
            // dailyRatebox
            // 
            this.dailyRatebox.Location = new System.Drawing.Point(131, 89);
            this.dailyRatebox.Name = "dailyRatebox";
            this.dailyRatebox.Size = new System.Drawing.Size(194, 23);
            this.dailyRatebox.TabIndex = 6;
            // 
            // weeklyRatebox
            // 
            this.weeklyRatebox.Location = new System.Drawing.Point(131, 129);
            this.weeklyRatebox.Name = "weeklyRatebox";
            this.weeklyRatebox.Size = new System.Drawing.Size(194, 23);
            this.weeklyRatebox.TabIndex = 7;
            // 
            // monthlyRatebox
            // 
            this.monthlyRatebox.Location = new System.Drawing.Point(131, 167);
            this.monthlyRatebox.Name = "monthlyRatebox";
            this.monthlyRatebox.Size = new System.Drawing.Size(194, 23);
            this.monthlyRatebox.TabIndex = 8;
            // 
            // AddCarType
            // 
            this.AddCarType.Location = new System.Drawing.Point(131, 199);
            this.AddCarType.Name = "AddCarType";
            this.AddCarType.Size = new System.Drawing.Size(194, 38);
            this.AddCarType.TabIndex = 10;
            this.AddCarType.Text = "Add Car Type";
            this.AddCarType.UseVisualStyleBackColor = true;
            this.AddCarType.Click += new System.EventHandler(this.AddCarType_Click);
            // 
            // UpdateCarType
            // 
            this.UpdateCarType.Location = new System.Drawing.Point(131, 243);
            this.UpdateCarType.Name = "UpdateCarType";
            this.UpdateCarType.Size = new System.Drawing.Size(194, 38);
            this.UpdateCarType.TabIndex = 11;
            this.UpdateCarType.Text = "Update Car Type";
            this.UpdateCarType.UseVisualStyleBackColor = true;
            this.UpdateCarType.Click += new System.EventHandler(this.UpdateCarType_Click);
            // 
            // DeleteCarType
            // 
            this.DeleteCarType.Location = new System.Drawing.Point(131, 287);
            this.DeleteCarType.Name = "DeleteCarType";
            this.DeleteCarType.Size = new System.Drawing.Size(194, 38);
            this.DeleteCarType.TabIndex = 12;
            this.DeleteCarType.Text = "Delete Car Type";
            this.DeleteCarType.UseVisualStyleBackColor = true;
            this.DeleteCarType.Click += new System.EventHandler(this.DeleteCarType_Click);
            // 
            // descriptionbox
            // 
            this.descriptionbox.Location = new System.Drawing.Point(131, 50);
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(194, 23);
            this.descriptionbox.TabIndex = 13;
            // 
            // display
            // 
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Location = new System.Drawing.Point(343, 12);
            this.display.Name = "display";
            this.display.RowTemplate.Height = 25;
            this.display.Size = new System.Drawing.Size(549, 313);
            this.display.TabIndex = 14;
            // 
            // car_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 341);
            this.Controls.Add(this.display);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.DeleteCarType);
            this.Controls.Add(this.UpdateCarType);
            this.Controls.Add(this.AddCarType);
            this.Controls.Add(this.monthlyRatebox);
            this.Controls.Add(this.weeklyRatebox);
            this.Controls.Add(this.dailyRatebox);
            this.Controls.Add(this.carTypeIDbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "car_type";
            this.Text = "Car Type (Staff)";
            this.Load += new System.EventHandler(this.car_type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox carTypeIDbox;
        private TextBox dailyRatebox;
        private TextBox weeklyRatebox;
        private TextBox monthlyRatebox;
        private Button AddCarType;
        private Button UpdateCarType;
        private Button DeleteCarType;
        private TextBox descriptionbox;
        private DataGridView display;
    }
}