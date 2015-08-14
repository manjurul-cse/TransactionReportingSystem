using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TransactionReportingSystem.DAL.DAO;
using TransactionReportingSystem.BLL;

namespace TransactionReportingSystem
{
    public partial class RemarksUI : Form
    {
       private Remark aRemark = new Remark();
        RemarkManager remarkManager = new RemarkManager();
       
        public RemarksUI()
        {
            InitializeComponent();
            LoadListBox();
        }

        private void LoadListBox()
        {
            remarkListBox.DataSource = remarkManager.GetAll();
            remarkListBox.DisplayMember = "Name";
            remarkListBox.ValueMember = "ID";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string message;
            if (remarkTextBox.Text != null)
            {
                aRemark.Name = remarkTextBox.Text;
                try
                {
                    if(remarkManager.Save(aRemark,out message))
                    {
                        MessageBox.Show(message);
                        LoadListBox();
                    }
                    else
                    {
                        MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
