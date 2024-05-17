using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationSystem.NotificationSystem.Web
{
	public class clsSearch
	{
        private string m_ReportName = string.Empty;
        private string m_ActivityBy = string.Empty;
        private string m_ReportPath = string.Empty;
        private string m_RequestDate = string.Empty;
        private string m_DueDate = string.Empty;
        private string m_Year = string.Empty;
        private bool m_DateRange = false;
        private int m_AgentID = 0;
        private int m_CustomerID = 0;

        public string ReportName
        {
            get
            {
                return m_ReportName;
            }
            set
            {
                m_ReportName = value;
            }
        }
        public string ActivityBy
        {
            get
            {
                return m_ActivityBy;
            }
            set
            {
                m_ActivityBy = value;
            }
        }
        public string ReportPath
        {
            get
            {
                return m_ReportPath;
            }
            set
            {
                m_ReportPath = value;
            }
        }
        public bool DateRange
        {
            get
            {
                return m_DateRange;
            }
            set
            {
                m_DateRange = value;
            }
        }

        public string RequestDate
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
        public string DueDate
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
        public string Year
        {
            get
            {
                return m_Year;
            }
            set
            {
                m_Year = value;
            }
        }

        //public object AgentID { get; internal set; }
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
		//public object CustomerID { get; internal set; }
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
	}
}