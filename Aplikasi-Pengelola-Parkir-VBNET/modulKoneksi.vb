Imports System.Data.OleDb

Module modulKoneksi
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public ds As DataSet
    Public dt As New DataTable
    Public str As String
    Public x As Integer

    Sub koneksi()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=database.accdb")
        conn.Open()
    End Sub
End Module
