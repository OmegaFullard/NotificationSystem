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
using NotificationSystem_Practice.NotificationSystem.Data;
using System.Data;
using NotificationSystem_Practice.NotificationSystem.Data.xsReportsTableAdapters;
using static NotificationSystem_Practice.NotificationSystem.Data.xsReports;

namespace NotificationSystem_Practice.NotificationSystem.Data.Classes
{
    class clsReports
    {
        public DataTable Notification()
        {
            try
            {
                NotificationsTableAdapter adpNotification = new NotificationsTableAdapter();
                NotificationsDataTable tblNotification = adpNotification.GetData();

                return tblNotification;
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable GetRange(DateTime RequestDate)
        {
            try
            {
                TroubleTicketReqTableAdapter adpTroubleTicketReq = new TroubleTicketReqTableAdapter();
                TroubleTicketReqDataTable tblMonthly = adpTroubleTicketReq.GetDataByRange(Convert.ToString(RequestDate));

                return tblMonthly;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public DataTable GetByCustID(int CustomerID)
        {
            try
            {
                TroubleTicketReqTableAdapter adpTroubleTicket = new TroubleTicketReqTableAdapter();
                TroubleTicketReqDataTable tblTroubleTicketReq = adpTroubleTicket.GetDataByCustomerID(CustomerID);

                return tblTroubleTicketReq;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
