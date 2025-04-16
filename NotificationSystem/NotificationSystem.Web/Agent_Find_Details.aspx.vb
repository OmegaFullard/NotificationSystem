Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Agent_Find_Details
        Inherits Page
        Private m_AgentID As Integer = 0

        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
            End Set
        End Property


        Protected Sub Page_Load(sender As Object, e As EventArgs)

            '''syntax errors 3 / 23 / 24

            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable()

            Try
                If Equals(Request.QueryString("Agent"), Nothing) Then Return

                Dim arrAgents = Request.QueryString("agent").Split(Convert.ToChar(":"))
                AgentID = Integer.Parse(arrAgents(0))
                If AgentID = 0 Then Return

                tblAgent = CType(theNotificationSystem.GetAgent(AgentID), NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable)
                                ''' Cannot convert IfStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitIfStatement(IfStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
''' 				if (tblAgent.Count == 0)
''' 					return;
''' 
''' 

                If True Then
                    Dim withBlock = tblAgent(0)
                    withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                    txttitle.Text = withBlock.Title
                    withBlock.Salary = Integer.Parse(txtSalary.Text)
                    txtfirstname.Text = withBlock.FirstN
                    txtlastname.Text = withBlock.LastN

                    If Not String.IsNullOrEmpty(withBlock.Phone) Then txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

                    If Not String.IsNullOrEmpty(withBlock.Email) Then
                        txtEmailAddress.Text = withBlock.Email
                    End If

                    If Not String.IsNullOrEmpty(withBlock.Fax) Then txtFaxNumber.Text = withBlock.Fax.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")
                End If





            Catch __unusedException1__ As Exception
            End Try
        End Sub
    End Class
End Namespace
