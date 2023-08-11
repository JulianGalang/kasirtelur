Imports System.Data.Odbc
Public Class telur
    Private Sub telur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        koneksi()
        rel()
        tampil()
        lbtanggal.Text = Format(Now, "yyyy-MM-dd-hh-mm-ss")

    End Sub
    Sub atuid()
        koneksi()
        Dim urut As String
        Dim hitung As String
        cmd = New OdbcCommand("select * from jenis where id in (select max(id) from jenis )", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "TL" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "TL" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        tbid.Text = urut
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("Select * From telur", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "telur")
        dgvtelur.DataSource = (ds.Tables("telur"))

        dgvtelur.Columns(0).Width = 40
        dgvtelur.Columns(1).Width = 95
        dgvtelur.Columns(2).Width = 70
        dgvtelur.Columns(3).Width = 70
        dgvtelur.Columns(4).Width = 70
        dgvtelur.Columns(5).Width = 70
        dgvtelur.Columns(6).Width = 70

        dgvtelur.Columns(0).HeaderText = "ID"
        dgvtelur.Columns(1).HeaderText = "Jenis Ayam"
        dgvtelur.Columns(2).HeaderText = "Harga Pertelur"
        dgvtelur.Columns(3).HeaderText = "Stok Telur"
        dgvtelur.Columns(4).HeaderText = "Kondisi Bagus"
        dgvtelur.Columns(5).HeaderText = "Kondisi Pecah"
        dgvtelur.Columns(6).HeaderText = "Kondisi Busuk"
        dgvtelur.Columns(7).HeaderText = "Tanggal Masuk"

    End Sub
    Sub dgvklik()
        bawaan()
        Dim i As Integer
        i = dgvtelur.CurrentRow.Index
        tbid.Text = dgvtelur.Item(0, i).Value
        relasi.Text = dgvtelur.Item(1, i).Value
        tharga.Text = dgvtelur.Item(2, i).Value
        tstok.Value = dgvtelur.Item(3, i).Value.ToString
        kbaik.Value = dgvtelur.Item(4, i).Value.ToString
        kpecah.Value = dgvtelur.Item(5, i).Value.ToString
        kbusuk.Value = dgvtelur.Item(6, i).Value.ToString

        btambah.Enabled = False
        bsimpan.Enabled = False
        bubah.Enabled = True
        bhapus.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False
        relasi.Enabled = True

        tbid.Enabled = False
        tharga.Enabled = False
        tstok.Enabled = True
        kbaik.Enabled = True
        kpecah.Enabled = True
        kbusuk.Enabled = True


    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bsimpan.Enabled = False
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True
        relasi.Enabled = False

        tbid.Enabled = False
        tharga.Enabled = False
        tstok.Enabled = False
        kbaik.Enabled = False
        kpecah.Enabled = False
        kbusuk.Enabled = False

        tbid.Text = ""
        relasi.Text = ""
        tharga.Text = ""
        tstok.Text = ""
        kbaik.Value = "0"
        kpecah.Value = "0"
        kbusuk.Value = "0"
        tstok.Maximum = 10000
        kbaik.Maximum = 10000
        kpecah.Maximum = 10000
        kbusuk.Maximum = 10000
        tstok.Minimum = 0
        kbaik.Minimum = 0
        kpecah.Minimum = 0
        kbusuk.Minimum = 0
    End Sub
    Sub rel()
        koneksi()
        cmd = New OdbcCommand("select * from  jenis", Conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            relasi.Items.Add(dr.GetString(1))
        Loop
    End Sub
    Sub tambah()
        btambah.Enabled = False
        bsimpan.Enabled = True
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = False
        relasi.Enabled = True

        tbid.Enabled = False
        tharga.Enabled = False
        tstok.Enabled = True
        kbaik.Enabled = True
        kpecah.Enabled = True
        kbusuk.Enabled = True
    End Sub
    Sub simpan()
        Dim simpandata As String
        simpandata = "insert into telur value ('" & tbid.Text & "','" & relasi.Text & "','" & tharga.Text & "','" & tstok.Value.ToString & "','" & kbaik.Value.ToString & "','" & kpecah.Value.ToString & "','" & kbusuk.Value.ToString & "','" & lbtanggal.Text & "',' '' ')"
        cmd = New OdbcCommand(simpandata, Conn)
        cmd.ExecuteNonQuery()
        tampil()
        MsgBox("Berhasil Menyimpan Data")
    End Sub
    Sub ubah()
        Dim ubahdata As String
        ubahdata = "update telur set nama_jenis='" & relasi.Text & "', harga='" & tharga.Text & "', stok='" & tstok.Value.ToString & "', baik='" & kbaik.Value.ToString & "', pecah='" & kpecah.Value.ToString & "', busuk='" & kbusuk.Value.ToString & "', diubah='" & lbtanggal.Text & "' where id='" & tbid.Text & "'"
        cmd = New OdbcCommand(ubahdata, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Mengubah Data")
        tampil()
    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from telur where id='" & tbid.Text & "';"
        cmd = New OdbcCommand(hapusdata, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Data")
        tampil()
    End Sub
    Private Sub btambah_Click_1(sender As Object, e As EventArgs) Handles btambah.Click
        tambah()
        atuid()
    End Sub

    Private Sub bsimpan_Click_1(sender As Object, e As EventArgs) Handles bsimpan.Click
        simpan()
        bawaan()
    End Sub

    Private Sub bubah_Click_1(sender As Object, e As EventArgs) Handles bubah.Click
        ubah()
        bawaan()
    End Sub

    Private Sub bhapus_Click_1(sender As Object, e As EventArgs) Handles bhapus.Click
        hapus()
        bawaan()
    End Sub

    Private Sub bbatal_Click_1(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub btutup_Click_1(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub dgvtelur_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtelur.CellClick
        dgvklik()
    End Sub

    Private Sub relasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles relasi.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("select * from jenis where nama='" & relasi.Text & "'", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tharga.Text = dr.GetString(2)
        End If
        tharga.Enabled = False
    End Sub
    Sub maxmin()

    End Sub

    Private Sub kbaik_ValueChanged(sender As Object, e As EventArgs) Handles kbaik.ValueChanged
        kbaik.Maximum = tstok.Value
    End Sub

    Private Sub kpecah_ValueChanged(sender As Object, e As EventArgs) Handles kpecah.ValueChanged
        kpecah.Maximum = tstok.Value - kbaik.Value
    End Sub

    Private Sub kbusuk_ValueChanged(sender As Object, e As EventArgs) Handles kbusuk.ValueChanged
        kbusuk.Maximum = tstok.Value - kbaik.Value - kpecah.Value
    End Sub
End Class