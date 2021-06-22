Imports System.Data.Odbc

Public Class formPengaturanTambahUser

    Sub loadIdUser()
        txtIdUser.Enabled = False
        Dim urutan As String
        Dim hitung As Long
        koneksi()
        cmd = New OdbcCommand("Select * from tabelPegawai where id_pegawai in (select max(id_pegawai) from tabelPegawai)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "USER" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urutan = "USER" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtIdUser.Text = urutan
    End Sub

    Sub hapusForm()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtNamaUser.Text = ""
        txtAlamat.Text = ""
        txtNoTelepon.Text = ""
        cmbJabatan.SelectedIndex = -1
        cmbJenisAkun.SelectedIndex = -1
        txtUsername.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        cmd = New OdbcCommand("insert into tabelPegawai values ('" & txtIdUser.Text & "','" &
                               txtUsername.Text & "','" & txtPassword.Text & "','" & txtNamaUser.Text & "','" & txtAlamat.Text & "','" &
                               txtNoTelepon.Text & "','" & cmbJabatan.Text & "','" & cmbJenisAkun.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan!")
        hapusForm()
        loadIdUser()
    End Sub

    Private Sub formPengaturanTambahUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadIdUser()
    End Sub
End Class