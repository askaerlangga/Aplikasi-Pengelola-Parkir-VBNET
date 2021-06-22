Imports System.Data.OleDb

Public Class formLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        koneksi()
        cmd = New OleDb.OleDbCommand("select * from tabelPegawai where username_user='" & txtUsername.Text & "' and password_user='" & txtPassword.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MessageBox.Show("Login Berhasil, Selamat datang " + dr("nama_pegawai").ToString + "!")
            formUtama.lblNamaUser.Text = dr("nama_pegawai").ToString
            Me.Hide()
            formUtama.Show()
        Else
            MessageBox.Show("Login Gagal! Username atau Password anda salah")
            txtPassword.Focus()
        End If
    End Sub
End Class