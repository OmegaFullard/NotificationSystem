using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class ctrTroubleTicketReq : System.Web.UI.UserControl
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
			TroubleTicketReqDataTable tblTTR = new TroubleTicketReqDataTable();
			int troubleticketNo = m_TroubleTicketNo;

			try
			{
				if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"] == "Search")
					this.lblSearchResult.Text = Convert.ToString(m_TroubleTicketNo);

				if ((Page.IsPostBack) & this.lblSearchResult.Text.Length > 0)

					tblTTR = (TroubleTicketReqDataTable)theNotificationSystem.GetTroubleTicketByNo(troubleticketNo);



				else

					tblTTR = (TroubleTicketReqDataTable)theNotificationSystem.GetTroubleTicket();


				this.lblSearchResult.Text = tblTTR.Rows.Count + " Result(s)";
				this.grdTroubleTicketReq.DataSource = tblTTR.DefaultView;
				this.grdTroubleTicketReq.DataBind();

			}

			catch (Exception)
			{
				throw;
			}
		}
		private void grdTroubleTicketReq_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (!(Information.IsNothing(ViewState["columnname"]) | Information.IsNothing(ViewState["direction"])))
                {
                    DataView m_DataView = (DataView)this.grdTroubleTicketReq.DataSource;

                    if (m_DataView == null)
                    {
                        m_DataView.Sort = ViewState["columnname"].ToString() + " " + ViewState["direction"].ToString();
                        this.grdTroubleTicketReq.DataSource = m_DataView;
                    }
                }

                this.grdTroubleTicketReq.PageIndex = e.NewPageIndex;
                this.grdTroubleTicketReq.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void grdTroubleTicketReq_Sorting(object sender, GridViewSortEventArgs e)
        {
            try
            {
                DataView m_Dataview = (DataView)grdTroubleTicketReq.DataSource;

                if (m_Dataview == null)
                {
                    m_Dataview.Sort = e.SortExpression + " " + ConvertSortDirection(e);
                    this.grdTroubleTicketReq.DataSource = m_Dataview;
                    this.grdTroubleTicketReq.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string ConvertSortDirection(System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            ViewState.Add("columnname", e.SortExpression);

            if ((ViewState["direction"] == null))
                ViewState.Add("direction", "asc");
            else
                ViewState["direction"] = Interaction.IIf(ViewState["direction"].ToString().ToLower() == "desc", "asc", "desc");

            return ViewState["direction"].ToString();
        }

    }
}
