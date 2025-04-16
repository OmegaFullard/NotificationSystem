Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Admin_Add
        Inherits Page
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
            If MyBase.Page.IsPostBack Then
                If Equals(Request.Form("ctl00$MainContent$ctrSearch_Admin$btnSearch"), "Search") Then
                    ctrSearch_Admin.PopulateSearchControl()
                    If Equals(ctrSearch_Admin.UserName, "0") Then Return
                    ctrAdmin_Add.ClearControls()
                    ctrAdmin_Add.UserName = ctrSearch_Admin.UserName
                ElseIf Equals(Request.Form("ctl00$MainContent$ctrAdmin_Add$btnCreate"), "Add") Then
                    ctrAdmin_Add.AddAdmin()
                    If Equals(ctrSearch_Admin.UserName, "0") Then

                    End If
                    Return
                End If

            End If
        End Sub
    End Class
End Namespace
