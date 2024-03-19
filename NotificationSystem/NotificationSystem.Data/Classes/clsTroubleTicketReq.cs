using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;



namespace NotificationSystem.NotificationSystem.Data.Classes
{
    public class clsTroubleTicketReq
    {
		internal int Original_TroubleTicketNo;
		private string m_Status = string.Empty;
        private int m_CustomerID = 0;
        private int m_AgentID = 0;
        private int m_TroubleTicketNo = 0;
        private DateTime m_DueDate;
        private DateTime m_RequestDate = DateTime.Now;

        public string Status
        {
            get
            {
                return m_Status;
            }
            set
            {
                m_Status = value;
            }
        }

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


        public int TroubleTicketNo
        {
            get
            {
                return m_TroubleTicketNo;
            }
            set
            {
                m_TroubleTicketNo = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return m_DueDate;
            }
            set
            {
                m_DueDate = value;
            }
        }

        public DateTime RequestDate
        {
            get
            {
                return m_RequestDate;
            }
            set
            {
                m_RequestDate = value;
            }
        }

		public string Type { get; internal set; }
	}
}
