using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TransactionReportingSystem.DAL.DAO;

namespace TransactionReportingSystem.DAL.Gateway
{
    class RemarkGateway:CommonGateway
    {
        
        public List<Remark> GetAll()
        {
            List<Remark> remarks = new List<Remark>();
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("Select * From tbl_Remark");
                SqlCommandObj.CommandText = query;
                SqlDataReader dataReader = SqlCommandObj.ExecuteReader();
                while (dataReader.Read())
                {
                    Remark aRemark = new Remark();
                    aRemark.Id = Convert.ToInt32(dataReader["ID"]);
                    aRemark.Name = dataReader["Name"].ToString();
                    remarks.Add(aRemark);

                }
            }
            catch(Exception ex)
            {
                throw new Exception("Remarks can not loaded from your system",ex);
            }
            finally
            {
                if (SqlCommandObj !=null && SqlConnectionObj.State==ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return remarks;
        }
        public Remark GetRemark(int remarkId)
        {
            try
            {

           
            SqlConnectionObj.Open();
            string query = string.Format("Select * From tbl_Remark where ID = " + remarkId);

            SqlCommandObj.CommandText = query;
            SqlDataReader dataReader = SqlCommandObj.ExecuteReader();
            Remark aRemark = new Remark();
            while (dataReader.Read())
            {
                aRemark.Id = Convert.ToInt32(dataReader["ID"]);
                aRemark.Name = dataReader["Name"].ToString();
            }
            return aRemark;
            }
            catch (Exception ex)
            {
                throw new Exception("Remarks can not loaded from your system", ex);
            }
            finally
            {
                if (SqlCommandObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
           
        }
        public bool Save(Remark remark)
        {
            try
            {SqlConnectionObj.Open();
                string query = string.Format("Insert into tbl_Remark values('{0}')", remark.Name);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Remark couldn't saved", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return true;
        }
        public bool HasThisRemarkName(string name)
        {

            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("SELECT * FROM tbl_Remark WHERE Name='{0}'", name);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                if (reader != null)
                {
                    return reader.HasRows;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Remark couldn't loaded from your system", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
        }
    }
}
