Imports System
Imports System.Data.SqlClient
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem

Namespace NotificationSystem.NotificationSystem.Web.Controls_Delete
    Public Partial Class ctrCustomer_Delete
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
            Dim theNotificationSystem As New clsNotificationSystem
            Dim tblCustomer As New CustomerDataTable

            Try
                If Page.IsPostBack Then


                    If Request.Form("ctl00$MainContent$ctrCustomer_Delete$btnDelete") = "Delete" Then
                        DeleteCustomer()
                    End If
                Else
                    If m_CustomerID = 0 Then Return
                    tblCustomer = CType(theNotificationSystem.GetCustomer(CustomerID), CustomerDataTable)

                    If tblCustomer.Count = 0 Then Return

                    Dim withBlock = tblCustomer(0)

                        withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                        withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                        withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                        txtfirstname.Text = withBlock.FirstN
                        txtlastname.Text = withBlock.LastN
                        withBlock.UserName = txtusername.Text
                        withBlock.Password = txtpassword.Text
                        If Not String.IsNullOrEmpty(withBlock.Phone) Then txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

                        If Not String.IsNullOrEmpty(withBlock.Email) Then
                            txtemailaddress.Text = withBlock.Email
                        End If


                        If Not String.IsNullOrEmpty(withBlock.Address) Then
                            txtaddress.Text = withBlock.Address
                        End If

                        If Not String.IsNullOrEmpty(withBlock.City) Then
                            txtcity.Text = withBlock.City

                            If Not String.IsNullOrEmpty(withBlock.State) Then txtstate.Text = withBlock.State
                        End If

                        If Not String.IsNullOrEmpty(withBlock.Zip) Then txtzip.Text = withBlock.Zip.Substring(0, 5)

                    btnDelete.Enabled = True
                End If

            Catch ex As Exception
                Dim SendError As New clsNotificationSystem_Web
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try

        End Sub
        Public Sub DeleteCustomer()

            Dim thisCustomer = New clsCustomer


            If txtcustomerid.Text.Length = 0 Then Return
            thisCustomer.CustomerID = Integer.Parse(txtcustomerid.Text)

            Try
                Dim theNotificationSystem As New clsNotificationSystem
                theNotificationSystem.DeleteCustomer(thisCustomer)

                lblResult.Text = "Customer data has been deleted"
            Catch ex As Exception

                Throw
            End Try
            CleanupControls()

        End Sub
        Private Sub CleanupControls()
            txtcustomerid.Text = String.Empty
            txtAgentID.Text = String.Empty
            txttroubleticketno.Text = String.Empty
            txtfirstname.Text = String.Empty
            txtlastname.Text = String.Empty
            txtusername.Text = String.Empty
            txtpassword.Text = String.Empty
            txtemailaddress.Text = String.Empty
            txtPhoneNumber.Text = String.Empty
            txtaddress.Text = String.Empty
            txtcity.Text = String.Empty
            txtstate.Text = String.Empty
            txtzip.Text = String.Empty
        End Sub
        Public Sub CleanResultControl()
            lblResult.Text = String.Empty
        End Sub

        Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
            Response.Redirect("Customer_Find.aspx", False)
        End Sub
    End Class
End Namespace
