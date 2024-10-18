using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using Microsoft.VisualBasic;

namespace NotificationSystem.NotificationSystem.Web
    {

    public partial class TicketDetails : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ((Page.IsPostBack))
                {
                    if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"] == "Search")
                    {
                        ctrTroubleTicketReq_Search.PopulateSearchControl();
                        this.ctrTroubleTicketReq_Find.TroubleTicketNo = ctrTroubleTicketReq_Search.TroubleTicketNo;

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
        public override bool EnableEventValidation
        {
            get
            {
                return false;
            }
            set
            {
            }
        }
    }

}