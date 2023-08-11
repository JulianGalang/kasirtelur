
Public Class ujicoba
    Private Sub ujicoba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        Timer1.Start()


    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bsimpan.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = True

        LbIDTransaksi.Text = ""
        TextBoxNama.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxTelepon.Text = ""
        ComboBoxKdJenis.Text = ""
        TextBoxBayar.Text = ""
        LbKembalian.Text = ""
        LbJenis.Text = ""
        LbHarga.Text = "2000"
        LbItem.Text = 0

        buatkolom()
    End Sub


    Sub buatkolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("IdTelur", "ID Telur")
        DataGridView1.Columns.Add("JenisTelur", "Jenis Telur")
        DataGridView1.Columns.Add("Harga/KG", "Harga/KG")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Beli")
        DataGridView1.Columns.Add("Hartot", "Harga Total")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub total()
        Dim menghitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            menghitung = menghitung + DataGridView1.Rows(i).Cells(4).Value
            LbSubTotal.Text = menghitung
        Next

    End Sub


    Sub nambahitem()
        DataGridView1.Rows.Add(New String() {ComboBoxKdJenis.Text, LbJenis.Text, LbHarga.Text, TextBoxJumlah.Text, Val(LbHarga.Text) * Val(TextBoxJumlah.Text)})
        ComboBoxKdJenis.Text = ""
        LbHarga.Text = ""
        LbJenis.Text = ""
        TextBoxJumlah.Text = ""
        hitungitem()
        total()
    End Sub

    Sub hitungitem()
        Dim atem As Double = 0
        For i As Double = 0 To DataGridView1.Rows.Count - 1
            atem = atem + DataGridView1.Rows(i).Cells(3).Value
            LbItem.Text = atem.ToString("n")
        Next
    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        nambahitem()

    End Sub


    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LbTanggal.Text = DateTime.Now.ToString("dddd dd-MM-yyyy")
        LbJam.Text = TimeOfDay
    End Sub



    Private Sub TextBoxBayar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBayar.TextChanged
        If LbSubTotal.Text IsNot "" And TextBoxBayar.Text IsNot "" Then
            Dim kembalian As String
            kembalian = Val(TextBoxBayar.Text) - Val(LbSubTotal.Text)
            LbKembalian.Text = kembalian
        End If
    End Sub

    Private Sub LbSubTotal_Click(sender As Object, e As EventArgs) Handles LbSubTotal.Click

    End Sub
End Class