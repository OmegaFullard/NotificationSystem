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
    public partial class ctrCustomer_Update : System.Web.UI.UserControl
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
                if (m_CustomerID > 0)
                    this.lblcustomerid.Text = "ID" + m_CustomerID;

                if (this.lblcustomerid.Text.Length == 2)
                    return;

                try
                {
                    if (Request.Form["ct100$MainContent$ctrCustomer_Search$btnSearch"] == "Search")
                    {
                        grdCustomers.EditIndex = -1;
                        this.BindGrid();
                        this.lblcustomerid.Text = "ID" + m_CustomerID;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void BindGrid()
        {
            int count = 0;
            string result = count.ToString();

            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            CustomerDataTable tblCustomer = (CustomerDataTable)theNotificationSystem.GetCustomers();
            this.lblSearchResult.Text = tblCustomer.Rows.Count.ToString(result + "Result(s)");

            grdCustomers.DataSource = tblCustomer;
            grdCustomers.DataBind();
        }

        private void grdCustomers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            clsCustomer thisCustomer = new clsCustomer();
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

            if (this.lblcustomerid.Text.Length == 2)
                return;

            GridViewRow row = (GridViewRow)grdCustomers.Rows[e.RowIndex];

            int CustomerID = Convert.ToInt32((row.FindControl("txtCustomerID") as TextBox)?.Text);
            int AgentID = Convert.ToInt32((row.FindControl("txtAgentID") as TextBox)?.Text);
            int TroubleTicketNo = Convert.ToInt32((row.FindControl("txtTroubleTicketNo") as TextBox)?.Text);
            string FirstN = (row.FindControl("txtfirstname") as TextBox).Text;
            string LastN = (row.FindControl("txtlastname") as TextBox).Text;
            string Email = (row.FindControl("txtemail") as TextBox).Text;
            string Phone = (row.FindControl("txtphone") as TextBox).Text;
            string Address = (row.FindControl("txtaddress") as TextBox).Text;
            string City = (row.FindControl("txtcity") as TextBox).Text;
            string State = (row.FindControl("txtstate") as TextBox).Text;
            string Zip = (row.FindControl("txtzip") as TextBox).Text;


            {
                var withBlock = thisCustomer;
                withBlock.CustomerID = CustomerID;
            }

            theNotificationSystem.UpdateCustomer(thisCustomer);

            grdCustomers.EditIndex = -1;
            this.BindGrid();
        }



        private void grdCustomers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
        }

        protected void grdCustomers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdCustomers.EditIndex = -1;
            this.BindGrid();
        }

        protected void grdCustomers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdCustomers.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }
    }
}
