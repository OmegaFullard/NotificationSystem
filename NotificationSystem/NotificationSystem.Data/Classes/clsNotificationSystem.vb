Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections.Generic
Imports NotificationSystem.NotificationSystem.Data
Imports NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem


Namespace NotificationSystem.NotificationSystem.Data.Classes
    Public Class clsNotificationSystem


        Public Function GetCustomersList() As DataTable
            Try
                Dim adpCustomerList As CustomerTableAdapter = New CustomerTableAdapter
                Dim tblCustomerList As CustomerDataTable = adpCustomerList.GetData()

                Return tblCustomerList

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetCustReport() As DataTable
            Try
                Dim adpCustomers As CustomerTableAdapter = New CustomerTableAdapter
                Dim tblCustomer As CustomerDataTable = adpCustomers.GetData()

                Return tblCustomer
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetCustomer(ByRef CustomerID As Integer) As DataTable
            Try
                Dim adpCustomerList As New CustomerTableAdapter
                Dim tblCustomerList As CustomerDataTable = adpCustomerList.GetCustomerByCustomerID(CustomerID)

                Return tblCustomerList
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetCustomers() As DataTable
            Try
                Dim adpCustomer As New CustomerTableAdapter
                Dim tblCustomer As CustomerDataTable = adpCustomer.GetData()

                Return tblCustomer

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetCustomerByTroubleTicket(ByRef TroubleTicketNo As Integer) As DataTable
            Try
                Dim adpCustomer As New CustomerTableAdapter
                Dim tblCustomer As CustomerDataTable = adpCustomer.GetByTroubleTicket(TroubleTicketNo)

                Return tblCustomer

            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Sub UpdateCustomer(ByVal thisCustomer As clsCustomer)
            Dim adpCustomer As New CustomerTableAdapter


            Try
                With thisCustomer
                    adpCustomer.Update(.AgentID, .TroubleTicketNo, .FirstN, .LastN, .Email, .Phone, .Address, .City, .State, .Zip, .UserName, .Password, .Original_CustomerID)
                End With

            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Function GetCustomerID() As Integer
            Dim adpGetCustomerID As New GetCustomerIDTableAdapter

            Try
                Dim tblGetCustomerID As GetCustomerIDDataTable = adpGetCustomerID.GetData()
                Dim row As GetCustomerIDRow = tblGetCustomerID(0)

                Return row.CustomerID
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub GetbyUserPW(username As String, password As String)
            Try
                Dim adpCustomer As New CustomerTableAdapter
                Dim tblCustomer As CustomerDataTable = adpCustomer.GetDataByUserPw(username, password)
                Dim row As CustomerRow = tblCustomer(0)
                Return
            Catch ex As Exception
                Throw
            End Try
        End Sub



        Public Function AddCustomer(ByVal thisCustomer As clsCustomer) As Integer
            Dim adpCustomer As New CustomerTableAdapter
            Dim adpGetCustomerID As New GetCustomerIDTableAdapter

            Try
                adpCustomer.Insert(thisCustomer.AgentID, thisCustomer.TroubleTicketNo, thisCustomer.FirstN, thisCustomer.LastN, thisCustomer.Phone, thisCustomer.Email, thisCustomer.Address, thisCustomer.City, thisCustomer.State, thisCustomer.Zip, thisCustomer.UserName, thisCustomer.Password)

                Dim tblGetCustomerID As GetCustomerIDDataTable = adpGetCustomerID.GetData()
                Dim row As GetCustomerIDRow = tblGetCustomerID(0)
                Return row.CustomerID
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub DeleteCustomer(ByVal thisCustomer As clsCustomer)
            Dim adpCustomer As New CustomerTableAdapter

            Try
                adpCustomer.DeleteQuery(thisCustomer.CustomerID)
            Catch ex As Exception
                Throw
            End Try
        End Sub


        Public Function GetAgentList() As DataTable
            Try
                Dim adpAgentList As New NotificationSystemTableAdapters.AgentTableAdapter
                Dim tblAgentList As New NotificationSystem.AgentDataTable
                tblAgentList = adpAgentList.GetData()

                Return tblAgentList

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetAgent(ByRef AgentID As Integer) As DataTable
            Try
                Dim adpAgentList As New NotificationSystemTableAdapters.AgentTableAdapter
                Dim tblGetAgent As New NotificationSystem.AgentDataTable
                tblGetAgent = adpAgentList.GetDataByAgentID(AgentID)

                Return tblGetAgent
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GetAgents() As DataTable
            Try
                Dim adpAgent As New NotificationSystemTableAdapters.AgentTableAdapter()
                Dim tblAgent As New NotificationSystem.AgentDataTable()
                tblAgent = adpAgent.GetData()

                Return tblAgent

            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GetAgReport(ByRef AgentID As Integer) As DataTable
            Try
                Dim adpAgents As New NotificationSystemTableAdapters.AgentTableAdapter
                Dim tblAgent As New NotificationSystem.AgentDataTable
                tblAgent = adpAgents.GetDataByAgentReport(AgentID)

                Return tblAgent
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GetAgentByTicket(ByRef TroubleTicketNo As Integer) As DataTable
            Try
                Dim adpAgent As New NotificationSystemTableAdapters.AgentTableAdapter
                Dim tblAgent As New NotificationSystem.AgentDataTable
                tblAgent = adpAgent.GetDataByTicket(TroubleTicketNo)

                Return tblAgent

            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GetAgentID() As Integer
            Dim adpGetAgentID As New NotificationSystemTableAdapters.GetAgentIDTableAdapter

            Try
                Dim tblGetAgentID As New NotificationSystem.GetAgentIDDataTable
                tblGetAgentID = adpGetAgentID.GetData()
                Dim row As NotificationSystem.GetAgentIDRow = tblGetAgentID(0)

                Return row.AgentID
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function AddAgent(ByVal thisAgent As clsAgent) As Integer
            Dim adpAgent As New AgentTableAdapter
            Dim adpGetAgentID As New GetAgentIDTableAdapter

            Try
                adpAgent.InsertQuery(thisAgent.TroubleTicketNo, thisAgent.Title, thisAgent.StartDate.ToString(), Integer.Parse(thisAgent.Salary), thisAgent.FirstN, thisAgent.LastN, thisAgent.Email, thisAgent.Phone, thisAgent.Fax)

                Dim tblGetAgentID As GetAgentIDDataTable = adpGetAgentID.GetData()
                Dim row As GetAgentIDRow = tblGetAgentID(0)
                Return row.AgentID
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub UpdateAgent(ByVal thisAgent As clsAgent)
            Dim adpAgent As New AgentTableAdapter

            Try
                adpAgent.UpdateQuery(thisAgent.TroubleTicketNo, thisAgent.Title, thisAgent.StartDate.ToString(), Integer.Parse(thisAgent.Salary), thisAgent.FirstN, thisAgent.LastN, thisAgent.Email, thisAgent.Phone, thisAgent.Fax, thisAgent.Original_AgentID)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Function GetTroubleTicketList() As DataTable
            Try
                Dim adpTroubleTicketList As New TroubleTicketReqTableAdapter
                Dim tblTroubleTicketList As TroubleTicketReqDataTable = adpTroubleTicketList.GetData()

                Return tblTroubleTicketList

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetTroubleTicketByNo(ByRef TroubleTicketNo As Integer) As Integer
            Try
                Dim adpTroubleTicketList As New TroubleTicketReqTableAdapter
                Dim tblTroubleTicketList As TroubleTicketReqDataTable = adpTroubleTicketList.GetDataByTroubleTicket(TroubleTicketNo)
                Dim row As TroubleTicketReqRow = tblTroubleTicketList(0)
                Return row.TroubleTicketNo
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetTT() As DataTable
            Try
                Dim adpTroubleTicket As New TroubleTicketReqTableAdapter()
                Dim tblTroubleTicketReq As TroubleTicketReqDataTable = adpTroubleTicket.GetData()

                Return tblTroubleTicketReq

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetTroubleTicket(ByRef TroubleTicketNo As Integer) As DataTable
            Try
                Dim adpTroubleTicketReq As New TroubleTicketReqTableAdapter
                Dim tblTroubleTicketReq As TroubleTicketReqDataTable = adpTroubleTicketReq.GetDataByTroubleTicket(TroubleTicketNo)

                Return tblTroubleTicketReq

            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Sub UpdateTroubleTicket(ByVal thisTroubleTicket As clsTroubleTicketReq)
            Dim adpTroubleTicket As New TroubleTicketReqTableAdapter

            Try
                adpTroubleTicket.Update(thisTroubleTicket.CustomerID, thisTroubleTicket.AgentID, thisTroubleTicket.Status, thisTroubleTicket.DueDate, thisTroubleTicket.RequestDate, thisTroubleTicket.Type, thisTroubleTicket.TroubleTicketNo)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub AddTroubleTicket(ByVal thisTroubleTicket As clsTroubleTicketReq)
            Dim adpTroubleTicketReq As New TroubleTicketReqTableAdapter

            Try
                adpTroubleTicketReq.Insert(thisTroubleTicket.CustomerID, thisTroubleTicket.AgentID, thisTroubleTicket.Status, thisTroubleTicket.DueDate, thisTroubleTicket.RequestDate, thisTroubleTicket.Type)
            Catch ex As Exception
                Throw
            End Try
        End Sub


        Public Function GetTroubleTicketNo() As Integer

            Dim adpTroubleTicketNumber As New GetTroubleTicketNoTableAdapter

            Try
                Dim tblGetTroubleTicketNo As GetTroubleTicketNoDataTable = adpTroubleTicketNumber.GetData()
                Dim row As GetTroubleTicketNoRow = tblGetTroubleTicketNo(0)

                Return row.TroubleTicketNo
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GetTypeList() As DataTable
            Try

                Dim adpType As New TypeTableAdapter
                Dim tblType As TypeDataTable = adpType.GetData()

                Return tblType
            Catch ex As Exception
                Throw
            End Try
        End Function

        'DataSet ds = new DataSet();
        'DataTable dt = new DataTable("GetData");
        '         DataRow dr;

        'dt.Columns.Add("Type", Type.GetType("System.String")).DefaultValue = string.Empty;

        '         // Create and populate rows
        '         // DataRow dr = dt.NewRow();

        '         dr = dt.NewRow();
        '         dr["Type"] = "Incident";
        '         dt.Rows.Add(dr);

        '         dr = dt.NewRow();
        '         dr["Type"] = "Task";
        '         dt.Rows.Add(dr);

        '         dr = dt.NewRow();
        '         dr["Type"] = "Problem";
        '         dt.Rows.Add(dr);

        '         return dt;
        'End Function


        Public Function GetStatusList() As DataTable

            Try
                Dim adpStatus As New StatusTableAdapter
                Dim tblStatus As StatusDataTable = adpStatus.GetData()

                Return tblStatus
            Catch ex As Exception
                Throw
            End Try
            'DataSet ds = new DataSet();
            'DataTable dt = new DataTable("GetData");
            '         DataRow dr;

            '''Add columns with appropriate data types


            '''dt.Columns.Add("ID", Type.GetType("System.String")).DefaultValue = 0;
            'dt.Columns.Add("Status", Type.GetType("System.String")).DefaultValue = string.Empty;

            '         //Create and populate rows

            '         //DataRow dr = dt.NewRow();

            '         dr = dt.NewRow();
            '         dr["Status"] = "Open";
            '         dt.Rows.Add(dr);

            '         dr = dt.NewRow();
            '         dr["Status"] = "Pending";
            '         dt.Rows.Add(dr);

            '         dr = dt.NewRow();
            '         dr["Status"] = "Resolved";
            '         dt.Rows.Add(dr);
            '         dr = dt.NewRow();
            '         dr["Status"] = "Closed";
            '         dt.Rows.Add(dr);


            '         return dt;
        End Function

        Public Function GetStatesList() As DataTable
            Dim ds As DataSet = New DataSet()
            Dim dt As DataTable = New DataTable("GetData")
            Dim dr As DataRow

            dt.Columns.Add("State", System.Type.GetType("System.String")).DefaultValue = String.Empty

            dr = dt.NewRow()
            dr("State") = "AL"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "AK"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "AZ"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "AR"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "CA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "CO"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "CT"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "DE"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "DC"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "FL"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "GA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "ID"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "IL"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "IN"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "IA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "KS"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "KY"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "LA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "Me"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "MD"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "MA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "MI"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "MN"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "MS"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "MO"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "MT"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "NE"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "NV"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "NH"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "NJ"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "NM"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "NY"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "NC"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "ND"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "OH"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "OK"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "OR"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "PA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "PR"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "RI"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "SC"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "SD"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "TN"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "TX"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "UT"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "VI"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "VA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "WA"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "WV"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "WI"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("State") = "WY"
            dt.Rows.Add(dr)


            Return dt
        End Function



        Public Sub GetAdminbyUserPW(password As String, username As String)
            Try
                Dim adpAdmin As New AdminTableAdapter
                Dim tblAdmin As AdminDataTable = adpAdmin.GetDataByUserNamePassword(username, password)
                Dim row As AdminRow = tblAdmin(0)
                Return
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Function GetAdmins() As DataTable
            Try
                Dim adpAdmin As New AdminTableAdapter
                Dim tblAdmin As AdminDataTable = adpAdmin.GetData()
                Return tblAdmin
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetAdmin(ByRef UserName As String) As DataTable
            Try
                Dim adpAdmin As New AdminTableAdapter
                Dim tblAdmin As AdminDataTable = adpAdmin.GetDataByUserName(UserName)
                Return tblAdmin
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub UpdateAdmin(ByVal thisAdmin As clsAdmin)
            Dim adpAdmin As New AdminTableAdapter

            Try
                adpAdmin.UpdateQuery(thisAdmin.UserName, thisAdmin.Password, thisAdmin.Email, thisAdmin.First, thisAdmin.Last, thisAdmin.UserName)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub AddAdmin(ByVal thisAdmin As clsAdmin)
            Dim adpAdmin As New AdminTableAdapter

            Try
                adpAdmin.InsertQuery(thisAdmin.UserName, thisAdmin.Password, thisAdmin.Email, thisAdmin.First, thisAdmin.Last)
            Catch ex As Exception
                Throw
            End Try
        End Sub


        Public Sub DeleteAdmin(ByVal thisAdmin As clsAdmin)
            Dim adpAdmin As New AdminTableAdapter

            Try
                adpAdmin.DeleteQuery(thisAdmin.UserName)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace
