Imports System
Imports System.Data.SqlClient
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Add
    Public Partial Class ctrAdmin_Add
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
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable()

            Try
                If MyBase.Page.IsPostBack Then
                    If Equals(Request.Form("ctl00$MainContent$ctrAdmin_Add$btnAdd"), "Add") Then AddAdmin()
                Else
                    PopulateControls()
                End If
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Public Sub AddAdmin()
            Try
                Dim thisAdmin As NotificationSystem.NotificationSystem.Data.Classes.clsAdmin = New NotificationSystem.NotificationSystem.Data.Classes.clsAdmin()

                If True Then
                    Dim withBlock = thisAdmin
                    If txtusername.Text.Length = 0 Then Return


                    withBlock.UserName = txtusername.Text
                    withBlock.Password = txtpassword.Text
                    withBlock.First = txtfirstname.Text
                    withBlock.Last = txtlastname.Text
                    withBlock.Email = txtemailaddress.Text
                End If

                Try
                    Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
                    theNotificationSystem.AddAdmin(thisAdmin)
                    lblResult.Text = "Admin data has been added"
                Catch ex As SqlException
                    If ex.Number = 2627 Then
                        lblResult.Text = "Admin already exist!"
                    Else
                        Throw New ApplicationException(ex.Message)
                    End If
                End Try


            Catch ex As Exception
                Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try
        End Sub
        Public Sub PopulateControls()
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
        End Sub
        Public Sub ClearControls()
            Try


            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
            Response.Redirect("Admin_Find.aspx", False)
        End Sub
    End Class
End Namespace
