Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports System.Data.SqlClient
Imports System.Net.Http


Public Partial Class ctrCustomer_Add
    Inherits UserControl

    Private m_CustomerID As Integer = 0

    Public Property CustomerID As Integer
        Get
            Return m_CustomerID
        End Get
        Set(value As Integer)
            m_CustomerID = value
        End Set
    End Property

    Public Property txtCustomerList As TextBox
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        PopulateControls()
        If Not IsPostBack Then
            txtcustomerid.Text = CustomerID.ToString()
            txtcustomerid.Enabled = False
            txtAgentID.Text = "0"
            txttroubleticketno.Text = "0"
            txtfirstname.Text = ""
            txtlastname.Text = ""
            txtemailaddress.Text = ""
            txtPhoneNumber.Text = ""
            txtaddress.Text = ""
            txtcity.Text = ""
            txtstate.Text = ""
            txtzip.Text = ""
            txtusername.Text = ""
            txtpassword.Text = ""
        End If
    End Sub


    Public Sub AddCustomer()
        Try
            Dim thisCustomer As New clsCustomer

            With thisCustomer

                thisCustomer.CustomerID = Integer.Parse(txtcustomerid.Text)
                thisCustomer.AgentID = Integer.Parse(txtAgentID.Text)
                thisCustomer.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                thisCustomer.FirstN = txtfirstname.Text
                thisCustomer.LastN = txtlastname.Text
                thisCustomer.Email = txtemailaddress.Text
                thisCustomer.Phone = txtPhoneNumber.Text
                thisCustomer.Address = txtaddress.Text
                thisCustomer.City = txtcity.Text
                thisCustomer.State = txtstate.Text
                thisCustomer.Zip = txtzip.Text
                thisCustomer.UserName = txtusername.Text
                thisCustomer.Password = txtpassword.Text
                If txtcustomerid.Text.Length = 0 Then Return

            End With



            Dim theNotificationSystem As New clsNotificationSystem
            theNotificationSystem.AddCustomer(thisCustomer)
                lblResult.Text = "Customer data has been added"

            Catch ex As Exception
            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
            Dim NotificationBody = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try
    End Sub

    Private Sub PopulateControls()
        'clsNotificationSystem theCustomer = new clsNotificationSystem();

        'this.cmbStates.DataSource = theCustomer.GetStatesList();
        'this.cmbStates.DataTextField = "State";
        'this.cmbStates.DataBind();
        'this.cmbStates.Text = "PA";

        'txtcity.Text = "Philadelphia";
    End Sub
    Public Sub ClearControls()
        Try
            txtcustomerid.Text = ""
            txtAgentID.Text = ""
            txttroubleticketno.Text = ""
            txtfirstname.Text = ""
            txtlastname.Text = ""
            txtemailaddress.Text = ""
            txtPhoneNumber.Text = ""
            txtaddress.Text = ""
            txtcity.Text = ""
            txtstate.Text = ""
            txtzip.Text = ""
            txtusername.Text = ""
            txtpassword.Text = ""
        Catch ex As Exception
            lblResult.Text = "An error occurred while clearing controls: " & ex.Message
        End Try
    End Sub
    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        Response.Redirect("Customer_Find.aspx", False)
    End Sub
End Class
