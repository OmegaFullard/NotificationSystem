Imports System
Imports System.Web.UI

Public Partial Class ctrAgent_Search
    Inherits UserControl

    Public m_AgentID As Integer = 0

    Public Property AgentID As Integer
        Get
            Return m_AgentID
        End Get
        Set(value As Integer)
            m_AgentID = value
        End Set

    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Public Sub PopulateSearchControl()
        m_AgentID = Integer.Parse(txtagentid.Text)

    End Sub
End Class
