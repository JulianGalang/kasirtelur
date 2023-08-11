<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jenis
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
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblid = New System.Windows.Forms.Label()
        Me.btambah = New Guna.UI2.WinForms.Guna2Button()
        Me.bsimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.bubah = New Guna.UI2.WinForms.Guna2Button()
        Me.bhapus = New Guna.UI2.WinForms.Guna2Button()
        Me.bbatal = New Guna.UI2.WinForms.Guna2Button()
        Me.btutup = New Guna.UI2.WinForms.Guna2Button()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbtanggal = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(171, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis Telur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(142, 79)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(354, 20)
        Me.tbnama.TabIndex = 3
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(34, 166)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(442, 111)
        Me.dgv.TabIndex = 10
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Segoe Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(12, 53)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(27, 22)
        Me.lblid.TabIndex = 12
        Me.lblid.Text = "ID"
        '
        'btambah
        '
        Me.btambah.AutoRoundedCorners = True
        Me.btambah.BorderRadius = 10
        Me.btambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btambah.ForeColor = System.Drawing.Color.White
        Me.btambah.Location = New System.Drawing.Point(16, 137)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(75, 23)
        Me.btambah.TabIndex = 13
        Me.btambah.Text = "TAMBAH"
        '
        'bsimpan
        '
        Me.bsimpan.AutoRoundedCorners = True
        Me.bsimpan.BorderRadius = 10
        Me.bsimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bsimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bsimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bsimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bsimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bsimpan.ForeColor = System.Drawing.Color.White
        Me.bsimpan.Location = New System.Drawing.Point(97, 137)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(75, 23)
        Me.bsimpan.TabIndex = 14
        Me.bsimpan.Text = "SIMPAN"
        '
        'bubah
        '
        Me.bubah.AutoRoundedCorners = True
        Me.bubah.BorderRadius = 10
        Me.bubah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bubah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bubah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bubah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bubah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bubah.ForeColor = System.Drawing.Color.White
        Me.bubah.Location = New System.Drawing.Point(178, 137)
        Me.bubah.Name = "bubah"
        Me.bubah.Size = New System.Drawing.Size(75, 23)
        Me.bubah.TabIndex = 15
        Me.bubah.Text = "UBAH"
        '
        'bhapus
        '
        Me.bhapus.AutoRoundedCorners = True
        Me.bhapus.BorderRadius = 10
        Me.bhapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bhapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bhapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bhapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bhapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bhapus.ForeColor = System.Drawing.Color.White
        Me.bhapus.Location = New System.Drawing.Point(259, 137)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(75, 23)
        Me.bhapus.TabIndex = 16
        Me.bhapus.Text = "HAPUS"
        '
        'bbatal
        '
        Me.bbatal.AutoRoundedCorners = True
        Me.bbatal.BorderRadius = 10
        Me.bbatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bbatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bbatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bbatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bbatal.ForeColor = System.Drawing.Color.White
        Me.bbatal.Location = New System.Drawing.Point(340, 137)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(75, 23)
        Me.bbatal.TabIndex = 17
        Me.bbatal.Text = "BATAL"
        '
        'btutup
        '
        Me.btutup.AutoRoundedCorners = True
        Me.btutup.BorderRadius = 10
        Me.btutup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btutup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btutup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btutup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btutup.ForeColor = System.Drawing.Color.White
        Me.btutup.Location = New System.Drawing.Point(421, 137)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(75, 23)
        Me.btutup.TabIndex = 18
        Me.btutup.Text = "TUTUP"
        '
        'tbharga
        '
        Me.tbharga.Location = New System.Drawing.Point(142, 105)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(354, 20)
        Me.tbharga.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Harga Pertelur"
        '
        'lbtanggal
        '
        Me.lbtanggal.AutoSize = True
        Me.lbtanggal.Font = New System.Drawing.Font("Segoe Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtanggal.Location = New System.Drawing.Point(469, 9)
        Me.lbtanggal.Name = "lbtanggal"
        Me.lbtanggal.Size = New System.Drawing.Size(27, 22)
        Me.lbtanggal.TabIndex = 21
        Me.lbtanggal.Text = "ID"
        Me.lbtanggal.Visible = False
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(142, 53)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(354, 20)
        Me.tbid.TabIndex = 22
        '
        'jenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(517, 293)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.lbtanggal)
        Me.Controls.Add(Me.tbharga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btutup)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bubah)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.btambah)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "jenis"
        Me.Text = "jenis"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents btambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bsimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bubah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bhapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bbatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btutup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbharga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbtanggal As Label
    Friend WithEvents tbid As TextBox
End Class
