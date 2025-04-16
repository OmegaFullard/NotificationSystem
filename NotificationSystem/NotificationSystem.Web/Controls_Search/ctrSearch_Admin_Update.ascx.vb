Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Admin_Update
        Inherits UserControl
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()

            If Not MyBase.Page.IsPostBack Then
                cmbAdmin.DataSource = theNotificationSystem.GetAdmins()
                cmbAdmin.DataTextField = "UserName"
                cmbAdmin.DataValueField = "Password"
                cmbAdmin.DataBind()
            End If
        End Sub

        Public Sub ClearControl()
            cmbAdmin.Value = String.Empty
            cmbAdmin.Text = "--"
        End Sub
    End Class
End Namespace
