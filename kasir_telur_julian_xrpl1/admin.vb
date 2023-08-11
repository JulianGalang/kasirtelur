Imports System.Data.Odbc
Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        bawaan()
        lbtanggal.Text = Format(Now, "yyyy-MM-dd-hh-mm-ss")
    End Sub
    Sub idauto()
        koneksi()
        cmd = New OdbcCommand("select * from admin where id in (select max(id) from admin)", Conn)
        Dim urut As String
        Dim hitung As String
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "ADM" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "ADM" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        tbid.Text = urut
    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bsimpan.Enabled = False
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True

        tbnama.Enabled = False
        tbusername.Enabled = False
        tbpassword.Enabled = False
        tbid.Enabled = False
        tbid.Text = ""
        tbnama.Text = ""
        tbusername.Text = ""
        tbpassword.Text = ""
    End Sub
    Sub dgvcl()
        btambah.Enabled = False
        bsimpan.Enabled = False
        bubah.Enabled = True
        bhapus.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False

        tbnama.Enabled = True
        tbusername.Enabled = True
        tbpassword.Enabled = True
        tbid.Enabled = False
    End Sub
    Sub tambah()
        btambah.Enabled = False
        bsimpan.Enabled = True
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = False

        tbnama.Enabled = True
        tbusername.Enabled = True
        tbpassword.Enabled = True
        tbid.Enabled = False
        idauto()
    End Sub
    Sub atur()
        dgv.Columns(0).Width = 65
        dgv.Columns(1).Width = 170
        dgv.Columns(2).Width = 120
        dgv.Columns(3).Width = 120

        dgv.Columns(0).HeaderText = "ID"
        dgv.Columns(1).HeaderText = "NAMA"
        dgv.Columns(2).HeaderText = "USERNAME"
        dgv.Columns(3).HeaderText = "PASSWORD"
        dgv.Columns(4).HeaderText = "Tanggal Dibuat"
        dgv.Columns(5).HeaderText = "Tanggal Diubah"
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("select * from admin", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "admin")
        dgv.DataSource = (ds.Tables("admin"))
        atur()
    End Sub
    Sub simpan()
        Dim simpandata As String
        If tbnama.Text = "" And tbusername.Text = "" And tbpassword.Text = "" Then
            MessageBox.Show("Mohon isi field yang kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            simpandata = "insert into admin value ('" & tbid.Text & "','" & tbnama.Text & "','" & tbusername.Text & "','" & tbpassword.Text & "','" & lbtanggal.Text & "',' '' ')"
            cmd = New OdbcCommand(simpandata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan Data", , "Kasir Telur")
            tampil()
            bawaan()
        End If

    End Sub
    Sub ubah()
        Dim ubahdata As String
        ubahdata = "update admin set nama='" & tbnama.Text & "',username='" & tbusername.Text & "',password='" & tbpassword.Text & "', diubah='" & lbtanggal.Text & "' where id='" & tbid.Text & "'"
        cmd = New OdbcCommand(ubahdata, Conn)
        cmd.ExecuteNonQuery()
        tampil()
        MsgBox("Berhasil Mengubah Data")
    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from admin where id='" & tbid.Text & "';"
        cmd = New OdbcCommand(hapusdata, Conn)
        cmd.ExecuteNonQuery()
        tampil()
        MsgBox("Berhasil Menghapus Data")
    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        tambah()
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

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = dgv.CurrentRow.Index
        tbid.Text = dgv.Item(0, i).Value
        tbnama.Text = dgv.Item(1, i).Value
        tbusername.Text = dgv.Item(2, i).Value
        tbpassword.Text = dgv.Item(3, i).Value
        dgvcl()
    End Sub
End Class