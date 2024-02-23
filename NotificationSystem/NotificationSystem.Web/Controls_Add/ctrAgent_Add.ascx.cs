using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Telerik.Web.UI;
using System.Data.SqlClient;
using NotificationSystem_Practice.NotificationSystem.Data.Classes;

public partial class ctrAgent_Add : System.Web.UI.UserControl
{

    private SqlDataReader dr;

    private int m_AgentID = 0;

    public int AgentID
    {
        get
        {
            return m_AgentID;
        }
        set
        {
            m_AgentID = value;
        }
    }


    public TextBox txtAgentList { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void AddAgent()
    {
        try
        {
            clsAgent thisAgent = new clsAgent();

            {
                var withBlock = thisAgent;
                withBlock.AgentID = txtAgentID; withBlock.Title = txttitle.Text; withBlock.FirstN = txtfirstname.Text; withBlock.LastN = txtlastname.Text; withBlock.Email = txtemailaddress.Text; withBlock.Phone = txtPhoneNumber.Text; withBlock.Fax = txtFaxNumber.Text; withBlock.StartDate = txtStartDate.Text; withBlock.Salary = txtSalary.Text;

                if (withBlock.AgentID.Length == 0 | withBlock.TroubleTicketNo.Length == 0)
                    return;
            }

            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            m_AgentID = theNotificationSystem.AddAgent(thisAgent);


            this.lblAgentID.Text = "ID" + m_AgentID;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public void ClearControls()
    {
        try
        {
        }


        catch (Exception ex)
        {
            throw;
        }
    }
    private void PopulateControls()
    {
        var AgentID = Request.QueryString["num"];
        try
        {
            clsNotificationSystem theNotificationSystem = new clsNotificationSystem();

            if (true)
            {
                txtfirstname.Text = Convert.ToString(dr["FirstN"]);
                txtlastname.Text = Convert.ToString(dr["LastN"]);
                txtemailaddress.Text = Convert.ToString(dr["Email"]);
                txtPhoneNumber.Text = Convert.ToString(dr["Phone"]);
                txtFaxNumber.Text = Convert.ToString(dr["Fax"]);
                txttitle.Text = Convert.ToString(dr["Title"]);
                txtSalary.Text = Convert.ToString(dr["Salary"]);
                txtStartDate.Text = Convert.ToString(dr["StartDate"]);
                txtAgentID.Text = Convert.ToString(dr["AgentID"]);
            }
        }
        catch (Exception ex)
        {
        }
    }
}
