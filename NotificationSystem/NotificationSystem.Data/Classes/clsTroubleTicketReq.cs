﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotificationSystem_Practice.NotificationSystem.Data.xsNotificationSystemTableAdapters;



namespace NotificationSystem_Practice.NotificationSystem.Data.Classes
{
    public class clsTroubleTicketReq
    {
        private string m_Status = string.Empty;
        private int m_CustomerID = 0;
        private int m_AgentID = 0;
        private int m_TroubleTicketNo = 0;
        private DateTime m_DueDate;
        private DateTime m_RequestDate;

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
    }
}