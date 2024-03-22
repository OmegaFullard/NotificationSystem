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
					theNotificationSystem.GetTroubleTicketByNo(Convert.ToInt32(this.lblTroubleTicketNo.Text.Replace("TicketNo", "")));
					if (tblTroubleTicketReq.Count == 0)
						return;

					{
						this.grdTroubleTicketReq.DataSource = tblTroubleTicketReq;
						this.grdTroubleTicketReq.DataBind();
					}
				}
				catch (Exception ex)
				{
					throw;
				}
			}
		}
	}

