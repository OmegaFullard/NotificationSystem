﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class Admin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if ((Page.IsPostBack))
			{
				if (Page.Request.Form["ctl00$MainContent$ctrAdmin_Search$btnSearch"] == "Search")
				{
					ctrSearch_Admin.PopulateSearchControl();
					ctrAdmin.UserName = ctrSearch_Admin.UserName;
				}
			}
		}
	}
}