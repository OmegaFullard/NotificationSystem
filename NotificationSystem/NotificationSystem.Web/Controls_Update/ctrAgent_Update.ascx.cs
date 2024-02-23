using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;
using NotificationSystem_Practice.NotificationSystem.Data.Classes;

public partial class ctrAgent_Update : System.Web.UI.UserControl
{
    private Int16 m_AgentID = 0;

    public Int16 AgentID
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

        if (Page.IsPostBack)
        {
            if (m_AgentID > 0)
                this.lblagentid.Text = "ID" + m_AgentID;

            if (this.lblagentid.Text.Length == 2)
                return;

            try
            {
                if (Request.Form["ct100$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    //grdAgents.EditIndex = -1;
                    this.BindGrid();
                    this.lblagentid.Text = "ID" + m_AgentID;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    private void BindGrid()
    {
        Int32 count = 0;
        string result = count.ToString();

        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
        AgentDataTable tblAgent = theNotificationSystem.GetAgentListByID(Replace(this.lblagentid.Text, "ID", ""));
        this.lblSearchResult.Text = tblAgent.Rows.Count.ToString (result + "Result(s)");

        grdAgent.DataSource = tblAgent;
        grdAgent.DataBind();
    }

    private void grdAgent_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        clsAgent thisAgent = new clsAgent();
        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

        if (this.lblagentid.Text.Length == 2)
            return;

        GridViewRow row = (GridViewRow)grdAgent.Rows(e.RowIndex);


        Int32 AgentID = Convert.ToString(row.FindControl("txtAgentID") as TextBox).ToString;
        Int32 TroubleTicketNo = Convert.ToString(row.FindControl("txtTroubleTicketNo") as TextBox).ToString;
        string Title = (row.FindControl("txttitle") as TextBox).Text;
        DateTime StartDate = Convert.ToString(row.FindControl("StartDate") as TextBox).ToString;
        Int32 Salary = Convert.ToString(row.FindControl("txtsalary") as TextBox).ToString;
        string FirstN = (row.FindControl("txtfirstname") as TextBox).Text;
        string LastN = (row.FindControl("txtlastname") as TextBox).Text;
        string Email = (row.FindControl("txtemail") as TextBox).Text;
        string Phone = (row.FindControl("txtphone") as TextBox).Text;
        string Fax = (row.FindControl("txtfax") as TextBox).Text;

        // Dim StartDate As String = IIf((TryCast(row.FindControl("pickStartDate"), Telerik.Web.UI.RadDatePicker)).SelectedDate Is Nothing, String.Empty, (TryCast(row.FindControl("pickStartDate"), Telerik.Web.UI.RadDatePicker)).SelectedDate)
        // thisAgent = CheckCalendarControls(AgentID, StartDate)

        {
            var withBlock = thisAgent;
            withBlock.AgentID = AgentID;
        }

        theNotificationSystem.UpdateAgent(thisAgent);

        grdAgent.EditIndex = -1;
        this.BindGrid();
    }

    private clsAgent CheckCalendarControls(ref Int16 AgentID, DateTime StartDate)
    {
        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
        clsAgent thisAgent = new clsAgent();
        AgentDataTable tblAgent = theNotificationSystem.GetAgentListByID(AgentID);
        AgentRow row = tblAgent(0);

        {
            var withBlock = thisAgent;

            // .StartDate = IIf(StartDate = String.Empty, row.StartDate, StartDate)
            withBlock.AgentID = IIf(AgentID == string.Empty, row.AgentID, AgentID);
        }

        return thisAgent;
    }

    private void grdAgent_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
    }

    protected void grdAgent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdAgent.EditIndex = -1;
        this.BindGrid();
    }

    protected void grdAgent_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdAgent.EditIndex = e.NewEditIndex;
        this.BindGrid();
    }
}
    
