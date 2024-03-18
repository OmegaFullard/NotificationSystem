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
    public partial class Customer_Add : System.Web.UI.Page
    {
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((IsPostBack))
        {
            if (Request.Form["ctl00$MainContent$ctrCustomer_Search$btnSearch"] == "Search")
            {
                ctrCustomer_Search.PopulateSearchControl();
                if (((short)ctrCustomer_Search.CustomerID) == 0)
                    return;
                this.ctrCustomer_Add.ClearControls(); this.ctrCustomer_Add.CustomerID = ctrCustomer_Search.CustomerID;
            }
            else if (Request.Form["ctl00$MainContent$ctrCustomer_Add$btnCreate"] == "Add")
            {
                this.ctrCustomer_Add.AddCustomer();
                if (((short)ctrCustomer_Search.CustomerID) == 0)
                    return;
            }
        }
    }
}
}
