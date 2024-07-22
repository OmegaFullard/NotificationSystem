using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web.Controls_Search
{
	public partial class ctrSearch_TTR_Update : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
			if (!(Page.IsPostBack))
			{
				cmbTicket.DataSource = theNotificationSystem.GetTT();
				cmbTicket.DataTextField = "TroubleTicketNo"; 
				cmbTicket.DataValueField = "Status";
				cmbTicket.DataValueField = "Type";
				cmbTicket.DataBind();

			//	cmbType.DataSource = theNotificationSystem.GetTypeList();
			//	cmbType.DataTextField = "TroubleTicket";
			//	cmbType.DataValueField = "Type";
			//	cmbType.DataBind();
			}
		}

		public void ClearControl()
		{
			this.cmbTicket.Value = string.Empty; 
			cmbTicket.Text = "--";
			//this.cmbType.Value = string.Empty; 
			//cmbType.Text = "--";
		}
	}
}