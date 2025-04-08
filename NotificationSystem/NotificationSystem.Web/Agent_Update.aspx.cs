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
using Microsoft.VisualBasic;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Agent_Update : System.Web.UI.Page
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
            try
            {
                if ((Page.IsPostBack))
                {
                    try
                    {
                        string strAgent = Request.Form["ctl00_MainContent_ctrAgent_Update_AgentID_ClientState"];
                        if (strAgent == "Search")
                        {
                            strAgent = strAgent
                                .Replace("\"", "")
                                .Replace("{", "")
                                .Replace("}", "")
                                .Replace(",", "")
                                .Replace("text", "")
                                .Replace("value", "")
                                .Replace("%20", " ")
                                .Replace("%26", "&");

                            if (strAgent.Length > 2)
                            {
                                string[] arrAgents = strAgent.Split(Convert.ToChar(":"));
                                this.ctrAgent_Update.AgentID = int.Parse(arrAgents[1]);
                                this.ctrAgent_Update.AgentID = int.Parse(arrAgents[2]);
                                //this.ctrSearch_Agent_Update.ClearControl();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
                        string NotificationBody = ex.Message + Constants.vbCrLf + ex.StackTrace;
                        SendError.SendMailMessage(NotificationBody);
                        Response.Redirect("ErrorPage.aspx", false);
                    }
                }
                
            }
            catch (Exception ex)
            {
                clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
                string NotificationBody = ex.Message + Constants.vbCrLf + ex.StackTrace;
                SendError.SendMailMessage(NotificationBody);
                Response.Redirect("ErrorPage.aspx", false);
            }
        }
    }
}