<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ujicoba
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbIDTransaksi = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.TextBoxTelepon = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbSubTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LbTanggal = New System.Windows.Forms.Label()
        Me.LbJam = New System.Windows.Forms.Label()
        Me.LbAdmin = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LbJenis = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LbHarga = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btambah = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LbKembalian = New System.Windows.Forms.Label()
        Me.TextBoxBayar = New System.Windows.Forms.TextBox()
        Me.btutup = New Guna.UI2.WinForms.Guna2Button()
        Me.bbatal = New Guna.UI2.WinForms.Guna2Button()
        Me.bsimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbItem = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxKdJenis = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Transaksi"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pembeli"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telepon"
        '
        'LbIDTransaksi
        '
        Me.LbIDTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbIDTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIDTransaksi.Location = New System.Drawing.Point(202, 39)
        Me.LbIDTransaksi.Name = "LbIDTransaksi"
        Me.LbIDTransaksi.Size = New System.Drawing.Size(254, 27)
        Me.LbIDTransaksi.TabIndex = 4
        Me.LbIDTransaksi.Text = "NOTRANSAKSI"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNama.Location = New System.Drawing.Point(202, 66)
        Me.TextBoxNama.Multiline = True
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(254, 27)
        Me.TextBoxNama.TabIndex = 5
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlamat.Location = New System.Drawing.Point(202, 93)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(254, 27)
        Me.TextBoxAlamat.TabIndex = 6
        '
        'TextBoxTelepon
        '
        Me.TextBoxTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelepon.Location = New System.Drawing.Point(202, 120)
        Me.TextBoxTelepon.Multiline = True
        Me.TextBoxTelepon.Name = "TextBoxTelepon"
        Me.TextBoxTelepon.Size = New System.Drawing.Size(254, 27)
        Me.TextBoxTelepon.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(765, 188)
        Me.DataGridView1.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(450, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 27)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "SUB TOTAL"
        '
        'LbSubTotal
        '
        Me.LbSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSubTotal.Location = New System.Drawing.Point(574, 39)
        Me.LbSubTotal.Name = "LbSubTotal"
        Me.LbSubTotal.Size = New System.Drawing.Size(211, 27)
        Me.LbSubTotal.TabIndex = 28
        Me.LbSubTotal.Text = "SUB TOTAL"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(450, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 27)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Tanggal"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(450, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 27)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Jam"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(450, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 27)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Petugas"
        '
        'LbTanggal
        '
        Me.LbTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTanggal.Location = New System.Drawing.Point(574, 66)
        Me.LbTanggal.Name = "LbTanggal"
        Me.LbTanggal.Size = New System.Drawing.Size(211, 27)
        Me.LbTanggal.TabIndex = 32
        Me.LbTanggal.Text = "SUB TOTAL"
        '
        'LbJam
        '
        Me.LbJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJam.Location = New System.Drawing.Point(574, 93)
        Me.LbJam.Name = "LbJam"
        Me.LbJam.Size = New System.Drawing.Size(211, 27)
        Me.LbJam.TabIndex = 33
        Me.LbJam.Text = "SUB TOTAL"
        '
        'LbAdmin
        '
        Me.LbAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAdmin.Location = New System.Drawing.Point(574, 120)
        Me.LbAdmin.Name = "LbAdmin"
        Me.LbAdmin.Size = New System.Drawing.Size(211, 27)
        Me.LbAdmin.TabIndex = 34
        Me.LbAdmin.Text = "SUB TOTAL"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 27)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Kode"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(197, 147)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 27)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Jenis"
        '
        'LbJenis
        '
        Me.LbJenis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJenis.Location = New System.Drawing.Point(256, 147)
        Me.LbJenis.Name = "LbJenis"
        Me.LbJenis.Size = New System.Drawing.Size(114, 27)
        Me.LbJenis.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(373, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 27)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Harga"
        '
        'LbHarga
        '
        Me.LbHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHarga.Location = New System.Drawing.Point(450, 147)
        Me.LbHarga.Name = "LbHarga"
        Me.LbHarga.Size = New System.Drawing.Size(114, 27)
        Me.LbHarga.TabIndex = 40
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(566, 147)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 27)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Jumlah"
        '
        'btambah
        '
        Me.btambah.AutoRoundedCorners = True
        Me.btambah.BorderRadius = 12
        Me.btambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btambah.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btambah.ForeColor = System.Drawing.Color.White
        Me.btambah.Location = New System.Drawing.Point(699, 147)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(86, 27)
        Me.btambah.TabIndex = 43
        Me.btambah.Text = "TAMBAH"
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJumlah.Location = New System.Drawing.Point(641, 147)
        Me.TextBoxJumlah.Multiline = True
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(58, 27)
        Me.TextBoxJumlah.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(557, 371)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 27)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Bayar"
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(557, 398)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 27)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Kembalian"
        '
        'LbKembalian
        '
        Me.LbKembalian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKembalian.Location = New System.Drawing.Point(653, 398)
        Me.LbKembalian.Name = "LbKembalian"
        Me.LbKembalian.Size = New System.Drawing.Size(96, 27)
        Me.LbKembalian.TabIndex = 47
        Me.LbKembalian.Text = "Kembalian"
        '
        'TextBoxBayar
        '
        Me.TextBoxBayar.Location = New System.Drawing.Point(653, 371)
        Me.TextBoxBayar.Multiline = True
        Me.TextBoxBayar.Name = "TextBoxBayar"
        Me.TextBoxBayar.Size = New System.Drawing.Size(96, 27)
        Me.TextBoxBayar.TabIndex = 48
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
        Me.btutup.Location = New System.Drawing.Point(256, 374)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(98, 42)
        Me.btutup.TabIndex = 51
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
        Me.bbatal.Location = New System.Drawing.Point(134, 374)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(98, 42)
        Me.bbatal.TabIndex = 50
        Me.bbatal.Text = "BATAL"
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
        Me.bsimpan.Location = New System.Drawing.Point(20, 374)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(98, 42)
        Me.bsimpan.TabIndex = 49
        Me.bsimpan.Text = "SIMPAN"
        '
        'Timer1
        '
        '
        'LbItem
        '
        Me.LbItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbItem.Location = New System.Drawing.Point(509, 374)
        Me.LbItem.Name = "LbItem"
        Me.LbItem.Size = New System.Drawing.Size(45, 27)
        Me.LbItem.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 27)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Item"
        '
        'ComboBoxKdJenis
        '
        Me.ComboBoxKdJenis.FormattingEnabled = True
        Me.ComboBoxKdJenis.Location = New System.Drawing.Point(79, 150)
        Me.ComboBoxKdJenis.Name = "ComboBoxKdJenis"
        Me.ComboBoxKdJenis.Size = New System.Drawing.Size(119, 21)
        Me.ComboBoxKdJenis.TabIndex = 54
        '
        'ujicoba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBoxKdJenis)
        Me.Controls.Add(Me.LbItem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btutup)
        Me.Controls.Add(Me.bbatal)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.TextBoxBayar)
        Me.Controls.Add(Me.LbKembalian)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBoxJumlah)
        Me.Controls.Add(Me.btambah)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.LbHarga)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LbJenis)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LbAdmin)
        Me.Controls.Add(Me.LbJam)
        Me.Controls.Add(Me.LbTanggal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbSubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxTelepon)
        Me.Controls.Add(Me.TextBoxAlamat)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.LbIDTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ujicoba"
        Me.Text = "ujicoba"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbIDTransaksi As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents TextBoxTelepon As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents LbSubTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LbTanggal As Label
    Friend WithEvents LbJam As Label
    Friend WithEvents LbAdmin As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LbJenis As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LbHarga As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents LbKembalian As Label
    Friend WithEvents TextBoxBayar As TextBox
    Friend WithEvents btutup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bbatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bsimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LbItem As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxKdJenis As ComboBox
End Class
