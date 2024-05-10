using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web.Controls_Search
{
	public partial class ctrSearch_Customer_Update : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

			if (!(Page.IsPostBack))
			{
				cmbCustomer.DataSource = theNotificationSystem.GetCustomer();
				cmbCustomer.DataTextField = "CustomerID"; cmbCustomer.DataValueField = "FirstN";
				cmbCustomer.DataBind();
			}
		}

		public void ClearControl()
		{
			this.cmbCustomer.Value = string.Empty; cmbCustomer.Text = "--";
		}
	}

}