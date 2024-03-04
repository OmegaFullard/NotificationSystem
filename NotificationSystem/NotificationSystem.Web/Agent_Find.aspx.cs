using System;
using System.Collections.Generic;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

    public partial class Agent_Find : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Page.IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    ctrAgent_Search.PopulateSearchControl();
                if (((short)ctrAgent_Search.AgentID) == 0)
                    return;
                    // Me.ctrAgent_Find.ClearControls()
                 //   this.ctrAgent_Find.AgentID = ctrAgentSearch.AgentID;
                }
            }
        }
    }
