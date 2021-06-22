Imports System.Data.OleDb

Public Class formPengaturanTarifKendaraan

    Sub hapusForm()
        cmbJenisKendaraan.SelectedIndex = -1
        txtTarifAwal.Text = ""
        txtTarifPerJam.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbJenisKendaraan.SelectedIndex = -1 Then
            MessageBox.Show("Data tidak boleh kosong!")
        Else
            koneksi()
            str = "update tabelTarifKendaraan set tarif_kendaraan_awal = '" & txtTarifAwal.Text & "', tarif_kendaraan_perjam = '" & txtTarifPerJam.Text & "' where jenis_kendaraan = '" & cmbJenisKendaraan.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Tersimpan!")
            hapusForm()
        End If
    End Sub

    Private Sub cmbJenisKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisKendaraan.SelectedIndexChanged
        If cmbJenisKendaraan.SelectedIndex >= 0 Then
            koneksi()
            cmd = New OleDb.OleDbCommand("select * from tabelTarifKendaraan where id_tarif_kendaraan = '" & cmbJenisKendaraan.SelectedIndex & "'", conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            txtTarifAwal.Text = dr("tarif_kendaraan_awal")
            txtTarifPerJam.Text = dr("tarif_kendaraan_perjam")
        End If

    End Sub
End Class