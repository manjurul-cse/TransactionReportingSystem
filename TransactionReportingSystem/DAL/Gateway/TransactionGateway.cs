using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionReportingSystem.DAL.DAO;
using System.Data;
using System.Data.SqlClient;

namespace TransactionReportingSystem.DAL.Gateway
{
    class TransactionGateway : CommonGateway
    {
        RemarkGateway remarkGateway = new RemarkGateway();
        public string Save(Transaction transaction)
        {

            string message = "";
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("Insert into tbl_Transaction values('{0}','{1}','{2}','{3}')", transaction.Amount, transaction.TransactionDate, transaction.Type, transaction.Remarks.Id);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
                message =  transaction.Type + " type transaction has been completed successfully.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred during to data save to database. Try again", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }

            return message;
        }
        public List<Transaction> GetDetailTransaction(string date)
        {
            List<Transaction> transactions = new List<Transaction>();
            try
            {
                SqlConnectionObj.Open();
                string query = "Select * From  tbl_Transaction where Date = '" + date + "'";
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    Transaction aTransaction = new Transaction();
                    aTransaction.Amount = Convert.ToDouble(reader[1]);
                    aTransaction.Type = reader[3].ToString();
                    aTransaction.Remarks = remarkGateway.GetRemark(Convert.ToInt32(reader[4]));
                    transactions.Add(aTransaction);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error occurred during transactions loading from your system.", exception);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return transactions;
        }
        public List<Transaction> GetTransactionSummary(string dateFrom, string dateTo)
        {
            List<Transaction> transactions = new List<Transaction>();
            try
            {
                SqlConnectionObj.Open();
                string query = "Select a.Date,IsNull(Sum(b.Amount),0) as Income,IsNull(Sum(c.Amount),0) as Expense from tbl_Transaction a";  
                      query+=" Left outer Join tbl_Transaction b on b.ID = a.ID and b.Type = 'Income'";
                     query +=" Left Join tbl_Transaction c on c.ID = a.ID and c.Type= 'Expense'";
                      query +=" Where a.Date between '"+dateFrom+"' and '"+dateTo+"'";
                      query += " Group by a.Date";
                      query += " Order By a.Date";
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    Transaction aTransaction = new Transaction();
                    aTransaction.TransactionDate = reader[0].ToString();
                    aTransaction.Income = Convert.ToDouble(reader[1]);
                    aTransaction.Expence = Convert.ToDouble(reader[2]);
                    transactions.Add(aTransaction);
                }

                List<string> dateList = CreateDateList(dateFrom, dateTo);
                List<string> tempDateList = new List<string>();

                foreach (string obj in dateList)
                {
                    bool flag = false;
                    foreach (var objt in transactions)
                    {
                        if (objt.TransactionDate == obj)
                        {
                            flag = true;
                            break;
                        }

                    }
                    if (flag)
                    {
                        tempDateList.Add(obj);

                    }
                }

                foreach (var obj in tempDateList)
                {
                    dateList.Remove(obj);
                }


                foreach (var obj in dateList)
                {
                    transactions.Add(new Transaction {TransactionDate = obj  });
                }

            }
            catch (Exception exception)
            {
                throw new Exception("Error occurred during transactions loading from your system.", exception);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return transactions;
        }

        private List<string> CreateDateList(string dateFrom, string dateTo)
        {
            List<string> resultDate = new List<string>();
            //int dt = Convert.ToDateTime(dateFrom).DayOfYear;
            //int dt1 = Convert.ToDateTime(dateTo).DayOfYear;
            //for (int i = dt; dt1 > i; i++)
            //{
            //    resultDate.Add(DateTime.).ToShortDateString());
            //}

            return resultDate;
        }
    }
}
