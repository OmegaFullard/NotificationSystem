using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationSystem.NotificationSystem.Data.Classes
{
	public class clsTypeList
	{
		
		private string m_Type = string.Empty;
		private int m_TroubleTicketNo = 0;

   
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