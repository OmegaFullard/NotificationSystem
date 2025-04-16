Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Admin_Find
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
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            m_UserName = txtUserName.Text
        End Sub
    End Class
End Namespace
