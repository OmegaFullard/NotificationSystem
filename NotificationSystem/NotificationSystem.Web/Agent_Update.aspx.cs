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
    public partial class Agent_Update : System.Web.UI.Page
    {
        private int m_AgentID = 0;

        public int AgentID
        {
            get
            {
                return m_AgentID;
            }
            set
            {
                m_AgentID = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Page.IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    ctrAgent_Search.PopulateSearchControl();

                    if (((short)ctrAgent_Search.AgentID) == 0)
                        return;
                    this.ctrAgent_Update.AgentID = ctrAgent_Search.AgentID;
                }
            }
        }
    }
}