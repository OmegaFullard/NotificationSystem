Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports System.Data.SqlClient

Public Partial Class ctrAgent_Add
    Inherits UserControl
    Private m_AgentList As Integer



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

    Public Property AgentList As Integer
        Get
            Return m_AgentList
        End Get
        Friend Set(value As Integer)
            m_AgentList = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        PopulateControls()



    End Sub

    Public Sub AddAgent()
        Try
            Dim thisAgent As New clsAgent

            With thisAgent



                .AgentID = Integer.Parse(txtagentid.Text)
                .Title = txttitle.Text
                .FirstN = txtfirstname.Text
                .LastN = txtlastname.Text
                .Email = txtemailaddress.Text
                .Phone = txtPhoneNumber.Text
                .Fax = txtFaxNumber.Text
                .Salary = txtsalary.Text

                If txtagentid.Text.Length = 0 Then Return
            End With


            Dim theNotificationSystem As New clsNotificationSystem
            theNotificationSystem.AddAgent(thisAgent)
                lblResult.Text = "Agent data has been added"


        Catch ex As Exception
            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web
            Dim NotificationBody = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try
    End Sub
    Public Sub PopulateControls()

    End Sub
    Public Sub ClearControls()
        Try


        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        Response.Redirect("Agent_Find.aspx", False)
    End Sub
End Class
