using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationSystem.NotificationSystem.Data.Classes
{
	public class clsStatusList
	{

		private string m_Status = string.Empty;
		private int m_TroubleTicketNo = 0;

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