Imports System
Imports System.Data.SqlClient
Imports System.Web.UI

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
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable()

            Try
                If MyBase.Page.IsPostBack Then
                    'button click to delete form data 

                    If Equals(Request.Form("ctl00$MainContent$ctrAdmin_Delete$btnDelete"), "Delete") Then DeleteAdmin()
                Else

                    If Equals(m_UserName, "0") Then Return
                    tblAdmin = CType(theNotificationSystem.GetAdmins(), NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable)
                                        ''' Cannot convert IfStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitIfStatement(IfStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
''' 
''' 
'''                     if (tblAdmin.Count == 0)
'''                         return;
''' 
''' 

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

                    btnDelete.Enabled = True
                End If

            Catch ex As Exception
                Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try
        End Sub


        Public Sub DeleteAdmin()
            Try
                Dim thisAdmin As NotificationSystem.NotificationSystem.Data.Classes.clsAdmin = New NotificationSystem.NotificationSystem.Data.Classes.clsAdmin()

                If True Then

                    If txtusername.Text.Length = 0 Then Return
                    If True Then
                        Dim withBlock = thisAdmin
                        withBlock.UserName = txtusername.Text
                    End If


                End If

                '    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                '    theNotificationSystem.DeleteAdmin(thisAdmin);
                '    lblResult.Text = "Admin data has been deleted";
                Try
                Catch ex As SqlException

                    Throw New ApplicationException(ex.Message)
                End Try


                CleanupControls()
            Catch __unusedException1__ As Exception
                Throw
            End Try
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
