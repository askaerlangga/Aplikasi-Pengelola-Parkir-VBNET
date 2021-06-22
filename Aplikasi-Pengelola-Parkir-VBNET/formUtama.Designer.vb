<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUtama))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNamaParkiran = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNamaUser = New System.Windows.Forms.Label()
        Me.panelUtama = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnPengaturan = New System.Windows.Forms.Button()
        Me.btnBeranda = New System.Windows.Forms.Button()
        Me.btnTentang = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1180, 624)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnTransaksi, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPengaturan, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBeranda, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTentang, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel14, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 624)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.lblNamaParkiran, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(194, 144)
        Me.TableLayoutPanel14.TabIndex = 4
        '
        'lblNamaParkiran
        '
        Me.lblNamaParkiran.AutoSize = True
        Me.lblNamaParkiran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNamaParkiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaParkiran.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNamaParkiran.Location = New System.Drawing.Point(0, 72)
        Me.lblNamaParkiran.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblNamaParkiran.Name = "lblNamaParkiran"
        Me.lblNamaParkiran.Size = New System.Drawing.Size(191, 72)
        Me.lblNamaParkiran.TabIndex = 2
        Me.lblNamaParkiran.Text = "Aska Parking"
        Me.lblNamaParkiran.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.panelUtama, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(200, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(980, 624)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblNamaUser, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnLogout, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(20, 10)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(20, 10, 20, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(940, 40)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'lblNamaUser
        '
        Me.lblNamaUser.AutoSize = True
        Me.lblNamaUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNamaUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNamaUser.Location = New System.Drawing.Point(743, 0)
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Size = New System.Drawing.Size(144, 40)
        Me.lblNamaUser.TabIndex = 1
        Me.lblNamaUser.Text = "Nama User"
        Me.lblNamaUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelUtama
        '
        Me.panelUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUtama.Location = New System.Drawing.Point(3, 53)
        Me.panelUtama.Name = "panelUtama"
        Me.panelUtama.Size = New System.Drawing.Size(974, 568)
        Me.panelUtama.TabIndex = 2
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTransaksi.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconKasir
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(4, 204)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(192, 42)
        Me.btnTransaksi.TabIndex = 1
        Me.btnTransaksi.Text = "Transaksi"
        Me.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnPengaturan
        '
        Me.btnPengaturan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPengaturan.FlatAppearance.BorderSize = 0
        Me.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengaturan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengaturan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPengaturan.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconPengaturan
        Me.btnPengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPengaturan.Location = New System.Drawing.Point(4, 254)
        Me.btnPengaturan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPengaturan.Name = "btnPengaturan"
        Me.btnPengaturan.Size = New System.Drawing.Size(192, 42)
        Me.btnPengaturan.TabIndex = 2
        Me.btnPengaturan.Text = " Pengaturan"
        Me.btnPengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPengaturan.UseVisualStyleBackColor = True
        '
        'btnBeranda
        '
        Me.btnBeranda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBeranda.FlatAppearance.BorderSize = 0
        Me.btnBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeranda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeranda.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBeranda.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconBeranda
        Me.btnBeranda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBeranda.Location = New System.Drawing.Point(4, 154)
        Me.btnBeranda.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBeranda.Name = "btnBeranda"
        Me.btnBeranda.Size = New System.Drawing.Size(192, 42)
        Me.btnBeranda.TabIndex = 0
        Me.btnBeranda.Text = " Beranda"
        Me.btnBeranda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBeranda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBeranda.UseVisualStyleBackColor = True
        '
        'btnTentang
        '
        Me.btnTentang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTentang.FlatAppearance.BorderSize = 0
        Me.btnTentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTentang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTentang.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTentang.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconTentang
        Me.btnTentang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTentang.Location = New System.Drawing.Point(4, 304)
        Me.btnTentang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTentang.Name = "btnTentang"
        Me.btnTentang.Size = New System.Drawing.Size(192, 42)
        Me.btnTentang.TabIndex = 3
        Me.btnTentang.Text = " Tentang"
        Me.btnTentang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTentang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTentang.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox2.Image = Global.Aplikasi_Pengelola_Parkir_VBNET.My.Resources.Resources.iconParkir
        Me.PictureBox2.Location = New System.Drawing.Point(84, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(893, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(44, 34)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'formUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 624)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Pengelola Parkir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBeranda As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnPengaturan As Button
    Friend WithEvents btnTentang As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblNamaUser As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents lblNamaParkiran As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents panelUtama As Panel
End Class
