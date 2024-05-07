using System;
using System.Collections.Generic;
using System.Data;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Agent_Find : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)

        {
            try
            {
                if ((Page.IsPostBack))
                {
                    if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                    {
                        ctrSearch_Agent_Find.PopulateSearchControl();
                        this.ctrAgent_Find.AgentID = ctrSearch_Agent_Find.AgentID;

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


