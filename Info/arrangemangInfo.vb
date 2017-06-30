Public Class arrangemangInfo
    'TODO lägg till alla parametrar som behövs och tillkommer i arrangemangstabellen

    Private _arrid As Integer
    Private _rubrik As String
    Private _arrstatus As String

    Public Sub New()
        _arrid = 0
        _rubrik = ""
        _arrstatus = ""
    End Sub
    Public Property Arrid() As Integer
        Get
            Return _arrid
        End Get
        Set(ByVal value As Integer)
            _arrid = value
        End Set
    End Property


    Public Property Rubrik() As String
        Get
            Return _rubrik
        End Get
        Set(ByVal value As String)
            _rubrik = value
        End Set
    End Property


    Public Property Arrstatus() As String
        Get
            Return _arrstatus
        End Get
        Set(ByVal value As String)
            _arrstatus = value
        End Set
    End Property

End Class
