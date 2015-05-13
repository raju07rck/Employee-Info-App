namespace AccountOperationApp
{
    partial class accountOperationUI
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
            this.accountCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.customeraNameLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.accountCreationGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountCreationGroupBox
            // 
            this.accountCreationGroupBox.Controls.Add(this.createButton);
            this.accountCreationGroupBox.Controls.Add(this.customeraNameLabel);
            this.accountCreationGroupBox.Controls.Add(this.accountNumberLabel);
            this.accountCreationGroupBox.Controls.Add(this.customerNameTextBox);
            this.accountCreationGroupBox.Controls.Add(this.accountNumberTextBox);
            this.accountCreationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.accountCreationGroupBox.Name = "accountCreationGroupBox";
            this.accountCreationGroupBox.Size = new System.Drawing.Size(474, 120);
            this.accountCreationGroupBox.TabIndex = 0;
            this.accountCreationGroupBox.TabStop = false;
            this.accountCreationGroupBox.Text = "Account Creation";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(296, 81);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 25);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // customeraNameLabel
            // 
            this.customeraNameLabel.AutoSize = true;
            this.customeraNameLabel.Location = new System.Drawing.Point(52, 57);
            this.customeraNameLabel.Name = "customeraNameLabel";
            this.customeraNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customeraNameLabel.TabIndex = 2;
            this.customeraNameLabel.Text = "Customer Name";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(47, 27);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.accountNumberLabel.TabIndex = 1;
            this.accountNumberLabel.Text = "Account Number";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(159, 54);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(213, 20);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(159, 24);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(213, 20);
            this.accountNumberTextBox.TabIndex = 0;
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.amountLabel);
            this.transactionGroupBox.Controls.Add(this.withdrawButton);
            this.transactionGroupBox.Controls.Add(this.depositButton);
            this.transactionGroupBox.Controls.Add(this.amountTextBox);
            this.transactionGroupBox.Location = new System.Drawing.Point(12, 138);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Size = new System.Drawing.Size(474, 87);
            this.transactionGroupBox.TabIndex = 1;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(98, 26);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(283, 46);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(88, 23);
            this.withdrawButton.TabIndex = 1;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(159, 46);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(104, 23);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(159, 20);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(212, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(193, 245);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(163, 23);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // accountOperationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 299);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.accountCreationGroupBox);
            this.Name = "accountOperationUI";
            this.Text = "Account Operation";
            this.accountCreationGroupBox.ResumeLayout(false);
            this.accountCreationGroupBox.PerformLayout();
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox accountCreationGroupBox;
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label customeraNameLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button reportButton;
    }
}

