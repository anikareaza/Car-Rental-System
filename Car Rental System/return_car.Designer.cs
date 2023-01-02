namespace Car_Rental_System
{
    partial class return_car
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
            this.Postal_Code = new System.Windows.Forms.Label();
            this.TIDbox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.actual_return = new System.Windows.Forms.DateTimePicker();
            this.return_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dropTimebox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Postal_Code
            // 
            this.Postal_Code.AutoSize = true;
            this.Postal_Code.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Postal_Code.Location = new System.Drawing.Point(12, 83);
            this.Postal_Code.Name = "Postal_Code";
            this.Postal_Code.Size = new System.Drawing.Size(93, 21);
            this.Postal_Code.TabIndex = 9;
            this.Postal_Code.Text = "Return Date";
            // 
            // TIDbox
            // 
            this.TIDbox.AutoSize = true;
            this.TIDbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TIDbox.Location = new System.Drawing.Point(13, 12);
            this.TIDbox.Name = "TIDbox";
            this.TIDbox.Size = new System.Drawing.Size(108, 21);
            this.TIDbox.TabIndex = 8;
            this.TIDbox.Text = "Transaction ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(161, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 29);
            this.textBox1.TabIndex = 10;
            // 
            // actual_return
            // 
            this.actual_return.Location = new System.Drawing.Point(161, 83);
            this.actual_return.Name = "actual_return";
            this.actual_return.Size = new System.Drawing.Size(200, 23);
            this.actual_return.TabIndex = 11;
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.return_button.Location = new System.Drawing.Point(161, 146);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(200, 31);
            this.return_button.TabIndex = 12;
            this.return_button.Text = "Return Car";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(161, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 29);
            this.textBox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Return Branch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Return Time";
            // 
            // dropTimebox
            // 
            this.dropTimebox.FormattingEnabled = true;
            this.dropTimebox.Items.AddRange(new object[] {
            "7:00:00",
            "8:00:00",
            "9:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00"});
            this.dropTimebox.Location = new System.Drawing.Point(161, 112);
            this.dropTimebox.Name = "dropTimebox";
            this.dropTimebox.Size = new System.Drawing.Size(200, 23);
            this.dropTimebox.TabIndex = 22;
            // 
            // return_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 188);
            this.Controls.Add(this.dropTimebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.actual_return);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Postal_Code);
            this.Controls.Add(this.TIDbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "return_car";
            this.Text = "Return Car (Staff)";
            this.Load += new System.EventHandler(this.return_car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Postal_Code;
        private Label TIDbox;
        private TextBox textBox1;
        private DateTimePicker actual_return;
        private Button return_button;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ComboBox dropTimebox;
    }
}