Imports System.Data.Odbc
Public Class jenis

    Private Sub jenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
        lbtanggal.Text = Format(Now, "yyyy-MM-dd-hh-mm-ss")
    End Sub
    Sub idauto()
        koneksi()
        Dim urut As String
        Dim hitung As String
        cmd = New OdbcCommand("select * from jenis where id in (select max(id) from jenis)", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "JNS" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "JNS" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        tbid.Text = urut
    End Sub
    Sub simpan()
        Dim simpandata As String
        simpandata = "insert into jenis values ('" & tbid.Text & "','" & tbnama.Text & "','" & tbharga.Text & "','" & lbtanggal.Text & "',' '' ')"
        cmd = New OdbcCommand(simpandata, Conn)
        cmd.ExecuteNonQuery()
        tampil()
        MsgBox("Berhasil Menyimpan Data")
    End Sub
    Sub tambah()
        tbnama.Enabled = True
        tbharga.Enabled = True
        btambah.Enabled = False
        bsimpan.Enabled = True
        tbid.Enabled = False
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = False
        idauto()
    End Sub
    Sub bawaan()
        tbharga.Enabled = False
        tbnama.Enabled = False
        tbid.Enabled = False
        btambah.Enabled = True
        bsimpan.Enabled = False
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True

        tbnama.Text = ""
        tbharga.Text = ""
        tbid.Text = ""
    End Sub
    Sub dgvclick()
        tbharga.Enabled = True
        tbnama.Enabled = True
        btambah.Enabled = False
        tbid.Enabled = False
        bsimpan.Enabled = False
        bubah.Enabled = True
        bhapus.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False
    End Sub
    Sub ubah()
        Dim ubahdata As String
        ubahdata = "update jenis set nama='" & tbnama.Text & "', harga = '" & tbharga.Text & "', diubah= '" & lbtanggal.Text & "'where id= '" & tbid.Text & "'"
        cmd = New OdbcCommand(ubahdata, Conn)
        cmd.ExecuteNonQuery()
        tampil()
        MsgBox("Berhasil Mengubah Data")
    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from jenis where id='" & tbid.Text & "';"
        cmd = New OdbcCommand(hapusdata, Conn)
        cmd.ExecuteNonQuery()
        tampil()
        MsgBox("Berhasil Menghapus Data")
    End Sub
    Sub atur()
        dgv.Columns(0).Width = 80
        dgv.Columns(1).Width = 170
        dgv.Columns(2).Width = 170
        dgv.Columns(0).HeaderText = "ID"
        dgv.Columns(1).HeaderText = "JENIS TELUR"
        dgv.Columns(2).HeaderText = "HARGA PERTELUR"
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("Select * From jenis", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jenis")
        dgv.DataSource = (ds.Tables("jenis"))
        atur()
    End Sub

    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        tambah()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        simpan()
        bawaan()
    End Sub

    Private Sub bubah_Click(sender As Object, e As EventArgs) Handles bubah.Click
        ubah()
        bawaan()
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        hapus()
        bawaan()
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = dgv.CurrentRow.Index
        tbid.Text = dgv.Item(0, i).Value
        tbnama.Text = dgv.Item(1, i).Value
        tbharga.Text = dgv.Item(2, i).Value
        dgvclick()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class