Imports System.Data.OleDb

Public Class formPengaturanUmum

    Sub loadDataPengaturanUmum()
        koneksi()
        cmd = New OleDb.OleDbCommand("select * from tabelPengaturanUmum where id_pengaturan = '" & "0" & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        txtNamaParkiran.Text = dr("nama_parkiran")
        txtNamaPemilik.Text = dr("nama_pemilik")
        txtAlamatParkiran.Text = dr("alamat_parkiran")
        txtNoTelpParkiran.Text = dr("no_telp_parkiran")
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        str = "update tabelPengaturanUmum set nama_parkiran = '" & txtNamaParkiran.Text & "', nama_pemilik = '" & txtNamaPemilik.Text & "', alamat_parkiran = '" & txtAlamatParkiran.Text & "', no_telp_parkiran = '" & txtNoTelpParkiran.Text & "' where id_pengaturan = '" & "0" & "'"
        cmd = New OleDbCommand(str, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan!")
    End Sub

    Private Sub formPengaturanUmum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataPengaturanUmum()
    End Sub
End Class