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

		public DataTable GetCustomersList()
        {
            try
            {
                CustomerListTableAdapter adpCustomerList = new CustomerListTableAdapter();
                NotificationSystem.CustomerListDataTable tblCustomerList = adpCustomerList.GetData();

                return tblCustomerList;
            }

            catch (Exception ex)
            {
                throw;
            }
        }

		public int GetCustomerListbyID(int CustomerID)
		{
			try
			{
				CustomerListTableAdapter adpCustomerList = new CustomerListTableAdapter();
				CustomerListDataTable tblCustomerList = adpCustomerList.GetDataByID(CustomerID);
				CustomerListRow row = tblCustomerList[0];
				return row.CustomerID;

			}
			catch (Exception ex)
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

            catch (Exception ex)
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

            catch (Exception ex)
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
                    adpCustomer.Update(withBlock.CustomerID, withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip, withBlock.UserName, withBlock.Password, withBlock.Original_CustomerID);
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }


        public void AddCustomer(clsCustomer thisCustomer)
        {

			//add CustomerID to table and save


			CustomerTableAdapter adpCustomer = new CustomerTableAdapter();

			NotificationSystem.CustomerDataTable tblCustomer = new NotificationSystem.CustomerDataTable();
			Customer = false;


			try
			{
				{
					var withBlock = thisCustomer;
					adpCustomer.Insert(withBlock.CustomerID, withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Phone, withBlock.Email, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip, withBlock.UserName, withBlock.Password);
				}



			}
			catch (Exception ex)
			{
				throw;
			}
			return;

		}

        public void GetbyUserPW(string username, string password)
        {
            try
            {
                CustomerTableAdapter adpCustomer = new CustomerTableAdapter();
                CustomerDataTable tblCustomer = adpCustomer.GetDataByUserPW(username, password);
                CustomerRow row = tblCustomer[0];
                return;

            }
            catch (Exception ex)
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

            catch (Exception ex)
            {
                throw;
            }
        }

		public int GetTroubleTicketListbyID(int TroubleTicketNo)
		{
			try
			{
				TroubleTicketListTableAdapter adpTroubleTicketList = new TroubleTicketListTableAdapter();
				TroubleTicketListDataTable tblTroubleTicketList = adpTroubleTicketList.GetDataByTroubleTicketNo(TroubleTicketNo);
				TroubleTicketListRow row = tblTroubleTicketList[0];
				return row.TroubleTicketNo;

			}
			catch (Exception ex)
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

            catch (Exception ex)
            {
                throw;
            }
        }

		public DataTable GetTroubleTicketByNo(int TroubleTicketNo)
		{
			try
			{
				TroubleTicketReqTableAdapter adpTroubleTicketReq = new TroubleTicketReqTableAdapter();
				NotificationSystem.TroubleTicketReqDataTable tblTroubleTicketReq = adpTroubleTicketReq.GetDataByTroubleTicketNo(TroubleTicketNo);

				return tblTroubleTicketReq;
			}

			catch (Exception ex)
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
					adpTroubleTicket.Update(withBlock.CustomerID, withBlock.AgentID, withBlock.Status, withBlock.DueDate, withBlock.RequestDate, withBlock.Type, withBlock.TroubleTicketNo);
				}
            }

            catch (Exception ex)
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
					adpTroubleTicketReq.Insert(withBlock.CustomerID, withBlock.AgentID, withBlock.Status, withBlock.DueDate, withBlock.RequestDate, withBlock.Type);
				}



            }
            catch (Exception ex)
            {
                throw;
            }
            return;

        }

		public DataTable GetTypeList()
		{
			DataSet ds = new DataSet();
			DataTable dt = new DataTable("GetData");
		



			dt.Columns.Add("ID", Type.GetType("System.Integer")).DefaultValue = string.Empty;
			dt.Columns.Add("Type", Type.GetType("System.String")).DefaultValue = string.Empty;

            // Create and populate rows
            DataRow dr = dt.NewRow();
            dr["ID"] = 0; dr["Type"] = "Incident";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = 1; dr["Type"] = "Task";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = 2; dr["Type"] = "Problem";
            dt.Rows.Add(dr);



            return dt;
		}

		public DataTable GetStatusList()
		{
			DataSet ds = new DataSet();
			DataTable dt = new DataTable("GetData");


			//Add columns with appropriate data types


			dt.Columns.Add("TroubleTicketNo", Type.GetType("System.Integer")).DefaultValue = 0;
			dt.Columns.Add("Status", Type.GetType("System.String")).DefaultValue = string.Empty;

			//Create and populate rows

		DataRow dr = dt.NewRow();

			dr = dt.NewRow();
			dr["ID"] = "1"; dr["Status"] = "Open";
			dt.Rows.Add(dr);

			dr = dt.NewRow();
			dr["ID"] = "2"; dr["Status"] = "Pending";
			dt.Rows.Add(dr);

			dr = dt.NewRow();
			dr["ID"] = "3"; dr["Status"] = "Resolved";
			dt.Rows.Add(dr);

			dr = dt.NewRow();
			dr["ID"] = "4"; dr["Status"] = "Closed";
			dt.Rows.Add(dr);

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

            catch (Exception ex)
            {
                throw;
            }
        }


        
