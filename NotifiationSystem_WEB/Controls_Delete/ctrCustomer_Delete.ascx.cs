using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Web.Controls_Delete
{
	public partial class ctrCustomer_Delete : System.Web.UI.UserControl
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
            CustomerDataTable tblCustomer = new CustomerDataTable();
            
            try
            {
                if ((Page.IsPostBack))
                {


                    if (Request.Form["ctl00$MainContent$ctrCustomer_Delete$btnDelete"] == "Delete")
                        DeleteCustomer();
                }
                else
                {
                    if (m_CustomerID == 0)
                        return;
                    tblCustomer = (CustomerDataTable)theNotificationSystem.GetCustomers();


                    if (tblCustomer.Count == 0)
                        return;

                    {
                        var withBlock = tblCustomer[0];

                        withBlock.CustomerID = int.Parse(txtcustomerid.Text); withBlock.AgentID = int.Parse(txtAgentID.Text); withBlock.TroubleTicketNo = int.Parse(txttroubleticketno.Text);
                        this.txtfirstname.Text = withBlock.FirstN; this.txtlastname.Text = withBlock.LastN; withBlock.UserName = txtusername.Text; withBlock.Password = txtpassword.Text;
                        if (!string.IsNullOrEmpty(withBlock.Phone))
                            txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

                        if (!string.IsNullOrEmpty(withBlock.Email))
                        {
                            txtemailaddress.Text = withBlock.Email;
                        }


						if (!string.IsNullOrEmpty(withBlock.Address))
						{
							txtaddress.Text = withBlock.Address;
						}

						if (!string.IsNullOrEmpty(withBlock.City))
						{
							this.txtcity.Text = withBlock.City;
							if (!string.IsNullOrEmpty(withBlock.State))

								   this.txtstate.Text = withBlock.State;
						}
						if (!string.IsNullOrEmpty(withBlock.Zip))

								this.txtzip.Text = withBlock.Zip.Substring(0, 5);
					}

                    this.btnDelete.Enabled = true;
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
        public void DeleteCustomer()
        {
            try
            {
                clsCustomer thisCustomer = new clsCustomer();

                {

                    if (txtcustomerid.Text.Length == 0)
                        return;
                    {
                        var withBlock = thisCustomer;
                        withBlock.CustomerID = int.Parse(txtcustomerid.Text);
                    }


                }

                try
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.DeleteCustomer(thisCustomer);
                    lblResult.Text = "Customer data has been deleted";
                }
                catch (SqlException ex)
                {

                    throw new ApplicationException(ex.Message);
                }


                CleanupControls();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CleanupControls()
        {
            txtcustomerid.Text = string.Empty; txtAgentID.Text = string.Empty; txttroubleticketno.Text = string.Empty; 
            txtfirstname.Text = string.Empty; txtlastname.Text = string.Empty; txtusername.Text = string.Empty; txtpassword.Text = string.Empty;
            txtemailaddress.Text = string.Empty; txtPhoneNumber.Text = string.Empty;
            txtaddress.Text = string.Empty; txtcity.Text = string.Empty; txtstate.Text = string.Empty; txtzip.Text = string.Empty;
        }
        public void CleanResultControl()
        {
            this.lblResult.Text = string.Empty;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_Find.aspx", false);
        }
    }
}