using System;
using System.Collections.Genericusing System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Agent_Find : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((System.Web.UI.Control.Page.IsPostBack))
            {
                if (System.Web.UI.Page.Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    ctrAgent_Search.PopulateSearchControl();
                    if (ctrAgent_Search.AgentID.Length == 0)
                        return;
                    // Me.ctrAgent_Find.ClearControls()
                    this.ctrAgent_Find.AgentID = ctrAgentSearch.AgentID;
                }
            }
        }
    }
}