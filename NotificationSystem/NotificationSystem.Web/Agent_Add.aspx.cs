using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Agent_Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    ctrAgent_Search.PopulateSearchControl();
                    if (((short)ctrAgent_Search.AgentID) == 0)
                        return;
                    this.ctrAgent_Add.ClearControls(); this.ctrAgent_Add.AgentID = ctrAgent_Search.AgentID;
                }
                else if (Request.Form["ctl00$MainContent$ctrAgent_Add$btnCreate"] == "Add")
                {
                    this.ctrAgent_Add.AddAgent();
                    if (((short)ctrAgent_Search.AgentID) == 0)

                        return;
                }
            }
        }
    }
}
