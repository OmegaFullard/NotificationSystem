Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Microsoft.VisualBasic
Imports System.Data

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class ctrTroubleTicketReq
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
        Protected Sub Page_Load(sender As Object, e As EventArgs)


            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblTTR As NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable()

            Try
                If Equals(Request.Form("ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"), "Search") Then ctrHiddebField.Value = Convert.ToString(m_TroubleTicketNo)


                If MyBase.Page.IsPostBack And ctrHiddebField.Value.Length > 0 Then
                    tblTTR = CType(theNotificationSystem.GetTroubleTicket(m_TroubleTicketNo), NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable)
                Else
                    tblTTR = CType(theNotificationSystem.GetTT(), NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable)
                End If

                lblSearchResult.Text = tblTTR.Rows.Count.ToString() & " Result(s)"
                grdTroubleTicketReq.DataSource = tblTTR.DefaultView
                grdTroubleTicketReq.DataBind()
            Catch __unusedException1__ As Exception
                Throw
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
End Namespace
