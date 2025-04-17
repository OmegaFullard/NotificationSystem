Imports System
Imports System.Data.SqlClient
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem

Namespace NotificationSystem.NotificationSystem.Web.Controls_Update
    Public Partial Class ctrAdmin_Update
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
            Dim tblAdmin As AdminDataTable

            Try
                If Page.IsPostBack Then

                    If Request.Form("ct100$MainContent$ctrAdmin_Update$btnUpdate") = "Update" Then
                        UpdateAdmin()
                    Else
                        If CInt(m_UserName) = 0 Then Return



                        tblAdmin = CType(theNotificationSystem.GetAdmins(), AdminDataTable)

                        If tblAdmin.Count = 0 Then Return


                        If True Then
                            Dim withBlock = tblAdmin(0)

                            withBlock.UserName = txtusername.Text
                                withBlock.Password = txtpassword.Text
                                withBlock.First = txtfirstname.Text
                                withBlock.Last = txtlastname.Text
                                withBlock.Email = txtemailaddress.Text


                                If Not String.IsNullOrEmpty(withBlock.Email) Then
                                    txtemailaddress.Text = withBlock.Email
                                End If


                        End If
                        btnUpdate.Enabled = True
                End If

                Else

                PopulateControls()
                End If

            Catch ex As Exception
                Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)

            End Try
        End Sub

        Public Sub ClearControls()
            Try


            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Public Sub UpdateAdmin()

            Dim thisAdmin As New clsAdmin
            Try

                Dim withBlock = thisAdmin
                    If txtusername.Text.Length = 0 Then Return

                withBlock.First = txtfirstname.Text
                    withBlock.Last = txtlastname.Text
                    withBlock.Email = txtemailaddress.Text

                    withBlock.UserName = txtusername.Text
                    withBlock.Password = txtpassword.Text


                Try
                    Dim theNotificationSystem As New clsNotificationSystem

                    theNotificationSystem.UpdateAdmin(thisAdmin)
                    lblResult.Text = "Admin data has been updated"
                Catch ex As SqlException

                    Throw New ApplicationException(ex.Message)
                End Try


            Catch ex As Exception
                Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try


        End Sub

        Private Sub PopulateControls()
            'clsNotificationSystem theNotificationSystem = new clsNotificationSystem();


            'cmbStates.DataSource = theNotificationSystem.GetStatesList();
            'cmbStates.DataTextField = "State";
            'cmbStates.DataBind();
            'cmbStates.Text = "PA";



        End Sub

        Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
            Response.Redirect("Admin_Find.aspx", False)
        End Sub
    End Class
End Namespace
