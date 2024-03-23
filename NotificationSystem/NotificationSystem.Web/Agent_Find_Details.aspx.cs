using NotificationSystem.NotificationSystem.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Web
{
    public partial class Agent_Find_Details : System.Web.UI.Page
    {
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


        protected void Page_Load(object sender, EventArgs e)
        {

            //syntax errors 3/23/24
        //    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
        //    AgentDataTable tblAgent = new AgentDataTable();

        //    try
        //    {
        //        if ((Request.QueryString["Department"] == null))
        //            return;

        //        string[] arrAgents = Request.QueryString["agent"].Split(":");
        //        AgentID = arrAgents[0];
        //        if (AgentID.Length == 0)
        //            return;

        //        tblAgent = theNotificationSystem.GetAgentByID(AgentID);
        //        if (tblAgent.Count == 0)
        //            return;

        //        {
        //            var withBlock = tblAgent[0];
        //            this.txttroubleticketno.Text = withBlock.TroubleTickeNo; this.txttitle.Text = withBlock.Title; this.txtSalary.Text = withBlock.Salary; if (withBlock.IsTroubleTickeNoNull)
        //                this.txttroubleticketno.Text = withBlock.TroubleTickeNo;

        //            if (withBlock.IsPhoneNull)
        //                txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

        //            if (withBlock.IsEmailNull)
        //            {
        //                txtEmailAddress.Text = withBlock.Email;
        //            }

        //            if (!withBlock.IsFaxNull)
        //                txtFaxNumber.Text = withBlock.Fax.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
        //        }
        //    }





        //    catch (Exception ex)
        //    {
        //    }
        }
    }
    }
