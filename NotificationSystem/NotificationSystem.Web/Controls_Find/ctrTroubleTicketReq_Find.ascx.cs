using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using Microsoft.VisualBasic;
using System.Data;
using System.IO;

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

		clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
		TroubleTicketReqDataTable tblTroubleTicketReq = new TroubleTicketReqDataTable();
		try
		{
			if (Request.Form["ctl00$MainContent$ctrSearch_TT_Find$btnSearch"] == "Search")
				this.lblSearchResult.Text = "Ticket" + m_TroubleTicketNo;

			if ((Page.IsPostBack) & this.lblSearchResult.Text.Length > 0)
				tblTroubleTicketReq = (TroubleTicketReqDataTable)theNotificationSystem.GetTroubleTicket(int.Parse(this.lblSearchResult.Text.Replace("Ticket", "")));

			else
				tblTroubleTicketReq = (TroubleTicketReqDataTable)theNotificationSystem.GetTT();


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

	
	private string ConvertSortDirection(System.Web.UI.WebControls.GridViewSortEventArgs e)
	{
		ViewState.Add("columnname", e.SortExpression);

		if ((ViewState["direction"] == null))
			ViewState.Add("direction", "asc");
		else
			ViewState["direction"] = Interaction.IIf(ViewState["direction"].ToString().ToLower() == "desc", "asc", "desc");

		return ViewState["direction"].ToString();
	}
	public void CreateExcelFiles()
	{
		try
		{
			Response.Clear();
			Response.Buffer = true;
			Response.AddHeader("content-disposition", "attachment;filename=Ticket_Information.xls");
			Response.Charset = "";
			Response.ContentType = "application/vnd.ms-excel";
			StringWriter sw = new StringWriter();
			HtmlTextWriter hw = new HtmlTextWriter(sw);
			grdTroubleTicketReq.AllowPaging = false;
			this.grdTroubleTicketReq.DataBind();

			for (int y = 0; y <= 12; y++)
				grdTroubleTicketReq.HeaderRow.Cells[y].Style.Add("background-color", "#cfdbe6");

			for (int x = 0; x <= grdTroubleTicketReq.Rows.Count - 1; x++)
			{
				for (int y = 0; y <= 12; y++)
				{
					if (x % 2 > 0)
						grdTroubleTicketReq.Rows[x].Cells[y].Style.Add("background-color", "#e0ebea");
				}
			}

			grdTroubleTicketReq.Attributes.Add("style", "vnd.ms-excel.numberformat:@");
			grdTroubleTicketReq.RenderControl(hw);
			Response.Output.Write(sw.ToString());
			Response.Flush();
			Response.End();
		}




		catch (Exception)
		{
			throw;
		}
	}

	private void btnSubmit_Click(object sender, EventArgs e)
	{
		CreateExcelFiles();
	}

	protected void grdTroubleTicketReq_PageIndexChanging(object sender, GridViewPageEventArgs e)
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

	protected void grdTroubleTicketReq_Sorting(object sender, GridViewSortEventArgs e)
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
}


