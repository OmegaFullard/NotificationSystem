using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Agent_Find_Details : System.Web.UI.Page
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

			//syntax errors 3 / 23 / 24

			clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
			AgentDataTable tblAgent = new AgentDataTable();

			try
			{
				if ((Request.QueryString["Agent"] == null))
					return;

				string[] arrAgents = Request.QueryString["agent"].Split(Convert.ToChar(":"));
				AgentID = int.Parse(arrAgents[0]);
				if (AgentID == 0)
					return;

				tblAgent = (AgentDataTable)theNotificationSystem.GetAgentByID(AgentID);
				if (tblAgent.Count == 0)
					return;

				{
					var withBlock = tblAgent[0];
					withBlock.AgentID = int.Parse(this.txtAgentID.Text); this.txttitle.Text = withBlock.Title; withBlock.Salary = int.Parse(this.txtSalary.Text); 
						this.txtfirstname.Text = withBlock.FirstN; this.txtlastname.Text = withBlock.LastN;

					if (!string.IsNullOrEmpty(withBlock.Phone))
						txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

					if (!string.IsNullOrEmpty(withBlock.Email))
					{
						txtEmailAddress.Text = withBlock.Email;
					}

					if (!string.IsNullOrEmpty(withBlock.Fax))
						txtFaxNumber.Text = withBlock.Fax.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
				}
			}





			catch (Exception)
			{
			}
		}
    }
    }
