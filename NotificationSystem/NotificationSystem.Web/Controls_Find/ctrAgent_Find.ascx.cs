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
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;


namespace NotificationSystem.NotificationSystem.Web
{
    public partial class ctrAgent_Find : System.Web.UI.UserControl
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
                if (((short)m_AgentID) > 0)
                    this.lblAgentID.Text = "ID" + m_AgentID;
                if (this.lblAgentID.Text.Length == 2)
                    return;

                try
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    AgentDataTable tblAgent = new AgentDataTable();
                    theNotificationSystem.GetAgentByID(Convert.ToInt32(this.lblAgentID.Text.Replace("ID", "")));
                    if (tblAgent.Count == 0)
                        return;

                    this.grdAgent.DataSource = tblAgent;
                    this.grdAgent.DataBind();
                }

                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
