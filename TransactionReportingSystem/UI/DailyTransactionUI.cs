using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransactionReportingSystem.BLL;
using TransactionReportingSystem.DAL.DAO;

namespace TransactionReportingSystem.UI
{
    public partial class DailyTransactionUI : Form
    {
        RemarkManager remarks = new RemarkManager();
        TransactionManager transactions = new TransactionManager();
        public DailyTransactionUI()
        {
            InitializeComponent();
            LoadRemarks();
            
        }

        private void LoadRemarks()
        {
            remarkComboBox.DataSource = remarks.GetAll();
            remarkComboBox.DisplayMember = "Name";
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            RemarksUI remarksObj = new RemarksUI();
            remarksObj.ShowDialog();
            LoadRemarks();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                if (amountTextBox.Text != "" && remarkComboBox.Text != "")
                {
                    string message = "";
                Transaction aTransaction = new Transaction();
                aTransaction.Amount = Convert.ToDouble(amountTextBox.Text);
                aTransaction.TransactionDate =Convert.ToDateTime(datePicker.Text).ToShortDateString();
            
                if (incomeRadioButton.Checked)
                {
                    if (remarkComboBox.Text != "House Rent")
                    {

                        aTransaction.Type = "Income";
                        aTransaction.Remarks = (Remark)remarkComboBox.SelectedItem;
                    }
                    else
                    {
                        MessageBox.Show("House Rent is not  Income Type");
                        flag = false;
                    }
                    
                }
                else if (expenseRadioButton.Checked)
                {
                    if (remarkComboBox.Text != "Salary")
                    {
                        aTransaction.Type = "Expense";
                        aTransaction.Remarks = (Remark)remarkComboBox.SelectedItem;
                    }
                    else
                    {
                        MessageBox.Show("Salary is not  Expense Type");
                        flag = false;
                    }
                }


                try
                {
                    if (flag)
                    {
                        message = transactions.Save(aTransaction);
                        MessageBox.Show(message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                }
                else
                    MessageBox.Show("Amount is mandatory");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void detailTransactionButton_Click(object sender, EventArgs e)
        {
            DetailTransactionUI detailTranObj = new DetailTransactionUI();
            detailTranObj.ShowDialog();
        }

        private void transactionSummaryButton_Click(object sender, EventArgs e)
        {
            TransactionSummaryUI tranSummaryObj = new TransactionSummaryUI();
            tranSummaryObj.ShowDialog();
        }
        }
    }

