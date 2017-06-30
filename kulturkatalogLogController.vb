Public Class kulturkatalogLogController
    Private _dalobj As New kk_aj_log_DAL
    Enum proctypes
        arr = 1
        logtyp = 2
        status = 3
        alla = 4
    End Enum

    Public Function getlogEvent(commandtyp As String, param As logInfo) As List(Of logInfo)
        Dim ret As List(Of logInfo) = New List(Of logInfo)

        Select Case commandtyp
            Case "byarrid"
                ret = _dalobj.getannonslog(proctypes.arr, param.Arrid)

            Case "bylogtyp"
                ret = _dalobj.getannonslog(proctypes.logtyp, param.logtypid)

            Case "bystatus"
                ret = _dalobj.getannonslog(proctypes.status, param.Statustypid)
            Case "byuser"
            Case "byutovare"
            Case "bylogid"
            Case "all"
                ret = _dalobj.getannonslog(proctypes.alla, 0)
        End Select

        Return ret

    End Function

    Public Function addlogEvent(param As logInfo) As Boolean

        Return _dalobj.addlogEvent(param)
    End Function
End Class