public int GetAgentByID(int AgentID)
        {
            try
            {
                AgentTableAdapter adpAgentList = new AgentTableAdapter();
                NotificationSystem.AgentDataTable tblAgentList = adpAgentList.GetDataByAgentID(AgentID);

                AgentRow row = tblAgentList[0];
                return row.AgentID;
            }
            catch (Exception ex)
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

            catch (Exception ex)
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

            catch (Exception ex)
            {
                throw;
            }
        }



        public void AddAgent(clsAgent thisAgent)
        {
           

            NotificationSystem.AgentDataTable tblAgent = new NotificationSystem.AgentDataTable();
            Agent = false;

            try
            {
               
              
                AgentTableAdapter adpAgent = new AgentTableAdapter();

                {
                    var withBlock = thisAgent;
                    adpAgent.Insert(withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.Title, withBlock.StartDate, withBlock.Salary, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Fax);

                  
                }

            
            }
            catch (Exception ex)
            {
                throw;
            }
            return;
        }

       

        public void UpdateAgent(clsAgent thisAgent)
        {
            AgentTableAdapter adpAgent = new AgentTableAdapter();


            try
            {
                {
                    var withBlock = thisAgent;
                    adpAgent.Update(withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.Title, withBlock.StartDate, withBlock.Salary, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Fax, withBlock.Original_AgentID);
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }


        public void GetAdminbyUserPW(string password, string username)
        {
            try
            {
                AdminTableAdapter adpAdmin = new AdminTableAdapter();
                AdminDataTable tblAdmin = adpAdmin.GetData(username, password);
                AdminRow row = tblAdmin[0];
                return;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable GetAdmins(string username, string password)
        {
            try
            {
                AdminTableAdapter adpAdmin = new AdminTableAdapter();
                NotificationSystem.AdminDataTable tblAdmin = adpAdmin.GetData(username, password);

                return tblAdmin;
            }

            catch (Exception ex)
            {
                throw;
            }
        }





        public void UpdateAdmin(clsAdmin thisAdmin)
        {
            AdminTableAdapter adpAdmin = new AdminTableAdapter();


            try
            {
                {
                    var withBlock = thisAdmin;
                    adpAdmin.Update(withBlock.UserName, withBlock.Password, withBlock.Email, withBlock.First, withBlock.Last);
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }


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
                    adpAdmin.Insert(withBlock.UserName, withBlock.Password, withBlock.Email, withBlock.First, withBlock.Last);
                }



            }
            catch (Exception ex)
            {
                throw;
            }
            return;

        }


    }
}
