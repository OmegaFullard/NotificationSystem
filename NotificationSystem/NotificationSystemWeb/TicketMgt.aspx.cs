﻿using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class TicketMgt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

		private void PopulateControls()
		{
			clsNotificationSystem theNotificationSystem = new clsNotificationSystem();


			//this.cmbStatus.DataSource = theNotificationSystem.GetStatusList();
			//this.cmbStatus.DataTextField = "Status";
			//this.cmbStatus.DataBind();
			//this.cmbStatus.Text = "Open";


			//this.cmbType.DataSource = theNotificationSystem.GetTypeList();
			//this.cmbType.DataTextField = "Type";
			//this.cmbType.DataBind();


		}
	}


}