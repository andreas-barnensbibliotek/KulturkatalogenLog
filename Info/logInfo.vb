Public Class logInfo

    Private _logid As Integer
    Private _logtyp As Integer
    Private _datum As Date
    Private _arrid As Integer
    Private _beskrivning As String
    Private _changebyuserid As Integer
    Private _status As String
    Private _arrangemang As arrangemangInfo

    Public Sub New()
        _logid = 0
        _logtyp = 0
        _datum = Date.Now
        _arrid = 0
        _beskrivning = ""
        _changebyuserid = 0
        _status = ""
        _arrangemang = New arrangemangInfo
    End Sub
    Public Property logid() As Integer
        Get
            Return _logid
        End Get
        Set(ByVal value As Integer)
            _logid = value
        End Set
    End Property


    Public Property logtyp() As Integer
        Get
            Return _logtyp
        End Get
        Set(ByVal value As Integer)
            _logtyp = value
        End Set
    End Property

    Public Property Datum() As Date
        Get
            Return _datum
        End Get
        Set(ByVal value As Date)
            _datum = value
        End Set
    End Property

    Public Property Arrid() As Integer
        Get
            Return _arrid
        End Get
        Set(ByVal value As Integer)
            _arrid = value
        End Set
    End Property
    Public Property Beskrivning() As String
        Get
            Return _beskrivning
        End Get
        Set(ByVal value As String)
            _beskrivning = value
        End Set
    End Property
    Public Property ChangebyUserid() As Integer
        Get
            Return _changebyuserid
        End Get
        Set(ByVal value As Integer)
            _changebyuserid = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Public Property LogArrangemang() As arrangemangInfo
        Get
            Return _arrangemang
        End Get
        Set(ByVal value As arrangemangInfo)
            _arrangemang = value
        End Set
    End Property
End Class
