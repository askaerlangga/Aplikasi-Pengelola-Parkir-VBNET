Imports System.Data.OleDb

Public Class formPengaturanUbahDataUser

    Sub hapusForm()
        txtIdUser.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtNamaUser.Text = ""
        txtAlamat.Text = ""
        txtNoTelepon.Text = ""
        cmbJabatan.SelectedIndex = -1
        cmbJenisAkun.SelectedIndex = -1
        txtIdUser.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        str = "update tabelPegawai set username_user = '" & txtUsername.Text & "', password_user = '" & txtPassword.Text & "', nama_pegawai = '" & txtNamaUser.Text & "', alamat_pegawai = '" & txtAlamat.Text & "', no_telp_pegawai = '" & txtNoTelepon.Text & "', jabatan = '" & cmbJabatan.Text & "', jenis_user = '" & cmbJenisAkun.Text & "' where id_pegawai = '" & txtIdUser.Text & "'"
        cmd = New OleDbCommand(str, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan!")
        hapusForm()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        koneksi()
        If txtIdUser.Text = "" Then
            MessageBox.Show("Form Tidak boleh Kosong!")
        Else
            koneksi()
            cmd = New OleDb.OleDbCommand("select * from tabelPegawai where id_pegawai ='" & txtIdUser.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtUsername.Text = dr("username_user")
                txtPassword.Text = dr("password_user")
                txtNamaUser.Text = dr("nama_pegawai")
                txtAlamat.Text = dr("alamat_pegawai")
                txtNoTelepon.Text = dr("no_telp_pegawai")
                cmbJabatan.Text = dr("jabatan")
                cmbJenisAkun.Text = dr("jenis_user")
            Else
                MessageBox.Show("Data tidak ditemukan!")
            End If
        End If
    End Sub
End Class