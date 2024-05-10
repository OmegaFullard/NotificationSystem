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
		
			clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
			TroubleTicketReqDataTable tblTroubleTicketReq = new TroubleTicketReqDataTable();
			try
				{
			if ((Page.IsPostBack))
				theNotificationSystem.GetTroubleTicketByNo(Convert.ToInt32(this.lblTroubleTicketNo.Text.Replace("TicketNo", "")));
			else
				tblTroubleTicketReq = (TroubleTicketReqDataTable)theNotificationSystem.GetTroubleTicket();

			this.lblSearchResult.Text = tblTroubleTicketReq.Rows.Count.ToString();
			this.grdTroubleTicketReq.DataSource = tblTroubleTicketReq.DefaultView;
						this.grdTroubleTicketReq.DataBind();
					
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


