Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports KulturkatalogenLog

<TestClass()> Public Class kulturkatalogenLogControllerTEST

    <TestMethod()> Public Sub TestMethod1()

        Dim testobj As logInfo = New logInfo

        testobj.logtypid = 1
        testobj.Arrid = 1
        testobj.Statustypid = 4
        testobj.Beskrivning = "godkänt och klart"
        testobj.ChangebyUserid = 2

        Dim cont As kulturkatalogLogController = New kulturkatalogLogController

        Dim ret As Boolean = cont.addlogEvent(testobj)

        Dim test As String = ""

    End Sub
    <TestMethod()> Public Sub TestMethod2()

        Dim testobj As logInfo = New logInfo

        testobj.logtypid = 1
        testobj.Arrid = 1
        testobj.Statustypid = 4
        testobj.Beskrivning = "inkommet Systemevent"
        testobj.ChangebyUserid = 2

        Dim cont As kulturkatalogLogController = New kulturkatalogLogController

        Dim ret As List(Of logInfo) = cont.getlogEvent("byarrid", testobj)

        Dim test As String = ""

    End Sub

    <TestMethod()> Public Sub TestMethod3()

        Dim testobj As logInfo = New logInfo

        testobj.logtypid = 1
        testobj.Arrid = 1
        testobj.Statustypid = 4
        testobj.Beskrivning = "inkommet Systemevent"
        testobj.ChangebyUserid = 2

        Dim cont As kulturkatalogLogController = New kulturkatalogLogController

        Dim ret As List(Of logInfo) = cont.getlogEvent("all", testobj)

        Dim test As String = ""

    End Sub
End Class