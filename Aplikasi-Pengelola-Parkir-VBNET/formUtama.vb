Imports System.Data.OleDb

Public Class formUtama
    Sub konfirmasiLogout()
        If (MessageBox.Show("Apakah anda yakin ingin Logout?", "Logout", MessageBoxButtons.YesNo) = vbYes) Then
            Me.Close()
            formLogin.Show()
            formLogin.txtUsername.Text = ""
            formLogin.txtPassword.Text = ""
            formLogin.txtUsername.Focus()
        End If
    End Sub

    Sub loadNamaParkiran()
        koneksi()
        cmd = New OleDb.OleDbCommand("select * from tabelPengaturanUmum where id_pengaturan = '" & "0" & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        lblNamaParkiran.Text = dr("nama_parkiran")
    End Sub

    Private Sub btnPengaturan_Click(sender As Object, e As EventArgs) Handles btnPengaturan.Click
        cmd = New OleDb.OleDbCommand("select * from tabelPegawai where nama_pegawai = '" & lblNamaUser.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr("jenis_user") = "admin") Then
            Me.panelUtama.Controls.Clear()
            formPengaturan.AutoSize = False
            formPengaturan.TopLevel = False
            formPengaturan.Dock = DockStyle.Fill
            Me.panelUtama.Controls.Add(formPengaturan)
            formPengaturan.Show()
            formPengaturan.loadFormPengaturanUmum()
        Else
            MessageBox.Show("Maaf, Halaman Pengaturan Hanya bisa dibuka Oleh user Admin!")
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        konfirmasiLogout()
    End Sub

    Private Sub btnLogout_MouseHover(sender As Object, e As EventArgs) Handles btnLogout.MouseHover
        ToolTip1.SetToolTip(btnLogout, "Logout")
    End Sub

    Private Sub formUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formBeranda.AutoSize = False
        formBeranda.TopLevel = False
        formBeranda.Dock = DockStyle.Fill
        Me.panelUtama.Controls.Add(formBeranda)
        formBeranda.Show()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Me.panelUtama.Controls.Clear()
        formTransaksi.AutoSize = False
        formTransaksi.TopLevel = False
        formTransaksi.Dock = DockStyle.Fill
        Me.panelUtama.Controls.Add(formTransaksi)
        formTransaksi.Show()
        formTransaksiParkirMasuk.hapusForm()
        formTransaksiParkirMasuk.loadWaktu()
    End Sub

    Private Sub btnBeranda_Click(sender As Object, e As EventArgs) Handles btnBeranda.Click
        Me.panelUtama.Controls.Clear()
        formBeranda.AutoSize = False
        formBeranda.TopLevel = False
        formBeranda.Dock = DockStyle.Fill
        Me.panelUtama.Controls.Add(formBeranda)
        formBeranda.Show()
        formBeranda.loadDashboard()
    End Sub

    Private Sub btnTentang_Click(sender As Object, e As EventArgs) Handles btnTentang.Click
        formTentang.ShowDialog()
    End Sub
End Class