using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

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
		if ((Page.IsPostBack))
		{
			try
			{
				if (m_TroubleTicketNo > 0)
					this.lblTroubleTicketNo.Text = "ID" + m_TroubleTicketNo;
				if (this.lblTroubleTicketNo.Text.Length == 2)
					return;



				clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
				TroubleTicketReqDataTable tblTroubleTicketReq = new TroubleTicketReqDataTable();
					
					theNotificationSystem.GetTroubleTicketListbyID(TroubleTicketNo);
				if (tblTroubleTicketReq.Count == 0)
					return;

				{
					var withBlock = tblTroubleTicketReq[0];
					withBlock.CustomerID = int.Parse(lblCustomerID.Text);
					withBlock.AgentID = int.Parse(lblAgentID.Text);
					withBlock.Status = (lblStatus.Text);
					lblDueDate.Text = withBlock.DueDate.ToString("MM/dd/yyyy");
					lblRequestDate.Text = withBlock.RequestDate.ToString("MM/dd/yyyy");
					withBlock.Type = (lblType.Text);
				}
			}
			catch (Exception ex)
			{
				throw;
			}
		}
	}
}
