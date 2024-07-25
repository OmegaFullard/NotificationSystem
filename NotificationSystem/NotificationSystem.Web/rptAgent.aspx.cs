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
using Microsoft.Reporting.WebForms;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;
using System.Text.RegularExpressions;

namespace NotificationSystem.NotificationSystem.Web
{
	public partial class rptAgent : System.Web.UI.Page
	{
        private clsSearch theSearch = new clsSearch();
        private clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

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
                    theSearch.ReportPath = "~NotificationSystem.Web/rptAgent.rdlc";
                    theSearch.AgentID = ctrAgent_Search.AgentID;
                    ShowAgReport();
                }
            }
        }

        private void ShowAgReport()
        {
            try
            {
                clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

                ReportDataSource ReportDataSource = new ReportDataSource();
                string strTitle = string.Empty;
                AgentDataTable dtReport;    
                
                ReportDataSource.Name = "DataSet1";
          

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(theSearch.ReportPath);

                //if (theNotificationSystem.AgentID.ToString().Length == 0)
                  //  theNotificationSystem.AgentID = int.Parse("xxxxxx");        
                
                dtReport = (AgentDataTable)theNotificationSystem.GetAgent(theSearch.AgentID);
                ReportDataSource.Value = dtReport;


                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource);
                ReportViewer1.LocalReport.Refresh();
            }


            catch (Exception)
            {
                throw;
            }
        }

		protected void ReportViewer1_Load(object sender, EventArgs e)
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