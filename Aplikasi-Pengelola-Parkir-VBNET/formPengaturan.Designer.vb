<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPengaturan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelPengaturan = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTarifKendaraan = New System.Windows.Forms.Button()
        Me.btnUbahDataUser = New System.Windows.Forms.Button()
        Me.btnPengaturanUser = New System.Windows.Forms.Button()
        Me.btnPengaturanUmum = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelPengaturan
        '
        Me.panelPengaturan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPengaturan.Location = New System.Drawing.Point(3, 3)
        Me.panelPengaturan.Name = "panelPengaturan"
        Me.panelPengaturan.Size = New System.Drawing.Size(680, 428)
        Me.panelPengaturan.TabIndex = 3
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
        Me.TableLayoutPanel3.TabIndex = 5
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
        Me.Label2.Text = "Pengaturan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panelPengaturan, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(936, 434)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTarifKendaraan)
        Me.Panel1.Controls.Add(Me.btnUbahDataUser)
        Me.Panel1.Controls.Add(Me.btnPengaturanUser)
        Me.Panel1.Controls.Add(Me.btnPengaturanUmum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(689, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 428)
        Me.Panel1.TabIndex = 4
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
        'btnTarifKendaraan
        '
        Me.btnTarifKendaraan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTarifKendaraan.FlatAppearance.BorderSize = 0
        Me.btnTarifKendaraan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarifKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarifKendaraan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTarifKendaraan.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconMobil
        Me.btnTarifKendaraan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTarifKendaraan.Location = New System.Drawing.Point(11, 217)
        Me.btnTarifKendaraan.Name = "btnTarifKendaraan"
        Me.btnTarifKendaraan.Size = New System.Drawing.Size(224, 37)
        Me.btnTarifKendaraan.TabIndex = 7
        Me.btnTarifKendaraan.Text = "Tarif Kendaraan"
        Me.btnTarifKendaraan.UseVisualStyleBackColor = False
        '
        'btnUbahDataUser
        '
        Me.btnUbahDataUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUbahDataUser.FlatAppearance.BorderSize = 0
        Me.btnUbahDataUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbahDataUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbahDataUser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUbahDataUser.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconPassword
        Me.btnUbahDataUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUbahDataUser.Location = New System.Drawing.Point(11, 164)
        Me.btnUbahDataUser.Name = "btnUbahDataUser"
        Me.btnUbahDataUser.Size = New System.Drawing.Size(224, 37)
        Me.btnUbahDataUser.TabIndex = 6
        Me.btnUbahDataUser.Text = "Ubah Data User"
        Me.btnUbahDataUser.UseVisualStyleBackColor = False
        '
        'btnPengaturanUser
        '
        Me.btnPengaturanUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPengaturanUser.FlatAppearance.BorderSize = 0
        Me.btnPengaturanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengaturanUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengaturanUser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPengaturanUser.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconUser
        Me.btnPengaturanUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPengaturanUser.Location = New System.Drawing.Point(11, 111)
        Me.btnPengaturanUser.Name = "btnPengaturanUser"
        Me.btnPengaturanUser.Size = New System.Drawing.Size(224, 37)
        Me.btnPengaturanUser.TabIndex = 4
        Me.btnPengaturanUser.Text = "Tambah User"
        Me.btnPengaturanUser.UseVisualStyleBackColor = False
        '
        'btnPengaturanUmum
        '
        Me.btnPengaturanUmum.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPengaturanUmum.FlatAppearance.BorderSize = 0
        Me.btnPengaturanUmum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengaturanUmum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengaturanUmum.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPengaturanUmum.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconPengaturan
        Me.btnPengaturanUmum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPengaturanUmum.Location = New System.Drawing.Point(11, 58)
        Me.btnPengaturanUmum.Name = "btnPengaturanUmum"
        Me.btnPengaturanUmum.Size = New System.Drawing.Size(224, 37)
        Me.btnPengaturanUmum.TabIndex = 3
        Me.btnPengaturanUmum.Text = "Umum"
        Me.btnPengaturanUmum.UseVisualStyleBackColor = False
        '
        'formPengaturan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 490)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formPengaturan"
        Me.Text = "formPengaturan"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelPengaturan As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUbahDataUser As Button
    Friend WithEvents btnPengaturanUser As Button
    Friend WithEvents btnPengaturanUmum As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTarifKendaraan As Button
End Class
