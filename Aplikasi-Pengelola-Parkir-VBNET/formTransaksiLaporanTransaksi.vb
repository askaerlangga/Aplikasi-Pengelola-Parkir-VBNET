Imports System.Data.Odbc

Public Class formTransaksiLaporanTransaksi

    Sub loadLaporanTransaksi()
        koneksi()
        da = New OdbcDataAdapter("select no_tiket, no_kendaraan, jenis_kendaraan, tanggal_transaksi, jam_masuk, jam_keluar,tarif_kendaraan,total_biaya,nama_operator from tabelTransaksi where keterangan = '" & "KELUAR" & "'", conn)
        ds = New DataSet
        da.Fill(ds)
        dtgLaporanTransaksi.DataSource = ds.Tables(0)
        With dtgLaporanTransaksi.ColumnHeadersDefaultCellStyle
            dtgLaporanTransaksi.Columns(0).HeaderText = "No. Tiket"
            dtgLaporanTransaksi.Columns(1).HeaderText = "No. Kendaraan"
            dtgLaporanTransaksi.Columns(2).HeaderText = "Jenis Kendaraan"
            dtgLaporanTransaksi.Columns(3).HeaderText = "Tanggal Transaksi"
            dtgLaporanTransaksi.Columns(4).HeaderText = "Jam Masuk"
            dtgLaporanTransaksi.Columns(5).HeaderText = "Jam Keluar"
            dtgLaporanTransaksi.Columns(6).HeaderText = "Tarif"
            dtgLaporanTransaksi.Columns(7).HeaderText = "Total Biaya"
            dtgLaporanTransaksi.Columns(8).HeaderText = "Operator"
            dtgLaporanTransaksi.ReadOnly = True
        End With
    End Sub

    Private Sub formTransaksiLaporanTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLaporanTransaksi()
    End Sub

    Private Sub btnCetakLaporan_Click(sender As Object, e As EventArgs) Handles btnCetakLaporan.Click
        If dtgLaporanTransaksi.RowCount > 0 Then
            Dim ApExcel As Object
            ApExcel = CreateObject("Excel.application")
            ApExcel.Visible = False
            ApExcel.Workbooks.Add()
            For i As Integer = 1 To dtgLaporanTransaksi.Columns.Count
                ApExcel.Columns(i).ColumnWidth = 20
                ApExcel.Cells(1, i).Value = dtgLaporanTransaksi.Columns(i - 1).HeaderText
            Next

            For r = 0 To dtgLaporanTransaksi.RowCount - 1
                For i As Integer = 1 To dtgLaporanTransaksi.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = dtgLaporanTransaksi.Rows(r).Cells(i - 1).Value
                Next
            Next
            ApExcel.Range("A1:H1").Font.Bold = True
            'ApExcel.Range("A1:H1").interior.colorindex = 36
            ApExcel.Visible = True
            ApExcel = Nothing
        End If
    End Sub
End Class