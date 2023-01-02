namespace Car_Rental_System
{
    partial class exist_user
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
            this.filterbranch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DOBID = new System.Windows.Forms.TextBox();
            this.PUBID = new System.Windows.Forms.TextBox();
            this.display = new System.Windows.Forms.DataGridView();
            this.addTransbutton = new System.Windows.Forms.Button();
            this.dropTimebox = new System.Windows.Forms.ComboBox();
            this.pickTimebox = new System.Windows.Forms.ComboBox();
            this.dropDatebox = new System.Windows.Forms.DateTimePicker();
            this.pickDatebox = new System.Windows.Forms.DateTimePicker();
            this.Vbox = new System.Windows.Forms.TextBox();
            this.custIDbox = new System.Windows.Forms.TextBox();
            this.droppffBranchbox = new System.Windows.Forms.Label();
            this.pickupBranchbox = new System.Windows.Forms.Label();
            this.vinbox = new System.Windows.Forms.Label();
            this.CIDbox = new System.Windows.Forms.Label();
            this.dropoffTimebox = new System.Windows.Forms.Label();
            this.pickupTimebox = new System.Windows.Forms.Label();
            this.droppffDatebox = new System.Windows.Forms.Label();
            this.pickupDatebox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // filterbranch
            // 
            this.filterbranch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.filterbranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterbranch.Location = new System.Drawing.Point(821, 43);
            this.filterbranch.Name = "filterbranch";
            this.filterbranch.Size = new System.Drawing.Size(100, 29);
            this.filterbranch.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(735, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "Branch ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(396, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(396, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Start Date";
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(490, 77);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(200, 23);
            this.enddate.TabIndex = 59;
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(490, 46);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(200, 23);
            this.startdate.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(396, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "See available cars";
            // 
            // DOBID
            // 
            this.DOBID.Location = new System.Drawing.Point(186, 287);
            this.DOBID.Name = "DOBID";
            this.DOBID.Size = new System.Drawing.Size(194, 23);
            this.DOBID.TabIndex = 56;
            // 
            // PUBID
            // 
            this.PUBID.Location = new System.Drawing.Point(187, 252);
            this.PUBID.Name = "PUBID";
            this.PUBID.Size = new System.Drawing.Size(194, 23);
            this.PUBID.TabIndex = 55;
            // 
            // display
            // 
            this.display.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Location = new System.Drawing.Point(398, 106);
            this.display.Name = "display";
            this.display.RowTemplate.Height = 25;
            this.display.Size = new System.Drawing.Size(887, 433);
            this.display.TabIndex = 54;
            // 
            // addTransbutton
            // 
            this.addTransbutton.Location = new System.Drawing.Point(186, 318);
            this.addTransbutton.Name = "addTransbutton";
            this.addTransbutton.Size = new System.Drawing.Size(194, 46);
            this.addTransbutton.TabIndex = 51;
            this.addTransbutton.Text = "Make Reservation";
            this.addTransbutton.UseVisualStyleBackColor = true;
            this.addTransbutton.Click += new System.EventHandler(this.addTransbutton_Click);
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
            this.dropTimebox.Location = new System.Drawing.Point(188, 134);
            this.dropTimebox.Name = "dropTimebox";
            this.dropTimebox.Size = new System.Drawing.Size(192, 23);
            this.dropTimebox.TabIndex = 50;
            // 
            // pickTimebox
            // 
            this.pickTimebox.FormattingEnabled = true;
            this.pickTimebox.Items.AddRange(new object[] {
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
            this.pickTimebox.Location = new System.Drawing.Point(189, 97);
            this.pickTimebox.Name = "pickTimebox";
            this.pickTimebox.Size = new System.Drawing.Size(192, 23);
            this.pickTimebox.TabIndex = 49;
            // 
            // dropDatebox
            // 
            this.dropDatebox.Location = new System.Drawing.Point(188, 57);
            this.dropDatebox.Name = "dropDatebox";
            this.dropDatebox.Size = new System.Drawing.Size(192, 23);
            this.dropDatebox.TabIndex = 48;
            // 
            // pickDatebox
            // 
            this.pickDatebox.Location = new System.Drawing.Point(188, 15);
            this.pickDatebox.Name = "pickDatebox";
            this.pickDatebox.Size = new System.Drawing.Size(192, 23);
            this.pickDatebox.TabIndex = 47;
            // 
            // Vbox
            // 
            this.Vbox.Location = new System.Drawing.Point(188, 213);
            this.Vbox.Name = "Vbox";
            this.Vbox.Size = new System.Drawing.Size(194, 23);
            this.Vbox.TabIndex = 46;
            // 
            // custIDbox
            // 
            this.custIDbox.Location = new System.Drawing.Point(188, 175);
            this.custIDbox.Name = "custIDbox";
            this.custIDbox.Size = new System.Drawing.Size(194, 23);
            this.custIDbox.TabIndex = 45;
            // 
            // droppffBranchbox
            // 
            this.droppffBranchbox.AutoSize = true;
            this.droppffBranchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.droppffBranchbox.Location = new System.Drawing.Point(14, 285);
            this.droppffBranchbox.Name = "droppffBranchbox";
            this.droppffBranchbox.Size = new System.Drawing.Size(139, 21);
            this.droppffBranchbox.TabIndex = 43;
            this.droppffBranchbox.Text = "Drop off Branch ID";
            // 
            // pickupBranchbox
            // 
            this.pickupBranchbox.AutoSize = true;
            this.pickupBranchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickupBranchbox.Location = new System.Drawing.Point(14, 250);
            this.pickupBranchbox.Name = "pickupBranchbox";
            this.pickupBranchbox.Size = new System.Drawing.Size(131, 21);
            this.pickupBranchbox.TabIndex = 42;
            this.pickupBranchbox.Text = "Pick up Branch ID";
            // 
            // vinbox
            // 
            this.vinbox.AutoSize = true;
            this.vinbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vinbox.Location = new System.Drawing.Point(14, 283);
            this.vinbox.Name = "vinbox";
            this.vinbox.Size = new System.Drawing.Size(36, 21);
            this.vinbox.TabIndex = 41;
            this.vinbox.Text = "VIN";
            // 
            // CIDbox
            // 
            this.CIDbox.AutoSize = true;
            this.CIDbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CIDbox.Location = new System.Drawing.Point(16, 173);
            this.CIDbox.Name = "CIDbox";
            this.CIDbox.Size = new System.Drawing.Size(97, 21);
            this.CIDbox.TabIndex = 40;
            this.CIDbox.Text = "Customer ID";
            // 
            // dropoffTimebox
            // 
            this.dropoffTimebox.AutoSize = true;
            this.dropoffTimebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropoffTimebox.Location = new System.Drawing.Point(14, 132);
            this.dropoffTimebox.Name = "dropoffTimebox";
            this.dropoffTimebox.Size = new System.Drawing.Size(106, 21);
            this.dropoffTimebox.TabIndex = 39;
            this.dropoffTimebox.Text = "Drop off Time";
            // 
            // pickupTimebox
            // 
            this.pickupTimebox.AutoSize = true;
            this.pickupTimebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickupTimebox.Location = new System.Drawing.Point(14, 95);
            this.pickupTimebox.Name = "pickupTimebox";
            this.pickupTimebox.Size = new System.Drawing.Size(98, 21);
            this.pickupTimebox.TabIndex = 38;
            this.pickupTimebox.Text = "Pick up Time";
            // 
            // droppffDatebox
            // 
            this.droppffDatebox.AutoSize = true;
            this.droppffDatebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.droppffDatebox.Location = new System.Drawing.Point(14, 57);
            this.droppffDatebox.Name = "droppffDatebox";
            this.droppffDatebox.Size = new System.Drawing.Size(104, 21);
            this.droppffDatebox.TabIndex = 37;
            this.droppffDatebox.Text = "Drop off Date";
            // 
            // pickupDatebox
            // 
            this.pickupDatebox.AutoSize = true;
            this.pickupDatebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickupDatebox.Location = new System.Drawing.Point(14, 15);
            this.pickupDatebox.Name = "pickupDatebox";
            this.pickupDatebox.Size = new System.Drawing.Size(96, 21);
            this.pickupDatebox.TabIndex = 36;
            this.pickupDatebox.Text = "Pick up Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "VIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(941, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 65;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exist_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterbranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOBID);
            this.Controls.Add(this.PUBID);
            this.Controls.Add(this.display);
            this.Controls.Add(this.addTransbutton);
            this.Controls.Add(this.dropTimebox);
            this.Controls.Add(this.pickTimebox);
            this.Controls.Add(this.dropDatebox);
            this.Controls.Add(this.pickDatebox);
            this.Controls.Add(this.Vbox);
            this.Controls.Add(this.custIDbox);
            this.Controls.Add(this.droppffBranchbox);
            this.Controls.Add(this.pickupBranchbox);
            this.Controls.Add(this.vinbox);
            this.Controls.Add(this.CIDbox);
            this.Controls.Add(this.dropoffTimebox);
            this.Controls.Add(this.pickupTimebox);
            this.Controls.Add(this.droppffDatebox);
            this.Controls.Add(this.pickupDatebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "exist_user";
            this.Text = "Existing User (User)";
            this.Load += new System.EventHandler(this.exist_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox filterbranch;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker enddate;
        private DateTimePicker startdate;
        private Label label1;
        private TextBox DOBID;
        private TextBox PUBID;
        private DataGridView display;
        private Button addTransbutton;
        private ComboBox dropTimebox;
        private ComboBox pickTimebox;
        private DateTimePicker dropDatebox;
        private DateTimePicker pickDatebox;
        private TextBox Vbox;
        private TextBox custIDbox;
        private Label droppffBranchbox;
        private Label pickupBranchbox;
        private Label vinbox;
        private Label CIDbox;
        private Label dropoffTimebox;
        private Label pickupTimebox;
        private Label droppffDatebox;
        private Label pickupDatebox;
        private Label label5;
        private Button button1;
    }
}