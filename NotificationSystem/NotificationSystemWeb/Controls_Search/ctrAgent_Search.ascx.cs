﻿using System;
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



    public partial class ctrAgent_Search : System.Web.UI.UserControl
    {

	public int m_AgentID = 0;

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

        }

        public void PopulateSearchControl()
        {
            m_AgentID = int.Parse(this.txtagentid.Text);
       
        }
    }