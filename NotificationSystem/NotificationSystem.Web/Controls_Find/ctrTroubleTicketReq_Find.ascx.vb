Imports NotificationSystem.NotificationSystem.Data.Classes
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.IO

Public Partial Class ctrTroubleTicketReq_Find
    Inherits UserControl
    Private m_TroubleTicketNo As Integer = 0
    Private m_AgentID As Integer = 0
    Private m_CustomerID As Integer = 0

    Public Property TroubleTicketNo As Integer
        Get
            Return m_TroubleTicketNo
        End Get
        Set(value As Integer)
            m_TroubleTicketNo = value
        End Set
    End Property



    Public Property AgentID As Integer
        Get
            Return m_AgentID
        End Get
        Set(value As Integer)
            m_AgentID = value
        End Set

    End Property

    Public Property CustomerID As Integer
        Get
            Return m_CustomerID
        End Get
        Set(value As Integer)
            m_CustomerID = value
        End Set
    End Property
    Protected Sub Page_Load(sender As Object, e As EventArgs)

        Dim theNotificationSystem As clsNotificationSystem = New clsNotificationSystem()
        Dim tblTroubleTicketReq As TroubleTicketReqDataTable = New TroubleTicketReqDataTable()
        Try
            If Equals(Request.Form("ctl00$MainContent$ctrSearch_TT_Find$btnSearch"), "Search") Then lblSearchResult.Text = "Ticket" & m_TroubleTicketNo.ToString()

            If MyBase.Page.IsPostBack And lblSearchResult.Text.Length > 0 Then
                tblTroubleTicketReq = CType(theNotificationSystem.GetTroubleTicket(Integer.Parse(lblSearchResult.Text.Replace("Ticket", ""))), TroubleTicketReqDataTable)
            Else
                tblTroubleTicketReq = CType(theNotificationSystem.GetTT(), TroubleTicketReqDataTable)
            End If


            lblSearchResult.Text = tblTroubleTicketReq.Rows.Count.ToString()
            grdTroubleTicketReq.DataSource = tblTroubleTicketReq.DefaultView
            grdTroubleTicketReq.DataBind()


        Catch ex As Exception

            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
            Dim NotificationBody = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try
    End Sub


    Private Function ConvertSortDirection(e As GridViewSortEventArgs) As String
        MyBase.ViewState.Add("columnname", e.SortExpression)

        If MyBase.ViewState("direction") Is Nothing Then
            MyBase.ViewState.Add("direction", "asc")
        Else
            MyBase.ViewState("direction") = IIf(Equals(MyBase.ViewState("direction").ToString().ToLower(), "desc"), "asc", "desc")
        End If

        Return MyBase.ViewState("direction").ToString()
    End Function
    Public Sub CreateExcelFiles()
        Try
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("content-disposition", "attachment;filename=Ticket_Information.xls")
            Response.Charset = ""
            Response.ContentType = "application/vnd.ms-excel"
            Dim sw As StringWriter = New StringWriter()
            Dim hw As HtmlTextWriter = New HtmlTextWriter(sw)
            grdTroubleTicketReq.AllowPaging = False
            grdTroubleTicketReq.DataBind()

            For y = 0 To 12
                grdTroubleTicketReq.HeaderRow.Cells(y).Style.Add("background-color", "#cfdbe6")
            Next

            For x As Integer = 0 To grdTroubleTicketReq.Rows.Count - 1
                For y = 0 To 12
                    If x Mod 2 > 0 Then grdTroubleTicketReq.Rows(x).Cells(y).Style.Add("background-color", "#e0ebea")
                Next
            Next

            grdTroubleTicketReq.Attributes.Add("style", "vnd.ms-excel.numberformat:@")
            grdTroubleTicketReq.RenderControl(hw)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()




        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        CreateExcelFiles()
    End Sub

    Protected Sub grdTroubleTicketReq_PageIndexChanging(sender As Object, e As GridViewPageEventArgs)
        Try
            If Not (IsNothing(MyBase.ViewState("columnname")) Or IsNothing(MyBase.ViewState("direction"))) Then
                Dim m_DataView = CType(grdTroubleTicketReq.DataSource, DataView)

                If m_DataView Is Nothing Then
                    m_DataView.Sort = MyBase.ViewState("columnname").ToString() & " " & MyBase.ViewState("direction").ToString()
                    grdTroubleTicketReq.DataSource = m_DataView
                End If
            End If

            grdTroubleTicketReq.PageIndex = e.NewPageIndex
            grdTroubleTicketReq.DataBind()
        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub

    Protected Sub grdTroubleTicketReq_Sorting(sender As Object, e As GridViewSortEventArgs)
        Try
            Dim m_Dataview = CType(grdTroubleTicketReq.DataSource, DataView)

            If m_Dataview Is Nothing Then
                m_Dataview.Sort = e.SortExpression & " " & ConvertSortDirection(e)
                grdTroubleTicketReq.DataSource = m_Dataview
                grdTroubleTicketReq.DataBind()
            End If
        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub
End Class

