Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes

Public Partial Class ctrTroubleTicketReq_Add
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
    Protected Sub Page_Load(sender As Object, e As EventArgs)
        If MyBase.Page.IsPostBack Then
            Try
                If Equals(Request.Form("ctl00$MainContent$ctrTroubleTicketReq_Add$btnAdd"), "Add") Then
                    AddTroubleTicket()

                ElseIf Equals(Request.Form("ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"), "Search") Then
                    Dim theNotificationSystem As clsNotificationSystem = New clsNotificationSystem()

                    Dim tblTroubleTicketReq As TroubleTicketReqDataTable = theNotificationSystem.GetTroubleTicket(m_TroubleTicketNo)

                    If True Then
                        Dim withBlock = tblTroubleTicketReq(0)
                        withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                        withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                        withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                        cmbStatus.Text = withBlock.Status
                        cmbType.Text = withBlock.Type
                        withBlock.RequestDate = Date.Now
                        withBlock.DueDate = Date.Now
                    End If
                End If

                PopulateControls()
            Catch ex As Exception
                Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try
        End If
    End Sub

    Public Sub AddTroubleTicket()
        Try
            Dim thisTroubleTicket As clsTroubleTicketReq = New clsTroubleTicketReq()

            If True Then
                Dim withBlock = thisTroubleTicket
                If txttroubleticketno.Text.Length = 0 Then

                    'if (pickRequestDate.SelectedDate == null)
                    '    withBlock.RequestDate = DateTime.Now;
                    'else
                    '    withBlock.RequestDate = (DateTime)pickRequestDate.SelectedDate;
                    If Equals(cmbType.Text, String.Empty) Then Return
                End If



                withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                cmbStatus.Text = withBlock.Status
                cmbType.Text = withBlock.Type
                withBlock.DueDate = Date.Now
                withBlock.RequestDate = Date.Now


            End If
            Try

                Dim theNotificationSystem As clsNotificationSystem = New clsNotificationSystem()
                theNotificationSystem.AddTroubleTicket(thisTroubleTicket)
                lblResult.Text = "Trouble Ticket data has been added"

            Catch ex As SqlException
                If ex.Number = 2627 Then
                    lblResult.Text = "Ticket already exist!"
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
        Return
    End Sub

    Public Sub ClearControls()
        Try
            'pickRequestDate.Clear();
            cmbStatus.Value = String.Empty
            cmbStatus.Text = String.Empty
            cmbType.Value = String.Empty
            cmbType.Text = String.Empty


        Catch __unusedException1__ As Exception
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
    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        Response.Redirect("TroubleTicketReq_Find.aspx", False)
    End Sub
End Class
