using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using System.Data.SqlClient;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class ctrAgent_Update : System.Web.UI.UserControl
    {
        private int m_AgentID = 0;

        public int AgentID
        {
            get
            {
                return m_AgentID;
            }
            set
            {
                m_AgentID = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            AgentDataTable tblAgent = new AgentDataTable();
            try
            {
                if (Page.IsPostBack)
                {

                    if (Request.Form["ct100$MainContent$ctrAgent_Update$btnUpdate"] == "Update")
                        UpdateAgent();
                    else
                    {
                        if (m_AgentID > 0)
                            lblResult.Text = "ID" + m_AgentID;

                        if (lblResult.Text.Length == 0)
                            return;

                        tblAgent = (AgentDataTable)theNotificationSystem.GetAgentList();
                        if (tblAgent.Count == 0)
                            return;

                        {
                            var withBlock = tblAgent[0];
                            txttitle.Text = withBlock.Title; withBlock.Salary = (txtsalary.Text);
                                withBlock.AgentID = int.Parse(this.txtagentid.Text);


                            if (!string.IsNullOrEmpty(withBlock.Phone))
                                txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

                            if (!string.IsNullOrEmpty(withBlock.Email))
                            {
                                txtemailaddress.Text = withBlock.Email;
                            }

                            if (!string.IsNullOrEmpty(withBlock.Fax))
                                txtFaxNumber.Text = withBlock.Fax.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

                        }

                    }
                    btnUpdate.Enabled = true;
                }
            }


            catch (Exception ex)
            {
                clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
                string NotificationBody = ex.Message + "  " + ex.StackTrace;
                SendError.SendMailMessage(NotificationBody);
                Response.Redirect("ErrorPage.aspx", false);

            }
        }

        public void ClearControls()
        {
            try
            {
            }


            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateAgent()
        {
            try
            {
                clsAgent thisAgent = new clsAgent();

                {
                    var withBlock = thisAgent;
                    if (txtagentid.Text.Length == 0)
                        return;


                    withBlock.AgentID = int.Parse(txtagentid.Text); withBlock.Title = txttitle.Text; withBlock.FirstN = txtfirstname.Text; withBlock.LastN = txtlastname.Text; withBlock.Email = txtemailaddress.Text; withBlock.Phone = txtPhoneNumber.Text; withBlock.Fax = txtFaxNumber.Text;
                    withBlock.Salary = (txtsalary.Text);
                }

                try
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.AddAgent(thisAgent);
                    lblResult.Text = "Agent data has been added";
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        lblResult.Text = "Agent already exist!";
                    else
                        throw new ApplicationException(ex.Message);
                }
            }


            catch (Exception ex)
            {
                clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
                string NotificationBody = ex.Message + "  " + ex.StackTrace;
                SendError.SendMailMessage(NotificationBody);
                Response.Redirect("ErrorPage.aspx", false);
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agent_Find.aspx", false);
        }
    }
}



