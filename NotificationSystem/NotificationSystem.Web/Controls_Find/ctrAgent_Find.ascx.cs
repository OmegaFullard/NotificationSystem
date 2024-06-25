using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;


public partial class ctrAgent_Find : System.Web.UI.UserControl
    {
        private int m_AgentID = 0;

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


        protected void Page_Load(object sender, System.EventArgs e)
        {
		clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
		AgentDataTable tblAgent = new AgentDataTable();

		try
		{

			if (Request.Form["ctl00$MainContent$ctrSearch_Agent_Find$btnSearch"] == "Search")

				this.lblSearchResult.Text = "ID" + m_AgentID;

			if ((Page.IsPostBack) & this.lblSearchResult.Text.Length > 0)


				tblAgent = (AgentDataTable)theNotificationSystem.GetAgent(int.Parse(this.lblSearchResult.Text.Replace("ID", "")));
			else
				tblAgent = (AgentDataTable)theNotificationSystem.GetAgents();

			this.lblSearchResult.Text = tblAgent.Rows.Count.ToString();
			this.grdAgent.DataSource = tblAgent.DefaultView;
			this.grdAgent.DataBind();
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
			Response.AddHeader("content-disposition", "attachment;filename=Agent_Information.xls");
			Response.Charset = "";
			Response.ContentType = "application/vnd.ms-excel";
			StringWriter sw = new StringWriter();
			HtmlTextWriter hw = new HtmlTextWriter(sw);
			grdAgent.AllowPaging = false;
			this.grdAgent.DataBind();

			for (int y = 0; y <= 12; y++)
				grdAgent.HeaderRow.Cells[y].Style.Add("background-color", "#cfdbe6");

			for (int x = 0; x <= grdAgent.Rows.Count - 1; x++)
			{
				for (int y = 0; y <= 12; y++)
				{
					if (x % 2 > 0)
						grdAgent.Rows[x].Cells[y].Style.Add("background-color", "#e0ebea");
				}
			}

			grdAgent.Attributes.Add("style", "vnd.ms-excel.numberformat:@");
			grdAgent.RenderControl(hw);
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

	protected void grdAgent_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		try
		{
			if (!(Information.IsNothing(ViewState["columnname"]) | Information.IsNothing(ViewState["direction"])))
			{
				DataView m_DataView = (DataView)this.grdAgent.DataSource;

				if (m_DataView == null)
				{
					m_DataView.Sort = ViewState["columnname"].ToString() + " " + ViewState["direction"].ToString();
					this.grdAgent.DataSource = m_DataView;
				}
			}

			this.grdAgent.PageIndex = e.NewPageIndex;
			this.grdAgent.DataBind();
		}
		catch (Exception)
		{
			throw;
		}
	}

	protected void grdAgent_Sorting(object sender, GridViewSortEventArgs e)
	{
		try
		{
			DataView m_Dataview = (DataView)grdAgent.DataSource;

			if (m_Dataview == null)
			{
				m_Dataview.Sort = e.SortExpression + " " + ConvertSortDirection(e);
				this.grdAgent.DataSource = m_Dataview;
				this.grdAgent.DataBind();
			}
		}
		catch (Exception)
		{
			throw;
		}
	}
}
