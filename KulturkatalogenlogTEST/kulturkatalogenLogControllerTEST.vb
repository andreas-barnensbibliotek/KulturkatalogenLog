Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports KulturkatalogenLog

<TestClass()> Public Class kulturkatalogenLogControllerTEST

    <TestMethod()> Public Sub TestMethod1()

        Dim testobj As logInfo = New logInfo

        testobj.logtyp = 1
        testobj.Arrid = 1
        testobj.Status = 1
        testobj.Beskrivning = "inkommet Systemevent"
        testobj.ChangebyUserid = 2

        Dim cont As kulturkatalogLogController = New kulturkatalogLogController

        Dim ret As Boolean = cont.addlogEvent(testobj)

        Dim test As String = ""

    End Sub
    <TestMethod()> Public Sub TestMethod2()

        Dim testobj As logInfo = New logInfo

        testobj.logtyp = 1
        testobj.Arrid = 1
        testobj.Status = 1
        testobj.Beskrivning = "inkommet Systemevent"
        testobj.ChangebyUserid = 2

        Dim cont As kulturkatalogLogController = New kulturkatalogLogController

        Dim ret As List(Of logInfo) = cont.getlogEvent("byarrid", testobj)

        Dim test As String = ""

    End Sub
End Class