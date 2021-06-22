Imports System.Data.OleDb

Public Class formTransaksiParkirKeluar
    Dim jamMasuk, jamKeluar, tarifAwal, tarifPerJam, totalBiaya As String

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim keterangan As String = "KELUAR"
        str = "update tabelTransaksi set jam_keluar = '" & jamKeluar & "', total_biaya = '" & Convert.ToInt32(totalBiaya) & "', keterangan = '" & keterangan & "' where no_tiket = '" & txtNoTiket.Text & "'"
        cmd = New OleDbCommand(str, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Tersimpan")
        hapusForm()

    End Sub
    'Dim jamMasuk, jamKeluar As Date
    Sub hapusForm()
        txtNoTiket.Text = ""
        txtNoKendaraan.Text = ""
        txtTanggal.Text = ""
        txtJam.Text = ""
        txtTarifKendaraan.Text = ""
        txtTotalBiaya.Text = ""
        txtNamaOperator.Text = ""
        txtJenisKendaraan.Text = ""
        txtLamaParkir.Text = ""
        txtNoTiket.Focus()
    End Sub

    Sub tampilTarifPerjam()
        koneksi()
        cmd = New OleDb.OleDbCommand("select * from tabelTarifKendaraan where jenis_kendaraan ='" & txtJenisKendaraan.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        tarifPerJam = dr("tarif_kendaraan_perjam")
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        koneksi()
        If txtNoTiket.Text = "" Then
            MessageBox.Show("Form Tidak boleh Kosong!")
        Else
            Dim keterangan As String = "TERPARKIR"
            Dim tanggalTransaksi, namaOperator As String
            koneksi()
            cmd = New OleDb.OleDbCommand("select * from tabelTransaksi where no_tiket ='" & txtNoTiket.Text & "' and keterangan = '" & keterangan & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                jamMasuk = dr("jam_masuk")
                jamKeluar = DateTime.Now.ToShortTimeString
                namaOperator = dr("nama_operator")
                tanggalTransaksi = dr("tanggal_transaksi")
                tarifAwal = dr("tarif_kendaraan")
                txtNoKendaraan.Text = dr("no_kendaraan")
                txtJenisKendaraan.Text = dr("jenis_kendaraan")
                tampilTarifPerjam()
                txtTanggal.Text = tanggalTransaksi
                txtJam.Text = jamMasuk + " / " + jamKeluar
                'txtLamaParkir.Text = dr("jam_keluar")
                txtTarifKendaraan.Text = tarifAwal + " / " + tarifPerJam
                'txtLamaParkir.Text = 
                txtLamaParkir.Text = DateAndTime.DateDiff(DateInterval.Hour, Convert.ToDateTime(jamMasuk), Convert.ToDateTime(jamKeluar))
                If Convert.ToInt32(txtLamaParkir.Text) <= 1 Then
                    totalBiaya = tarifAwal
                Else
                    totalBiaya = Convert.ToInt32(tarifAwal) + (Convert.ToInt32(tarifPerJam) * (Convert.ToInt32(txtLamaParkir.Text) - 1))
                End If
                txtTotalBiaya.Text = totalBiaya
                txtNamaOperator.Text = namaOperator
            Else
                MessageBox.Show("Data tidak Ditemukan!")
            End If
        End If
    End Sub
End Class