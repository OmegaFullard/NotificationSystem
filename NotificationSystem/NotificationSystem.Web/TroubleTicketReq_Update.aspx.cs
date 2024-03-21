using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;


    public partial class TroubleTicketReq_Update : System.Web.UI.Page
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
            if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"] == "Search")
            {
                if (((short)ctrTroubleTicketReq_Search.TroubleTicketNo) == 0)
                    return;
                this.ctrTroubleTicketReq_Update.TroubleTicketNo = (short)ctrTroubleTicketReq_Search.TroubleTicketNo;
            }
        }
    }
    }