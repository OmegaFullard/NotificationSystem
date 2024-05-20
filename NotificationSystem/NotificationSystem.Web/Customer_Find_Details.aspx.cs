using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class Customer_Find_Details : System.Web.UI.Page
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
				if ((Request.QueryString["Customer"] == null))
					return;

				string[] arrCustomers = Request.QueryString["customer"].Split(Convert.ToChar(":"));
				CustomerID = int.Parse(arrCustomers[0]);
				if (CustomerID == 0)
					return;

				tblCustomer = (CustomerDataTable)theNotificationSystem.GetCustomerListbyID(CustomerID);
				if (tblCustomer.Count == 0)
					return;

				{
					var withBlock = tblCustomer[0];
					withBlock.CustomerID = int.Parse(this.txtCustomerID.Text); withBlock.AgentID = int.Parse(this.txtAgentID.Text); withBlock.TroubleTicketNo = int.Parse(this.txttroubleticketno.Text);
					this.txtaddress.Text = withBlock.Address; this.txtcity.Text = withBlock.City; this.txtstate.Text = withBlock.State; this.txtzip.Text = withBlock.Zip;
					this.txtfirstname.Text = withBlock.FirstN; this.txtlastname.Text = withBlock.LastN;


					if (!string.IsNullOrEmpty(withBlock.Phone))
						txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

					if (!string.IsNullOrEmpty(withBlock.Email))
					{
						txtEmailAddress.Text = withBlock.Email;
					}

				}
			}





			catch (Exception)
			{
			}
		}

	}
}
