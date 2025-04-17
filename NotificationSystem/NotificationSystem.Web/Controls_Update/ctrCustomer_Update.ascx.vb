Imports System
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Partial Public Class ctrCustomer_Update
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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim theNotificationSystem As New clsNotificationSystem
        Dim tblCustomer As New CustomerDataTable
        Try
            If Page.IsPostBack Then

                If Request.Form("ct100$MainContent$ctrCustomer_Update$btnUpdate") = "Update" Then
                    UpdateCustomer()
                Else
                    If m_CustomerID > 0 Then lblResult.Text = "ID" & m_CustomerID.ToString()

                    If lblResult.Text.Length = 0 Then Return

                    tblCustomer = CType(theNotificationSystem.GetCustomers(), CustomerDataTable)
                    If tblCustomer.Count = 0 Then Return

                    If True Then
                        Dim withBlock = tblCustomer(0)

                        withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                        withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                        withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                        txtfirstname.Text = withBlock.FirstN
                        txtlastname.Text = withBlock.LastN
                        withBlock.Address = txtaddress.Text
                        withBlock.City = txtcity.Text
                        withBlock.State = txtstate.Text
                        withBlock.Zip = txtzip.Text
                        withBlock.UserName = txtusername.Text
                        withBlock.Password = txtpassword.Text


                        If Not String.IsNullOrEmpty(withBlock.Phone) Then txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

                        If Not String.IsNullOrEmpty(withBlock.Email) Then
                            txtemailaddress.Text = withBlock.Email
                        End If



                    End If

                End If
                btnUpdate.Enabled = True
            End If


            PopulateControls()

        Catch ex As Exception
            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
            Dim NotificationBody = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)

        End Try
    End Sub

    Public Sub ClearControls()
        Try

            txtcustomerid.Text = ""
            txtAgentID.Text = ""
            txttroubleticketno.Text = ""
            txtfirstname.Text = ""
            txtlastname.Text = ""
            txtaddress.Text = ""
            txtcity.Text = ""
            txtstate.Text = ""
            txtzip.Text = ""
            txtusername.Text = ""
            txtpassword.Text = ""
            txtPhoneNumber.Text = ""
            txtemailaddress.Text = ""

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub CleanResultControl()
        lblResult.Text = String.Empty
    End Sub

    Public Sub UpdateCustomer()

        Dim thisCustomer As New clsCustomer

        Try


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

            withBlock.CustomerID = Integer.Parse(Strings.Replace(txtcustomerid.Text, "ID", ""))
            Try
                Dim theNotificationSystem As New clsNotificationSystem
                theNotificationSystem.UpdateCustomer(thisCustomer)
                lblResult.Text = "Customer data has been updated"
            Catch ex As SqlException

                Throw New ApplicationException(ex.Message)
            End Try


        Catch ex As Exception
            Throw
        End Try



    End Sub

    Private Sub PopulateControls()
        'clsNotificationSystem theNotificationSystem = new clsNotificationSystem();


        'cmbStates.DataSource = theNotificationSystem.GetStatesList();
        'cmbStates.DataTextField = "State";
        'cmbStates.DataBind();
        'cmbStates.Text = "PA";



    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        Response.Redirect("Customer_Find.aspx", False)
    End Sub
End Class


