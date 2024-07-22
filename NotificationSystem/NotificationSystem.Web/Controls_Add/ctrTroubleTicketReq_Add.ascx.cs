using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Telerik.Web.UI;
using System.Data.SqlClient;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using System.Net.Http;

    public partial class ctrTroubleTicketReq_Add : System.Web.UI.UserControl
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
        if ((Page.IsPostBack))
        {
            try
            {
                if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Add$btnAdd"] == "Add")
                    AddTroubleTicket();

                else if (Request.Form["ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"] == "Search")
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

                    TroubleTicketReqDataTable tblTroubleTicketReq = (TroubleTicketReqDataTable)theNotificationSystem.GetTroubleTicket(m_TroubleTicketNo);

                    {
                        var withBlock = tblTroubleTicketReq[0];
                        withBlock.AgentID = int.Parse(this.txtAgentID.Text); withBlock.CustomerID = int.Parse(this.txtcustomerid.Text); withBlock.TroubleTicketNo = int.Parse(this.txttroubleticketno.Text);
                        cmbStatus.Text = withBlock.Status;
                        cmbType.Text = withBlock.Type;
                        withBlock.RequestDate = DateTime.Now;
                        withBlock.DueDate = DateTime.Now;
                    }
                }

                PopulateControls();
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

        public void AddTroubleTicket()
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
                    cmbStatus.Text = withBlock.Status; 
                    cmbType.Text = withBlock.Type; 
                    withBlock.DueDate = DateTime.Now; 
                    withBlock.RequestDate = DateTime.Now;


            }
            try

                {

                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.AddTroubleTicket(thisTroubleTicket);
                    lblResult.Text = "Trouble Ticket data has been added";

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
        return;
        }

        public void ClearControls()
        {
            try
            {
            pickRequestDate.Clear();
            cmbStatus.Value = string.Empty;  
            cmbStatus.Text = string.Empty;
            cmbType.Value = string.Empty;
            cmbType.Text = string.Empty;
           
        }


            catch (Exception)
            {
                throw;
            }
        }

	private void PopulateControls()
	{
		clsNotificationSystem theNotificationSystem = new clsNotificationSystem();



        cmbStatus.DataSource = theNotificationSystem.GetStatusList();
        cmbStatus.DataTextField = "Status";
        cmbStatus.DataBind();



        cmbType.DataSource = theNotificationSystem.GetTypeList();
        cmbType.DataTextField = "Type";
        cmbType.DataBind();


    }
	protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TroubleTicketReq_Find.aspx", false);
        }
    }
