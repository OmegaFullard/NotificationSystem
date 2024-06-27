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
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;
using static NotificationSystem.NotificationSystem.Data.NotificationSystem;

namespace NotificationSystem.NotificationSystem.Data.Classes
{
    public class clsNotificationSystem
    {
        public bool Customer { get; private set; }
        public bool Agent { get; private set; }
		public bool TroubleTicket { get; private set; }

        public bool TroubleTicketNo { get; private set; }
        public bool Title { get; private set; }
        public bool StartDate { get; private set; }

        public bool Salary { get; private set; }
		public bool Admin { get; private set; }

        private string m_ReportPath = string.Empty;
        private DateTime m_RequestDate;
        private DateTime m_StartDate;
        private int m_AgentID = 0;
        private int m_CustomerID = 0;

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
        //public object CustomerID { get; internal set; }
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

        public string ReportPath
        {
            get
            {
                return m_ReportPath;
            }
            set
            {
                m_ReportPath = value;
            }
        }

        //public DataTable GetCustomersList()
        //      {
        //          try
        //          {
        //              CustomerTableAdapter adpCustomerList = new CustomerTableAdapter();
        //              NotificationSystem.CustomerDataTable tblCustomerList = adpCustomerList.GetData();

        //              return tblCustomerList;
        //          }

        //          catch (Exception)
        //	{
        //              throw;
        //          }
        //      }

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

