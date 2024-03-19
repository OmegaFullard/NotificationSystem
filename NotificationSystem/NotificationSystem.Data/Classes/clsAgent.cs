using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;


namespace NotificationSystem.NotificationSystem.Data.Classes
{


    public class clsAgent
    {
		internal int Original_AgentID;
		private string m_Title = string.Empty;
        private string m_FirstN = string.Empty;
        private string m_LastN = string.Empty;
        private string m_Email = string.Empty;
        private string m_Phone = string.Empty;
        private string m_Fax = string.Empty;

        private int m_AgentID = 0;
        private int m_TroubleTicketNo = 0;
        private DateTime m_StartDate;
        private int m_Salary;
        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }


        public string FirstN
        {
            get
            {
                return m_FirstN;
            }
            set
            {
                m_FirstN = value;
            }
        }

        public string LastN
        {
            get
            {
                return m_LastN;
            }
            set
            {
                m_LastN = value;
            }
        }

        public string Email
        {
            get
            {
                return m_Email;
            }
            set
            {
                m_Email = value;
            }
        }

        public string Phone
        {
            get
            {
                return m_Phone;
            }
            set
            {
                m_Phone = value;
            }
        }

        public string Fax
        {
            get
            {
                return m_Fax;
            }
            set
            {
                m_Fax = value;
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

        public DateTime StartDate
        {
            get
            {
                return m_StartDate;
            }
            set
            {
                m_StartDate = value;
            }
        }

        public int Salary
        {
            get
            {
                return m_Salary;
            }
            set
            {
                m_Salary = value;
            }
        }

    }
}
