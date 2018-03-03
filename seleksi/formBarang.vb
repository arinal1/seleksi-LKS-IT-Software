Public Class formBarang
    'drag
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    'foto
    Dim pasFoto As Byte() = Nothing
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

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub formBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SeleksiDataSet.kategori' table. You can move, or remove it, as needed.
        Me.KategoriTableAdapter.Fill(Me.SeleksiDataSet.kategori)
        ulangForm()
        If MainMenu.editBarang Then
            txKode.Text = MainMenu.kodeBarang
            txNama.Text = MainMenu.namaBarang
            cbKategori.SelectedValue = MainMenu.kodeKategori
            txHarga.Text = MainMenu.hargaBarang
            txDiskon.Text = MainMenu.diskonBarang
            txStok.Text = MainMenu.stokBarang
            pasFoto = MainMenu.fotoBarang
            If pasFoto Is Nothing Then
                fotoBoxBarang.BackgroundImage = Nothing
            Else
                Dim ms As New IO.MemoryStream(pasFoto)
                fotoBoxBarang.BackgroundImage = Image.FromStream(ms)
            End If
            txNama.Select()
        End If
    End Sub

    Sub ulangForm()
        txNama.Clear()
        cbKategori.SelectedIndex = 0
        txHarga.Clear()
        txDiskon.Clear()
        txStok.Clear()
        fotoBoxBarang.BackgroundImage = Nothing
        If MainMenu.editBarang = False Then
            txKode.Enabled = True
            txKode.Clear()
            txKode.Select()
        Else
            txKode.Enabled = False
            txNama.Select()
        End If
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        ulangForm()
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        OpenFileDialog1.Filter = "Image Files (*.jpg, *.png) | *.jpg; *.png"
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            fotoBoxBarang.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            Dim ms As New IO.MemoryStream()
            fotoBoxBarang.BackgroundImage.Save(ms, fotoBoxBarang.BackgroundImage.RawFormat)
            pasFoto = ms.GetBuffer
        Else
            fotoBoxBarang.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txKode.Text = "" Or txNama.Text = "" Or cbKategori.SelectedValue = "" Or txHarga.Text = "" Or txDiskon.Text = "" Or txStok.Text = "" Then
            MsgBox("Mohon Data Dilengkapi", vbOKOnly, "The Bread Shop")
        Else
            If MainMenu.editBarang Then
                BarangTableAdapter.edit(txNama.Text, cbKategori.SelectedValue, Decimal.Parse(txHarga.Text), Integer.Parse(txDiskon.Text), Integer.Parse(txStok.Text), pasFoto, txKode.Text)
            Else
                BarangTableAdapter.Insert(txKode.Text, txNama.Text, cbKategori.SelectedValue, Decimal.Parse(txHarga.Text), Integer.Parse(txDiskon.Text), Integer.Parse(txStok.Text), pasFoto)
            End If
            Me.Close()
        End If
    End Sub
    Sub banInt(e As KeyPressEventArgs)
        Dim i As Integer = Asc(e.KeyChar)
        If i <> 8 Then
            If i < 48 Or i > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        banInt(e)
    End Sub

    Private Sub txHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txHarga.KeyPress
        banInt(e)
    End Sub

    Private Sub txStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txStok.KeyPress
        banInt(e)
    End Sub
End Class