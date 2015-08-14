using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionReportingSystem.DAL.DAO
{
    class Transaction
    {
        public int TransactionId { get; set; }
        public double Amount { get; set; }
        public string TransactionDate { get; set; }
        public string Type { get; set; }
        public double Income { get; set; }
        public double Expence { get; set; }
        public Remark Remarks { get; set; }
    }
}
