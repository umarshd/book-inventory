Imports System.Data.OleDb
Module MainModule
    Public mycommand As New System.Data.OleDb.OleDbCommand
    Public myadapter As New System.Data.OleDb.OleDbDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.OleDb.OleDbDataReader
    Public SQL As String
    Public conn As New OleDbConnection
    Public cn As New Connections

    'Tabel Buku
    '-------------------------------
    Public newBook As Boolean
    Public oBook As New Book
    '--------------------------------

    Public Sub DBConnect()
        cn.DataSource = "C:\Users\UmarSahid\Documents\UMC.accdb"

        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub
End Module
