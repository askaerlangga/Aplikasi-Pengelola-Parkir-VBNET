<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panelTransaksi = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLaporanTransaksi = New System.Windows.Forms.Button()
        Me.btnParkirKeluar = New System.Windows.Forms.Button()
        Me.btnParkirMasuk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(942, 490)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(20, 10)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(20, 10, 20, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(902, 40)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(896, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Transaksi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panelTransaksi, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(936, 434)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'panelTransaksi
        '
        Me.panelTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTransaksi.Location = New System.Drawing.Point(3, 3)
        Me.panelTransaksi.Name = "panelTransaksi"
        Me.panelTransaksi.Size = New System.Drawing.Size(680, 428)
        Me.panelTransaksi.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLaporanTransaksi)
        Me.Panel1.Controls.Add(Me.btnParkirKeluar)
        Me.Panel1.Controls.Add(Me.btnParkirMasuk)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(689, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 428)
        Me.Panel1.TabIndex = 4
        '
        'btnLaporanTransaksi
        '
        Me.btnLaporanTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLaporanTransaksi.FlatAppearance.BorderSize = 0
        Me.btnLaporanTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporanTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporanTransaksi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLaporanTransaksi.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconChart
        Me.btnLaporanTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporanTransaksi.Location = New System.Drawing.Point(11, 164)
        Me.btnLaporanTransaksi.Name = "btnLaporanTransaksi"
        Me.btnLaporanTransaksi.Size = New System.Drawing.Size(224, 37)
        Me.btnLaporanTransaksi.TabIndex = 6
        Me.btnLaporanTransaksi.Text = "Laporan Transaksi"
        Me.btnLaporanTransaksi.UseVisualStyleBackColor = False
        '
        'btnParkirKeluar
        '
        Me.btnParkirKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnParkirKeluar.FlatAppearance.BorderSize = 0
        Me.btnParkirKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParkirKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkirKeluar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnParkirKeluar.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconLogout
        Me.btnParkirKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParkirKeluar.Location = New System.Drawing.Point(11, 111)
        Me.btnParkirKeluar.Name = "btnParkirKeluar"
        Me.btnParkirKeluar.Size = New System.Drawing.Size(224, 37)
        Me.btnParkirKeluar.TabIndex = 4
        Me.btnParkirKeluar.Text = "Parkir Keluar"
        Me.btnParkirKeluar.UseVisualStyleBackColor = False
        '
        'btnParkirMasuk
        '
        Me.btnParkirMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnParkirMasuk.FlatAppearance.BorderSize = 0
        Me.btnParkirMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParkirMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkirMasuk.ForeColor = System.Drawing.SystemColors.Control
        Me.btnParkirMasuk.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconMasuk
        Me.btnParkirMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParkirMasuk.Location = New System.Drawing.Point(11, 58)
        Me.btnParkirMasuk.Name = "btnParkirMasuk"
        Me.btnParkirMasuk.Size = New System.Drawing.Size(224, 37)
        Me.btnParkirMasuk.TabIndex = 3
        Me.btnParkirMasuk.Text = "Parkir Masuk"
        Me.btnParkirMasuk.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sub-Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formTransaksi"
        Me.Text = "Transaksi"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents panelTransaksi As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnParkirMasuk As Button
    Friend WithEvents btnParkirKeluar As Button
    Friend WithEvents btnLaporanTransaksi As Button
    Friend WithEvents Label1 As Label
End Class
