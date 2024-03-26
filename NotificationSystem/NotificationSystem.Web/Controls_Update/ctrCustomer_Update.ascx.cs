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

public partial class ctrCustomer_Update : System.Web.UI.UserControl
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
    protected void Page_Load(object sender, EventArgs e)
    {
        clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
        CustomerDataTable tblCustomer = new CustomerDataTable();
        try
        {
            if (Page.IsPostBack)
            {

                if (Request.Form["ct100$MainContent$ctrCustomer_Update$btnUpdate"] == "Update")
                    UpdateCustomer();
                else
                {
                    if (m_CustomerID > 0)
                        this.lblResult.Text = "ID" + m_CustomerID;

                    if (this.lblResult.Text.Length == 0)
                        return;

                    tblCustomer = (CustomerDataTable)theNotificationSystem.GetCustomers();
                    if (tblCustomer.Count == 0)
                        return;

                    {
                        var withBlock = tblCustomer[0];

                        withBlock.AgentID = int.Parse(this.txtAgentID.Text); withBlock.CustomerID = int.Parse(this.txtcustomerid.Text);
                        withBlock.TroubleTicketNo = int.Parse(txttroubleticketno.Text); this.txtfirstname.Text = withBlock.FirstN; this.txtlastname.Text = withBlock.LastN;
                        withBlock.Address = txtaddress.Text; withBlock.City = txtcity.Text; withBlock.State = txtstate.Text; withBlock.Zip = txtzip.Text;
                        withBlock.UserName = txtusername.Text; withBlock.Password = txtpassword.Text;


                        if (!string.IsNullOrEmpty(withBlock.Phone))
                            txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

                        if (!string.IsNullOrEmpty(withBlock.Email))
                        {
                            txtemailaddress.Text = withBlock.Email;
                        }

                 

                    }

                }
                this.btnUpdate.Enabled = true;
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

        public void UpdateCustomer()
        {
            try
            {
                clsCustomer thisCustomer = new clsCustomer();

                {
                    var withBlock = thisCustomer;
                    if (txtcustomerid.Text.Length == 0)
                        return;


                withBlock.CustomerID = int.Parse(this.txtcustomerid.Text); withBlock.AgentID = int.Parse(txtAgentID.Text); withBlock.TroubleTicketNo = int.Parse(txttroubleticketno.Text); withBlock.FirstN = txtfirstname.Text; withBlock.LastN = txtlastname.Text; withBlock.Email = txtemailaddress.Text; withBlock.Phone = txtPhoneNumber.Text; 
                withBlock.Address = txtaddress.Text; withBlock.City = txtcity.Text; withBlock.State = txtstate.Text; withBlock.Zip = txtzip.Text;
                withBlock.UserName = txtusername.Text; withBlock.Password = txtpassword.Text;
            }

                try
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.UpdateCustomer(thisCustomer);
                    lblResult.Text = "Customer data has been updated";
                }
                catch (SqlException ex)
                {
                    //if (ex.Number == 2627)
                    //    lblResult.Text = "Customer already exist!";
                    //else
                    //    throw new ApplicationException(ex.Message);
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Customer_Find.aspx", false);
    }
}
      
    

