using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionReportingSystem.DAL.Gateway;
using TransactionReportingSystem.DAL.DAO;

namespace TransactionReportingSystem.BLL
{
    class TransactionManager
    {
        public TransactionGateway transactionGateway = new TransactionGateway();
        public string Save(Transaction aTransaction)
        {

            return transactionGateway.Save(aTransaction);
        }
        public List<Transaction> GetDetailTransaction(string date)
        {
            return transactionGateway.GetDetailTransaction(date);
        }
        public List<Transaction> GetTransactionSummary(string  dateFrom, string dateTo)
        {
            return transactionGateway.GetTransactionSummary(dateFrom, dateTo);
        }
    }
}
