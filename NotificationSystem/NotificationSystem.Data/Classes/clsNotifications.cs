using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotificationSystem_Practice.NotificationSystem.Data.xsNotificationSystemTableAdapters;

namespace NotificationSystem_Practice.NotificationSystem.Data.Classes
{
    public class clsNotifications
    {
        private int m_AgentID = 0;
        private int m_TroubleTicketNo = 0;
        private string m_Type = String.Empty;

        public string Type
        {
            get
            {
                return m_Type;
            }
            set
            {
                m_Type = value;
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


    }
}

