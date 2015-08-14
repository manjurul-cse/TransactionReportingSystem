using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TransactionReportingSystem.DAL.Gateway
{
    class CommonGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;

        public CommonGateway()
        {
            connectionObj= new SqlConnection(ConfigurationManager.ConnectionStrings["TransactionConnectionString"].ConnectionString);
            commandObj =new SqlCommand();

        }

        public SqlConnection SqlConnectionObj
        {
            get { return connectionObj; }
        }

        public SqlCommand SqlCommandObj
        {
            get { commandObj.Connection = connectionObj;
                return commandObj;
            }
        }
    }
}
