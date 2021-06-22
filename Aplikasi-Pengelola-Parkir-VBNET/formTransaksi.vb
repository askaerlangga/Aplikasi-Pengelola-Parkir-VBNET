Public Class formTransaksi
    Sub loadFormParkirMasuk()
        Me.panelTransaksi.Controls.Clear()
        formTransaksiParkirMasuk.AutoSize = False
        formTransaksiParkirMasuk.TopLevel = False
        formTransaksiParkirMasuk.Dock = DockStyle.Fill
        Me.panelTransaksi.Controls.Add(formTransaksiParkirMasuk)
        formTransaksiParkirMasuk.Show()
    End Sub

    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadFormParkirMasuk()
    End Sub

    Private Sub btnParkirMasuk_Click(sender As Object, e As EventArgs) Handles btnParkirMasuk.Click
        loadFormParkirMasuk()
        formTransaksiParkirMasuk.loadWaktu()
    End Sub

    Private Sub btnParkirKeluar_Click(sender As Object, e As EventArgs) Handles btnParkirKeluar.Click
        Me.panelTransaksi.Controls.Clear()
        formTransaksiParkirKeluar.AutoSize = False
        formTransaksiParkirKeluar.TopLevel = False
        formTransaksiParkirKeluar.Dock = DockStyle.Fill
        Me.panelTransaksi.Controls.Add(formTransaksiParkirKeluar)
        formTransaksiParkirKeluar.Show()
    End Sub

    Private Sub btnLaporanTransaksi_Click(sender As Object, e As EventArgs) Handles btnLaporanTransaksi.Click
        Me.panelTransaksi.Controls.Clear()
        formTransaksiLaporanTransaksi.AutoSize = False
        formTransaksiLaporanTransaksi.TopLevel = False
        formTransaksiLaporanTransaksi.Dock = DockStyle.Fill
        Me.panelTransaksi.Controls.Add(formTransaksiLaporanTransaksi)
        formTransaksiLaporanTransaksi.Show()
        formTransaksiLaporanTransaksi.loadLaporanTransaksi()
    End Sub
End Class