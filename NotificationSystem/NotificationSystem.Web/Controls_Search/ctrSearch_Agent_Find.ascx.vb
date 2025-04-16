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

        Protected Sub Page_Load(sender As Object, e As EventArgs)

        End Sub

        Public Sub PopulateSearchControl()
            m_AgentID = Integer.Parse(txtAgentName.Text)
        End Sub
    End Class
End Namespace
