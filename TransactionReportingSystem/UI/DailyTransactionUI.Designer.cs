namespace TransactionReportingSystem.UI
{
    partial class DailyTransactionUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyTransactionUI));
            this.addNewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.remarkComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.incomeRadioButton = new System.Windows.Forms.RadioButton();
            this.expenseRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.detailTransactionButton = new System.Windows.Forms.Button();
            this.transactionSummaryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(283, 89);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 23);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Remark";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(78, 33);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 2;
            // 
            // remarkComboBox
            // 
            this.remarkComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.remarkComboBox.FormattingEnabled = true;
            this.remarkComboBox.Location = new System.Drawing.Point(78, 91);
            this.remarkComboBox.Name = "remarkComboBox";
            this.remarkComboBox.Size = new System.Drawing.Size(199, 21);
            this.remarkComboBox.TabIndex = 3;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(78, 63);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 4;
            // 
            // incomeRadioButton
            // 
            this.incomeRadioButton.AutoSize = true;
            this.incomeRadioButton.Checked = true;
            this.incomeRadioButton.Location = new System.Drawing.Point(48, 19);
            this.incomeRadioButton.Name = "incomeRadioButton";
            this.incomeRadioButton.Size = new System.Drawing.Size(60, 17);
            this.incomeRadioButton.TabIndex = 5;
            this.incomeRadioButton.TabStop = true;
            this.incomeRadioButton.Text = "Income";
            this.incomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // expenseRadioButton
            // 
            this.expenseRadioButton.AutoSize = true;
            this.expenseRadioButton.Location = new System.Drawing.Point(48, 42);
            this.expenseRadioButton.Name = "expenseRadioButton";
            this.expenseRadioButton.Size = new System.Drawing.Size(66, 17);
            this.expenseRadioButton.TabIndex = 6;
            this.expenseRadioButton.Text = "Expense";
            this.expenseRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(151, 232);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // detailTransactionButton
            // 
            this.detailTransactionButton.Location = new System.Drawing.Point(88, 43);
            this.detailTransactionButton.Name = "detailTransactionButton";
            this.detailTransactionButton.Size = new System.Drawing.Size(189, 23);
            this.detailTransactionButton.TabIndex = 8;
            this.detailTransactionButton.Text = "Detail Transaction";
            this.detailTransactionButton.UseVisualStyleBackColor = true;
            this.detailTransactionButton.Click += new System.EventHandler(this.detailTransactionButton_Click);
            // 
            // transactionSummaryButton
            // 
            this.transactionSummaryButton.Location = new System.Drawing.Point(88, 82);
            this.transactionSummaryButton.Name = "transactionSummaryButton";
            this.transactionSummaryButton.Size = new System.Drawing.Size(189, 23);
            this.transactionSummaryButton.TabIndex = 9;
            this.transactionSummaryButton.Text = "Transaction Summary";
            this.transactionSummaryButton.UseVisualStyleBackColor = true;
            this.transactionSummaryButton.Click += new System.EventHandler(this.transactionSummaryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 269);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Transaction";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.incomeRadioButton);
            this.groupBox2.Controls.Add(this.expenseRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(66, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 84);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.detailTransactionButton);
            this.groupBox3.Controls.Add(this.transactionSummaryButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 138);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report";
            // 
            // DailyTransactionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 457);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.remarkComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DailyTransactionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyTransactionUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox remarkComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.RadioButton incomeRadioButton;
        private System.Windows.Forms.RadioButton expenseRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button detailTransactionButton;
        private System.Windows.Forms.Button transactionSummaryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}