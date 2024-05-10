using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationSystem.NotificationSystem.Web.Controls_Search
{
	public partial class ctrSearch_Customer_Find : System.Web.UI.UserControl
	{
        private int m_CustomerID = 0;

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
        protected void Page_Load(object sender, EventArgs e)
		{
            m_CustomerID = int.Parse(txtCustomerID.Text);
        }
	}
}