using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using Microsoft.VisualBasic;

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

        try
        {
            if ((Page.IsPostBack))
            {
                string strTroubleTicket = (Request.Form["ctl00_MainContent_ctrTroubleTicketReq_Update_TroubleTicketNo_ClientState"]
                    .Replace("\"", "")
                    .Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&"));

                if (strTroubleTicket.Length > 3)
                {
                    string[] arrTicket = strTroubleTicket.Split(Convert.ToChar(":"));
                    this.ctrTroubleTicketReq_Update.TroubleTicketNo = int.Parse(arrTicket[1]); this.ctrTroubleTicketReq_Update.TroubleTicketNo = int.Parse(arrTicket[2]);
                }
            }
        }
        catch (Exception ex)
        {
            clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
            string NotificationBody = ex.Message + Constants.vbCrLf + ex.StackTrace;
            SendError.SendMailMessage(NotificationBody);
            Response.Redirect("ErrorPage.aspx", false);
        }
    }
}

    