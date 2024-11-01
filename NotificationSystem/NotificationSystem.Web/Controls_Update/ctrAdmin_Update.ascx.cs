using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Web.Controls_Update
{
	public partial class ctrAdmin_Update : System.Web.UI.UserControl
	{

		private string m_UserName = string.Empty;

		public string UserName
		{
			get
			{
				return m_UserName;
			}
			set
			{
				m_UserName = value;
			}
		}
		protected void Page_Load(object sender, EventArgs e)
		{
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            AdminDataTable tblAdmin = new AdminDataTable();
            try
            {
                if (Page.IsPostBack)
                {

                    if (Request.Form["ct100$MainContent$ctrAdmin_Update$btnUpdate"] == "Update")
                        UpdateAdmin();
                    else
                    {
                        if (m_UserName == "0")
                            lblResult.Text = "ID" + m_UserName;

                        if (lblResult.Text.Length == 0)
                            return;

                        tblAdmin = (AdminDataTable)theNotificationSystem.GetAdmins();
                        if (tblAdmin.Count == 0)
                            return;

                        {
                            var withBlock = tblAdmin[0];

                        

                            withBlock.UserName = txtusername.Text; withBlock.Password = txtpassword.Text; withBlock.First = txtfirstname.Text; withBlock.Last = txtlastname.Text; withBlock.Email = txtemailaddress.Text;


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

        public void UpdateAdmin()
        {
            try
            {
                clsAdmin thisAdmin = new clsAdmin();

                {
                    var withBlock = thisAdmin;
                    if (txtusername.Text.Length == 0)
                        return;


                    withBlock.First = txtfirstname.Text; withBlock.Last = txtlastname.Text; withBlock.Email = txtemailaddress.Text;

                    withBlock.UserName = txtusername.Text; withBlock.Password = txtpassword.Text;
                }

                try
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.UpdateAdmin(thisAdmin);
                    lblResult.Text = "Admin data has been updated";
                }
                catch (SqlException)
                {
                    //if (ex.Number == 2627)
                    //    lblResult.Text = "Admin already exist!";
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
            PopulateControls();


        }

        private void PopulateControls()
        {
            //clsNotificationSystem theNotificationSystem = new clsNotificationSystem();


            //cmbStates.DataSource = theNotificationSystem.GetStatesList();
            //cmbStates.DataTextField = "State";
            //cmbStates.DataBind();
            //cmbStates.Text = "PA";



        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Find.aspx", false);
        }
    }
}