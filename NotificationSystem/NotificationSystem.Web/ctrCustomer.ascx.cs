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
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


    public partial class ctrCustomer : System.Web.UI.UserControl
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
            CustomerListDataTable tblCustomer = new CustomerListDataTable();
        int customerID = m_CustomerID;

            try
		{
			if (Request.Form["ctl00$MainContent$ctrCustomer_Search$btnSearch"] == "Search")
				ctrHiddebField.Value = Convert.ToString(m_CustomerID);

			if ((Page.IsPostBack) & this.lblSearchResult.Text.Length > 0)
				tblCustomer = (CustomerListDataTable)theNotificationSystem.GetCustomerListbyID(customerID);


			else

				tblCustomer = (CustomerListDataTable)theNotificationSystem.GetCustomers();


			this.lblSearchResult.Text = tblCustomer.Rows.Count + " Result(s)";
                this.grdCustomers.DataSource = tblCustomer.DefaultView;
                this.grdCustomers.DataBind();

            }

            catch (Exception)
            {
                throw;
            }
        }

        private void grdCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (!(Information.IsNothing(ViewState["columnname"]) | Information.IsNothing(ViewState["direction"])))
                {
                    DataView m_DataView = (DataView)this.grdCustomers.DataSource;

                    if (m_DataView == null)
                    {
                        m_DataView.Sort = ViewState["columnname"].ToString() + " " + ViewState["direction"].ToString();
                        this.grdCustomers.DataSource = m_DataView;
                    }
                }

                this.grdCustomers.PageIndex = e.NewPageIndex;
                this.grdCustomers.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void grdCustomers_Sorting(object sender, GridViewSortEventArgs e)
        {
            try
            {
                DataView m_Dataview = (DataView)grdCustomers.DataSource;

                if (m_Dataview == null)
                {
                    m_Dataview.Sort = e.SortExpression + " " + ConvertSortDirection(e);
                    this.grdCustomers.DataSource = m_Dataview;
                    this.grdCustomers.DataBind();
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
