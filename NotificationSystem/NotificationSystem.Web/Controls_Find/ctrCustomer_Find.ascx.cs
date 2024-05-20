using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using NotificationSystem.NotificationSystem.Data.Classes;
using Microsoft.VisualBasic;
using System.Data;
using System.IO;

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
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            CustomerDataTable tblCustomer = new CustomerDataTable();
		try 
        {
            if (Request.Form["ctl00$MainContent$ctrSearch_Customer_Find$btnSearch"] == "Search")
                this.lblCustomerID.Text = "ID" + m_CustomerID;

            if ((Page.IsPostBack) & this.lblCustomerID.Text.Length > 0)
                theNotificationSystem.GetCustomerListbyID(Convert.ToInt32(this.lblCustomerID.Text.Replace("ID", "")));

           else
                    tblCustomer = (CustomerDataTable)theNotificationSystem.GetCustomers();


                this.lblSearchResult.Text = tblCustomer.Rows.Count.ToString();
                this.grdCustomer.DataSource = tblCustomer.DefaultView;
                this.grdCustomer.DataBind();
            }


				catch (Exception ex)
				{

                clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
                string NotificationBody = ex.Message + "  " + ex.StackTrace;
                SendError.SendMailMessage(NotificationBody);
                Response.Redirect("ErrorPage.aspx", false);
                }
			}
        private void grdCustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (!(Information.IsNothing(ViewState["columnname"]) | Information.IsNothing(ViewState["direction"])))
                {
                    DataView m_DataView = (DataView)this.grdCustomer.DataSource;

                    if (m_DataView == null)
                    {
                        m_DataView.Sort = ViewState["columnname"].ToString() + " " + ViewState["direction"].ToString();
                        this.grdCustomer.DataSource = m_DataView;
                    }
                }

                this.grdCustomer.PageIndex = e.NewPageIndex;
                this.grdCustomer.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void grdCustomer_Sorting(object sender, GridViewSortEventArgs e)
        {
            try
            {
                DataView m_Dataview = (DataView)grdCustomer.DataSource;

                if (m_Dataview == null)
                {
                    m_Dataview.Sort = e.SortExpression + " " + ConvertSortDirection(e);
                    this.grdCustomer.DataSource = m_Dataview;
                    this.grdCustomer.DataBind();
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
        public void CreateExcelFiles()
        {
            try
            {
                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment;filename=Agent_Information.xls");
                Response.Charset = "";
                Response.ContentType = "application/vnd.ms-excel";
                StringWriter sw = new StringWriter();
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                grdCustomer.AllowPaging = false;
                this.grdCustomer.DataBind();

                for (int y = 0; y <= 12; y++)
                    grdCustomer.HeaderRow.Cells[y].Style.Add("background-color", "#cfdbe6");

                for (int x = 0; x <= grdCustomer.Rows.Count - 1; x++)
                {
                    for (int y = 0; y <= 12; y++)
                    {
                        if (x % 2 > 0)
                            grdCustomer.Rows[x].Cells[y].Style.Add("background-color", "#e0ebea");
                    }
                }

                grdCustomer.Attributes.Add("style", "vnd.ms-excel.numberformat:@");
                grdCustomer.RenderControl(hw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }




            catch (Exception)
            {
                throw;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateExcelFiles();
        }
    }

