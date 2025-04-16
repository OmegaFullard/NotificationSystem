Imports System
Imports System.Data.SqlClient
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace NotificationSystem.NotificationSystem.Web.Controls_Delete
    Public Partial Class ctrCustomer_Delete
        Inherits UserControl
        Private m_CustomerID As Integer = 0

        Public Property CustomerID As Integer
            Get
                Return m_CustomerID
            End Get
            Set(value As Integer)
                m_CustomerID = value
            End Set
        End Property
        Public Property txtCustomerList As TextBox
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable()

            Try
                If MyBase.Page.IsPostBack Then


                    If Equals(Request.Form("ctl00$MainContent$ctrCustomer_Delete$btnDelete"), "Delete") Then DeleteCustomer()
                Else
                    If m_CustomerID = 0 Then Return
                    tblCustomer = CType(theNotificationSystem.GetCustomers(), NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable)
                                        ''' Cannot convert IfStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitIfStatement(IfStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
''' 
''' 
'''                     if (tblCustomer.Count == 0)
'''                         return;
''' 
''' 

                    If True Then
                        Dim withBlock = tblCustomer(0)

                        withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                        withBlock.AgentID = Integer.Parse(txtAgentID.Text)
                        withBlock.TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
                        txtfirstname.Text = withBlock.FirstN
                        txtlastname.Text = withBlock.LastN
                        withBlock.UserName = txtusername.Text
                        withBlock.Password = txtpassword.Text
                        If Not String.IsNullOrEmpty(withBlock.Phone) Then txtPhoneNumber.Text = withBlock.Phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")

                        If Not String.IsNullOrEmpty(withBlock.Email) Then
                            txtemailaddress.Text = withBlock.Email
                        End If


                        If Not String.IsNullOrEmpty(withBlock.Address) Then
                            txtaddress.Text = withBlock.Address
                        End If

                        If Not String.IsNullOrEmpty(withBlock.City) Then
                            txtcity.Text = withBlock.City

                            If Not String.IsNullOrEmpty(withBlock.State) Then txtstate.Text = withBlock.State
                        End If

                        If Not String.IsNullOrEmpty(withBlock.Zip) Then txtzip.Text = withBlock.Zip.Substring(0, 5)
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
        Public Sub DeleteCustomer()
            Try
                Dim thisCustomer As NotificationSystem.NotificationSystem.Data.Classes.clsCustomer = New NotificationSystem.NotificationSystem.Data.Classes.clsCustomer()

                If True Then

                    If txtcustomerid.Text.Length = 0 Then Return
                    If True Then
                        Dim withBlock = thisCustomer
                        withBlock.CustomerID = Integer.Parse(txtcustomerid.Text)
                    End If


                End If

                'clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
                'theNotificationSystem.DeleteCustomer(thisCustomer);
                'lblResult.Text = "Customer data has been deleted";
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
            txtcustomerid.Text = String.Empty
            txtAgentID.Text = String.Empty
            txttroubleticketno.Text = String.Empty
            txtfirstname.Text = String.Empty
            txtlastname.Text = String.Empty
            txtusername.Text = String.Empty
            txtpassword.Text = String.Empty
            txtemailaddress.Text = String.Empty
            txtPhoneNumber.Text = String.Empty
            txtaddress.Text = String.Empty
            txtcity.Text = String.Empty
            txtstate.Text = String.Empty
            txtzip.Text = String.Empty
        End Sub
        Public Sub CleanResultControl()
            lblResult.Text = String.Empty
        End Sub

        Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
            Response.Redirect("Customer_Find.aspx", False)
        End Sub
    End Class
End Namespace
