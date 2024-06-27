using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem.NotificationSystem.Data.xsReports;

namespace NotificationSystem.NotificationSystem.Data.Classes
{
	class clsReports
	{


		public DataTable GetAgReport()
		{
			try
			{
				AgentTableAdapter adpAgents = new AgentTableAdapter();
				AgentDataTable tblAgent = adpAgents.GetData();

				return tblAgent;
			}
			catch (Exception)
			{
				throw;
			}
		}
		public DataTable GetAgentByAgentID(int AgentID)
		{
			try
			{
				AgentTableAdapter adpAgents = new AgentTableAdapter();
				AgentDataTable tblAgent = adpAgents.GetDataByAgentID(AgentID);

				return tblAgent;
			}
			catch (Exception)
			{
				throw;
			}
		}


		public DataTable GetCustReport()
		{
			try
			{
				CustomerTableAdapter adpCustomers = new CustomerTableAdapter();
				CustomerDataTable tblCustomer = adpCustomers.GetData();

				return tblCustomer;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public DataTable GetCustomerByCustomerID(int CustomerID)
		{
			try
			{
				CustomerTableAdapter adpCustomers = new CustomerTableAdapter();
				CustomerDataTable tblCustomer = adpCustomers.GetDataByCustomerID(CustomerID);

				return tblCustomer;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
