using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class Agent_Delete : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            try
            {
                if ((Page.IsPostBack))
                {
                    string strAgent = (Request.Form["ctl00_MainContent_ctrAgent_Update_AgentID_ClientState"]
                        .Replace("\"", "")
                        .Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&"));

                    if (strAgent.Length > 2)
                    {
                        string[] arrAgents = strAgent.Split(Convert.ToChar(":"));
                        this.ctrAgent_Delete.AgentID = int.Parse(arrAgents[1]); this.ctrAgent_Delete.AgentID = int.Parse(arrAgents[2]);
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