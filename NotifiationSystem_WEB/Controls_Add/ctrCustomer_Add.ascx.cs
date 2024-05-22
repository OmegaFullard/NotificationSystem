using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
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
using System.Net.Http;


    public partial class ctrCustomer_Add : System.Web.UI.UserControl
    {

        private int m_CustomerID = 0;

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

        public TextBox txtCustomerList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            CustomerDataTable tblAgent = new CustomerDataTable();
            var client = new HttpClient();
            try
            {
                if ((Page.IsPostBack))
                {


                    if (Request.Form["ctl00$MainContent$ctrCustomer_Add$btnAdd"] == "Add")
                        AddCustomer();
                }
                else
                {
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        public void AddCustomer()
        {
            try
            {
                clsCustomer thisCustomer = new clsCustomer();

                {
                    var withBlock = thisCustomer;
                    if (txtcustomerid.Text.Length == 0)
                        return;

                    withBlock.CustomerID = int.Parse(txtcustomerid.Text); withBlock.AgentID = int.Parse(txtAgentID.Text); withBlock.TroubleTicketNo = int.Parse(txttroubleticketno.Text); withBlock.FirstN = txtfirstname.Text; withBlock.LastN = txtlastname.Text; withBlock.Email = txtemailaddress.Text; withBlock.Phone = txtPhoneNumber.Text; withBlock.Address = txtaddress.Text; withBlock.City = txtcity.Text; withBlock.State = txtstate.Text; withBlock.Zip = txtzip.Text;
                withBlock.UserName = txtusername.Text; withBlock.Password = txtpassword.Text;

            }
                try

                {

                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.AddCustomer(thisCustomer);
                    lblResult.Text = "Customer data has been added";

                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        lblResult.Text = "Customer already exist!";
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
        }

    private void PopulateControls()
	{

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
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_Find.aspx", false);
        }
    }
    
