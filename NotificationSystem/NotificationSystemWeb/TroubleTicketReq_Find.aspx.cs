﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;


    public partial class TroubleTicketReq_Find : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        if ((Page.IsPostBack))
        {
            if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"] == "Search")
            {
                ctrTroubleTicketReq_Search.PopulateSearchControl();
                if ((ctrTroubleTicketReq_Search.TroubleTicketNo) == 0)
                    return;
              
                this.ctrTroubleTicketReq_Find.TroubleTicketNo = ctrTroubleTicketReq_Search.TroubleTicketNo;
            }
        }
    }
    }