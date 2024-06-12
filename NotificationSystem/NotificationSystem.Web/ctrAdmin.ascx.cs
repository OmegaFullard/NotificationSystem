using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;
using Microsoft.VisualBasic;
using System.Data;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class ctrAdmin : System.Web.UI.UserControl
	{
        private string m_UserName = string.Empty;
        private string m_Password = string.Empty;

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
             public string Password
        {
            get
            {
                return m_Password;
            }
            set
            {
                m_Password = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
		{
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            AdminDataTable tblGetAdmin = new AdminDataTable();


            try
            {

                if (Request.Form["ctl00$MainContent$ctrAdmin_Search$btnSearch"] == "Search")
                    ctrHiddebField.Value = Convert.ToString(m_UserName);


                if ((Page.IsPostBack) & this.lblSearchResult.Text.Length > 0)
                    tblGetAdmin = (AdminDataTable)theNotificationSystem.GetAdmin(m_UserName);

                this.lblSearchResult.Text = tblGetAdmin.Rows.Count + " Result(s)";
                this.grdAdmin.DataSource = tblGetAdmin.DefaultView;
                this.grdAdmin.DataBind();
            }

            catch (Exception)
            {
                throw;
            }
        }

        private void grdAdmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (!(Information.IsNothing(ViewState["columnname"]) | Information.IsNothing(ViewState["direction"])))
                {
                    DataView m_DataView = (DataView)this.grdAdmin.DataSource;

                    if (m_DataView == null)
                    {
                        m_DataView.Sort = ViewState["columnname"].ToString() + " " + ViewState["direction"].ToString();
                        this.grdAdmin.DataSource = m_DataView;
                    }
                }

                this.grdAdmin.PageIndex = e.NewPageIndex;
                this.grdAdmin.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void grdAdmin_Sorting(object sender, GridViewSortEventArgs e)
        {
            try
            {
                DataView m_Dataview = (DataView)grdAdmin.DataSource;

                if (m_Dataview == null)
                {
                    m_Dataview.Sort = e.SortExpression + " " + ConvertSortDirection(e);
                    this.grdAdmin.DataSource = m_Dataview;
                    this.grdAdmin.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string ConvertSortDirection(System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            ViewState.Add("columnname", e.SortExpression);

            if ((ViewState["direction"] == null))
                ViewState.Add("direction", "asc");
            else
                ViewState["direction"] = Interaction.IIf(ViewState["direction"].ToString().ToLower() == "desc", "asc", "desc");

            return ViewState["direction"].ToString();
        }
    }
}
