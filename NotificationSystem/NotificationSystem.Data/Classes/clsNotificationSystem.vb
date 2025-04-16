Imports System
Imports System.Data

Namespace NotificationSystem.NotificationSystem.Data.Classes
    Public Class clsNotificationSystem



        Private _Customer As Boolean, _Agent As Boolean, _TroubleTicket As Boolean, _Title As Boolean, _Salary As Boolean, _Admin As Boolean

        Public Property Customer As Boolean
            Get
                Return _Customer
            End Get
            Private Set(value As Boolean)
                _Customer = value
            End Set
        End Property

        Public Property Agent As Boolean
            Get
                Return _Agent
            End Get
            Private Set(value As Boolean)
                _Agent = value
            End Set
        End Property

        Public Property TroubleTicket As Boolean
            Get
                Return _TroubleTicket
            End Get
            Private Set(value As Boolean)
                _TroubleTicket = value
            End Set
        End Property

        Public Property Title As Boolean
            Get
                Return _Title
            End Get
            Private Set(value As Boolean)
                _Title = value
            End Set
        End Property
        Public Property StartDate As Date
            Get
                Return m_StartDate
            End Get
            Set(value As Date)
                m_StartDate = value
            End Set
        End Property

        Public Property Salary As Boolean
            Get
                Return _Salary
            End Get
            Private Set(value As Boolean)
                _Salary = value
            End Set
        End Property

        Public Property Admin As Boolean
            Get
                Return _Admin
            End Get
            Private Set(value As Boolean)
                _Admin = value
            End Set
        End Property

        Private m_ReportPath As String = String.Empty
        Private m_UserName As String = String.Empty
        'private DateTime m_RequestDate;
        Private m_RequestDate As Date = Date.Now ' Initialize with a default value

        Public Property RequestDate As Date
            Get
                Return m_RequestDate
            End Get
            Set(value As Date)
                m_RequestDate = value
            End Set
        End Property
        Private m_StartDate As Date = Date.MinValue ' Initialize with a default value
        Private m_AgentID As Integer = 0
        Private m_CustomerID As Integer = 0
        Private m_TroubleTicketNo As Integer = 0

        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
            End Set
        End Property
        'public object CustomerID { get; internal set; }
        Public Property CustomerID As Integer
            Get
                Return m_CustomerID
            End Get
            Set(value As Integer)
                m_CustomerID = value
            End Set
        End Property

        Public Property TroubleTicketNo As Integer
            Get
                Return m_TroubleTicketNo
            End Get
            Set(value As Integer)
                m_TroubleTicketNo = value
            End Set
        End Property

        Public Property UserName As String
            Get
                Return m_UserName
            End Get
            Set(value As String)
                m_UserName = value
            End Set
        End Property

        Public Property ReportPath As String
            Get
                Return m_ReportPath
            End Get
            Set(value As String)
                m_ReportPath = value
            End Set
        End Property

        Public Function GetCustomersList() As DataTable
            Try
                Dim adpCustomerList As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()
                Dim tblCustomerList As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = adpCustomerList.GetData()

                Return tblCustomerList

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetCustReport() As DataTable
            Try
                Dim adpCustomers As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()
                Dim tblCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = adpCustomers.GetData()

                Return tblCustomer
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetCustomer(CustomerID As Integer) As DataTable
            Try
                Dim adpCustomerList As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()
                Dim tblCustomerList As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = adpCustomerList.GetCustomerByCustomerID(CustomerID)

                Return tblCustomerList
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetCustomers() As DataTable
            Try
                Dim adpCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()
                Dim tblCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = adpCustomer.GetData()

                Return tblCustomer

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetCustomerByTroubleTicket(ByRef TroubleTicketNo As Integer) As DataTable
            Try
                Dim adpCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()
                Dim tblCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = adpCustomer.GetByTroubleTicket(TroubleTicketNo)

                Return tblCustomer

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function



        Public Sub UpdateCustomer(thisCustomer As NotificationSystem.NotificationSystem.Data.Classes.clsCustomer)
            Dim adpCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()


            Try
                If True Then
                    Dim withBlock = thisCustomer
                    adpCustomer.Update(withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip, withBlock.UserName, withBlock.Password, withBlock.Original_CustomerID)
                End If

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub


        Public Function AddCustomer(thisCustomer As NotificationSystem.NotificationSystem.Data.Classes.clsCustomer) As Integer

            'add CustomerID to table and save


            Dim adpCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()
            Dim adpGetCustomerID As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetCustomerIDTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetCustomerIDTableAdapter()

            Dim tblCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable()

            Customer = False


            Try
                If True Then
                    Dim withBlock = thisCustomer
                    adpCustomer.Insert(withBlock.AgentID, withBlock.TroubleTicketNo, withBlock.FirstN, withBlock.LastN, withBlock.Phone, withBlock.Email, withBlock.Address, withBlock.City, withBlock.State, withBlock.Zip, withBlock.UserName, withBlock.Password)
                End If

                Dim tblGetCustomerID As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetCustomerIDDataTable = adpGetCustomerID.GetData()
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetCustomerIDRow = tblGetCustomerID(0)
                Return row.CustomerID
            Catch __unusedException1__ As Exception
                Throw
            End Try


        End Function

        Public Function GetCustomerID() As Integer
            Dim adpGetCustomerID As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetCustomerIDTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetCustomerIDTableAdapter()

            Try
                Dim tblGetCustomerID As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetCustomerIDDataTable = adpGetCustomerID.GetData()
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetCustomerIDRow = tblGetCustomerID(0)

                Return row.CustomerID
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Sub DeleteCustomer(thisCustomer As NotificationSystem.NotificationSystem.Data.Classes.clsCustomer)
            Dim adpCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()

            Try
                If True Then
                    Dim withBlock = thisCustomer
                    adpCustomer.DeleteQuery(withBlock.CustomerID)
                End If
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Public Sub GetbyUserPW(username As String, password As String)
            Try
                Dim adpCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.CustomerTableAdapter()
                Dim tblCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = adpCustomer.GetDataByUserPw(username, password)
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerRow = tblCustomer(0)
                Return
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub






        Public Function GetTroubleTicketList() As DataTable
            Try
                Dim adpTroubleTicketList As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter()
                Dim tblTroubleTicketList As NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable = adpTroubleTicketList.GetData()

                Return tblTroubleTicketList

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetTroubleTicketByNo(TroubleTicketNo As Integer) As Integer
            Try
                Dim adpTroubleTicketList As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter()
                Dim tblTroubleTicketList As NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable = adpTroubleTicketList.GetDataByTroubleTicket(TroubleTicketNo)
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqRow = tblTroubleTicketList(0)
                Return row.TroubleTicketNo
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetTT() As DataTable
            Try
                Dim adpTroubleTicket As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter()
                Dim tblTroubleTicketReq As NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable = adpTroubleTicket.GetData()

                Return tblTroubleTicketReq

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function

        Public Function GetTroubleTicket(TroubleTicketNo As Integer) As DataTable
            Try
                Dim adpTroubleTicketReq As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter()
                Dim tblTroubleTicketReq As NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable = adpTroubleTicketReq.GetDataByTroubleTicket(TroubleTicketNo)

                Return tblTroubleTicketReq

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function



        Public Sub UpdateTroubleTicket(thisTroubleTicket As NotificationSystem.NotificationSystem.Data.Classes.clsTroubleTicketReq)
            Dim adpTroubleTicket As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter()

            Try
                Dim withBlock = thisTroubleTicket
                adpTroubleTicket.Update(withBlock.CustomerID, withBlock.AgentID, withBlock.Status, withBlock.DueDate, withBlock.RequestDate, withBlock.Type, withBlock.TroubleTicketNo)
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub


        Public Sub AddTroubleTicket(thisTroubleTicket As NotificationSystem.NotificationSystem.Data.Classes.clsTroubleTicketReq)
            Dim adpTroubleTicketReq As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TroubleTicketReqTableAdapter()
            Dim tblTroubleTicketReq As NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.TroubleTicketReqDataTable()
            TroubleTicket = False

            Try
                Dim withBlock = thisTroubleTicket
                adpTroubleTicketReq.Insert(withBlock.CustomerID, withBlock.AgentID, withBlock.Status, withBlock.DueDate, withBlock.RequestDate, withBlock.Type)
            Catch __unusedException1__ As Exception
                Throw
            End Try
            Return
        End Sub

        Public Function GetTroubleTicketNo() As Integer
            Dim adpTroubleTicketNumber As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetTroubleTicketNoTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetTroubleTicketNoTableAdapter()

            Try
                Dim tblGetTroubleTicketNo As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetTroubleTicketNoDataTable = adpTroubleTicketNumber.GetData()
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetTroubleTicketNoRow = tblGetTroubleTicketNo(0)

                Return row.TroubleTicketNo
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Function GetTypeList() As DataTable

            Try
                Dim adpType As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TypeTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.TypeTableAdapter()
                Dim tblType As NotificationSystem.NotificationSystem.Data.NotificationSystem.TypeDataTable = adpType.GetData()

                Return tblType
            Catch __unusedException1__ As Exception
                Throw
            End Try



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
        End Function


        Public Function GetStatusList() As DataTable

            Try
                Dim adpStatus As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.StatusTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.StatusTableAdapter()
                Dim tblStatus As NotificationSystem.NotificationSystem.Data.NotificationSystem.StatusDataTable = adpStatus.GetData()

                Return tblStatus
            Catch __unusedException1__ As Exception
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


        Public Function GetAgentList() As DataTable
            Try
                Dim adpAgentList As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter()
                Dim tblAgentList As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = adpAgentList.GetData()

                Return tblAgentList

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function



        Public Function GetAgent(AgentID As Integer) As DataTable
            Try
                Dim adpAgentList As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter()
                Dim tblGetAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = adpAgentList.GetDataByAgentID(AgentID)

                Return tblGetAgent
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Function GetAgents() As DataTable
            Try
                Dim adpAgent As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter()
                Dim tblAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = adpAgent.GetData()

                Return tblAgent

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Function GetAgReport(AgentID As Integer) As DataTable
            Try
                Dim adpAgents As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter()
                Dim tblAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = adpAgents.GetDataByAgentReport(AgentID)

                Return tblAgent
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Function GetAgentByTicket(ByRef TroubleTicketNo As Integer) As DataTable
            Try
                Dim adpAgent As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter()
                Dim tblAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = adpAgent.GetDataByTicket(TroubleTicketNo)

                Return tblAgent

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function



        Public Function AddAgent(thisAgent As NotificationSystem.NotificationSystem.Data.Classes.clsAgent) As Integer
            Dim adpAgent As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter()
            Dim adpGetAgentID As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetAgentIDTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetAgentIDTableAdapter()

            Dim tblAgent As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable()
            Agent = False

            Try
                Dim withBlock = thisAgent
                adpAgent.InsertQuery(withBlock.TroubleTicketNo, withBlock.Title, withBlock.StartDate.ToString(), Integer.Parse(withBlock.Salary), withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Fax)

                Dim tblGetAgentID As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetAgentIDDataTable = adpGetAgentID.GetData()
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetAgentIDRow = tblGetAgentID(0)
                Return row.AgentID
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Function GetAgentID() As Integer
            Dim adpGetAgentID As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetAgentIDTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.GetAgentIDTableAdapter()

            Try
                Dim tblGetAgentID As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetAgentIDDataTable = adpGetAgentID.GetData()
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.GetAgentIDRow = tblGetAgentID(0)

                Return row.AgentID
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function


        Public Sub UpdateAgent(thisAgent As NotificationSystem.NotificationSystem.Data.Classes.clsAgent)
            Dim adpAgent As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AgentTableAdapter()

            Try
                Dim withBlock = thisAgent
                adpAgent.UpdateQuery(withBlock.TroubleTicketNo, withBlock.Title, withBlock.StartDate.ToString(), Integer.Parse(withBlock.Salary), withBlock.FirstN, withBlock.LastN, withBlock.Email, withBlock.Phone, withBlock.Fax, withBlock.Original_AgentID)
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub
        'public void DeleteAgent(clsAgent thisAgent)
        '{
        '    AgentTableAdapter adpAgent = new AgentTableAdapter();

        '    try
        '    {
        '        {
        '            var withBlock = thisAgent;
        '            adpAgent.DeleteQuery(withBlock.AgentID);
        '        }
        '    }
        '    catch (Exception)
        '    {
        '        throw;
        '    }
        '}



        Public Sub GetAdminbyUserPW(password As String, username As String)
            Try
                Dim adpAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter()
                Dim tblAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable = adpAdmin.GetDataByUserNamePassword(username, password)
                Dim row As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminRow = tblAdmin(0)
                Return
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub



        'exception error ? 6/25/24 

        Public Function GetAdmins() As DataTable
            Try

                Dim adpAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter()
                Dim tblAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable = adpAdmin.GetData()
                Return tblAdmin
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function



        Public Function GetAdmin(UserName As String) As DataTable
            Try
                Dim adpAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter()
                Dim tblAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable = adpAdmin.GetDataByUserName(UserName)

                Return tblAdmin

            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Function



        Public Sub UpdateAdmin(thisAdmin As NotificationSystem.NotificationSystem.Data.Classes.clsAdmin)
            Dim adpAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter()

            Try
                Dim withBlock = thisAdmin
                adpAdmin.UpdateQuery(withBlock.UserName, withBlock.Password, withBlock.Email, withBlock.First, withBlock.Last, withBlock.UserName) ' Added Original_UserName parameter
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        'public void DeleteAdmin(clsAgent thisAdmin)
        '{
        '    AdminTableAdapter adpAdmin = new AdminTableAdapter();

        '    try
        '    {
        '        {
        '            var withBlock = thisAdmin;
        '            adpAdmin.DeleteQuery(withBlock.UserName);
        '        }
        '    }
        '    catch (Exception)
        '    {
        '        throw;
        '    }
        '}

        Public Sub AddAdmin(thisAdmin As NotificationSystem.NotificationSystem.Data.Classes.clsAdmin)

            'add Admin to table and save


            Dim adpAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter = New NotificationSystem.NotificationSystem.Data.NotificationSystemTableAdapters.AdminTableAdapter()

            Dim tblAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable()
            Admin = False


            Try
                If True Then
                    Dim withBlock = thisAdmin
                    adpAdmin.InsertQuery(withBlock.UserName, withBlock.Password, withBlock.Email, withBlock.First, withBlock.Last)
                End If
            Catch __unusedException1__ As Exception
                Throw
            End Try
            Return

        End Sub


    End Class
End Namespace
