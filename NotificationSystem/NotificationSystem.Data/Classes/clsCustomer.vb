
Namespace NotificationSystem.NotificationSystem.Data.Classes
    Public Class clsCustomer
        Friend Property Original_CustomerID As Integer = 0
        Private m_FirstN As String = String.Empty
        Private m_LastN As String = String.Empty
        Private m_Email As String = String.Empty
        Private m_Phone As String = String.Empty
        Private m_Address As String = String.Empty
        Private m_City As String = String.Empty
        Private m_State As String = String.Empty
        Private m_Zip As String = String.Empty
        Private m_UserName As String = String.Empty
        Private m_Password As String = String.Empty

        Private m_CustomerID As Integer = 0
        Private m_AgentID As Integer = 0
        Private m_TroubleTicketNo As Integer = 0

        Private m_StartDate As Date





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

        Public Property Address As String
            Get
                Return m_Address
            End Get
            Set(value As String)
                m_Address = value
            End Set
        End Property
        Public Property City As String
            Get
                Return m_City
            End Get
            Set(value As String)
                m_City = value
            End Set
        End Property


        Public Property State As String
            Get
                Return m_State
            End Get
            Set(value As String)
                m_State = value
            End Set
        End Property


        Public Property Zip As String
            Get
                Return m_Zip
            End Get
            Set(value As String)
                m_Zip = value
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

        Public Property StartDate As Date
            Get
                Return m_StartDate
            End Get
            Set(value As Date)
                m_StartDate = value
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


        Public Property Password As String
            Get
                Return m_Password
            End Get
            Set(value As String)
                m_Password = value
            End Set
        End Property

    End Class
End Namespace
