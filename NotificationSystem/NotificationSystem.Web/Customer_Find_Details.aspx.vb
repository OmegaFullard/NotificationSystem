Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Customer_Find_Details
        Inherits Page
        Private m_CustomerID As Integer = 0

        Public Property CustomerID As Integer
            Get
                Return m_CustomerID
            End Get
            Set(value As Integer)
                m_CustomerID = value
            End Set
        End Property
        Protected Sub Page_Load(sender As Object, e As EventArgs)

            'syntax errors - can not convert int to 'notificationsystem.notificationsystem.data.notificationsystem.AgentDataTable


            'clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            'CustomerDataTable tblCustomer = new CustomerDataTable();

            'try
            '{
            '	if ((Request.QueryString["Customer"] == null))
            '		return;

            '	string[] arrCustomers = Request.QueryString["customer"].Split(Convert.ToChar(":"));
            '	CustomerID = int.Parse(arrCustomers[0]);
            '	if (CustomerID == 0)
            '		return;

            '	tblCustomer = (CustomerDataTable)theNotificationSystem.GetCustomerListbyID(CustomerID);
            '	if (tblCustomer.Count == 0)
            '		return;

            '	{
            '		var withBlock = tblCustomer[0];
            '		withBlock.CustomerID = int.Parse(this.txtCustomerID.Text); withBlock.AgentID = int.Parse(this.txtAgentID.Text); withBlock.TroubleTicketNo = int.Parse(this.txttroubleticketno.Text);
            '		this.txtaddress.Text = withBlock.Address; this.txtcity.Text = withBlock.City; this.txtstate.Text = withBlock.State; this.txtzip.Text = withBlock.Zip;
            '		this.txtfirstname.Text = withBlock.FirstN; this.txtlastname.Text = withBlock.LastN;


            '		if (!string.IsNullOrEmpty(withBlock.Phone))
            '			txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

            '		if (!string.IsNullOrEmpty(withBlock.Email))
            '		{
            '			txtEmailAddress.Text = withBlock.Email;
            '		}

            '	}
            '}





            'catch (Exception)
            '{
            '}
        End Sub

    End Class
End Namespace
