using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;

namespace NotificationSystem.NotificationSystem.Web.Controls_Find
{
    public partial class ctrAgent_Find : System.Web.UI.UserControl
    {
        private @int m_AgentID = 0;

        public Int AgentID
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
            if ((System.Web.UI.Control.Page.IsPostBack))
            {
                try
                {
                    if (m_AgentID.Length > 0)
                        this.lblAgentID.Text = "ID" + m_AgentID;
                    if (this.lblAgentID.Text.Length == 2)
                        return;



                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    AgentDataTable tblAgent = theNotificationSystem.GetAgentListByID(System.Convert.ToInt32(Replace(this.lblAgentID.Text, "ID", "")));
                    if (tblAgent.Count == 0)
                        return;

                    {
                        var withBlock = tblAgent(0);
                        lblStartDate.Text = withBlock.StartDate.ToString("MM/dd/yyyy");
                        lblAgentID.Text = theNotificationSystem.GetAgentListByID(withBlock.AgentID);
                        lblTroubleTicketNo.Text = withBlock.TroubleTicketNo;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}