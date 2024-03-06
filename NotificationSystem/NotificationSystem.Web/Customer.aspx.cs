using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;


public partial class Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Page.IsPostBack))
        {
            if (Page.Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
            {
                ctrCustomer_Search.PopulateSearchControl();
                ctrCustomer_Search.CustomerID = ctrCustomer_Search.CustomerID;
            }
        }
    }
}
