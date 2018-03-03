Public Class formCariBarang
    'drag
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Public kodeBarang As String
    Public namaBarang As String
    Public hargaBarang As Decimal
    Public diskonBarang As Integer
    Public stokBarang As Integer
    Private Sub PanelWindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelWindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelWindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseUp
        drag = False
    End Sub
    Private Sub formCariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SeleksiDataSet.lihatBarang' table. You can move, or remove it, as needed.
        Me.LihatBarangTableAdapter.Fill(Me.SeleksiDataSet.lihatBarang)
        txCariBarang.Select()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub tabelDataBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataBarang.CellClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            kodeBarang = tabelDataBarang.Rows(i).Cells(0).Value
            namaBarang = tabelDataBarang.Rows(i).Cells(1).Value
            hargaBarang = tabelDataBarang.Rows(i).Cells(3).Value
            diskonBarang = tabelDataBarang.Rows(i).Cells(4).Value
            stokBarang = tabelDataBarang.Rows(i).Cells(5).Value
        End If
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data!", vbOKOnly, "The Bread Shop")
        Else
            Me.Close()
            MainMenu.txKodeBarang.Text = kodeBarang
            MainMenu.txNamaBarang.Text = namaBarang
            MainMenu.txHargaKasir.Text = hargaBarang
            MainMenu.txDiskon.Text = diskonBarang
            MainMenu.txStok.Text = stokBarang
        End If
    End Sub

    Private Sub txCariBarang_TextChanged(sender As Object, e As EventArgs) Handles txCariBarang.TextChanged
        If txCariBarang.Text = "" Then
            Me.LihatBarangTableAdapter.Fill(Me.SeleksiDataSet.lihatBarang)
        Else
            Dim kataKunci As String = "%" & txCariBarang.Text & "%"
            LihatBarangTableAdapter.FillByCari(SeleksiDataSet.lihatBarang, kataKunci, kataKunci)
        End If
    End Sub


End Class