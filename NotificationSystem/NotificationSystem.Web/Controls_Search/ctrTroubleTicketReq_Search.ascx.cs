using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



    public partial class ctrTroubleTicketReq_Search : System.Web.UI.UserControl
    {

    private int m_TroubleTicketNo = 0;

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
    protected void Page_Load(object sender, EventArgs e)
        {

        }

    public void PopulateSearchControl()
    {
        m_TroubleTicketNo = int.Parse(this.txttroubleticketno.Text);
    }
}
