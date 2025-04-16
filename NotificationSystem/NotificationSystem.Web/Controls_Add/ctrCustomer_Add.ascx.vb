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
    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim theNotificationSystem As clsNotificationSystem = New clsNotificationSystem()
        Dim tblAgent As CustomerDataTable = New CustomerDataTable()
        Dim client = New HttpClient()
        Try
            If MyBase.Page.IsPostBack Then


                If Equals(Request.Form("ctl00$MainContent$ctrCustomer_Add$btnAdd"), "Add") Then AddCustomer()
            Else
            End If
        Catch __unusedException1__ As Exception
            Throw
        End Try

    End Sub


    Public Sub AddCustomer()
        Try
            Dim thisCustomer As clsCustomer = New clsCustomer()

            If True Then
                Dim withBlock = thisCustomer
                If txtcustomerid.Text.Length = 0 Then Return

                withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                withBlock.FirstN = txtfirstname.Text
                withBlock.LastN = txtlastname.Text
                withBlock.Email = txtemailaddress.Text
                withBlock.Phone = txtPhoneNumber.Text
                withBlock.Address = txtaddress.Text
                withBlock.City = txtcity.Text
                withBlock.State = txtstate.Text
                withBlock.Zip = txtzip.Text
                withBlock.UserName = txtusername.Text
                withBlock.Password = txtpassword.Text

            End If
            Try

                Dim theNotificationSystem As clsNotificationSystem = New clsNotificationSystem()
                theNotificationSystem.AddCustomer(thisCustomer)
                lblResult.Text = "Customer data has been added"

            Catch ex As SqlException
                If ex.Number = 2627 Then
                    lblResult.Text = "Customer already exist!"
                Else
                    Throw New ApplicationException(ex.Message)
                End If
            End Try
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


        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub
    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        Response.Redirect("Customer_Find.aspx", False)
    End Sub
End Class
