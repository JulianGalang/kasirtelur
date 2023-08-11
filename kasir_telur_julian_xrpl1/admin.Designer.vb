<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lbtanggal = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.btambah = New Guna.UI2.WinForms.Guna2Button()
        Me.bsimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.bubah = New Guna.UI2.WinForms.Guna2Button()
        Me.bhapus = New Guna.UI2.WinForms.Guna2Button()
        Me.bbatal = New Guna.UI2.WinForms.Guna2Button()
        Me.btutup = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DAFTAR ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Marker", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Marker", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Marker", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PASSWORD"
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(168, 77)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(314, 20)
        Me.tbnama.TabIndex = 4
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(168, 107)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(314, 20)
        Me.tbusername.TabIndex = 5
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(168, 137)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(314, 20)
        Me.tbpassword.TabIndex = 6
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(16, 204)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(484, 93)
        Me.dgv.TabIndex = 13
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Segoe Marker", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(12, 47)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(29, 24)
        Me.lblid.TabIndex = 15
        Me.lblid.Text = "ID"
        '
        'lbtanggal
        '
        Me.lbtanggal.AutoSize = True
        Me.lbtanggal.Font = New System.Drawing.Font("Segoe Marker", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtanggal.Location = New System.Drawing.Point(453, 17)
        Me.lbtanggal.Name = "lbtanggal"
        Me.lbtanggal.Size = New System.Drawing.Size(29, 24)
        Me.lbtanggal.TabIndex = 16
        Me.lbtanggal.Text = "ID"
        Me.lbtanggal.Visible = False
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(168, 47)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(314, 20)
        Me.tbid.TabIndex = 20
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
        Me.btambah.Location = New System.Drawing.Point(16, 175)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(75, 23)
        Me.btambah.TabIndex = 17
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
        Me.bsimpan.Location = New System.Drawing.Point(97, 175)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(75, 23)
        Me.bsimpan.TabIndex = 18
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
        Me.bubah.Location = New System.Drawing.Point(178, 175)
        Me.bubah.Name = "bubah"
        Me.bubah.Size = New System.Drawing.Size(75, 23)
        Me.bubah.TabIndex = 19
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
        Me.bhapus.Location = New System.Drawing.Point(259, 175)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(75, 23)
        Me.bhapus.TabIndex = 19
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
        Me.bbatal.Location = New System.Drawing.Point(340, 175)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(75, 23)
        Me.bbatal.TabIndex = 19
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
        Me.btutup.Location = New System.Drawing.Point(421, 175)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(75, 23)
        Me.btutup.TabIndex = 19
        Me.btutup.Text = "TUTUP"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(516, 309)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.btutup)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bubah)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.btambah)
        Me.Controls.Add(Me.lbtanggal)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "admin"
        Me.Text = "admin"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lbtanggal As System.Windows.Forms.Label
    Friend WithEvents tbid As TextBox
    Friend WithEvents btambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bsimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bubah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bhapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bbatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btutup As Guna.UI2.WinForms.Guna2Button
End Class
