Public Class formPengaturan

    Sub loadFormPengaturanUmum()
        Me.panelPengaturan.Controls.Clear()
        formPengaturanUmum.AutoSize = False
        formPengaturanUmum.TopLevel = False
        formPengaturanUmum.Dock = DockStyle.Fill
        Me.panelPengaturan.Controls.Add(formPengaturanUmum)
        formPengaturanUmum.Show()
        formPengaturanUmum.loadDataPengaturanUmum()
    End Sub

    Private Sub btnPengaturanUmum_Click(sender As Object, e As EventArgs) Handles btnPengaturanUmum.Click
        loadFormPengaturanUmum()

    End Sub

    Private Sub btnPengaturanUser_Click(sender As Object, e As EventArgs) Handles btnPengaturanUser.Click
        Me.panelPengaturan.Controls.Clear()
        formPengaturanTambahUser.AutoSize = False
        formPengaturanTambahUser.TopLevel = False
        formPengaturanTambahUser.Dock = DockStyle.Fill
        Me.panelPengaturan.Controls.Add(formPengaturanTambahUser)
        formPengaturanTambahUser.Show()
        formPengaturanTambahUser.loadIdUser()
    End Sub

    Private Sub btnTarifKendaraan_Click(sender As Object, e As EventArgs) Handles btnTarifKendaraan.Click
        Me.panelPengaturan.Controls.Clear()
        formPengaturanTarifKendaraan.AutoSize = False
        formPengaturanTarifKendaraan.TopLevel = False
        formPengaturanTarifKendaraan.Dock = DockStyle.Fill
        Me.panelPengaturan.Controls.Add(formPengaturanTarifKendaraan)
        formPengaturanTarifKendaraan.Show()
    End Sub

    Private Sub btnUbahDataUser_Click(sender As Object, e As EventArgs) Handles btnUbahDataUser.Click
        Me.panelPengaturan.Controls.Clear()
        formPengaturanUbahDataUser.AutoSize = False
        formPengaturanUbahDataUser.TopLevel = False
        formPengaturanUbahDataUser.Dock = DockStyle.Fill
        Me.panelPengaturan.Controls.Add(formPengaturanUbahDataUser)
        formPengaturanUbahDataUser.Show()
    End Sub
End Class