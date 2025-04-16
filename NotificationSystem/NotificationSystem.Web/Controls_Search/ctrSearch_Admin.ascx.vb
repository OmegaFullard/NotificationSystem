Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Admin
        Inherits UserControl
        Private m_UserName As String = String.Empty

        Public Property UserName As String
            Get
                Return m_UserName
            End Get
            Set(value As String)
                m_UserName = value
            End Set
        End Property
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                txtUserName.Text = m_UserName
            End If

        End Sub
        Public Sub PopulateSearchControl()
            m_UserName = txtUserName.Text
        End Sub

    End Class
End Namespace
