Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class ErrorPage
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)

        End Sub

        Protected Sub btnBack_Click(sender As Object, e As EventArgs)
            Response.Redirect("Default.aspx", False)
        End Sub
    End Class
End Namespace
