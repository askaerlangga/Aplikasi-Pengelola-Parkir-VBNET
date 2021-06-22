Imports System.Data.OleDb

Public Class formTransaksiParkirMasuk

    Sub loadNoTiket()
        txtNoTiket.Enabled = False
        Dim urutan As String
        Dim hitung As Long
        koneksi()
        cmd = New OleDbCommand("Select * from tabelTransaksi where no_tiket in (select max(no_tiket) from tabelTransaksi)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = DateTime.Now.ToString("yyyyMM") + "00001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 5) + 1
            urutan = DateTime.Now.ToString("yyyyMM") + Microsoft.VisualBasic.Right("00000" & hitung, 5)
        End If
        txtNoTiket.Text = urutan
    End Sub

    Sub loadWaktu()
        txtJamMasuk.Clear()
        txtTanggal.Text = DateTime.Now.ToShortDateString
        txtJamMasuk.Text = DateTime.Now.ToShortTimeString
    End Sub

    Sub hapusForm()
        txtNoKendaraan.Text = ""
        cmbJenisKendaraan.SelectedIndex = -1
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim keterangan As String = "TERPARKIR"
        Dim totalBiaya As Integer = 0
        Dim jamKeluar As String = ""
        koneksi()
        cmd = New OleDbCommand("insert into tabelTransaksi values ('" & txtNoTiket.Text & "','" &
                               txtNoKendaraan.Text & "','" & cmbJenisKendaraan.Text & "','" & txtTanggal.Text & "','" &
                               txtJamMasuk.Text & "','" & jamKeluar & "','" & txtTarifAwal.Text & "','" & totalBiaya &
                               "','" & txtNamaOperator.Text & "','" & keterangan & "')", conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Kendaraan Terparkir!")
        loadNoTiket()
        hapusForm()
    End Sub

    Private Sub formTransaksiParkirMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadWaktu()
        loadNoTiket()
        hapusForm()
        txtNamaOperator.Text = formUtama.lblNamaUser.Text
    End Sub

    Private Sub cmbJenisKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisKendaraan.SelectedIndexChanged
        Dim tarif As String = ""
        If cmbJenisKendaraan.SelectedIndex = -1 Then
            txtTarifAwal.Text = ""
        Else
            koneksi()
            cmd = New OleDbCommand("Select * from tabelTarifKendaraan where id_tarif_kendaraan = '" & cmbJenisKendaraan.SelectedIndex & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            txtTarifAwal.Text = dr("tarif_kendaraan_awal").ToString
        End If
    End Sub
End Class