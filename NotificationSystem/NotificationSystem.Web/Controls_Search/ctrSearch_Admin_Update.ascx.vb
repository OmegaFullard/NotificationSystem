Imports System
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.Classes

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Admin_Update
        Inherits UserControl
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim theNotificationSystem As New clsNotificationSystem

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
