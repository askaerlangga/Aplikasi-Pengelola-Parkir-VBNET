Imports System.Data.OleDb

Public Class formBeranda

    Sub loadDashboard()
        koneksi()
        cmd = New OleDbCommand("Select * from tabelTransaksi where no_tiket in (select max(no_tiket) from tabelTransaksi)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MessageBox.Show("Tidak Ada Data!")
        Else
            loadKendaraanTerparkir()
            loadKunjungan()
            loadMobil()
            loadMotor()
            loadPendapatan()
        End If

    End Sub

    Sub loadKendaraanTerparkir()
        koneksi()
        da = New OleDbDataAdapter("select no_tiket, no_kendaraan, jenis_kendaraan, jam_masuk from tabelTransaksi where keterangan = '" & "TERPARKIR" & "'", conn)
        ds = New DataSet
        da.Fill(ds)
        dtgKendaraanTerparkir.DataSource = ds.Tables(0)
        With dtgKendaraanTerparkir.ColumnHeadersDefaultCellStyle
            dtgKendaraanTerparkir.Columns(0).HeaderText = "No. Tiket"
            dtgKendaraanTerparkir.Columns(1).HeaderText = "No. Kendaraan"
            dtgKendaraanTerparkir.Columns(2).HeaderText = "Jenis Kendaraan"
            dtgKendaraanTerparkir.Columns(3).HeaderText = "Jam Masuk"
            dtgKendaraanTerparkir.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtgKendaraanTerparkir.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtgKendaraanTerparkir.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtgKendaraanTerparkir.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtgKendaraanTerparkir.ReadOnly = True
        End With
    End Sub

    Sub loadMotor()
        Dim cc As String
        koneksi()
        cc = "select count(*) from tabelTransaksi where jenis_kendaraan = '" & "MOTOR" & "' and keterangan = '" & "TERPARKIR" & "'"
        cmd = New OleDb.OleDbCommand(cc, conn)
        Dim rs As Integer
        rs = cmd.ExecuteScalar
        lblMotorTerparkir.Text = rs
    End Sub

    Sub loadMobil()
        Dim cc As String
        koneksi()
        cc = "select count(*) from tabelTransaksi where jenis_kendaraan = '" & "MOBIL" & "' and keterangan = '" & "TERPARKIR" & "'"
        cmd = New OleDb.OleDbCommand(cc, conn)
        Dim rs As Integer
        rs = cmd.ExecuteScalar
        lblMobilTerparkir.Text = rs
    End Sub

    Sub loadKunjungan()
        Dim cc As String
        Dim tanggal As String
        tanggal = DateTime.Now.ToShortDateString
        koneksi()
        cc = "select count(*) from tabelTransaksi"
        cmd = New OleDb.OleDbCommand(cc, conn)
        Dim rs As Integer
        rs = cmd.ExecuteScalar
        lblTotalKunjungan.Text = rs
    End Sub

    Sub loadPendapatan()
        koneksi()
        Dim cc As String
        cc = "Select sum(total_biaya) from tabelTransaksi"
        cmd = New OleDbCommand(cc, conn)
        Dim rs As Integer
        rs = cmd.ExecuteScalar
        lblPendapatan.Text = "Rp" + Convert.ToString(rs)
    End Sub

    Private Sub formBeranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDashboard()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtNoTiket.Text = "" Then
            loadKendaraanTerparkir()
        Else
            koneksi()
            da = New OleDbDataAdapter("select no_tiket, no_kendaraan, jenis_kendaraan, jam_masuk from tabelTransaksi where no_tiket = '" & txtNoTiket.Text & "' and keterangan = '" & "TERPARKIR" & "'", conn)
            ds = New DataSet
            da.Fill(ds)
            dtgKendaraanTerparkir.DataSource = ds.Tables(0)
            With dtgKendaraanTerparkir.ColumnHeadersDefaultCellStyle
                dtgKendaraanTerparkir.Columns(0).HeaderText = "No. Tiket"
                dtgKendaraanTerparkir.Columns(1).HeaderText = "No. Kendaraan"
                dtgKendaraanTerparkir.Columns(2).HeaderText = "Jenis Kendaraan"
                dtgKendaraanTerparkir.Columns(3).HeaderText = "Jam Masuk"
                dtgKendaraanTerparkir.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtgKendaraanTerparkir.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtgKendaraanTerparkir.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtgKendaraanTerparkir.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtgKendaraanTerparkir.ReadOnly = True
            End With
        End If
    End Sub
End Class