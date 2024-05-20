using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Web.Controls_Delete
{
	public partial class ctrAgent_Delete : System.Web.UI.UserControl
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

        public TextBox txtAgentList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            AgentDataTable tblAgent = new AgentDataTable();
            
            try
            {
                if ((Page.IsPostBack))
                {
                    //button click to delete form data 

                    if (Request.Form["ctl00$MainContent$ctrAgent_Delete$btnDelete"] == "Delete")
                        DeleteAgent();
                }
                else
                {

                    if (m_AgentID == 0)
                        return;
                    tblAgent = (AgentDataTable)theNotificationSystem.GetAgents();


                    if (tblAgent.Count == 0)
                        return;
                    
                    {
                        var withBlock = tblAgent[0];

                        this.txttitle.Text = withBlock.Title; withBlock.Salary = int.Parse(txtsalary.Text); withBlock.AgentID = int.Parse(txtagentid.Text);
                        this.txtfirstname.Text = withBlock.FirstN; this.txtlastname.Text = withBlock.LastN; 

                        if (!string.IsNullOrEmpty(withBlock.Phone))
                            txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

                        if (!string.IsNullOrEmpty(withBlock.Email))
                        {
                            txtemailaddress.Text = withBlock.Email;
                        }

                        if (!string.IsNullOrEmpty(withBlock.Fax))
                            txtFaxNumber.Text = withBlock.Fax.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

                    }

                    this.btnDelete.Enabled = true;
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



public void DeleteAgent()
        {
            try
            {
                clsAgent thisAgent = new clsAgent();

                {
                   
                    if (txtagentid.Text.Length == 0)
                        return;
					{
                        var withBlock = thisAgent;
                        withBlock.AgentID = int.Parse(txtagentid.Text);
                    }

                   
                }

                try
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.DeleteAgent(thisAgent);
                    lblResult.Text = "Agent data has been deleted";
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException(ex.Message);
                }


                CleanupControls();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CleanupControls()
        {
            txtagentid.Text = string.Empty; txttitle.Text = string.Empty; txtsalary.Text = string.Empty;
            txtfirstname.Text = string.Empty; txtlastname.Text = string.Empty;
            txtemailaddress.Text = string.Empty; txtPhoneNumber.Text = string.Empty; txtFaxNumber.Text = string.Empty;
        }
        public void CleanResultControl()
        {
            this.lblResult.Text = string.Empty;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agent_Find.aspx", false);
        }

    }
}