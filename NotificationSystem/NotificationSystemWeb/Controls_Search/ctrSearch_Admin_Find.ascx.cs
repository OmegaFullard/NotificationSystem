using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web.Controls_Search
{
	public partial class ctrSearch_Admin_Find : System.Web.UI.UserControl
	{
        private string m_UserName = string.Empty;

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
        protected void Page_Load(object sender, EventArgs e)
		{
            m_UserName = txtUserName.Text;
        }
	}
}