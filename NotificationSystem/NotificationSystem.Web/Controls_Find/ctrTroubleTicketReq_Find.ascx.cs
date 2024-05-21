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
	private int m_AgentID = 0;
	private int m_CustomerID = 0;

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
		
		

			public int AgentID
	{
		get
		{
			return m_AgentID;
		}
		set
		{
			m_AgentID = value;
		}

	}

	public int CustomerID
	{
		get
		{
			return m_CustomerID;
		}
		set
		{
			m_CustomerID = value;
		}
	}
	protected void Page_Load(object sender, EventArgs e)
	{

		if ((Page.IsPostBack))
		{
			try
			{
				if (m_TroubleTicketNo > 0)
					this.lblTroubleTicketNo.Text = "TicketNo" + m_TroubleTicketNo;
				if (this.lblTroubleTicketNo.Text.Length == 2)
					return;


				clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

				TroubleTicketReqDataTable tblTroubleTicketReq = (TroubleTicketReqDataTable)theNotificationSystem.GetTroubleTicketByNo(Convert.ToInt32(this.lblTroubleTicketNo.Text.Replace("TicketNo", "")));
				if (tblTroubleTicketReq.Count == 0)
					return;

				{
					var withBlock = tblTroubleTicketReq[0];
					lblRequestDate.Text = withBlock.RequestDate.ToString("MM/dd/yyyy");
					lblDueDate.Text = withBlock.DueDate.ToString("MM/dd/yyyy");
					//lblTroubleTicketNo.Text = theNotificationSystem.GetDataByTroubleTicketNo(Convert.ToInt32(m_TroubleTicketNo));
					this.lblAgentID.Text = Convert.ToString(withBlock.AgentID);
					this.lblCustomerID.Text = Convert.ToString(withBlock.CustomerID);

				}
			}
			catch (Exception ex)
			{
				clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
				string NotificationBody = ex.Message + "  " + ex.StackTrace;
				SendError.SendMailMessage(NotificationBody);
				Response.Redirect("ErrorPage.aspx", false);
			}
		}
	}
}


