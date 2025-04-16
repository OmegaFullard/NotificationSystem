Imports System
Imports System.Data.SqlClient
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem

Namespace NotificationSystem.NotificationSystem.Web.Controls_Delete
    Public Partial Class ctrAdmin_Delete
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

            Dim theNotificationSystem As New clsNotificationSystem
            Dim tblAdmin As New AdminDataTable

            Try
                If Page.IsPostBack Then
                    'button click to delete form data 

                    If Request.Form("ctl00$MainContent$ctrAdmin_Delete$btnDelete") = "Delete" Then
                        DeleteAdmin()
                    End If
                Else

                    If m_UserName = "0" Then Return
                    tblAdmin = CType(theNotificationSystem.GetAdmins(), AdminDataTable)

                    If (tblAdmin.Count = 0) Then Return

                    Dim withBlock = tblAdmin(0)

                    withBlock.UserName = txtusername.Text
                    withBlock.Password = txtpassword.Text
                    withBlock.First = txtfirstname.Text
                    withBlock.Last = txtlastname.Text
                    withBlock.Email = txtemailaddress.Text


                    If Not String.IsNullOrEmpty(withBlock.Email) Then
                        txtemailaddress.Text = withBlock.Email


                        btnDelete.Enabled = True
                    End If

                End If

            Catch ex As Exception
                Dim SendError As New clsNotificationSystem_Web
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try
        End Sub


        Public Sub DeleteAdmin()

            Dim thisAdmin = New clsAdmin

            If txtusername.Text.Length = 0 Then Return
                    If True Then
                        Dim withBlock = thisAdmin
                        withBlock.UserName = txtusername.Text
                    End If

            '    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
            '    theNotificationSystem.DeleteAdmin(thisAdmin);
            '    lblResult.Text = "Admin data has been deleted";
            Try
                Catch ex As SqlException

                    Throw New ApplicationException(ex.Message)
                End Try


                CleanupControls()

        End Sub
        Private Sub CleanupControls()
            txtusername.Text = String.Empty
            txtpassword.Text = String.Empty
            txtfirstname.Text = String.Empty
            txtlastname.Text = String.Empty
            txtemailaddress.Text = String.Empty
        End Sub
        Public Sub CleanResultControl()
            lblResult.Text = String.Empty
        End Sub

        Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
            Response.Redirect("Admin_Find.aspx", False)
        End Sub
    End Class
End Namespace
