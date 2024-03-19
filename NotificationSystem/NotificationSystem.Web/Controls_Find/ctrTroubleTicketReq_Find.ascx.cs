using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


    public partial class ctrTroubleTicketReq_Find : System.Web.UI.UserControl
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
        //if ((Page.IsPostBack))
        //{
        //    try
        //    {
        //        if (m_TroubleTicketNo > 0)
        //            this.lblTroubleTicketNo.Text = "ID" + m_TroubleTicketNo;
        //        if (this.lblTroubleTicketNo.Text.Length == 2)
        //            return;



        //        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
        //       TroubleTicketReqDataTable tblTroubleTicketReq = theNotificationSystem.GetTroubleTicketListByID(Convert.ToInt32(this.lbltroubleticket.Text.Replace("ID", "")));
        //        if (tblTroubleTicketReq.Count == 0)
        //            return;

        //        {
        //            var withBlock = tblTroubleTicketReq[0];
        //            lblRequestDate.Text = withBlock.RequestDate.ToString("MM/dd/yyyy");
        //            lblAgentID.Text = theNotificationSystem.GetAgentListByID(withBlock.AgentID);
        //            lblTroubleTicketNo.Text = withBlock.TroubleTicketNo;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}
