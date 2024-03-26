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

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Customer_Find : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Page.IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrCustomer_Search$btnSearch"] == "Search")
                {
                    ctrCustomer_Search.PopulateSearchControl();
                    if (((ctrCustomer_Search.CustomerID) == 0))
                        return;
                    // this.ctrCustomer_Find.ClearControls()
                    this.ctrCustomer_Find.CustomerID = ctrCustomer_Search.CustomerID;

                }
            }
        }
    }
}
