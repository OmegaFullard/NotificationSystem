using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Web.Controls_Add
{
	public partial class ctrAdmin_Add : System.Web.UI.UserControl
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
                    if (Request.Form["ctl00$MainContent$ctrAdmin_Add$btnAdd"] == "Add")
                        AddAdmin();
                }
                else
                    PopulateControls();
            }
            catch (Exception)
			{
                throw;
            }
        }

        public void AddAdmin()
        {
            try
            {
                clsAdmin thisAdmin = new clsAdmin();

                {
                    var withBlock = thisAdmin;
                    if (txtusername.Text.Length == 0)
                        return;


                    withBlock.UserName = txtusername.Text; withBlock.Password = txtpassword.Text; withBlock.First = txtfirstname.Text; withBlock.Last = txtlastname.Text; withBlock.Email = txtemailaddress.Text;
                }

                try
                {
                    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                    theNotificationSystem.AddAdmin(thisAdmin);
                    lblResult.Text = "Admin data has been added";
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        lblResult.Text = "Admin already exist!";
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
        public void PopulateControls()
        {
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
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
            Response.Redirect("Admin_Find.aspx", false);
        }
    }
}