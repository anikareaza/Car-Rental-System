namespace Car_Rental_System
{
    partial class report
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
            this.execute = new System.Windows.Forms.Button();
            this.tableview = new System.Windows.Forms.DataGridView();
            this.userOption = new System.Windows.Forms.ComboBox();
            this.userdate1 = new System.Windows.Forms.DateTimePicker();
            this.userdate2 = new System.Windows.Forms.DateTimePicker();
            this.BranchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableview)).BeginInit();
            this.SuspendLayout();
            // 
            // execute
            // 
            this.execute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.execute.Location = new System.Drawing.Point(754, 421);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(97, 31);
            this.execute.TabIndex = 0;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableview
            // 
            this.tableview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableview.Location = new System.Drawing.Point(12, 12);
            this.tableview.Name = "tableview";
            this.tableview.RowTemplate.Height = 25;
            this.tableview.Size = new System.Drawing.Size(872, 368);
            this.tableview.TabIndex = 5;
            this.tableview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableview_CellContentClick);
            // 
            // userOption
            // 
            this.userOption.FormattingEnabled = true;
            this.userOption.Items.AddRange(new object[] {
            "1.) Get names of all customers who only rented from branches in their city",
            "2.) Find the total amount of revenue a branch made in a given period of time(plea" +
                "se select dates and branch below)",
            "3.) Find the branch with the most rentals within the given period of time (please" +
                " select dates from below)",
            "4.) Find the branches that do not have any rentals within the given period of tim" +
                "e (please select dates from below)",
            "5.) Find names of all customers who rented from the same branch more than once"});
            this.userOption.Location = new System.Drawing.Point(12, 386);
            this.userOption.Name = "userOption";
            this.userOption.Size = new System.Drawing.Size(872, 23);
            this.userOption.TabIndex = 6;
            this.userOption.SelectedIndexChanged += new System.EventHandler(this.userOption_SelectedIndexChanged);
            // 
            // userdate1
            // 
            this.userdate1.Location = new System.Drawing.Point(103, 422);
            this.userdate1.Name = "userdate1";
            this.userdate1.Size = new System.Drawing.Size(145, 23);
            this.userdate1.TabIndex = 8;
            this.userdate1.ValueChanged += new System.EventHandler(this.userdate1_ValueChanged);
            // 
            // userdate2
            // 
            this.userdate2.Location = new System.Drawing.Point(356, 424);
            this.userdate2.Name = "userdate2";
            this.userdate2.Size = new System.Drawing.Size(149, 23);
            this.userdate2.TabIndex = 9;
            // 
            // BranchBox
            // 
            this.BranchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchBox.Location = new System.Drawing.Point(620, 421);
            this.BranchBox.Name = "BranchBox";
            this.BranchBox.Size = new System.Drawing.Size(100, 29);
            this.BranchBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(537, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Branch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start Date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(271, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "End Date: ";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BranchBox);
            this.Controls.Add(this.userdate2);
            this.Controls.Add(this.userdate1);
            this.Controls.Add(this.userOption);
            this.Controls.Add(this.tableview);
            this.Controls.Add(this.execute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "report";
            this.Text = "Reports (Staff)";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button execute;
        private DataGridView tableview;
        private ComboBox userOption;
        private DateTimePicker userdate1;
        private DateTimePicker userdate2;
        private TextBox BranchBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}