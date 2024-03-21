using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters;

namespace NotificationSystem.NotificationSystem.Data.Classes
{
	public class clsAdmin
	{
		private string m_UserName = string.Empty;
		private string m_Password = string.Empty;
		private string m_Email = string.Empty;
		private string m_First = string.Empty;
		private string m_Last = string.Empty;

        public string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                m_UserName = value;
            }
        }

        public string Password
        {
            get
            {
                return m_Password;
            }
            set
            {
                m_Password = value;
            }
        }

        public string First
        {
            get
            {
                return m_First;
            }
            set
            {
                m_First = value;
            }
        }

        public string Last
        {
            get
            {
                return m_Last;
            }
            set
            {
                m_Last = value;
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
    }
}