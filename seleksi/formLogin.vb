Public Class formLogin
    'drag
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim pass As String
    Private Sub PanelWindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Function bikinPass()
        Dim tmp As String
        Dim nw As String
        Dim pass As String = ""
        For i = 1 To Len(txPass.Text)
            tmp = Mid(txPass.Text, i, 1)
            nw = Asc(tmp) + 1
            pass = pass & Chr(nw)
        Next
        Return pass
    End Function

    Private Sub PanelWindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelWindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseUp
        drag = False
    End Sub
    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txID.Clear()
        txPass.Clear()
        txID.Focus()
    End Sub

    Private Sub txID_KeyDown(sender As Object, e As KeyEventArgs) Handles txID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txID.Text IsNot "" Then
                txPass.Focus()
            End If
        End If
    End Sub

    Private Sub txPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txPass.Text IsNot "" And txID.Text IsNot "" Then
                If Len(txPass.Text) < 5 Then
                    lblWarn.Visible = True
                Else
                    lblWarn.Visible = False
                    btnMasuk_Click(sender, e)
                End If
            Else
                MsgBox("Mohon Data Dilengkapi", vbExclamation, "The Bread Shop")
            End If
        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If txPass.Text IsNot "" And txID.Text IsNot "" Then
            If Len(txPass.Text) < 5 Then
                lblWarn.Visible = True
            Else
                lblWarn.Visible = False
                pass = bikinPass()
                Dim dt As New seleksiDataSet.karyawanDataTable
                dt = KaryawanTableAdapter.GetDataByLogin(txID.Text, pass)
                If dt.Count = 0 Then
                    MsgBox("Username atau Password Salah!", vbOKOnly, "The Bread Shop")
                Else
                    MainMenu.idAdmin = dt.Rows(0).Item(0)
                    MainMenu.admin = dt.Rows(0).Item(1)
                    MainMenu.lvlAdmin = dt.Rows(0).Item(2)
                    Me.Hide()
                    MainMenu.ShowDialog()
                    If MainMenu.logOut = False Then
                        Me.Close()
                    Else
                        formLogin_Load(sender, e)
                    End If
                End If
            End If
        Else
            MsgBox("Mohon Data Dilengkapi", vbOKOnly, "The Bread Shop")
            txID.Focus()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub


End Class