Imports System
Imports System.Data.SqlClient
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace NotificationSystem.NotificationSystem.Web.Controls_Delete
    Public Partial Class ctrAgent_Delete
        Inherits UserControl
        Private m_AgentID As Integer = 0

        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
            End Set
        End Property

        Public Property txtAgentList As TextBox
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable()

            Try
                If MyBase.Page.IsPostBack Then
                    'button click to delete form data 

                    If Equals(Request.Form("ctl00$MainContent$ctrAgent_Delete$btnDelete"), "Delete") Then DeleteAgent()
                Else

                    If m_AgentID = 0 Then Return
                    tblAgent = CType(theNotificationSystem.GetAgents(), NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable)
                                        ''' Cannot convert IfStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitIfStatement(IfStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
''' 
''' 
'''                     if (tblAgent.Count == 0)
'''                         return;
''' 
''' 

                    If True Then
                        Dim withBlock = tblAgent(0)

                        withBlock.AgentID = Integer.Parse(txtagentid.Text)
                        txttitle.Text = withBlock.Title
                        withBlock.Salary = Integer.Parse(txtsalary.Text)
                        withBlock.AgentID = Integer.Parse(txtagentid.Text)
                        txtfirstname.Text = withBlock.FirstN
                        txtlastname.Text = withBlock.LastN

                        If Not String.IsNullOrEmpty(withBlock.Phone) Then txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

                        If Not String.IsNullOrEmpty(withBlock.Email) Then
                            txtemailaddress.Text = withBlock.Email
                        End If

                        If Not String.IsNullOrEmpty(withBlock.Fax) Then txtFaxNumber.Text = withBlock.Fax.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

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



        Public Sub DeleteAgent()
            Try
                Dim thisAgent As NotificationSystem.NotificationSystem.Data.Classes.clsAgent = New NotificationSystem.NotificationSystem.Data.Classes.clsAgent()

                If True Then

                    If txtagentid.Text.Length = 0 Then Return
                    If True Then
                        Dim withBlock = thisAgent
                        withBlock.AgentID = Integer.Parse(txtagentid.Text)
                    End If


                End If

                '    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                '    theNotificationSystem.DeleteAgent(thisAgent);
                '    lblResult.Text = "Agent data has been deleted";
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
            txtagentid.Text = String.Empty
            txttitle.Text = String.Empty
            txtsalary.Text = String.Empty
            txtfirstname.Text = String.Empty
            txtlastname.Text = String.Empty
            txtemailaddress.Text = String.Empty
            txtPhoneNumber.Text = String.Empty
            txtFaxNumber.Text = String.Empty
        End Sub
        Public Sub CleanResultControl()
            lblResult.Text = String.Empty
        End Sub

        Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
            Response.Redirect("Agent_Find.aspx", False)
        End Sub

    End Class
End Namespace
