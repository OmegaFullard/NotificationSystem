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
    public partial class TicketReq : System.Web.UI.Page
    {
        private int m_TroubleTicketNo = 0;

        public int TroubleTicketNo
        {
            get
            {
                return m_TroubleTicketNo;
            }
            set
            {
                m_TroubleTicketNo = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if ((Page.IsPostBack))
            {
                if (Page.Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"] == "Search")
                {

                    //ctrTroubleTicketReq_Search.PopulateSearchControl();
                    //ctrTroubleTicketReq.TroubleTicketNo = ctrTroubleTicketReq_Search.TroubleTicketNo;

                }
            }
        }


    }
}