using NotificationSystem_Practice.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using NotificationSystem.NotificationSystem.Data.Classes;

public partial class ctrCustomer_Find : System.Web.UI.UserControl
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
		if ((Page.IsPostBack))
		{
			try
			{
				if (((short)m_CustomerID) > 0)
					this.lblCustomerID.Text = "ID" + m_CustomerID;
				if (this.lblCustomerID.Text.Length == 2)
					return;




				clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
				CustomerDataTable tblCustomer = new CustomerDataTable();
					theNotificationSystem.GetCustomerListbyID(Convert.ToInt32(this.lblCustomerID.Text.Replace("ID", "")));
				if (tblCustomer.Count == 0)
					return;

				{
					this.grdCustomer.DataSource = tblCustomer;
					this.grdCustomer.DataBind();


				}
			}
			catch (Exception ex)
			{
				throw;
			}
		}
	}
    }