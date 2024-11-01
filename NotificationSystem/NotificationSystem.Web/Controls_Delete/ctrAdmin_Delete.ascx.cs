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
	public partial class ctrAdmin_Delete : System.Web.UI.UserControl
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
                if ((Page.IsPostBack))
                {
                    //button click to delete form data 

                    if (Request.Form["ctl00$MainContent$ctrAdmin_Delete$btnDelete"] == "Delete")
                        DeleteAdmin();
                }
                else
                {

                    if (m_UserName == "0")
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


        public void DeleteAdmin()
        {
            try
            {
                clsAdmin thisAdmin = new clsAdmin();

                {

                    if (txtusername.Text.Length == 0)
                        return;
                    {
                        var withBlock = thisAdmin;
                        withBlock.UserName = txtusername.Text;
                    }


                }

                try
                {
                    //    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    //    theNotificationSystem.DeleteAdmin(thisAdmin);
                    //    lblResult.Text = "Admin data has been deleted";
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
            txtusername.Text = string.Empty; txtpassword.Text = string.Empty;
            txtfirstname.Text = string.Empty; txtlastname.Text = string.Empty;
            txtemailaddress.Text = string.Empty;
        }
        public void CleanResultControl()
        {
            this.lblResult.Text = string.Empty;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Find.aspx", false);
        }
    }
}