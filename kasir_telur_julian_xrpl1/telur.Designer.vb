<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class telur
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tharga = New System.Windows.Forms.TextBox()
        Me.tstok = New System.Windows.Forms.NumericUpDown()
        Me.kbaik = New System.Windows.Forms.NumericUpDown()
        Me.kpecah = New System.Windows.Forms.NumericUpDown()
        Me.kbusuk = New System.Windows.Forms.NumericUpDown()
        Me.relasi = New System.Windows.Forms.ComboBox()
        Me.dgvtelur = New System.Windows.Forms.DataGridView()
        Me.lbtanggal = New System.Windows.Forms.Label()
        Me.btambah = New Guna.UI2.WinForms.Guna2Button()
        Me.bsimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.bubah = New Guna.UI2.WinForms.Guna2Button()
        Me.bhapus = New Guna.UI2.WinForms.Guna2Button()
        Me.bbatal = New Guna.UI2.WinForms.Guna2Button()
        Me.btutup = New Guna.UI2.WinForms.Guna2Button()
        Me.tbid = New System.Windows.Forms.TextBox()
        CType(Me.tstok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kbaik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kpecah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kbusuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtelur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TELUR"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblid.Location = New System.Drawing.Point(82, 53)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(37, 24)
        Me.lblid.TabIndex = 1
        Me.lblid.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Telur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Stok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Kondisi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(178, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Baik"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(178, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Pecah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(178, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Busuk"
        '
        'tharga
        '
        Me.tharga.Location = New System.Drawing.Point(257, 113)
        Me.tharga.Name = "tharga"
        Me.tharga.Size = New System.Drawing.Size(334, 20)
        Me.tharga.TabIndex = 4
        '
        'tstok
        '
        Me.tstok.Location = New System.Drawing.Point(257, 143)
        Me.tstok.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.tstok.Name = "tstok"
        Me.tstok.Size = New System.Drawing.Size(334, 20)
        Me.tstok.TabIndex = 5
        '
        'kbaik
        '
        Me.kbaik.Location = New System.Drawing.Point(257, 178)
        Me.kbaik.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.kbaik.Name = "kbaik"
        Me.kbaik.Size = New System.Drawing.Size(334, 20)
        Me.kbaik.TabIndex = 6
        '
        'kpecah
        '
        Me.kpecah.Location = New System.Drawing.Point(257, 208)
        Me.kpecah.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.kpecah.Name = "kpecah"
        Me.kpecah.Size = New System.Drawing.Size(334, 20)
        Me.kpecah.TabIndex = 7
        '
        'kbusuk
        '
        Me.kbusuk.Location = New System.Drawing.Point(257, 238)
        Me.kbusuk.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.kbusuk.Name = "kbusuk"
        Me.kbusuk.Size = New System.Drawing.Size(334, 20)
        Me.kbusuk.TabIndex = 8
        '
        'relasi
        '
        Me.relasi.FormattingEnabled = True
        Me.relasi.Location = New System.Drawing.Point(257, 83)
        Me.relasi.Name = "relasi"
        Me.relasi.Size = New System.Drawing.Size(334, 21)
        Me.relasi.TabIndex = 15
        '
        'dgvtelur
        '
        Me.dgvtelur.AllowUserToAddRows = False
        Me.dgvtelur.AllowUserToDeleteRows = False
        Me.dgvtelur.AllowUserToResizeColumns = False
        Me.dgvtelur.AllowUserToResizeRows = False
        Me.dgvtelur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtelur.Location = New System.Drawing.Point(30, 310)
        Me.dgvtelur.Name = "dgvtelur"
        Me.dgvtelur.ReadOnly = True
        Me.dgvtelur.Size = New System.Drawing.Size(632, 112)
        Me.dgvtelur.TabIndex = 16
        '
        'lbtanggal
        '
        Me.lbtanggal.AutoSize = True
        Me.lbtanggal.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbtanggal.Location = New System.Drawing.Point(644, 9)
        Me.lbtanggal.Name = "lbtanggal"
        Me.lbtanggal.Size = New System.Drawing.Size(37, 24)
        Me.lbtanggal.TabIndex = 17
        Me.lbtanggal.Text = "ID"
        Me.lbtanggal.Visible = False
        '
        'btambah
        '
        Me.btambah.AutoRoundedCorners = True
        Me.btambah.BorderRadius = 19
        Me.btambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btambah.ForeColor = System.Drawing.Color.White
        Me.btambah.Location = New System.Drawing.Point(47, 264)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(95, 40)
        Me.btambah.TabIndex = 18
        Me.btambah.Text = "TAMBAH"
        '
        'bsimpan
        '
        Me.bsimpan.AutoRoundedCorners = True
        Me.bsimpan.BorderRadius = 19
        Me.bsimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bsimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bsimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bsimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bsimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bsimpan.ForeColor = System.Drawing.Color.White
        Me.bsimpan.Location = New System.Drawing.Point(148, 264)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(95, 40)
        Me.bsimpan.TabIndex = 19
        Me.bsimpan.Text = "SIMPAN"
        '
        'bubah
        '
        Me.bubah.AutoRoundedCorners = True
        Me.bubah.BorderRadius = 19
        Me.bubah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bubah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bubah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bubah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bubah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bubah.ForeColor = System.Drawing.Color.White
        Me.bubah.Location = New System.Drawing.Point(249, 264)
        Me.bubah.Name = "bubah"
        Me.bubah.Size = New System.Drawing.Size(95, 40)
        Me.bubah.TabIndex = 20
        Me.bubah.Text = "UBAH"
        '
        'bhapus
        '
        Me.bhapus.AutoRoundedCorners = True
        Me.bhapus.BorderRadius = 19
        Me.bhapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bhapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bhapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bhapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bhapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bhapus.ForeColor = System.Drawing.Color.White
        Me.bhapus.Location = New System.Drawing.Point(350, 264)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(95, 40)
        Me.bhapus.TabIndex = 21
        Me.bhapus.Text = "HAPUS"
        '
        'bbatal
        '
        Me.bbatal.AutoRoundedCorners = True
        Me.bbatal.BorderRadius = 19
        Me.bbatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bbatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bbatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bbatal.ForeColor = System.Drawing.Color.White
        Me.bbatal.Location = New System.Drawing.Point(451, 264)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(95, 40)
        Me.bbatal.TabIndex = 22
        Me.bbatal.Text = "BATAL"
        '
        'btutup
        '
        Me.btutup.AutoRoundedCorners = True
        Me.btutup.BorderRadius = 19
        Me.btutup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btutup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btutup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btutup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btutup.ForeColor = System.Drawing.Color.White
        Me.btutup.Location = New System.Drawing.Point(552, 264)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(95, 40)
        Me.btutup.TabIndex = 23
        Me.btutup.Text = "TUTUP"
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(257, 53)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(334, 20)
        Me.tbid.TabIndex = 24
        '
        'telur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(693, 431)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.btutup)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bubah)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.btambah)
        Me.Controls.Add(Me.lbtanggal)
        Me.Controls.Add(Me.dgvtelur)
        Me.Controls.Add(Me.relasi)
        Me.Controls.Add(Me.kbusuk)
        Me.Controls.Add(Me.kpecah)
        Me.Controls.Add(Me.kbaik)
        Me.Controls.Add(Me.tstok)
        Me.Controls.Add(Me.tharga)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "telur"
        Me.Text = "telur"
        CType(Me.tstok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kbaik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kpecah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kbusuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtelur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tharga As System.Windows.Forms.TextBox
    Friend WithEvents tstok As System.Windows.Forms.NumericUpDown
    Friend WithEvents kbaik As System.Windows.Forms.NumericUpDown
    Friend WithEvents kpecah As System.Windows.Forms.NumericUpDown
    Friend WithEvents kbusuk As System.Windows.Forms.NumericUpDown
    Friend WithEvents relasi As System.Windows.Forms.ComboBox
    Friend WithEvents dgvtelur As System.Windows.Forms.DataGridView
    Friend WithEvents lbtanggal As System.Windows.Forms.Label
    Friend WithEvents btambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bsimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bubah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bhapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bbatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btutup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbid As TextBox
End Class
