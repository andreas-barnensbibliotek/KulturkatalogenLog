Public Class kulturkatalogLogController
    Private _dalobj As New kk_aj_log_DAL
    Public Function getlogEvent(commandtyp As String, param As logInfo) As List(Of logInfo)
        Dim ret As List(Of logInfo) = New List(Of logInfo)

        Select Case commandtyp
            Case "byarrid"
                ret = _dalobj.getlogbyarrid(param.Arrid)

            Case "bylogtyp"
                ret = _dalobj.getlogbylogtyp(param.logtyp)

            Case "bystatus"
            Case "byuser"
            Case "byutovare"
            Case "bylogid"
        End Select

        Return ret

    End Function

    Public Function addlogEvent(param As logInfo) As Boolean

        Return _dalobj.addlogEvent(param)
    End Function
End Class
