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
using System.Data.SqlClient;

public partial class ctrTroubleTicketReq_Update : System.Web.UI.UserControl
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

    public TextBox txtTroubleTicketList { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
        TroubleTicketReqDataTable tblTT = new TroubleTicketReqDataTable();
        try
        {
            if (Page.IsPostBack)
            {

                if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Update$btnUpdate"] == "Update")
                    UpdateTroubleTicket();

                else

                {
                    if (m_TroubleTicketNo > 0)
                        lblResult.Text = "ID" + m_TroubleTicketNo;
                    if (lblResult.Text.Length == 0)
                        return;

                    tblTT = (TroubleTicketReqDataTable)theNotificationSystem.GetTT();
                    if (tblTT.Count == 0)
                        return;
                    {
                        var withBlock = tblTT[0];
                        withBlock.AgentID = int.Parse(this.txtAgentID.Text); withBlock.CustomerID = int.Parse(this.txtcustomerid.Text); withBlock.TroubleTicketNo = int.Parse(this.txttroubleticketno.Text);
                        cmbStatus.Text = withBlock.Status;
                        cmbType.Text = withBlock.Type;
                        withBlock.RequestDate = DateTime.Now;
                        withBlock.DueDate = DateTime.Now;
                    }
                }
            }
            this.btnUpdate.Enabled = true;
        }

        catch (Exception ex)
        {
            clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
            string NotificationBody = ex.Message + "  " + ex.StackTrace;
            SendError.SendMailMessage(NotificationBody);
            Response.Redirect("ErrorPage.aspx", false);
        }
        }
  

    public void ClearControls()
    {
        try
        {
        }


        catch (Exception)
        {
            throw;
        }
    }


    public void UpdateTroubleTicket()
    {
        try
        {
            clsTroubleTicketReq thisTroubleTicket = new clsTroubleTicketReq();

            {
                var withBlock = thisTroubleTicket;
                if (txttroubleticketno.Text.Length == 0)

                    //if (pickRequestDate.SelectedDate == null)
                    //    withBlock.RequestDate = DateTime.Now;
                    //else
                    //    withBlock.RequestDate = (DateTime)pickRequestDate.SelectedDate;
                    if (cmbType.Text == string.Empty)
                        return;

                withBlock.CustomerID = int.Parse(txtcustomerid.Text); withBlock.AgentID = int.Parse(txtAgentID.Text); withBlock.TroubleTicketNo = int.Parse(txttroubleticketno.Text);
                withBlock.Type = cmbType.Text; withBlock.Status = cmbStatus.Text;
                withBlock.DueDate = DateTime.Now; withBlock.RequestDate = DateTime.Now;


            }
            try

            {
                clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                theNotificationSystem.UpdateTroubleTicket(thisTroubleTicket);
                lblResult.Text = "Trouble Ticket data has been updated";

            }
            catch (SqlException ex)
            {

                if (ex.Number == 2627)
                    lblResult.Text = "Ticket already exist!";
                else
                    throw new ApplicationException(ex.Message);

            }

        }
        catch (Exception ex)
        {
            clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
            string NotificationBody = ex.Message + "  " + ex.StackTrace;
            SendError.SendMailMessage(NotificationBody);
            Response.Redirect("ErrorPage.aspx", false);
        }
        PopulateControls();

    }



    private void PopulateControls()
    {
        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();


        this.cmbStatus.DataSource = theNotificationSystem.GetStatusList();
        cmbStatus.DataTextField = "Status";  this.cmbStatus.DataValueField = "Status";
        this.cmbStatus.DataBind();



        this.cmbType.DataSource = theNotificationSystem.GetTypeList();
        this.cmbType.DataTextField = "Type";  this.cmbType.DataValueField = "Type";
        this.cmbType.DataBind();

    }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TroubleTicketReq_Find.aspx", false);
        }
    }
        

