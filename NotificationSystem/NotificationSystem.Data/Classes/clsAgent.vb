

Namespace NotificationSystem.NotificationSystem.Data.Classes


    Public Class clsAgent
        Friend Property Original_AgentID As Integer = 0
        Private m_Title As String = String.Empty
        Private m_FirstN As String = String.Empty
        Private m_LastN As String = String.Empty
        Private m_Email As String = String.Empty
        Private m_Phone As String = String.Empty
        Private m_Fax As String = String.Empty
        Private m_Salary As String = String.Empty

        Private m_AgentID As Integer = 0
        Private m_TroubleTicketNo As Integer = 0
        Private m_StartDate As Date

        Public Property Title As String
            Get
                Return m_Title
            End Get
            Set(value As String)
                m_Title = value
            End Set
        End Property


        Public Property FirstN As String
            Get
                Return m_FirstN
            End Get
            Set(value As String)
                m_FirstN = value
            End Set
        End Property

        Public Property LastN As String
            Get
                Return m_LastN
            End Get
            Set(value As String)
                m_LastN = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return m_Email
            End Get
            Set(value As String)
                m_Email = value
            End Set
        End Property

        Public Property Phone As String
            Get
                Return m_Phone
            End Get
            Set(value As String)
                m_Phone = value
            End Set
        End Property

        Public Property Fax As String
            Get
                Return m_Fax
            End Get
            Set(value As String)
                m_Fax = value
            End Set
        End Property

        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
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

        Public Property StartDate As Date
            Get
                Return m_StartDate
            End Get
            Set(value As Date)
                m_StartDate = value
            End Set
        End Property

        Public Property Salary As String
            Get
                Return m_Salary
            End Get
            Set(value As String)
                m_Salary = value
            End Set
        End Property

    End Class
End Namespace
