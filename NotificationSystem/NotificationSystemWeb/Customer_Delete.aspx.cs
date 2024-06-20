using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class Customer_Delete : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            try
            {
                if ((Page.IsPostBack))
                {
                    string strCustomer = (Request.Form["ctl00_MainContent_ctrCustomer_Update_CustomerID_ClientState"]
                        .Replace("\"", "")
                        .Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&"));

                    if (strCustomer.Length > 3)
                    {
                        string[] arrCustomers = strCustomer.Split(Convert.ToChar(":"));
                        this.ctrCustomer_Delete.CustomerID = int.Parse(arrCustomers[1]); this.ctrCustomer_Delete.CustomerID = int.Parse(arrCustomers[2]);
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