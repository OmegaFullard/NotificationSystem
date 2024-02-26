using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotificationSystem_Practice.NotificationSystem.Data.xsNotificationSystemTableAdapters;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;


namespace NotificationSystem_Practice.NotificationSystem.Data.Classes
{
    public class clsNotificationSystem
    {
        public bool Customer { get; private set; }
        public bool Agent { get; private set; }

        public DataTable GetCustomersList()
        {
            try
            {
                CustomerListTableAdapter adpCustomerList = new CustomerListTableAdapter();
                xsNotificationSystem.CustomerListDataTable tblCustomerList = adpCustomerList.GetData();

                return tblCustomerList;
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        //public int GetCustomerListbyID(int CustomerID)
        //{
        //    try
        //    {
        //        CustomerListTableAdapter adpCustomerList = new CustomerListTableAdapter();
        //        CustomerListDataTable tblCustomerList = adpCustomerList.GetDataByID(CustomerID);
        //        CustomerListRow row = tblCustomerList(0);
        //        return row.CustomerList;
                
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        public DataTable GetCustomers()
        {
            try
            {
                CustomerTableAdapter adpCustomer = new CustomerTableAdapter();
                xsNotificationSystem.CustomerDataTable tblCustomer = adpCustomer.GetData();

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
                xsNotificationSystem.CustomerDataTable tblCustomer = adpCustomer.GetDataByTroubleTicket(TroubleTicketNo);

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
                    adpCustomer.Update(withBlock.CustomerID, withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Phone, withBlock.Email, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip);
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }


        public void AddCustomer(clsCustomer thisCustomer)
        {
            CustomerTableAdapter adpCustomer = new CustomerTableAdapter();

            xsNotificationSystem.CustomerDataTable tblCustomer = new xsNotificationSystem.CustomerDataTable();
            Customer = false;

            
            try
            {
                {
                    var withBlock = thisCustomer;
                    adpCustomer.Insert(withBlock.CustomerID, withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Phone, withBlock.Email, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip);
                }

               
              
            }
            catch (Exception ex)
            {
                throw;
            }
            return;

        }

        //public DataTable GetNotificationsList()
        //{
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable("GetData");
        //    DataRow dr;



        //    dt.Columns.Add("TroubleTicketNo", Type.GetType("System.Integer")).DefaultValue = 0;
        //    dt.Columns.Add("Type", Type.GetType("System.String")).DefaultValue = string.Empty;

        //    dr = dt.NewRow;
        //    dr("TroubleTicketNo") = "0"; dr("Type") = "Incident";
        //    dt.Rows.Add(dr);
        //    dr = dt.NewRow;
        //    dr("TroubleTicketNo") = "1"; dr("Type") = "Task";
        //    dt.Rows.Add(dr);
        //    dr = dt.NewRow;
        //    dr("TroubleTicketNo") = "2"; dr("Type") = "Problem";
        //    dt.Rows.Add(dr);



        //    return dt;
        //}

        //public DataTable GetTroubleTicketList()
        //{
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable("GetData");
        //    DataRow dr;



        //    dt.Columns.Add("TroubleTicketNo", Type.GetType("System.Integer")).DefaultValue = 0;
        //    dt.Columns.Add("Status", Type.GetType("System.String")).DefaultValue = string.Empty;

        //    dr = dt.NewRow;
        //    dr("TroubleTicketNo") = "1"; dr("Status") = "Open";
        //    dt.Rows.Add(dr);
        //    dr = dt.NewRow;
        //    dr("TroubleTicketNo") = "2"; dr("Status") = "Pending";
        //    dt.Rows.Add(dr);
        //    dr = dt.NewRow;
        //    dr("TroubleTicketNo") = "3"; dr("Status") = "Resolved";
        //    dt.Rows.Add(dr);
        //    dr = dt.NewRow;
        //    dr("TroubleTicketNo") = "4"; dr("Status") = "Closed";
        //    dt.Rows.Add(dr);

        //    return dt;
        //}



        public DataTable GetAgentList()
        {
            try
            {
                AgentListTableAdapter adpAgentList = new AgentListTableAdapter();
                AgentListDataTable tblAgentList = adpAgentList.GetData();

                return tblAgentList;
            }

            catch (Exception ex)
            {
                throw;
            }
        }
        public int GetAgentListByID(int AgentID)
        {
            try
            {
                AgentListTableAdapter adpAgentList = new AgentListTableAdapter();
                AgentListDataTable tblAgentList = adpAgentList.GetDataByID(AgentID);

                AgentListRow row = tblAgentList(0);
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
                xsNotificationSystem.AgentDataTable tblAgent = adpAgent.GetData();

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
                xsNotificationSystem.AgentDataTable tblAgent = adpAgent.GetDataByTicket(TroubleTicketNo);

                return tblAgent;
            }

            catch (Exception ex)
            {
                throw;
            }
        }



        public void AddAgent(clsAgent thisAgent)
        {

            xsNotificationSystem.AgentDataTable tblAgent = new xsNotificationSystem.AgentDataTable();
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
                    adpAgent.Update(withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.Title, withBlock.StartDate, withBlock.Salary, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Fax);
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
