using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class Admin_Delete : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            try
            {
                if ((Page.IsPostBack))
                {
                    string strAdmin = (Request.Form["ctl00_MainContent_ctrAdmin_Update_UserName_ClientState"]
                        .Replace("\"", "")
                        .Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&"));

                    if (strAdmin.Length > 2)
                    {
                        string[] arrAdmins = strAdmin.Split(Convert.ToChar(":"));
                        this.ctrAdmin_Delete.UserName = arrAdmins[1]; this.ctrAdmin_Delete.UserName = arrAdmins[2];
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