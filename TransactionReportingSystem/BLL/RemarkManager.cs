using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionReportingSystem.DAL.Gateway;
using TransactionReportingSystem.DAL.DAO;

namespace TransactionReportingSystem.BLL
{
    class RemarkManager
    {
        RemarkGateway remarkGateway = new RemarkGateway();
        public List<Remark> GetAll()
        {
            return remarkGateway.GetAll();
        }
        public bool Save(Remark aRemark, out string saveMessage)
        {
            if (aRemark.Name == string.Empty)
            {
                saveMessage = "Remark data is missing";
                return false;
            }
            else if (remarkGateway.HasThisRemarkName(aRemark.Name))
            {
                saveMessage = "Your system already has this remark data. Try again.";
                return false;
            }
            else
            {
                saveMessage = "Remark has been saved.";
                return remarkGateway.Save(aRemark);
            }
        }
    }
}
