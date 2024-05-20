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
using NotificationSystem.NotificationSystem.Data;
using NotificationSystem.NotificationSystem.Data.Classes;
using NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem.NotificationSystem.Data.xsReports;
using Microsoft.Reporting.WebForms;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using System.Text.RegularExpressions;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class rptAgent : System.Web.UI.Page
	{
        
        private clsSearch theSearch = new clsSearch();
        public bool IsNumeric(string value)
		{
            return value.All(char.IsNumber);
		}
        protected void Page_Load(object sender, EventArgs e)
		{
            if ((Page.IsPostBack))
            {
                if (Request.Form["ctl00$MainContent$ctrAgent_Search$btnSearch"] == "Search")
                {
                    ctrAgent_Search.PopulateSearchControl();
                    theSearch.ReportPath = "rptAgent.rdlc";
                    theSearch.AgentID = ctrAgent_Search.AgentID;
                    ShowReport();
                }
            }
        }

        private void ShowReport()
        {
            try
            {
                clsReports theNotificationSystem = new clsReports();

                ReportDataSource ReportDataSource = new ReportDataSource();
                string strTitle = string.Empty;
                Data.xsReports.AgentDataTable dtReport;

                ReportDataSource.Name = "DataSet1";
                ReportDataSource.Name = "DataSet2";
                ReportDataSource.Name = "DataSet3";

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Page.Server.MapPath(theSearch.ReportPath);

                if (theSearch.AgentID.ToString().Length == 0)
                {
                    //theSearch.AgentID = "XXXXXX";


                    int numAgentID = (theSearch.AgentID);
                    dtReport = (Data.xsReports.AgentDataTable)theNotificationSystem.GetAgentByAgentID(numAgentID);


                    //strTitle = "Agent Report: " + theSearch.TroubleTicketNo + " Activity by Agent ID ";



                    ReportDataSource.Value = dtReport;
                    //ReportParameter param1 = new ReportParameter("Title", strTitle);
                    //ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { param1 });

                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(ReportDataSource);
                    ReportViewer1.LocalReport.Refresh();
                }
            }


            catch (Exception)
            {
                throw;
            }
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            // string exportOption = "Excel";
            // string exportOption = "Word";
            string exportOption = "PDF";
            RenderingExtension extension = ReportViewer1.LocalReport.ListRenderingExtensions().ToList().Find(x => x.Name.Equals(exportOption, StringComparison.CurrentCultureIgnoreCase));
            if (extension != null)
            {
                System.Reflection.FieldInfo fieldInfo = extension.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                fieldInfo.SetValue(extension, false);
            }
        }


    }

}