using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;

namespace NotificationSystem.NotificationSystem.Data.Classes
{
    public class clsCustomer
    {
        private string m_FirstN = string.Empty;
        private string m_LastN = string.Empty;
        private string m_Email = string.Empty;
        private string m_Phone = string.Empty;
        private string m_Address = string.Empty;
        private string m_City = string.Empty;
        private string m_State = string.Empty;
        private string m_Zip = string.Empty;

        private int m_CustomerID = 0;
        private int m_AgentID = 0;
        private int m_TroubleTicketNo = 0;

        private DateTime m_StartDate;





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

        public string Address
        {
            get
            {
                return m_Address;
            }
            set
            {
                m_Address = value;
            }
        }
        public string City
        {
            get
            {
                return m_City;
            }
            set
            {
                m_City = value;
            }
        }


        public string State
        {
            get
            {
                return m_State;
            }
            set
            {
                m_State = value;
            }
        }


        public string Zip
        {
            get
            {
                return m_Zip;
            }
            set
            {
                m_Zip = value;
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

    }
}
