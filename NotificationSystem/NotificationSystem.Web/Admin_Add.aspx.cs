using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class Admin_Add : System.Web.UI.Page
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
            if ((Page.IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrSearch_Admin$btnSearch"] == "Search")
                {
                    ctrSearch_Admin.PopulateSearchControl();
                    if (ctrSearch_Admin.UserName == "0")
                        return;
                    this.ctrAdmin_Add.ClearControls(); this.ctrAdmin_Add.UserName = ctrSearch_Admin.UserName;
                }
                else if (Request.Form["ctl00$MainContent$ctrAdmin_Add$btnCreate"] == "Add")
                {
                    this.ctrAdmin_Add.AddAdmin();
                    if ((ctrSearch_Admin.UserName) == "0")
					{
                        
					}
                        return;
                }

            }
        }
	}
}