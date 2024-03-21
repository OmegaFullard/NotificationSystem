using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;


    public partial class TroubleTicketReq_Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        if ((IsPostBack))
        {
            if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"] == "Search")
            {
                ctrTroubleTicketReq_Search.PopulateSearchControl();
                if (((short)ctrTroubleTicketReq_Search.TroubleTicketNo) == 0)
                    return;
                this.ctrTroubleTicketReq_Add.ClearControls(); this.ctrTroubleTicketReq_Add.TroubleTicketNo = ctrTroubleTicketReq_Search.TroubleTicketNo;
            }
            else if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Add$btnCreate"] == "Add")
            {
                this.ctrTroubleTicketReq_Add.AddTroubleTicket();
                if (((short)ctrTroubleTicketReq_Search.TroubleTicketNo) == 0)
                    return;
            }
        }
    }
    }
