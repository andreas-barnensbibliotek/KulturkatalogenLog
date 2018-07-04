﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Data.Linq
Imports System.Configuration
Imports System.Text
Imports KulturkatalogenLog

Public Class kk_aj_log_DAL
    Dim connstring As New connectionstringHandler
    Private _linqObj As New Linq_kk_aj_LogDataContext(connstring.CurrentConnectionString)

#Region "Skrivboken CRUD funktioner"

    Public Function getannonslog(proctyp As Integer, logtypid As Integer) As List(Of logInfo)

        Dim tmpobj As New List(Of logInfo)
        Dim logs = From p In _linqObj.kk_aj_proc_getlog(proctyp, logtypid)
                   Select p

        For Each t In logs
            Dim nobj As New logInfo
            nobj.logid = t.logid
            nobj.logtypid = t.logtypid
            nobj.logtyp = t.logtyp
            nobj.Arrid = t.arrid
            nobj.Arrrubrik = t.Rubrik
            nobj.CurrentArrStatus = t.statustyp
            nobj.Arrutovare = t.Organisation
            nobj.ArrutovareID = t.UtovarID
            nobj.Statustypid = t.statusid
            nobj.ChangebyUserid = t.changebyuserid
            nobj.ChangebyUsernamn = getusername(t.changebyuserid)
            nobj.Statustyp = t.statustyp
            nobj.Datum = t.datum
            nobj.Beskrivning = t.beskrivning

            tmpobj.Add(nobj)
        Next

        Return tmpobj
    End Function




    Private Function getusername(userid As Integer) As String
        Dim tmpobj As String = ""

        Dim logs = From t In _linqObj.Users
                   Where t.UserID = userid
                   Select t

        For Each t In logs
            tmpobj = t.Username
        Next
        Return tmpobj

    End Function

#Region "CRUD FUNCTIONS"

    Public Function addlogEvent(ByVal logobj As logInfo) As Boolean
        Dim Inlagd As Boolean = False
        Try
            Dim newobj As New kk_aj_tbl_Log
            newobj.logtypid = logobj.logtypid
            newobj.arrid = logobj.Arrid
            newobj.statusid = logobj.Statustypid
            newobj.beskrivning = logobj.Beskrivning
            newobj.datum = logobj.Datum
            newobj.changebyuserid = logobj.ChangebyUserid

            _linqObj.kk_aj_tbl_Logs.InsertOnSubmit(newobj)
            _linqObj.SubmitChanges()
            Inlagd = True
        Catch ex As Exception
            Inlagd = False
        End Try

        Return Inlagd
    End Function


#End Region

    'Public Function EditUserText(ByVal UserTextObj As SkrivbokenInfo) As Boolean
    '    Dim uppdaterad As Boolean = False
    '    Dim linqobj As New linqDataClassesDataContext(_connectionString) ' måste skicka med connectionstring annars funkar det inte

    '    Dim valdsidinfo = From e In linqobj.tblAJBarnensSkrivs
    '                      Where e.SkrivID = UserTextObj.BarnensSkrivObj.SkrivID
    '                      Select e

    '    For Each x In valdsidinfo
    '        x.Approved = UserTextObj.BarnensSkrivObj.Approved
    '        x.Category = UserTextObj.BarnensSkrivObj.Category
    '        x.Gillar = UserTextObj.BarnensSkrivObj.Gillar
    '        x.Inserted = UserTextObj.BarnensSkrivObj.Inserted
    '        x.Story = UserTextObj.BarnensSkrivObj.Story
    '        x.Title = UserTextObj.BarnensSkrivObj.Title
    '        x.Userid = UserTextObj.BarnensSkrivObj.UserID
    '        x.publish = UserTextObj.BarnensSkrivObj.Publish
    '    Next

    '    Try
    '        linqobj.SubmitChanges()
    '        uppdaterad = True
    '    Catch ex As Exception
    '        uppdaterad = False
    '    End Try

    '    Return uppdaterad
    'End Function

    'Public Function InsertUserText(ByVal UserTextObj As SkrivbokenInfo) As Boolean
    '    Dim Inlagd As Boolean = False
    '    Dim linqobj As New linqDataClassesDataContext(_connectionString) ' måste skicka med connectionstring annars funkar det inte
    '    Try
    '        Dim b As New tblAJBarnensSkriv
    '        b.Approved = UserTextObj.BarnensSkrivObj.Approved
    '        b.category = UserTextObj.BarnensSkrivObj.Category
    '        b.gillar = UserTextObj.BarnensSkrivObj.Gillar
    '        b.Inserted = Date.Now
    '        'b.SkrivID = UserTextObj.BarnensSkrivObj.SkrivID
    '        b.Story = UserTextObj.BarnensSkrivObj.Story
    '        b.Title = UserTextObj.BarnensSkrivObj.Title
    '        b.Userid = UserTextObj.BarnensSkrivObj.UserID
    '        b.publish = UserTextObj.BarnensSkrivObj.Publish

    '        linqobj.tblAJBarnensSkrivs.InsertOnSubmit(b)
    '        linqobj.SubmitChanges()
    '        Inlagd = True
    '    Catch ex As Exception
    '        Inlagd = False
    '    End Try

    '    Return Inlagd
    'End Function

    'Public Function DelUserText(ByVal UserTextObj As SkrivbokenInfo) As Boolean
    '    Dim borttagen As Boolean = False
    '    Dim linqobj As New linqDataClassesDataContext(_connectionString) ' måste skicka med connectionstring annars funkar det inte

    '    Try
    '        Dim valdsidinfo = From e In linqobj.tblAJBarnensSkrivs
    '                          Where e.SkrivID = UserTextObj.BarnensSkrivObj.SkrivID
    '                          Select e

    '        linqobj.tblAJBarnensSkrivs.DeleteAllOnSubmit(valdsidinfo)
    '        linqobj.SubmitChanges()

    '        borttagen = True
    '    Catch ex As Exception
    '        borttagen = False
    '    End Try

    '    Return borttagen
    'End Function
#End Region
End Class
