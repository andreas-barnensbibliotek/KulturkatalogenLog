﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="dnndev_v902.me")>  _
Partial Public Class Linq_kk_aj_LogDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertkk_aj_tbl_Log(instance As kk_aj_tbl_Log)
    End Sub
  Partial Private Sub Updatekk_aj_tbl_Log(instance As kk_aj_tbl_Log)
    End Sub
  Partial Private Sub Deletekk_aj_tbl_Log(instance As kk_aj_tbl_Log)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.KulturkatalogenLog.My.MySettings.Default.dnndev_v902_meConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property kk_aj_tbl_Logs() As System.Data.Linq.Table(Of kk_aj_tbl_Log)
		Get
			Return Me.GetTable(Of kk_aj_tbl_Log)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.kk_aj_tbl_Log")>  _
Partial Public Class kk_aj_tbl_Log
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _logid As Integer
	
	Private _logtyp As System.Nullable(Of Integer)
	
	Private _arrid As System.Nullable(Of Integer)
	
	Private _beskrivning As String
	
	Private _datum As System.Nullable(Of Date)
	
	Private _status As System.Nullable(Of Integer)
	
	Private _changebyuserid As System.Nullable(Of Integer)
	
	Private _currenttimestamp As System.Data.Linq.Binary
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnlogidChanging(value As Integer)
    End Sub
    Partial Private Sub OnlogidChanged()
    End Sub
    Partial Private Sub OnlogtypChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnlogtypChanged()
    End Sub
    Partial Private Sub OnarridChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnarridChanged()
    End Sub
    Partial Private Sub OnbeskrivningChanging(value As String)
    End Sub
    Partial Private Sub OnbeskrivningChanged()
    End Sub
    Partial Private Sub OndatumChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OndatumChanged()
    End Sub
    Partial Private Sub OnstatusChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnstatusChanged()
    End Sub
    Partial Private Sub OnchangebyuseridChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnchangebyuseridChanged()
    End Sub
    Partial Private Sub OncurrenttimestampChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OncurrenttimestampChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logid", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true, UpdateCheck:=UpdateCheck.Never)>  _
	Public Property logid() As Integer
		Get
			Return Me._logid
		End Get
		Set
			If ((Me._logid = value)  _
						= false) Then
				Me.OnlogidChanging(value)
				Me.SendPropertyChanging
				Me._logid = value
				Me.SendPropertyChanged("logid")
				Me.OnlogidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logtyp", DbType:="Int", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property logtyp() As System.Nullable(Of Integer)
		Get
			Return Me._logtyp
		End Get
		Set
			If (Me._logtyp.Equals(value) = false) Then
				Me.OnlogtypChanging(value)
				Me.SendPropertyChanging
				Me._logtyp = value
				Me.SendPropertyChanged("logtyp")
				Me.OnlogtypChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_arrid", DbType:="Int", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property arrid() As System.Nullable(Of Integer)
		Get
			Return Me._arrid
		End Get
		Set
			If (Me._arrid.Equals(value) = false) Then
				Me.OnarridChanging(value)
				Me.SendPropertyChanging
				Me._arrid = value
				Me.SendPropertyChanged("arrid")
				Me.OnarridChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_beskrivning", DbType:="NVarChar(4000)", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property beskrivning() As String
		Get
			Return Me._beskrivning
		End Get
		Set
			If (String.Equals(Me._beskrivning, value) = false) Then
				Me.OnbeskrivningChanging(value)
				Me.SendPropertyChanging
				Me._beskrivning = value
				Me.SendPropertyChanged("beskrivning")
				Me.OnbeskrivningChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_datum", DbType:="DateTime", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property datum() As System.Nullable(Of Date)
		Get
			Return Me._datum
		End Get
		Set
			If (Me._datum.Equals(value) = false) Then
				Me.OndatumChanging(value)
				Me.SendPropertyChanging
				Me._datum = value
				Me.SendPropertyChanged("datum")
				Me.OndatumChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_status", DbType:="Int", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property status() As System.Nullable(Of Integer)
		Get
			Return Me._status
		End Get
		Set
			If (Me._status.Equals(value) = false) Then
				Me.OnstatusChanging(value)
				Me.SendPropertyChanging
				Me._status = value
				Me.SendPropertyChanged("status")
				Me.OnstatusChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_changebyuserid", DbType:="Int", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property changebyuserid() As System.Nullable(Of Integer)
		Get
			Return Me._changebyuserid
		End Get
		Set
			If (Me._changebyuserid.Equals(value) = false) Then
				Me.OnchangebyuseridChanging(value)
				Me.SendPropertyChanging
				Me._changebyuserid = value
				Me.SendPropertyChanged("changebyuserid")
				Me.OnchangebyuseridChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_currenttimestamp", AutoSync:=AutoSync.Always, DbType:="rowversion", IsDbGenerated:=true, IsVersion:=true, UpdateCheck:=UpdateCheck.Never)>  _
	Public Property currenttimestamp() As System.Data.Linq.Binary
		Get
			Return Me._currenttimestamp
		End Get
		Set
			If (Object.Equals(Me._currenttimestamp, value) = false) Then
				Me.OncurrenttimestampChanging(value)
				Me.SendPropertyChanging
				Me._currenttimestamp = value
				Me.SendPropertyChanged("currenttimestamp")
				Me.OncurrenttimestampChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
