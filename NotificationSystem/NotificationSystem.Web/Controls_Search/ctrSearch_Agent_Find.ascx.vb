Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Agent_Find
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
            If Not IsPostBack Then
                ' Initialize the control here if needed
            End If

        End Sub

        Public Sub PopulateSearchControl()
            m_AgentID = Integer.Parse(txtAgentName.Text)
        End Sub
    End Class
End Namespace
