using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;

    public partial class Agent_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Page.IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    ctrAgent_Search.PopulateSearchControl();

                    if (ctrAgent_Search.AgentID.Length == 0)
                        return;
                    this.ctrAgent_Update.AgentID = (short)ctrAgent_Search.AgentID;
                }
            }
        }
    }
