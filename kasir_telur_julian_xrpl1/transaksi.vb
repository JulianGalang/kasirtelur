Imports System.Data.Odbc
Public Class transaksi
    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        relasi()
        tampil()
        bawaan()
    End Sub
    Sub atuhid()
        Dim urut As String
        Dim hitung As String
        cmd = New OdbcCommand("select * from transaksi where id_transaksi in (select max(id_transaksi) from transaksi)", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "TRS" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "TRS" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        tbid.Text = urut
    End Sub
    Sub aturiddetail()
        Dim mengurut As String
        Dim menghitung As String
        cmd = New OdbcCommand("select * form detail where id in(select max(id) from detail)", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            mengurut = "DTL" + "0001"
        Else
            menghitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            mengurut = "DTL" + Microsoft.VisualBasic.Right("0000" + menghitung, 4)
        End If
        LabelIDDetail.Text = mengurut
    End Sub
    Sub relasi()
        koneksi()
        cmd = New OdbcCommand("select * from jenis", Conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cbjenis.Items.Add(dr.GetString(1))
        Loop
    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bsimpan.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True

        cbjenis.Enabled = False
        dtp.Enabled = False
        nmjumlah.Enabled = False
        tbjumlahharga.Enabled = False
        tbhargatotal.Enabled = False
        tbbayar.Enabled = False
        tbkembalian.Enabled = False
        tbid.Enabled = False
        cbjenis.Text = ""
        nmjumlah.Value = "0"
        tbjumlahharga.Text = ""
        tbhargatotal.Text = ""
        tbbayar.Text = ""
        tbkembalian.Text = ""
        tbid.Text = ""
    End Sub
    Sub tambah()
        btambah.Enabled = False
        bsimpan.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False

        cbjenis.Enabled = True
        dtp.Enabled = False
        nmjumlah.Enabled = False
        tbjumlahharga.Enabled = False
        tbhargatotal.Enabled = False
        tbbayar.Enabled = True
        tbkembalian.Enabled = False
    End Sub
    Sub atur()
        dgv.Columns(0).Width = 45
        dgv.Columns(1).Width = 145
        dgv.Columns(2).Width = 145
        dgv.Columns(3).Width = 145
        dgv.Columns(4).Width = 145

        dgv.Columns(0).HeaderText = "ID"
        dgv.Columns(1).HeaderText = "Tanggal Transaksi"
        dgv.Columns(2).HeaderText = "Total Harga Pembelian"
        dgv.Columns(3).HeaderText = "Nominal Bayar"
        dgv.Columns(4).HeaderText = "Nominal Kembalian"
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("Select * From transaksi", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "transaksi")
        dgv.DataSource = (ds.Tables("transaksi"))
        atur()
    End Sub
    Sub simpan()
        koneksi()
        Dim simpandata As String
        Dim simpandetail As String
        Dim tgl As String
        tgl = Format(dtp.Value, "yyyy-MM-dd-hh-mm-ss")
        simpandata = "insert into transaksi values ('" & tbid.Text & "','" & tgl & "','" & tbhargatotal.Text & "','" & tbbayar.Text & "','" & tbkembalian.Text & "')"
        simpandetail = "insert into detail values ('" & LabelIDDetail.Text &
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menyimpan Data")
        tampil()
        bawaan()
    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        tambah()
        atuhid()
    End Sub
    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        simpan()
    End Sub
    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub
    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub
    Private Sub cbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjenis.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("select * from jenis where nama='" & cbjenis.Text & "'", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tbjumlahharga.Text = dr.GetString(2)
        End If
    End Sub
    Private Sub tbjumlahharga_TextChanged(sender As Object, e As EventArgs) Handles tbjumlahharga.TextChanged
        If tbjumlahharga.Text = "" Then
            nmjumlah.Enabled = False
        Else
            nmjumlah.Enabled = True
        End If
    End Sub
    Private Sub nmjumlah_ValueChanged(sender As Object, e As EventArgs) Handles nmjumlah.ValueChanged
        Dim jumlahnm As String
        jumlahnm = nmjumlah.Value.ToString
        If jumlahnm IsNot "" And tbjumlahharga.Text IsNot "" Then
            tbhargatotal.Text = jumlahnm * tbjumlahharga.Text
        End If
    End Sub
    Private Sub tbbayar_TextChanged(sender As Object, e As EventArgs) Handles tbbayar.TextChanged
        If tbbayar.Text IsNot "" And tbhargatotal.Text IsNot "" Then
            tbkembalian.Text = tbbayar.Text - tbhargatotal.Text
        End If
    End Sub
End Class