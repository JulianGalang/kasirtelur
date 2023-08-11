<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.nmjumlah = New System.Windows.Forms.NumericUpDown()
        Me.tbjumlahharga = New System.Windows.Forms.TextBox()
        Me.tbhargatotal = New System.Windows.Forms.TextBox()
        Me.tbbayar = New System.Windows.Forms.TextBox()
        Me.tbkembalian = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btambah = New Guna.UI2.WinForms.Guna2Button()
        Me.bsimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.btutup = New Guna.UI2.WinForms.Guna2Button()
        Me.bbatal = New Guna.UI2.WinForms.Guna2Button()
        Me.albel = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.LabelIDDetail = New System.Windows.Forms.Label()
        CType(Me.nmjumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(275, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSAKSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jenis Telur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jumlah Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Harga Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(381, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Kembalian"
        '
        'cbjenis
        '
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Location = New System.Drawing.Point(203, 65)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(300, 21)
        Me.cbjenis.TabIndex = 10
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(203, 100)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(300, 20)
        Me.dtp.TabIndex = 11
        '
        'nmjumlah
        '
        Me.nmjumlah.Location = New System.Drawing.Point(203, 135)
        Me.nmjumlah.Name = "nmjumlah"
        Me.nmjumlah.Size = New System.Drawing.Size(172, 20)
        Me.nmjumlah.TabIndex = 12
        '
        'tbjumlahharga
        '
        Me.tbjumlahharga.Location = New System.Drawing.Point(509, 135)
        Me.tbjumlahharga.Name = "tbjumlahharga"
        Me.tbjumlahharga.Size = New System.Drawing.Size(211, 20)
        Me.tbjumlahharga.TabIndex = 13
        '
        'tbhargatotal
        '
        Me.tbhargatotal.Location = New System.Drawing.Point(203, 170)
        Me.tbhargatotal.Name = "tbhargatotal"
        Me.tbhargatotal.Size = New System.Drawing.Size(300, 20)
        Me.tbhargatotal.TabIndex = 14
        '
        'tbbayar
        '
        Me.tbbayar.Location = New System.Drawing.Point(203, 205)
        Me.tbbayar.Name = "tbbayar"
        Me.tbbayar.Size = New System.Drawing.Size(172, 20)
        Me.tbbayar.TabIndex = 15
        '
        'tbkembalian
        '
        Me.tbkembalian.Location = New System.Drawing.Point(509, 203)
        Me.tbkembalian.Name = "tbkembalian"
        Me.tbkembalian.Size = New System.Drawing.Size(211, 20)
        Me.tbkembalian.TabIndex = 16
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(39, 298)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(666, 107)
        Me.dgv.TabIndex = 23
        '
        'btambah
        '
        Me.btambah.AutoRoundedCorners = True
        Me.btambah.BorderRadius = 20
        Me.btambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btambah.ForeColor = System.Drawing.Color.White
        Me.btambah.Location = New System.Drawing.Point(95, 250)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(98, 42)
        Me.btambah.TabIndex = 24
        Me.btambah.Text = "TAMBAH"
        '
        'bsimpan
        '
        Me.bsimpan.AutoRoundedCorners = True
        Me.bsimpan.BorderRadius = 20
        Me.bsimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bsimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bsimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bsimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bsimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bsimpan.ForeColor = System.Drawing.Color.White
        Me.bsimpan.Location = New System.Drawing.Point(277, 250)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(98, 42)
        Me.bsimpan.TabIndex = 25
        Me.bsimpan.Text = "SIMPAN"
        '
        'btutup
        '
        Me.btutup.AutoRoundedCorners = True
        Me.btutup.BorderRadius = 20
        Me.btutup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btutup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btutup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btutup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btutup.ForeColor = System.Drawing.Color.White
        Me.btutup.Location = New System.Drawing.Point(588, 250)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(98, 42)
        Me.btutup.TabIndex = 29
        Me.btutup.Text = "TUTUP"
        '
        'bbatal
        '
        Me.bbatal.AutoRoundedCorners = True
        Me.bbatal.BorderRadius = 20
        Me.bbatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bbatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bbatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bbatal.ForeColor = System.Drawing.Color.White
        Me.bbatal.Location = New System.Drawing.Point(442, 250)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(98, 42)
        Me.bbatal.TabIndex = 28
        Me.bbatal.Text = "BATAL"
        '
        'albel
        '
        Me.albel.AutoSize = True
        Me.albel.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.albel.Location = New System.Drawing.Point(509, 65)
        Me.albel.Name = "albel"
        Me.albel.Size = New System.Drawing.Size(29, 18)
        Me.albel.TabIndex = 30
        Me.albel.Text = "ID"
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(544, 65)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(176, 20)
        Me.tbid.TabIndex = 31
        '
        'LabelIDDetail
        '
        Me.LabelIDDetail.AutoSize = True
        Me.LabelIDDetail.Location = New System.Drawing.Point(39, 13)
        Me.LabelIDDetail.Name = "LabelIDDetail"
        Me.LabelIDDetail.Size = New System.Drawing.Size(39, 13)
        Me.LabelIDDetail.TabIndex = 32
        Me.LabelIDDetail.Text = "Label9"
        Me.LabelIDDetail.Visible = False
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(749, 408)
        Me.Controls.Add(Me.LabelIDDetail)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.albel)
        Me.Controls.Add(Me.btutup)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.btambah)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.tbkembalian)
        Me.Controls.Add(Me.tbbayar)
        Me.Controls.Add(Me.tbhargatotal)
        Me.Controls.Add(Me.tbjumlahharga)
        Me.Controls.Add(Me.nmjumlah)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.cbjenis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "transaksi"
        Me.Text = "transaksi"
        CType(Me.nmjumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents nmjumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbjumlahharga As System.Windows.Forms.TextBox
    Friend WithEvents tbhargatotal As System.Windows.Forms.TextBox
    Friend WithEvents tbbayar As System.Windows.Forms.TextBox
    Friend WithEvents tbkembalian As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bsimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btutup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bbatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents albel As Label
    Friend WithEvents tbid As TextBox
    Friend WithEvents LabelIDDetail As Label
End Class
