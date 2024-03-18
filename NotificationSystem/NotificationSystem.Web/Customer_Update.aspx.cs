using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Customer_Update : System.Web.UI.Page
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
                if (Request.Form["ctl00$MainContent$ctrCustomer_Search$btnSearch"] == "Search")
                {
                    if (((short)ctrCustomer_Search.CustomerID) == 0)
                        return;
                    this.ctrCustomer_Update.CustomerID = (short)ctrCustomer_Search.CustomerID;
                }
            }
        }
    }
}
