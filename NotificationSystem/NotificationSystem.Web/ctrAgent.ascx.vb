Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports Microsoft.VisualBasic

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class ctrAgent
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
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblGetAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable()

            'int agentID = m_AgentID;

            Try

                If Equals(Request.Form("ctl00$MainContent$ctrAgent_Search$btnSearch"), "Search") Then ctrHiddebField.Value = Convert.ToString(m_AgentID)


                If MyBase.Page.IsPostBack And lblSearchResult.Text.Length > 0 Then
                    tblGetAgent = CType(theNotificationSystem.GetAgent(m_AgentID), NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable)
                Else
                    tblGetAgent = CType(theNotificationSystem.GetAgents(), NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable)
                End If


                lblSearchResult.Text = tblGetAgent.Rows.Count.ToString() & " Result(s)"
                grdAgents.DataSource = tblGetAgent.DefaultView
                grdAgents.DataBind()

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

        Protected Sub grdAgents_PageIndexChanging(sender As Object, e As GridViewPageEventArgs)
            Try
                If Not (IsNothing(MyBase.ViewState("columnname")) Or IsNothing(MyBase.ViewState("direction"))) Then
                    Dim m_DataView = CType(grdAgents.DataSource, DataView)

                    If m_DataView Is Nothing Then
                        m_DataView.Sort = MyBase.ViewState("columnname").ToString() & " " & MyBase.ViewState("direction").ToString()
                        grdAgents.DataSource = m_DataView
                    End If
                End If

                grdAgents.PageIndex = e.NewPageIndex
                grdAgents.DataBind()
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Protected Sub grdAgents_Sorting(sender As Object, e As GridViewSortEventArgs)
            Try
                Dim m_Dataview = CType(grdAgents.DataSource, DataView)

                If m_Dataview Is Nothing Then
                    m_Dataview.Sort = e.SortExpression & " " & ConvertSortDirection(e)
                    grdAgents.DataSource = m_Dataview
                    grdAgents.DataBind()
                End If
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub
    End Class
End Namespace
