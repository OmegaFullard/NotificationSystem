using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


	public partial class ctrSearch_Admin : System.Web.UI.UserControl
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

		}
        public void PopulateSearchControl()
        {
            m_UserName = txtUserName.Text;
        }

    }
