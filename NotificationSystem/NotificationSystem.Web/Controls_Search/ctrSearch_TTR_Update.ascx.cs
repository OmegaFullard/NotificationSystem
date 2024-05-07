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
				cmbStatus.DataSource = theNotificationSystem.GetStatusList();
				cmbStatus.DataTextField = "Status"; cmbStatus.DataValueField = "Status";
				cmbStatus.DataBind();

				cmbStatus.DataSource = theNotificationSystem.GetTypeList();
				cmbStatus.DataTextField = "Type"; cmbType.DataValueField = "Type";
				cmbStatus.DataBind();
			}
		}

		public void ClearControl()
		{
			this.cmbStatus.Value = string.Empty; cmbStatus.Text = "--";
			this.cmbType.Value = string.Empty; cmbType.Text = "--";
		}
	}
}