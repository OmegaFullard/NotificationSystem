using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using NotificationSystem_Practice.NotificationSystem.Data.Classes;

public partial class ctrAgent : System.Web.UI.UserControl
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
        protected void Page_Load(object sender, EventArgs e)
        {
        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
        AgentDataTable tblAgent = new AgentDataTable();

        try
        {
            if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                this.ctrHiddebField.Value = Convert.ToString(m_AgentID);

            if ((Page.IsPostBack) & this.ctrHiddebField.Value.Length > 0)
             //   tblAgent = theNotificationSystem.GetAgentByID("%" + this.ctrHiddebField.Value + "%");
           // else
             //   tblAgent = theNotificationSystem.GetAgents;


            this.lblSearchResult.Text = tblAgent.Rows.Count + " Result(s)";
            this.grdAgents.DataSource = tblAgent.DefaultView;
            this.grdAgents.DataBind();
        }

        catch (Exception ex)
        {
            throw;
        }
    }


    private void grdAgents_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            if (!(Information.IsNothing(ViewState["columnname"]) | Information.IsNothing(ViewState["direction"])))
            {
                DataView m_DataView = (DataView)this.grdAgents.DataSource;

                if (m_DataView == null)
                {
                    m_DataView.Sort = ViewState["columnname"].ToString() + " " + ViewState["direction"].ToString();
                    this.grdAgents.DataSource = m_DataView;
                }
            }

            this.grdAgents.PageIndex = e.NewPageIndex;
            this.grdAgents.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private void grdAgents_Sorting(object sender, GridViewSortEventArgs e)
    {
        try
        {
            DataView m_Dataview = (DataView)grdAgents.DataSource;

            if (m_Dataview == null)
            {
                m_Dataview.Sort = e.SortExpression + " " + ConvertSortDirection(e);
                this.grdAgents.DataSource = m_Dataview;
                this.grdAgents.DataBind();
            }
        }
        catch (Exception ex)
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