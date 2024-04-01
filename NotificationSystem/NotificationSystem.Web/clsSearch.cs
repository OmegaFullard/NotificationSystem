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
        private string m_DateFrom = string.Empty;
        private string m_DateTo = string.Empty;
        private string m_Year = string.Empty;
        private bool m_DateRange = false;
        private int m_AgentID = 0;

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

        public string DateFrom
        {
            get
            {
                return m_DateFrom;
            }
            set
            {
                m_DateFrom = value;
            }
        }
        public string DateTo
        {
            get
            {
                return m_DateTo;
            }
            set
            {
                m_DateTo = value;
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
        //public int m_AgentID
        //{
        //    get
        //    {
        //        return m_AgentID;
        //    }
        //    set
        //    {
        //        m_AgentID = value;
        //    }
        //}
    }
}