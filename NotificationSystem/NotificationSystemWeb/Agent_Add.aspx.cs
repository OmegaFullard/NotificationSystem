using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Agent_Add : System.Web.UI.Page
    {
        private string m_AgentList = string.Empty;

        public int m_AgentID = 0;

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
        public string AgentList
        {
            get
            {
                return m_AgentList;
            }
            set
            {
                m_AgentList = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Page.IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    ctrAgent_Search.PopulateSearchControl();
                    if (((ctrAgent_Search.AgentID) == 0))
                        return;
                    this.ctrAgent_Add.ClearControls(); this.ctrAgent_Add.AgentID = ctrAgent_Search.AgentID;
                }
                else if (Request.Form["ctl00$MainContent$ctrAgent_Add$btnCreate"] == "Add")
                {
                    this.ctrAgent_Add.AddAgent();
                    if ((ctrAgent_Search.AgentID) == 0)
                        return;
                }

            }
        }
    }
}
