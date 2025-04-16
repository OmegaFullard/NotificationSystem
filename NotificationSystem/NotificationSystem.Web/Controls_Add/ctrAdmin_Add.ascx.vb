Imports System
Imports System.Data.SqlClient
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.Classes

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

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            PopulateControls()
            If Not IsPostBack Then
                txtusername.Text = UserName
                txtusername.Enabled = False
                txtfirstname.Text = ""
                txtlastname.Text = ""
                txtemailaddress.Text = ""
                txtpassword.Text = ""
            End If

        End Sub

        Public Sub AddAdmin()
            Try
                Dim thisAdmin As New clsAdmin

                With thisAdmin

                    .UserName = txtusername.Text
                    .Password = txtpassword.Text
                    .First = txtfirstname.Text
                    .Last = txtlastname.Text
                    .Email = txtemailaddress.Text

                    If txtusername.Text.Length = 0 Then Return

                End With

                Dim theNotificationSystem As New clsNotificationSystem
                    theNotificationSystem.AddAdmin(thisAdmin)
                    lblResult.Text = "Admin data has been added"
                Catch ex As SqlException
                    If ex.Number = 2627 Then
                        lblResult.Text = "Admin already exist!"
                    Else
                        Throw New ApplicationException(ex.Message)
                    End If
                End Try



        End Sub
        Public Sub PopulateControls()
            Dim theNotificationSystem As New clsNotificationSystem
        End Sub
        Public Sub ClearControls()
            Try


            Catch ex As Exception
                Throw
            End Try
        End Sub

        Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
            Response.Redirect("Admin_Find.aspx", False)
        End Sub
    End Class
End Namespace
