namespace Car_Rental_System
{
    partial class rental
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
            this.transIDbox = new System.Windows.Forms.Label();
            this.pickupDatebox = new System.Windows.Forms.Label();
            this.droppffDatebox = new System.Windows.Forms.Label();
            this.pickupTimebox = new System.Windows.Forms.Label();
            this.dropoffTimebox = new System.Windows.Forms.Label();
            this.CIDbox = new System.Windows.Forms.Label();
            this.vinbox = new System.Windows.Forms.Label();
            this.pickupBranchbox = new System.Windows.Forms.Label();
            this.droppffBranchbox = new System.Windows.Forms.Label();
            this.TIDbox = new System.Windows.Forms.TextBox();
            this.custIDbox = new System.Windows.Forms.TextBox();
            this.Vbox = new System.Windows.Forms.TextBox();
            this.pickDatebox = new System.Windows.Forms.DateTimePicker();
            this.dropDatebox = new System.Windows.Forms.DateTimePicker();
            this.pickTimebox = new System.Windows.Forms.ComboBox();
            this.dropTimebox = new System.Windows.Forms.ComboBox();
            this.addTransbutton = new System.Windows.Forms.Button();
            this.updateTransbutton = new System.Windows.Forms.Button();
            this.deleteTransbutton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.PUBID = new System.Windows.Forms.TextBox();
            this.DOBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filterbranch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // transIDbox
            // 
            this.transIDbox.AutoSize = true;
            this.transIDbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transIDbox.Location = new System.Drawing.Point(12, 12);
            this.transIDbox.Name = "transIDbox";
            this.transIDbox.Size = new System.Drawing.Size(108, 21);
            this.transIDbox.TabIndex = 0;
            this.transIDbox.Text = "Transaction ID";
            this.transIDbox.Click += new System.EventHandler(this.label1_Click);
            // 
            // pickupDatebox
            // 
            this.pickupDatebox.AutoSize = true;
            this.pickupDatebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickupDatebox.Location = new System.Drawing.Point(12, 52);
            this.pickupDatebox.Name = "pickupDatebox";
            this.pickupDatebox.Size = new System.Drawing.Size(96, 21);
            this.pickupDatebox.TabIndex = 1;
            this.pickupDatebox.Text = "Pick up Date";
            // 
            // droppffDatebox
            // 
            this.droppffDatebox.AutoSize = true;
            this.droppffDatebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.droppffDatebox.Location = new System.Drawing.Point(12, 94);
            this.droppffDatebox.Name = "droppffDatebox";
            this.droppffDatebox.Size = new System.Drawing.Size(104, 21);
            this.droppffDatebox.TabIndex = 2;
            this.droppffDatebox.Text = "Drop off Date";
            // 
            // pickupTimebox
            // 
            this.pickupTimebox.AutoSize = true;
            this.pickupTimebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickupTimebox.Location = new System.Drawing.Point(12, 132);
            this.pickupTimebox.Name = "pickupTimebox";
            this.pickupTimebox.Size = new System.Drawing.Size(98, 21);
            this.pickupTimebox.TabIndex = 3;
            this.pickupTimebox.Text = "Pick up Time";
            this.pickupTimebox.Click += new System.EventHandler(this.label4_Click);
            // 
            // dropoffTimebox
            // 
            this.dropoffTimebox.AutoSize = true;
            this.dropoffTimebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropoffTimebox.Location = new System.Drawing.Point(12, 169);
            this.dropoffTimebox.Name = "dropoffTimebox";
            this.dropoffTimebox.Size = new System.Drawing.Size(106, 21);
            this.dropoffTimebox.TabIndex = 4;
            this.dropoffTimebox.Text = "Drop off Time";
            // 
            // CIDbox
            // 
            this.CIDbox.AutoSize = true;
            this.CIDbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CIDbox.Location = new System.Drawing.Point(14, 210);
            this.CIDbox.Name = "CIDbox";
            this.CIDbox.Size = new System.Drawing.Size(97, 21);
            this.CIDbox.TabIndex = 5;
            this.CIDbox.Text = "Customer ID";
            // 
            // vinbox
            // 
            this.vinbox.AutoSize = true;
            this.vinbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vinbox.Location = new System.Drawing.Point(14, 248);
            this.vinbox.Name = "vinbox";
            this.vinbox.Size = new System.Drawing.Size(36, 21);
            this.vinbox.TabIndex = 6;
            this.vinbox.Text = "VIN";
            // 
            // pickupBranchbox
            // 
            this.pickupBranchbox.AutoSize = true;
            this.pickupBranchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickupBranchbox.Location = new System.Drawing.Point(12, 287);
            this.pickupBranchbox.Name = "pickupBranchbox";
            this.pickupBranchbox.Size = new System.Drawing.Size(131, 21);
            this.pickupBranchbox.TabIndex = 7;
            this.pickupBranchbox.Text = "Pick up Branch ID";
            // 
            // droppffBranchbox
            // 
            this.droppffBranchbox.AutoSize = true;
            this.droppffBranchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.droppffBranchbox.Location = new System.Drawing.Point(12, 322);
            this.droppffBranchbox.Name = "droppffBranchbox";
            this.droppffBranchbox.Size = new System.Drawing.Size(139, 21);
            this.droppffBranchbox.TabIndex = 8;
            this.droppffBranchbox.Text = "Drop off Branch ID";
            // 
            // TIDbox
            // 
            this.TIDbox.Location = new System.Drawing.Point(186, 14);
            this.TIDbox.Name = "TIDbox";
            this.TIDbox.Size = new System.Drawing.Size(194, 23);
            this.TIDbox.TabIndex = 10;
            // 
            // custIDbox
            // 
            this.custIDbox.Location = new System.Drawing.Point(186, 212);
            this.custIDbox.Name = "custIDbox";
            this.custIDbox.Size = new System.Drawing.Size(194, 23);
            this.custIDbox.TabIndex = 11;
            // 
            // Vbox
            // 
            this.Vbox.Location = new System.Drawing.Point(186, 250);
            this.Vbox.Name = "Vbox";
            this.Vbox.Size = new System.Drawing.Size(194, 23);
            this.Vbox.TabIndex = 12;
            // 
            // pickDatebox
            // 
            this.pickDatebox.Location = new System.Drawing.Point(186, 52);
            this.pickDatebox.Name = "pickDatebox";
            this.pickDatebox.Size = new System.Drawing.Size(192, 23);
            this.pickDatebox.TabIndex = 14;
            // 
            // dropDatebox
            // 
            this.dropDatebox.Location = new System.Drawing.Point(186, 94);
            this.dropDatebox.Name = "dropDatebox";
            this.dropDatebox.Size = new System.Drawing.Size(192, 23);
            this.dropDatebox.TabIndex = 15;
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
            this.pickTimebox.Location = new System.Drawing.Point(187, 134);
            this.pickTimebox.Name = "pickTimebox";
            this.pickTimebox.Size = new System.Drawing.Size(192, 23);
            this.pickTimebox.TabIndex = 16;
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
            this.dropTimebox.Location = new System.Drawing.Point(186, 171);
            this.dropTimebox.Name = "dropTimebox";
            this.dropTimebox.Size = new System.Drawing.Size(192, 23);
            this.dropTimebox.TabIndex = 20;
            // 
            // addTransbutton
            // 
            this.addTransbutton.Location = new System.Drawing.Point(184, 353);
            this.addTransbutton.Name = "addTransbutton";
            this.addTransbutton.Size = new System.Drawing.Size(194, 31);
            this.addTransbutton.TabIndex = 21;
            this.addTransbutton.Text = "Add Transaction";
            this.addTransbutton.UseVisualStyleBackColor = true;
            this.addTransbutton.Click += new System.EventHandler(this.addTransbutton_Click);
            // 
            // updateTransbutton
            // 
            this.updateTransbutton.Location = new System.Drawing.Point(183, 393);
            this.updateTransbutton.Name = "updateTransbutton";
            this.updateTransbutton.Size = new System.Drawing.Size(194, 31);
            this.updateTransbutton.TabIndex = 22;
            this.updateTransbutton.Text = "Update Transaction";
            this.updateTransbutton.UseVisualStyleBackColor = true;
            this.updateTransbutton.Click += new System.EventHandler(this.updateTransbutton_Click);
            // 
            // deleteTransbutton
            // 
            this.deleteTransbutton.Location = new System.Drawing.Point(184, 433);
            this.deleteTransbutton.Name = "deleteTransbutton";
            this.deleteTransbutton.Size = new System.Drawing.Size(193, 31);
            this.deleteTransbutton.TabIndex = 23;
            this.deleteTransbutton.Text = "Delete Transaction";
            this.deleteTransbutton.UseVisualStyleBackColor = true;
            this.deleteTransbutton.Click += new System.EventHandler(this.deleteTransbutton_Click);
            // 
            // display
            // 
            this.display.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Location = new System.Drawing.Point(401, 105);
            this.display.Name = "display";
            this.display.RowTemplate.Height = 25;
            this.display.Size = new System.Drawing.Size(887, 433);
            this.display.TabIndex = 24;
            this.display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PUBID
            // 
            this.PUBID.Location = new System.Drawing.Point(185, 289);
            this.PUBID.Name = "PUBID";
            this.PUBID.Size = new System.Drawing.Size(194, 23);
            this.PUBID.TabIndex = 26;
            // 
            // DOBID
            // 
            this.DOBID.Location = new System.Drawing.Point(184, 324);
            this.DOBID.Name = "DOBID";
            this.DOBID.Size = new System.Drawing.Size(194, 23);
            this.DOBID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(399, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "See available cars";
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(493, 45);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(200, 23);
            this.startdate.TabIndex = 29;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(493, 76);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(200, 23);
            this.enddate.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(399, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(399, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(738, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Branch ID:";
            // 
            // filterbranch
            // 
            this.filterbranch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.filterbranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterbranch.Location = new System.Drawing.Point(824, 42);
            this.filterbranch.Name = "filterbranch";
            this.filterbranch.Size = new System.Drawing.Size(100, 29);
            this.filterbranch.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 31);
            this.button2.TabIndex = 35;
            this.button2.Text = "Return Car";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 31);
            this.button3.TabIndex = 36;
            this.button3.Text = "Display All Transactions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filterbranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOBID);
            this.Controls.Add(this.PUBID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.deleteTransbutton);
            this.Controls.Add(this.updateTransbutton);
            this.Controls.Add(this.addTransbutton);
            this.Controls.Add(this.dropTimebox);
            this.Controls.Add(this.pickTimebox);
            this.Controls.Add(this.dropDatebox);
            this.Controls.Add(this.pickDatebox);
            this.Controls.Add(this.Vbox);
            this.Controls.Add(this.custIDbox);
            this.Controls.Add(this.TIDbox);
            this.Controls.Add(this.droppffBranchbox);
            this.Controls.Add(this.pickupBranchbox);
            this.Controls.Add(this.vinbox);
            this.Controls.Add(this.CIDbox);
            this.Controls.Add(this.dropoffTimebox);
            this.Controls.Add(this.pickupTimebox);
            this.Controls.Add(this.droppffDatebox);
            this.Controls.Add(this.pickupDatebox);
            this.Controls.Add(this.transIDbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rental";
            this.Text = "Rental Transaction (Staff)";
            this.Load += new System.EventHandler(this.rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label transIDbox;
        private Label pickupDatebox;
        private Label droppffDatebox;
        private Label pickupTimebox;
        private Label dropoffTimebox;
        private Label CIDbox;
        private Label vinbox;
        private Label pickupBranchbox;
        private Label droppffBranchbox;
        private TextBox TIDbox;
        private TextBox custIDbox;
        private TextBox Vbox;
        private DateTimePicker pickDatebox;
        private DateTimePicker dropDatebox;
        private ComboBox pickTimebox;
        private ComboBox dropTimebox;
        private Button addTransbutton;
        private Button updateTransbutton;
        private Button deleteTransbutton;
        private DataGridView display;
        private Button button1;
        private TextBox PUBID;
        private TextBox DOBID;
        private Label label1;
        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox filterbranch;
        private Button button2;
        private Button button3;
    }
}