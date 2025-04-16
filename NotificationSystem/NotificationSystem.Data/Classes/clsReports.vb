Imports System
Imports System.Data

Namespace NotificationSystem.NotificationSystem.Data.Classes
    Friend Class clsReports


        Public Function GetAgReport() As DataTable
            Try
                Dim adpAgents As NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.AgentTableAdapter()
                Dim tblAgent As NotificationSystem.NotificationSystem.Data.xsReports.AgentDataTable = adpAgents.GetData()

                Return tblAgent
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function
        Public Function GetAgentByAgentID(AgentID As Integer) As DataTable
            Try
                Dim adpAgents As NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.AgentTableAdapter()
                Dim tblAgent As NotificationSystem.NotificationSystem.Data.xsReports.AgentDataTable = adpAgents.GetDataByAgentID(AgentID)

                Return tblAgent
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Function GetCustReport() As DataTable
            Try
                Dim adpCustomers As NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.CustomerTableAdapter()
                Dim tblCustomer As NotificationSystem.NotificationSystem.Data.xsReports.CustomerDataTable = adpCustomers.GetData()

                Return tblCustomer
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetCustomerByCustomerID(CustomerID As Integer) As DataTable
            Try
                Dim adpCustomers As NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.xsReportsTableAdapters.CustomerTableAdapter()
                Dim tblCustomer As NotificationSystem.NotificationSystem.Data.xsReports.CustomerDataTable = adpCustomers.GetDataByCustomerID(CustomerID)

                Return tblCustomer
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace
