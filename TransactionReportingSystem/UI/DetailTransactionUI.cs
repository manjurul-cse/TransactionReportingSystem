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
    public partial class DetailTransactionUI : Form
    {
        TransactionManager transactionManager = new TransactionManager();
        public DetailTransactionUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string date = string.Format("{0}-{1}-{2}", datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day);
            //string date = Convert.ToDateTime(datePicker.Text).ToString("mm-dd-yyyy");
            LoadListView(date);
            
           
           
        }

        private void LoadListView(string date)
        {
            DetailTransactionListView.Items.Clear();
            List<Transaction> transactions;
            try
            {
              transactions = transactionManager.GetDetailTransaction(date);
              if (transactions.Count > 0)
              {
                  foreach (Transaction eachTransaction in transactions)
                  {
                      ListViewItem item = new ListViewItem(eachTransaction.Amount.ToString());
                      item.SubItems.Add(eachTransaction.Type);
                      item.SubItems.Add(eachTransaction.Remarks.Name);
                      DetailTransactionListView.Items.Add(item);
                  }

              }
              else
              {
                  MessageBox.Show("There’s no transactions on your selected date");
              }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
