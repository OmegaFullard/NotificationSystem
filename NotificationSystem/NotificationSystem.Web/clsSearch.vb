
Namespace NotificationSystem.NotificationSystem.Web
    Public Class clsSearch
        Private m_ReportName As String = String.Empty
        Private m_ActivityBy As String = String.Empty
        Private m_ReportPath As String = String.Empty
        Private m_RequestDate As String = String.Empty
        Private m_DueDate As String = String.Empty
        Private m_Year As String = String.Empty
        Private m_DateRange As Boolean = False
        Private m_AgentID As Integer = 0
        Private m_CustomerID As Integer = 0

        Public Property ReportName As String
            Get
                Return m_ReportName
            End Get
            Set(value As String)
                m_ReportName = value
            End Set
        End Property
        Public Property ActivityBy As String
            Get
                Return m_ActivityBy
            End Get
            Set(value As String)
                m_ActivityBy = value
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
        Public Property DateRange As Boolean
            Get
                Return m_DateRange
            End Get
            Set(value As Boolean)
                m_DateRange = value
            End Set
        End Property

        Public Property RequestDate As String
            Get
                Return m_RequestDate
            End Get
            Set(value As String)
                m_RequestDate = value
            End Set
        End Property
        Public Property DueDate As String
            Get
                Return m_DueDate
            End Get
            Set(value As String)
                m_DueDate = value
            End Set
        End Property
        Public Property Year As String
            Get
                Return m_Year
            End Get
            Set(value As String)
                m_Year = value
            End Set
        End Property

        'public object AgentID { get; internal set; }
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
    End Class
End Namespace
