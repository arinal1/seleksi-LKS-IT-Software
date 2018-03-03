Public Class formKaryawan
    'drag
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    'foto
    Dim pasFoto As Byte() = Nothing
    'pass
    Dim pass As String
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

    Private Sub formKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        ulangForm()
        If MainMenu.editKaryawan Then
            txID.Text = MainMenu.idKaryawan
            txNama.Text = MainMenu.namaKaryawan
            cbLevel.SelectedItem = MainMenu.lvlKaryawan
            txPassword.Text = cariPass()
            pasFoto = MainMenu.fotoKaryawan
            If pasFoto Is Nothing Then
                fotoBox.BackgroundImage = Nothing
            Else
                Dim ms As New IO.MemoryStream(pasFoto)
                fotoBox.BackgroundImage = Image.FromStream(ms)
            End If
            txNama.Select()
        End If
    End Sub

    Function cariPass()
        Dim tmp As String
        Dim nw As String
        Dim pass As String = ""
        For i = 1 To Len(MainMenu.password)
            tmp = Mid(MainMenu.password, i, 1)
            nw = Asc(tmp) - 1
            pass = pass & Chr(nw)
        Next
        Return pass
    End Function

    Function bikinPass()
        Dim tmp As String
        Dim nw As String
        Dim pass As String = ""
        For i = 1 To Len(txPassword.Text)
            tmp = Mid(txPassword.Text, i, 1)
            nw = Asc(tmp) + 1
            pass = pass & Chr(nw)
        Next
        Return pass
    End Function

    Sub ulangForm()
        txNama.Clear()
        cbLevel.SelectedIndex = 0
        txPassword.Clear()
        fotoBox.BackgroundImage = Nothing
        If MainMenu.editKaryawan = False Then
            txID.Enabled = True
            txID.Clear()
            txID.Select()
        Else
            txID.Enabled = False
            txNama.Select()
        End If
    End Sub
    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        ulangForm()
    End Sub
    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        OpenFileDialog1.Filter = "Image Files (*.jpg, *.png) | *.jpg; *.png"
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            fotoBox.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            Dim ms As New IO.MemoryStream()
            fotoBox.BackgroundImage.Save(ms, fotoBox.BackgroundImage.RawFormat)
            pasFoto = ms.GetBuffer
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txID.Text = "" Or txNama.Text = "" Or cbLevel.SelectedItem = "" Or txPassword.Text = "" Then
            MsgBox("Mohon Data Dilengkapi", vbOKOnly, "The Bread Shop")
        Else
            If Len(txPassword.Text) < 5 Then
                MsgBox("Password Minimal 5 karakter!", vbOKOnly, "The Bread Shop")
            Else
                Dim pass As String = bikinPass()
                If MainMenu.editKaryawan Then
                    KaryawanTableAdapter.edit(txNama.Text, cbLevel.SelectedItem, pasFoto, pass, txID.Text)
                Else
                    KaryawanTableAdapter.Insert(txID.Text, txNama.Text, cbLevel.SelectedItem, pasFoto, pass)
                End If
                Me.Close()
            End If
        End If
    End Sub
End Class