using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using Microsoft.VisualBasic;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Customer_Update : System.Web.UI.Page
    {


        private int m_CustomerID = 0;

        public int CustomerID
        {
            get
            {
                return m_CustomerID;
            }
            set
            {
                m_CustomerID = value;
            }
        }
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
                        this.ctrCustomer_Update.CustomerID = int.Parse(arrCustomers[1]); this.ctrCustomer_Update.CustomerID = int.Parse(arrCustomers[2]);
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
