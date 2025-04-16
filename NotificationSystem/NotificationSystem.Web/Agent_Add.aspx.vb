Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Agent_Add
        Inherits Page
        Private m_AgentList As String = String.Empty

        Public m_AgentID As Integer = 0

        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
            End Set
        End Property
        Public Property AgentList As String
            Get
                Return m_AgentList
            End Get
            Set(value As String)
                m_AgentList = value
            End Set
        End Property

        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If MyBase.Page.IsPostBack Then
                If Equals(Request.Form("ctl00$MainContent$ctrAgent_Search$btnSearch"), "Search") Then
                    ctrAgent_Search.PopulateSearchControl()
                    If ctrAgent_Search.AgentID = 0 Then Return
                    ctrAgent_Add.ClearControls()
                    ctrAgent_Add.AgentList = ctrAgent_Search.AgentID
                ElseIf Equals(Request.Form("ctl00$MainContent$ctrAgent_Add$btnCreate"), "Add") Then
                    ctrAgent_Add.AddAgent()
                    If ctrAgent_Search.AgentID = 0 Then Return
                End If

            End If
        End Sub
    End Class
End Namespace
