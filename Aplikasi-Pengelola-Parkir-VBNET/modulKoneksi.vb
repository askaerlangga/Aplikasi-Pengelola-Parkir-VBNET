Imports System.Data.Odbc

Module modulKoneksi
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public ds As DataSet
    Public dt As New DataTable
    Public str As String
    Public x As Integer

    Sub koneksi()
        conn = New OdbcConnection("Dsn=AplikasiPengelolaParkir")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            MessageBox.Show("Koneksi Gagal")
        End If

    End Sub
End Module
