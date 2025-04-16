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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PopulateControls()
        If Not IsPostBack Then
            txtcustomerid.Text = TroubleTicketNo.ToString()
            txtcustomerid.Enabled = False
            txtAgentID.Text = "0"
            txttroubleticketno.Text = "0"
            cmbStatus.Text = ""
            cmbType.Text = ""
        End If
    End Sub

    Public Sub AddTroubleTicket()
        Try
            Dim thisTroubleTicket As New clsTroubleTicketReq


            With thisTroubleTicket

                If pickRequestDate.SelectedDate Is Nothing Then .RequestDate = Date.Now Else .RequestDate = CDate(pickRequestDate.SelectedDate)


                If String.IsNullOrEmpty(cmbType.Text) Then Return

                .CustomerID = Integer.Parse(txtcustomerid.Text)
                .AgentID = Integer.Parse(txtAgentID.Text)
                .TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                .Status = cmbStatus.Text
                .Type = cmbType.Text
                .DueDate = Date.Now

                If txttroubleticketno.Text.Length = 0 Then
                    ' Handle empty TroubleTicketNo if necessary
                End If
            End With
            Dim theNotificationSystem As New clsNotificationSystem
            theNotificationSystem.AddTroubleTicket(thisTroubleTicket)
                lblResult.Text = "Trouble Ticket data has been added"


        Catch ex As Exception
            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
            Dim NotificationBody = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try

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
