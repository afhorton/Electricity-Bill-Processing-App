namespace ElectricityBills
{
    partial class frmElectricityBills
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtKWHused = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalKWH = new System.Windows.Forms.TextBox();
            this.txtAverageBill = new System.Windows.Forms.TextBox();
            this.txtTotalCustomers = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(48, 372);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(770, 264);
            this.lstCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Electric Bills By Customer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBillAmount);
            this.groupBox1.Controls.Add(this.txtKWHused);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Customer Data";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(236, 191);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(124, 40);
            this.btnInput.TabIndex = 9;
            this.btnInput.Text = "&Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bill Amount:";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(236, 145);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(124, 26);
            this.txtBillAmount.TabIndex = 7;
            // 
            // txtKWHused
            // 
            this.txtKWHused.Location = new System.Drawing.Point(56, 145);
            this.txtKWHused.Name = "txtKWHused";
            this.txtKWHused.Size = new System.Drawing.Size(115, 26);
            this.txtKWHused.TabIndex = 6;
            this.txtKWHused.Tag = "Nr of kWh used";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nr of kWh used:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(236, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(124, 26);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Tag = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(56, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(115, 26);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Tag = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "First:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalKWH);
            this.groupBox2.Controls.Add(this.txtAverageBill);
            this.groupBox2.Controls.Add(this.txtTotalCustomers);
            this.groupBox2.Location = new System.Drawing.Point(461, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Accounts Data:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Average Bill Amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total kWh used:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Customers:";
            // 
            // txtTotalKWH
            // 
            this.txtTotalKWH.Location = new System.Drawing.Point(204, 103);
            this.txtTotalKWH.Name = "txtTotalKWH";
            this.txtTotalKWH.ReadOnly = true;
            this.txtTotalKWH.Size = new System.Drawing.Size(124, 26);
            this.txtTotalKWH.TabIndex = 7;
            // 
            // txtAverageBill
            // 
            this.txtAverageBill.Location = new System.Drawing.Point(204, 145);
            this.txtAverageBill.Name = "txtAverageBill";
            this.txtAverageBill.ReadOnly = true;
            this.txtAverageBill.Size = new System.Drawing.Size(124, 26);
            this.txtAverageBill.TabIndex = 6;
            // 
            // txtTotalCustomers
            // 
            this.txtTotalCustomers.Location = new System.Drawing.Point(204, 62);
            this.txtTotalCustomers.Name = "txtTotalCustomers";
            this.txtTotalCustomers.ReadOnly = true;
            this.txtTotalCustomers.Size = new System.Drawing.Size(124, 26);
            this.txtTotalCustomers.TabIndex = 5;
            // 
            // frmElectricityBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmElectricityBills";
            this.Text = "Electricity Bills";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtKWHused;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalKWH;
        private System.Windows.Forms.TextBox txtAverageBill;
        private System.Windows.Forms.TextBox txtTotalCustomers;
    }
}

