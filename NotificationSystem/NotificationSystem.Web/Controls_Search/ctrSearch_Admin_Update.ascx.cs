using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web.Controls_Search
{
	public partial class ctrSearch_Admin_Update : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

			if (!(Page.IsPostBack))
			{
				cmbAdmin.DataSource = theNotificationSystem.GetAdmins();
				cmbAdmin.DataTextField = "UserName"; cmbAdmin.DataValueField = "Password";
				cmbAdmin.DataBind();
			}
		}

		public void ClearControl()
		{
			this.cmbAdmin.Value = string.Empty; cmbAdmin.Text = "--";
		}
	}
}