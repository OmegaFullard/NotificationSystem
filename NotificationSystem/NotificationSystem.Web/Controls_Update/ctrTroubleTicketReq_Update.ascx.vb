Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Partial Public Class ctrTroubleTicketReq_Update
    Inherits UserControl

    Private m_TroubleTicketNo As Integer = 0

    Public Property TroubleTicketNo As Integer
        Get
            Return m_TroubleTicketNo
        End Get
        Set(value As Integer)
            m_TroubleTicketNo = value
        End Set
    End Property

    Public Property txtTroubleTicketList As TextBox
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim theNotificationSystem As New clsNotificationSystem
        Dim tblTT As New TroubleTicketReqDataTable

        Try
            If Page.IsPostBack Then

                If Request.Form("ctl00$MainContent$ctrTroubleTicketReq_Update$btnUpdate") = "Update" Then
                    UpdateTroubleTicket()
                Else
                    If m_TroubleTicketNo > 0 Then lblResult.Text = "ID" & m_TroubleTicketNo.ToString()
                    If lblResult.Text.Length = 0 Then Return

                    tblTT = CType(theNotificationSystem.GetTT(), TroubleTicketReqDataTable)
                    If tblTT.Count = 0 Then Return
                    If True Then
                        Dim withBlock = tblTT(0)
                        withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                        withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                        withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                        cmbStatus.Text = withBlock.Status
                        cmbType.Text = withBlock.Type
                        withBlock.RequestDate = Date.Now
                        withBlock.DueDate = Date.Now
                    End If


                    btnUpdate.Enabled = True
                End If
            Else

                PopulateControls()
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
            txtcustomerid.Text = String.Empty
            txtAgentID.Text = String.Empty
            txttroubleticketno.Text = String.Empty
            cmbStatus.Value = ""
            cmbType.Value = ""
            lblResult.Text = String.Empty


        Catch ex As Exception
            Throw
        End Try
    End Sub


    Public Sub UpdateTroubleTicket()

        Dim thisTroubleTicket As New clsTroubleTicketReq

        Try

            Dim withBlock = thisTroubleTicket
            If txttroubleticketno.Text.Length = 0 Then Return
            If Equals(cmbType.Text, String.Empty) Then Exit Sub

            'If (pickRequestDate.SelectedDate == null) Then
            'withBlock.RequestDate = DateTime.Now
            '  Else
            'withBlock.RequestDate = (DateTime)pickRequestDate.SelectedDate

            withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
            withBlock.AgentID = Integer.Parse(txtAgentID.Text)
            withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
            withBlock.Type = cmbType.Text
            withBlock.Status = cmbStatus.Text
            withBlock.DueDate = Date.Now
            withBlock.RequestDate = Date.Now

            withBlock.TroubleTicketNo = Integer.Parse(Strings.Replace(txttroubleticketno.Text, "ID", ""))


            Try
                Dim theNotificationSystem As New clsNotificationSystem
                theNotificationSystem.UpdateTroubleTicket(thisTroubleTicket)
                lblResult.Text = "Trouble Ticket data has been updated"
            Catch ex As SqlException


                Throw New ApplicationException(ex.Message)


            End Try
        Catch ex As Exception
            Throw
        End Try


    End Sub



    Private Sub PopulateControls()
        Dim theNotificationSystem As clsNotificationSystem = New clsNotificationSystem()


        cmbStatus.DataSource = theNotificationSystem.GetStatusList()
        cmbStatus.DataTextField = "Status"
        cmbStatus.DataValueField = "Status"
        cmbStatus.DataBind()



        cmbType.DataSource = theNotificationSystem.GetTypeList()
        cmbType.DataTextField = "Type"
        cmbType.DataValueField = "Type"
        cmbType.DataBind()

    End Sub
    Public Sub CleanResultControl()
        lblResult.Text = String.Empty
    End Sub
    Public Sub CleanControls()

        txtcustomerid.Text = String.Empty
        txtAgentID.Text = String.Empty
        txttroubleticketno.Text = String.Empty
        cmbStatus.Value = ""
        cmbType.Value = ""
        lblResult.Text = String.Empty
    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        Response.Redirect("TroubleTicketReq_Find.aspx", False)
    End Sub
End Class