        public DataTable GetCustomer(int CustomerID)
        {
            try
            {
                CustomerTableAdapter adpCustomerList = new CustomerTableAdapter();
                CustomerDataTable tblCustomerList = adpCustomerList.GetDataByID(CustomerID);
        
            return tblCustomerList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetCustomers()
        {
            try
            {
                CustomerTableAdapter adpCustomer = new CustomerTableAdapter();
                NotificationSystem.CustomerDataTable tblCustomer = adpCustomer.GetData();

                return tblCustomer;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetCustomerByTroubleTicket(ref int TroubleTicketNo)
        {
            try
            {
                CustomerTableAdapter adpCustomer = new CustomerTableAdapter();
                NotificationSystem.CustomerDataTable tblCustomer = adpCustomer.GetDataByTroubleTicket(TroubleTicketNo);

                return tblCustomer;
            }

            catch (Exception)
            {
                throw;
            }
        }



        public void UpdateCustomer(clsCustomer thisCustomer)
        {
            CustomerTableAdapter adpCustomer = new CustomerTableAdapter();


            try
            {
                {
                    var withBlock = thisCustomer;
                    adpCustomer.Update(withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip, withBlock.UserName, withBlock.Password, withBlock.Original_CustomerID);
                }
            }

            catch (Exception)
            {
                throw;
            }
        }


        public int AddCustomer(clsCustomer thisCustomer)
        {

			//add CustomerID to table and save


			CustomerTableAdapter adpCustomer = new CustomerTableAdapter();
            GetCustomerIDTableAdapter adpGetCustomerID = new GetCustomerIDTableAdapter();

			NotificationSystem.CustomerDataTable tblCustomer = new NotificationSystem.CustomerDataTable();

			Customer = false;


			try
			{
				{
					var withBlock = thisCustomer;
					adpCustomer.Insert(withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Phone, withBlock.Email, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip, withBlock.UserName, withBlock.Password);
				}

                GetCustomerIDDataTable tblGetCustomerID = adpGetCustomerID.GetData();
                GetCustomerIDRow row = tblGetCustomerID[0];
                return row.CustomerID;

            }
			catch (Exception)
			{
				throw;
			}
		

		}

        public int GetCustomerID()
        {
            GetCustomerIDTableAdapter adpGetCustomerID = new GetCustomerIDTableAdapter();

            try
            {
                GetCustomerIDDataTable tblGetCustomerID = adpGetCustomerID.GetData();
                GetCustomerIDRow row = tblGetCustomerID[0];

                return row.CustomerID;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //public void DeleteCustomer(clsCustomer thisCustomer)
        //{
        //    CustomerTableAdapter adpCustomer = new CustomerTableAdapter();

        //    try
        //    {
        //        {
        //            var withBlock = thisCustomer;
        //            adpCustomer.DeleteQuery(withBlock.CustomerID);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public void GetbyUserPW(string username, string password)
        {
            try
            {
                CustomerTableAdapter adpCustomer = new CustomerTableAdapter();
                CustomerDataTable tblCustomer = adpCustomer.GetDataByUserPW(username, password);
                CustomerRow row = tblCustomer[0];
                return;

            }
            catch (Exception)
            {
                throw;
            }
        }


        



        public DataTable GetTroubleTicketList()
        {
            try
            {
                TroubleTicketListTableAdapter adpTroubleTicketList = new TroubleTicketListTableAdapter();
                NotificationSystem.TroubleTicketListDataTable tblTroubleTicketList = adpTroubleTicketList.GetData();

                return tblTroubleTicketList;
            }

            catch (Exception)
            {
                throw;
            }
        }

		public int GetTroubleTicketByNo(int TroubleTicketNo)
		{
			try
			{
				TroubleTicketListTableAdapter adpTroubleTicketList = new TroubleTicketListTableAdapter();
				TroubleTicketListDataTable tblTroubleTicketList = adpTroubleTicketList.GetDataByTroubleTicketNo(TroubleTicketNo);
				TroubleTicketListRow row = tblTroubleTicketList[0];
				return row.TroubleTicketNo;

			}
			catch (Exception)
			{
				throw;
			}
		}

		public DataTable GetTroubleTicket()
        {
            try
            {
                TroubleTicketReqTableAdapter adpTroubleTicketReq = new TroubleTicketReqTableAdapter();
                NotificationSystem.TroubleTicketReqDataTable tblTroubleTicketReq = adpTroubleTicketReq.GetData();

                return tblTroubleTicketReq;
            }

            catch (Exception)
            {
                throw;
            }
        }

		public DataTable GetTroubleTicket(int TroubleTicketNo)
		{
			try
			{
				TroubleTicketReqTableAdapter adpTroubleTicketReq = new TroubleTicketReqTableAdapter();
				NotificationSystem.TroubleTicketReqDataTable tblTroubleTicketReq = adpTroubleTicketReq.GetDataByTroubleTicketNo(TroubleTicketNo);

				return tblTroubleTicketReq;
			}

			catch (Exception)
			{
				throw;
			}
		}



		public void UpdateTroubleTicket(clsTroubleTicketReq thisTroubleTicket)
        {
            TroubleTicketReqTableAdapter adpTroubleTicket = new TroubleTicketReqTableAdapter();


            try
            {
                {
					var withBlock = thisTroubleTicket;
					adpTroubleTicket.Update(withBlock.CustomerID, withBlock.AgentID, withBlock.Status, withBlock.Type, withBlock.DueDate, withBlock.RequestDate, withBlock.TroubleTicketNo);
				}
            }

            catch (Exception)
            {
                throw;
            }
        }


        public void AddTroubleTicket(clsTroubleTicketReq thisTroubleTicket)
        {

            //add TroubleTicket to table and save


            TroubleTicketReqTableAdapter adpTroubleTicketReq = new TroubleTicketReqTableAdapter();

            NotificationSystem.TroubleTicketReqDataTable tblTroubleTicketReq = new NotificationSystem.TroubleTicketReqDataTable();
            TroubleTicket = false;


            try
            {
                {
					var withBlock = thisTroubleTicket;
					adpTroubleTicketReq.Insert(withBlock.CustomerID, withBlock.AgentID, withBlock.Status, withBlock.Type, withBlock.DueDate, withBlock.RequestDate);
				}



            }
            catch (Exception)
            {
                throw;
            }
            return;

        }

        public int GetTroubleTicketNo()
        {
            GetTroubleTicketNoTableAdapter adpTroubleTicketNumber = new GetTroubleTicketNoTableAdapter();

            try
            {
                GetTroubleTicketNoDataTable tblGetTroubleTicketNo = adpTroubleTicketNumber.GetData();
                GetTroubleTicketNoRow row = tblGetTroubleTicketNo[0];

                return row.TroubleTicketNo;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable GetTypeList()
		{
			DataSet ds = new DataSet();
			DataTable dt = new DataTable("GetData");
            DataRow dr;



			dt.Columns.Add("ID", Type.GetType("System.String")).DefaultValue = string.Empty;
			dt.Columns.Add("Type", Type.GetType("System.String")).DefaultValue = string.Empty;

            // Create and populate rows
            // DataRow dr = dt.NewRow();

            dr = dt.NewRow();
            dr["ID"] = "0"; dr["Type"] = "Incident";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = "1"; dr["Type"] = "Task";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = "2"; dr["Type"] = "Problem";
            dt.Rows.Add(dr);

            return dt;
		}


        public DataTable GetStatusList()
		{
			DataSet ds = new DataSet();
			DataTable dt = new DataTable("GetData");
            DataRow dr;

			//Add columns with appropriate data types


			dt.Columns.Add("ID", Type.GetType("System.String")).DefaultValue = 0;
			dt.Columns.Add("Status", Type.GetType("System.String")).DefaultValue = string.Empty;

            //Create and populate rows

            //DataRow dr = dt.NewRow();

            dr = dt.NewRow();
            dr["ID"] = "0"; dr["Status"] = "Open";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = "1"; dr["Status"] = "Pending";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = "2"; dr["Status"] = "Resolved";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["ID"] = "4"; dr["Status"] = "Closed";
            dt.Rows.Add(dr);


            return dt;
		}

        public DataTable GetStatesList()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("GetData");
            DataRow dr;

            dt.Columns.Add("State", Type.GetType("System.String")).DefaultValue = string.Empty;

            dr = dt.NewRow(); dr["State"] = "AL"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "AK"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "AZ"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "AR"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "CA"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "CO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "CT"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "DE"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "DC"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "FL"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "GA"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "ID"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "IL"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "IN"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "IA"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "KS"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "KY"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "LA"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "Me"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "MD"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "MA"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "MI"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "MN"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "MS"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "MO"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "MT"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "NE"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "NV"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "NH"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "NJ"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "NM"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "NY"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "NC"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "ND"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "OH"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "OK"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "OR"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "PA"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "PR"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "RI"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "SC"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "SD"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "TN"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "TX"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "UT"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "VI"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "VA"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "WA"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["State"] = "WV"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "WI"; dt.Rows.Add(dr); dr = dt.NewRow(); dr["State"] = "WY"; dt.Rows.Add(dr);


            return dt;
        }


        public DataTable GetAgentList()
        {
            try
            {
                AgentTableAdapter adpAgentList = new AgentTableAdapter();
                NotificationSystem.AgentDataTable tblAgentList = adpAgentList.GetData();

                return tblAgentList;
            }

            catch (Exception)
            {
                throw;
            }
        }



        public DataTable GetAgent(int AgentID)
        {
            try
            {
                AgentTableAdapter adpAgentList = new AgentTableAdapter();
                AgentDataTable tblGetAgent = adpAgentList.GetDataByAgentID(AgentID);

                return tblGetAgent;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable GetAgents()
        {
            try
            {
                AgentTableAdapter adpAgent = new AgentTableAdapter();
                NotificationSystem.AgentDataTable tblAgent = adpAgent.GetData();

                return tblAgent;
            }

            catch (Exception)
            {
                throw;
            }
        }


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


        public DataTable GetAgentByTicket(ref int TroubleTicketNo)
        {
            try
            {
                AgentTableAdapter adpAgent = new AgentTableAdapter();
                NotificationSystem.AgentDataTable tblAgent = adpAgent.GetDataByTicket(TroubleTicketNo);

                return tblAgent;
            }

            catch (Exception)
            {
                throw;
            }
        }



		public int AddAgent(clsAgent thisAgent)
		{

			AgentTableAdapter adpAgent = new AgentTableAdapter();
			GetAgentIDTableAdapter adpGetAgentID = new GetAgentIDTableAdapter();

			NotificationSystem.AgentDataTable tblAgent = new NotificationSystem.AgentDataTable();
			Agent = false;

			try
			{

				{
					var withBlock = thisAgent;
					adpAgent.InsertQuery(withBlock.TroubleTicketNo, withBlock.Title, withBlock.Salary, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Fax);


				}

				GetAgentIDDataTable tblGetAgentID = adpGetAgentID.GetData();
				GetAgentIDRow row = tblGetAgentID[0];
				return row.AgentID;


			}
			catch (Exception)
			{
				throw;
			}

		}


		public int GetAgentID()
        {
            GetAgentIDTableAdapter adpGetAgentID = new GetAgentIDTableAdapter();

            try
            {
                GetAgentIDDataTable tblGetAgentID = adpGetAgentID.GetData();
                GetAgentIDRow row = tblGetAgentID[0];

                return row.AgentID;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void UpdateAgent(clsAgent thisAgent)
        {
            AgentTableAdapter adpAgent = new AgentTableAdapter();


            try
            {
                {
                    var withBlock = thisAgent;
                    adpAgent.UpdateQuery(withBlock.TroubleTicketNo, withBlock.Title, withBlock.Salary, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Fax, withBlock.Original_AgentID);
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
        //public void DeleteAgent(clsAgent thisAgent)
        //{
        //    AgentTableAdapter adpAgent = new AgentTableAdapter();

        //    try
        //    {
        //        {
        //            var withBlock = thisAgent;
        //            adpAgent.DeleteQuery(withBlock.AgentID);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}



        public void GetAdminbyUserPW(string password, string username)
        {
            try
            {
                AdminTableAdapter adpAdmin = new AdminTableAdapter();
                AdminDataTable tblAdmin = adpAdmin.GetDataByUserNamePassword(username, password);
                AdminRow row = tblAdmin[0];
                return;

            }
            catch (Exception)
            {
                throw;
            }
        }

		public DataTable GetAdmins()


		//exception error ? 6/25/24 

		{
			try
			{

				AdminTableAdapter adpAdmin = new AdminTableAdapter();
				AdminDataTable tblAdmin = adpAdmin.GetDataBy2();
				return tblAdmin;
			}
			catch (Exception)
			{
				throw;
			}
		}



		public DataTable GetAdmin(string UserName)
        {
            try
            {
                AdminTableAdapter adpAdmin = new AdminTableAdapter();
                NotificationSystem.AdminDataTable tblAdmin = adpAdmin.GetDataByUserName(UserName);

                return tblAdmin;
            }

            catch (Exception)
            {
                throw;
            }
        }



		//public void UpdateAdmin(clsAdmin thisAdmin)
		//{
		//	AdminTableAdapter adpAdmin = new AdminTableAdapter();


		//	try
		//	{
		//		{
		//			var withBlock = thisAdmin;
		//			adpAdmin.UpdateQuery(withBlock.UserName, withBlock.Password, withBlock.Email, withBlock.First, withBlock.Last);
		//		}
		//	}

		//	catch (Exception)
		//	{
		//		throw;
		//	}
		//}


		public void AddAdmin(clsAdmin thisAdmin)
        {

            //add Admin to table and save


            AdminTableAdapter adpAdmin = new AdminTableAdapter();

            NotificationSystem.AdminDataTable tblAdmin = new NotificationSystem.AdminDataTable();
            Admin = false;


            try
            {
                {
                    var withBlock = thisAdmin;
                    adpAdmin.InsertQuery(withBlock.UserName, withBlock.Password, withBlock.Email, withBlock.First, withBlock.Last);
                }



            }
            catch (Exception)
            {
                throw;
            }
            return;

        }


    }
}
