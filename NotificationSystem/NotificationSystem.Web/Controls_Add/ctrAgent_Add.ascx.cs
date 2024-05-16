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
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Telerik.Web.UI;
using System.Data.SqlClient;
using System.Net.Http;


    public partial class ctrAgent_Add : System.Web.UI.UserControl
    {

        private SqlDataReader dr;

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
	public int AgentList { get; internal set; }

	protected void Page_Load(object sender, EventArgs e)
        {
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            AgentDataTable tblAgent = new AgentDataTable();
            var client = new HttpClient();
            try
            {
                if ((Page.IsPostBack))
                {
                    //button click to add form data ?

                    if (Request.Form["ctl00$MainContent$ctrAgent_Add$btnAdd"] == "Add")
                        AddAgent();
                }
                else
                {
                PopulateControls();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AddAgent()
        {
            try
            {
                clsAgent thisAgent = new clsAgent();

                {
                    var withBlock = thisAgent;
                    if (txtagentid.Text.Length == 0)
                        return;


                    withBlock.AgentID = int.Parse(txtagentid.Text); withBlock.Title = txttitle.Text; withBlock.FirstN = txtfirstname.Text; withBlock.LastN = txtlastname.Text; withBlock.Email = txtemailaddress.Text; withBlock.Phone = txtPhoneNumber.Text; withBlock.Fax = txtFaxNumber.Text;
                    withBlock.Salary = int.Parse(txtsalary.Text); 
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
    public void PopulateControls()
	{
        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
    }
        public void ClearControls()
        {
            try
            {

            }


            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agent_Find.aspx", false);
        }
    }
