Imports System
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Partial Public Class ctrAgent_Update
    Inherits UserControl
    Private m_AgentID As Integer = 0

    Public Property AgentID As Integer
        Get
            Return m_AgentID
        End Get
        Set(value As Integer)
            m_AgentID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim theNotificationSystem As New clsNotificationSystem
        Dim tblAgent As New AgentDataTable
        Try
            If Page.IsPostBack Then

                If Request.Form("ctl00$MainContent$ctrAgent_Update$btnUpdate") = "Update" Then
                    UpdateAgent()
                Else
                    If m_AgentID > 0 Then lblResult.Text = "ID" & m_AgentID.ToString()

                    If lblResult.Text.Length = 0 Then Return

                    tblAgent = CType(theNotificationSystem.GetAgents(), AgentDataTable)
                    If tblAgent.Count = 0 Then Return

                    If True Then
                        Dim withBlock = tblAgent(0)
                        txttitle.Text = withBlock.Title
                        withBlock.Salary = Integer.Parse(txtsalary.Text)
                        txtfirstname.Text = withBlock.FirstN
                        txtlastname.Text = withBlock.LastN
                        txttitle.Text = withBlock.Title
                        withBlock.Salary = Integer.Parse(txtsalary.Text)
                        withBlock.AgentID = Integer.Parse(txtagentid.Text)
                        withBlock.AgentID = Integer.Parse(txtagentid.Text)


                        If Not String.IsNullOrEmpty(withBlock.Phone) Then txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

                        If Not String.IsNullOrEmpty(withBlock.Email) Then
                            txtemailaddress.Text = withBlock.Email
                        End If

                        If Not String.IsNullOrEmpty(withBlock.Fax) Then txtFaxNumber.Text = withBlock.Fax.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

                    End If

                End If
                btnUpdate.Enabled = True
            End If


        Catch ex As Exception
            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
            Dim NotificationBody = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)

        End Try
    End Sub

    Public Sub ClearControls()
        Try
            txtagentid.Text = ""
            txttitle.Text = ""
            txtfirstname.Text = ""
            txtlastname.Text = ""
            txtemailaddress.Text = ""
            txtPhoneNumber.Text = ""
            txtFaxNumber.Text = ""
            txtsalary.Text = ""


        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub UpdateAgent()

        Dim thisAgent As New clsAgent
        Try


            Dim withBlock = thisAgent
            If txtagentid.Text.Length = 0 Then Return

            withBlock.AgentID = Integer.Parse(txtagentid.Text)
            withBlock.Title = txttitle.Text
            withBlock.FirstN = txtfirstname.Text
            withBlock.LastN = txtlastname.Text
            withBlock.Email = txtemailaddress.Text
            withBlock.Phone = txtPhoneNumber.Text
            withBlock.Fax = txtFaxNumber.Text
            withBlock.Salary = txtsalary.Text

            withBlock.AgentID = Integer.Parse(Strings.Replace(txtagentid.Text, "ID", ""))
            Try
                Dim theNotificationSystem As New clsNotificationSystem
                theNotificationSystem.UpdateAgent(thisAgent)
                lblResult.Text = "Agent data has been added"
            Catch ex As SqlException
                If ex.Number = 2627 Then
                    lblResult.Text = "Agent already exist!"
                Else
                    Throw New ApplicationException(ex.Message)
                End If
            End Try


        Catch ex As Exception
            Throw
        End Try
    End Sub
    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        Response.Redirect("Agent_Find.aspx", False)
    End Sub
End Class


