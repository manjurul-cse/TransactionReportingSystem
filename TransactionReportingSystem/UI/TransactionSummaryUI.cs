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

namespace TransactionReportingSystem
{
    public partial class TransactionSummaryUI : Form
    {
        TransactionManager transactionManager = new TransactionManager();
        public TransactionSummaryUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string dateStart = string.Format("{0}-{1}-{2}", fromDatePicker.Value.Year, fromDatePicker.Value.Month, fromDatePicker.Value.Day);
            string dateEnd = string.Format("{0}-{1}-{2}", toDatePicker.Value.Year, toDatePicker.Value.Month, toDatePicker.Value.Day);

            LoadListView(dateStart, dateEnd);

        }

        private void LoadListView(string dateFrom, string dateTo)
        {
            TransactionSummaryListView.Items.Clear();
            List<Transaction> transactions;
            try
            {
                transactions = transactionManager.GetTransactionSummary(dateFrom,dateTo);
                if (transactions.Count > 0)
                {
                    foreach (Transaction eachTransaction in transactions)
                    {
                        
                        ListViewItem item = new ListViewItem(eachTransaction.TransactionDate);
                        item.SubItems.Add(eachTransaction.Income.ToString());
                        item.SubItems.Add(eachTransaction.Expence.ToString());
                        TransactionSummaryListView.Items.Add(item);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
