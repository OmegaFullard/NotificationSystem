using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using NotificationSystem.NotificationSystem.Data.Classes;

namespace NotificationSystem.NotificationSystem.Web.Controls_Find
{
	public partial class ctrAdmin_Find : System.Web.UI.UserControl
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
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            AdminDataTable tblAdmin = new AdminDataTable();

            try
            {
                if (Request.Form["ctl00$MainContent$ctrSearch_Admin_Find$btnSearch"] == "Search")
                    this.lblUserName.Text = "ID" + m_UserName;

                if ((Page.IsPostBack) & this.lblUserName.Text.Length > 0)
                    theNotificationSystem.GetAdmin(this.lblUserName.Text.Replace("Name", ""));
                else
                    tblAdmin = (AdminDataTable)theNotificationSystem.GetAdmin(UserName);


                this.lblSearchResult.Text = tblAdmin.Rows.Count.ToString();
                this.grdAdmin.DataSource = tblAdmin.DefaultView;
                this.grdAdmin.DataBind();
            }

            catch (Exception ex)
            {
                clsNotificationSystem_Web SendError = new clsNotificationSystem_Web();
                string NotificationBody = ex.Message + "  " + ex.StackTrace;
                SendError.SendMailMessage(NotificationBody);
                Response.Redirect("ErrorPage.aspx", false);
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
            catch (Exception ex)
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
            catch (Exception ex)
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
                Response.AddHeader("content-disposition", "attachment;filename=Admin_Information.xls");
                Response.Charset = "";
                Response.ContentType = "application/vnd.ms-excel";
                StringWriter sw = new StringWriter();
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                grdAdmin.AllowPaging = false;
                this.grdAdmin.DataBind();

                for (int y = 0; y <= 12; y++)
                    grdAdmin.HeaderRow.Cells[y].Style.Add("background-color", "#cfdbe6");

                for (int x = 0; x <= grdAdmin.Rows.Count - 1; x++)
                {
                    for (int y = 0; y <= 12; y++)
                    {
                        if (x % 2 > 0)
                            grdAdmin.Rows[x].Cells[y].Style.Add("background-color", "#e0ebea");
                    }
                }

                grdAdmin.Attributes.Add("style", "vnd.ms-excel.numberformat:@");
                grdAdmin.RenderControl(hw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }




            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateExcelFiles();
        }

    }
}