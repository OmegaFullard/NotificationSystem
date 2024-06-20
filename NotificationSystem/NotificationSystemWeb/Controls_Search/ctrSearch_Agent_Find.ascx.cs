using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web.Controls_Search
{
	public partial class ctrSearch_Agent_Find : System.Web.UI.UserControl
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

		}

        public void PopulateSearchControl()
		{
            m_AgentID = int.Parse(txtAgentName.Text);
		}
	}
}