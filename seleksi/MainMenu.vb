Imports System.ComponentModel

Public Class MainMenu
    'login
    Public admin As String
    Public idAdmin As String
    Public lvlAdmin As String
    Public logOut As Boolean
    'drag
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    'barang
    Public editBarang As Boolean
    Public kodeBarang As String
    Public namaBarang As String
    Public kodeKategori As String
    Public hargaBarang As Decimal
    Public diskonBarang As Integer
    Public stokBarang As Integer
    Public fotoBarang As Byte()
    Dim lihatFotoBarang As Boolean
    'kasir
    Dim indexTabelKasir As Integer
    'karyawan
    Public editKaryawan As Boolean
    Public idKaryawan As String
    Public namaKaryawan As String
    Public lvlKaryawan As String
    Public password As String
    Public fotoKaryawan As Byte()
    Dim lihatFotoKaryawan As Boolean
    'laporan
    Dim lihatSemuaLaporan As Boolean
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
    'window
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        logOut = False
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'menu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SeleksiDataSet.Laporan' table. You can move, or remove it, as needed.
        Me.LaporanTableAdapter.Fill(Me.SeleksiDataSet.Laporan)
        lblAdmin.Text = admin
        ulangForm()
        btnDashboard_Click(sender, e)
        Me.KeyPreview = True
        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub refreshData()
        'TODO: This line of code loads data into the 'SeleksiDataSet.Laporan' table. You can move, or remove it, as needed.
        Me.LaporanTableAdapter.Fill(Me.SeleksiDataSet.Laporan)
        'TODO: This line of code loads data into the 'SeleksiDataSet.lihatBarang' table. You can move, or remove it, as needed.
        Me.LihatBarangTableAdapter.Fill(Me.SeleksiDataSet.lihatBarang)
        'TODO: This line of code loads data into the 'SeleksiDataSet.penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.SeleksiDataSet.penjualan)
        'TODO: This line of code loads data into the 'SeleksiDataSet.karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.SeleksiDataSet.karyawan)
        'TODO: This line of code loads data into the 'SeleksiDataSet.header_penjualan' table. You can move, or remove it, as needed.
        Me.Header_penjualanTableAdapter.Fill(Me.SeleksiDataSet.header_penjualan)
        'TODO: This line of code loads data into the 'SeleksiDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.SeleksiDataSet.barang)
        lblDataBarang.Text = BarangTableAdapter.GetData().Count
        lblDataKaryawan.Text = KaryawanTableAdapter.GetData().Count
        lblStokBarang.Text = LihatBarangTableAdapter.stok
        lblPenjualan.Text = Header_penjualanTableAdapter.GetDataByDashboard(Now()).Count
        lblStokRoti.Text = LihatBarangTableAdapter.dashboardStok("r")
        lblStokMinuman.Text = LihatBarangTableAdapter.dashboardStok("m")
    End Sub
    Sub ulangForm()
        refreshData()
        PanelKontenDashboard.Visible = False
        PanelKontenKasir.Visible = False
        PanelKontenBarang.Visible = False
        PanelKontenKaryawan.Visible = False
        PanelKontenLaporan.Visible = False
        btnDashboard.BackColor = Color.FromArgb(52, 73, 94)
        btnKasir.BackColor = Color.FromArgb(52, 73, 94)
        btnBarang.BackColor = Color.FromArgb(52, 73, 94)
        btnKaryawan.BackColor = Color.FromArgb(52, 73, 94)
        btnLaporan.BackColor = Color.FromArgb(52, 73, 94)
        btnLogout.BackColor = Color.FromArgb(52, 73, 94)
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnLaporan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ulangForm()
        PanelKontenDashboard.Visible = True
        btnDashboard.BackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Halaman Awal"
        lblKeteranganMenu.Text = ""
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        ulangForm()
        PanelKontenKasir.Visible = True
        btnKasir.BackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Menu Penjualan"
        lblKeteranganMenu.Text = "Tekan Enter Untuk Melanjutkan | Tekan F1 Untuk Mencari Barang | Tekan F2 Untuk Menghapus Barang | Tekan F3 Untuk Mengulan Belanja | Tekan F4 Untuk Membayar"
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        ulangForm()
        PanelKontenBarang.Visible = True
        btnBarang.BackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Menu Data Barang"
        lblKeteranganMenu.Text = "Tekan F1 Untuk Mencari | Tekan F2 Untuk Menambah Data | Tekan F3 Untuk Mengedit Data | Tekan F4 Untuk Menghapus Data | Tekan F5 Untuk Buka / Tutup Foto"
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        ulangForm()
        PanelKontenKaryawan.Visible = True
        btnKaryawan.BackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Menu Data Karyawan"
        lblKeteranganMenu.Text = "Tekan F1 Untuk Mencari | Tekan F2 Untuk Menambah Data | Tekan F3 Untuk Mengedit Data | Tekan F4 Untuk Menghapus Data | Tekan F5 Untuk Buka / Tutup Foto"
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        ulangForm()
        PanelKontenLaporan.Visible = True
        btnLaporan.BackColor = Color.FromArgb(46, 136, 197)
        btnLaporan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Laporan Penjualan"
        lblKeteranganMenu.Text = "Tekan F1 Untuk Mencari "
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        logOut = True
        Me.Close()
        formLogin.Show()
        btnLogout.BackColor = Color.FromArgb(46, 136, 197)
        btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
    End Sub

    'Barang

    Private Sub tabelDataBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataBarang.CellClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            kodeBarang = tabelDataBarang.Rows(i).Cells(0).Value
            namaBarang = tabelDataBarang.Rows(i).Cells(1).Value
            kodeKategori = tabelDataBarang.Rows(i).Cells(7).Value
            hargaBarang = Decimal.ToInt64(tabelDataBarang.Rows(i).Cells(3).Value)
            diskonBarang = tabelDataBarang.Rows(i).Cells(4).Value
            stokBarang = tabelDataBarang.Rows(i).Cells(5).Value
            If IsDBNull(tabelDataBarang.Rows(i).Cells(6).Value) = False Then
                fotoBarang = tabelDataBarang.Rows(i).Cells(6).Value
                Dim ms As New IO.MemoryStream(fotoBarang)
                fotoBoxBarang.BackgroundImage = Image.FromStream(ms)
            Else
                fotoBarang = Nothing
                fotoBoxBarang.BackgroundImage = Nothing
            End If
        End If
    End Sub

    Private Sub btnTambahBarang_Click(sender As Object, e As EventArgs) Handles btnTambahBarang.Click
        editBarang = False
        formBarang.ShowDialog()
        refreshData()
        kodeBarang = ""
    End Sub

    Private Sub btnEditBarang_Click(sender As Object, e As EventArgs) Handles btnEditBarang.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data", vbOKOnly, "The Bread Shop")
        Else
            editBarang = True
            formBarang.ShowDialog()
            refreshData()
            kodeBarang = ""
        End If
    End Sub

    Private Sub btnHapusBarang_Click(sender As Object, e As EventArgs) Handles btnHapusBarang.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data", vbOKOnly, "The Bread Shop")
        Else
            If MsgBox("Apakah Anda Yakin Menghapus Data " & kodeBarang & "?", vbYesNo, "The Bread Shop") = vbYes Then
                BarangTableAdapter.hapus(kodeBarang)
                refreshData()
                kodeBarang = ""
            End If
        End If
    End Sub

    Private Sub btnLihatFotoBarang_Click(sender As Object, e As EventArgs) Handles btnLihatFotoBarang.Click
        lihatFotoBarang = Not lihatFotoBarang
        If lihatFotoBarang Then
            PanelFooterBarang.Visible = True
            btnLihatFotoBarang.Text = "v"
        Else
            PanelFooterBarang.Visible = False
            btnLihatFotoBarang.Text = "^"
        End If
    End Sub

    Private Sub txCariBarang_TextChanged(sender As Object, e As EventArgs) Handles txCariBarang.TextChanged
        If txCariBarang.Text = "" Then
            refreshData()
        Else
            Dim kataKunci As String = "%" & txCariBarang.Text & "%"
            LihatBarangTableAdapter.FillByCari(SeleksiDataSet.lihatBarang, kataKunci, kataKunci)
        End If
    End Sub

    Private Sub PanelKontenBarang_VisibleChanged(sender As Object, e As EventArgs) Handles PanelKontenBarang.VisibleChanged
        If PanelKontenBarang.Visible Then
            txCariBarang.Focus()
            txCariBarang.Select()
        End If
    End Sub

    'kasir
    Private Sub tabelDataKasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKasir.CellClick
        If e.RowIndex >= 0 Then
            indexTabelKasir = e.RowIndex
        Else
            indexTabelKasir = -1
        End If
    End Sub

    Private Sub txKodeBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txKodeBarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txKodeBarang IsNot "" Then
                Dim dt As New seleksiDataSet.lihatBarangDataTable
                dt = LihatBarangTableAdapter.GetDataByCari(txKodeBarang.Text, "")
                If dt.Count = 0 Then
                    txNamaBarang.Clear()
                    txDiskon.Clear()
                    txHargaKasir.Clear()
                    txStok.Clear()
                Else
                    txNamaBarang.Text = dt.Rows(0).Item(1)
                    txHargaKasir.Text = Decimal.ToInt64(dt.Rows(0).Item(3))
                    txDiskon.Text = dt.Rows(0).Item(4)
                    txStok.Text = dt.Rows(0).Item(5)
                    txQty.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txQty.Text IsNot "" Then
                If Integer.Parse(txQty.Text) > Integer.Parse(txStok.Text) Then
                    MsgBox("Stok Barang Tersedia " & txStok.Text & "!", vbOKOnly, "The Bread Shop")
                Else
                    txDiskon.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txDiskon_KeyDown(sender As Object, e As KeyEventArgs) Handles txDiskon.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txKodeBarang.Text = "" Or txNamaBarang.Text = "" Or txQty.Text = "" Or txDiskon.Text = "" Then
                MsgBox("Mohon Data Dilengkapi!", vbOKOnly, "The Bread Shop")
            Else
                Dim qty As Integer
                Dim subTotal As Integer
                Dim jml As Integer
                Dim stok As Integer
                Dim indexTambah As Integer

                qty = Integer.Parse(txQty.Text)
                jml = qty * txHargaKasir.Text
                If txDiskon.Text = "0" Or txDiskon.Text = "" Then
                    subTotal = jml
                Else
                    subTotal = jml - (jml * Integer.Parse(txDiskon.Text) / 100)
                End If
                stok = Integer.Parse(txStok.Text) - Integer.Parse(txQty.Text)

                indexTambah = tambahQty()
                If indexTambah = -1 Then
                    tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeBarang.Text, txNamaBarang.Text, txHargaKasir.Text, qty, txDiskon.Text, subTotal, stok)
                Else
                    qty = qty + tabelDataKasir.Rows(indexTambah).Cells(4).Value
                    stok = stok - tabelDataKasir.Rows(indexTambah).Cells(7).Value
                    subTotal = subTotal + tabelDataKasir.Rows(indexTambah).Cells(6).Value
                    tabelDataKasir.Rows.RemoveAt(indexTambah)
                    tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeBarang.Text, txNamaBarang.Text, txHargaKasir.Text, qty, txDiskon.Text, subTotal, stok)
                    For i = 0 To tabelDataKasir.RowCount - 1
                        tabelDataKasir.Rows(i).Cells(0).Value = i + 1
                    Next
                End If
                totalan(-1)
                txKodeBarang.Clear()
                txNamaBarang.Clear()
                txQty.Clear()
                txDiskon.Clear()
                txHargaKasir.Clear()
                txStok.Clear()
                txKodeBarang.Focus()
            End If
        End If
    End Sub

    Function tambahQty()
        Dim ada As Boolean
        Dim index As Integer = -1

        If tabelDataKasir.RowCount > 0 Then
            For i = 0 To tabelDataKasir.RowCount - 1
                If ada = False Then
                    If txKodeBarang.Text = tabelDataKasir.Rows(i).Cells(1).Value Then
                        ada = True
                        index = i
                    Else
                        ada = False
                    End If
                End If
            Next
        End If
        Return index
    End Function

    Sub totalan(dikurang As Integer)
        Dim total As Integer = 0
        Dim diskon As Integer
        Dim bayar As Integer

        If dikurang = -1 Then
            For i = 0 To tabelDataKasir.RowCount - 1
                total = total + tabelDataKasir.Rows(i).Cells(6).Value
            Next
        Else
            total = Integer.Parse(txTotal.Text) - dikurang
        End If
        txTotal.Text = total

        If txDiskonBelanja.Text = "" Or txDiskon.Text = "0" Then
            txTotalBelanja.Text = total
        Else
            diskon = Integer.Parse(txDiskonBelanja.Text)
            If diskon > 100 Then
                txTotalBelanja.Text = "0"
            Else
                txTotalBelanja.Text = total - (total * diskon / 100)
            End If
        End If

        If txBayar.Text = "" Or txBayar.Text = "0" Then
            bayar = 0
            txKembalian.Text = "0"
        Else
            bayar = Integer.Parse(txBayar.Text)
            If bayar < Integer.Parse(txTotalBelanja.Text) Then
                txKembalian.Text = "0"
            Else
                txKembalian.Text = bayar - Integer.Parse(txTotalBelanja.Text)
            End If
        End If

    End Sub

    Private Sub txDiskonBelanja_TextChanged(sender As Object, e As EventArgs) Handles txDiskonBelanja.TextChanged
        totalan(-1)
    End Sub

    Private Sub txBayar_TextChanged(sender As Object, e As EventArgs) Handles txBayar.TextChanged
        totalan(-1)
    End Sub

    Private Sub PanelHeaderKasir_VisibleChanged(sender As Object, e As EventArgs) Handles PanelHeaderKasir.VisibleChanged
        If PanelKontenKasir.Visible Then
            ulangKasir()
        End If
    End Sub
    Sub ulangKasir()
        refreshData()
        cariStruk()
        tglKasir.Value = Now()
        txKodeBarang.Clear()
        txNamaBarang.Clear()
        txHargaKasir.Clear()
        txDiskon.Clear()
        txStok.Clear()
        txTotal.Text = "0"
        txTotalBelanja.Text = "0"
        txDiskonBelanja.Text = "0"
        txBayar.Text = "0"
        txKembalian.Text = "0"
        tabelDataKasir.Rows.Clear()
        txKodeBarang.Focus()
    End Sub
    Sub cariStruk()
        Dim jml As Integer = Header_penjualanTableAdapter.GetData().Count
        If jml = 0 Then
            txStruk.Text = "Struk" & 1 & Now()
        Else
            txStruk.Text = "Struk" & jml + 1 & Now()
        End If
    End Sub

    Private Sub btnCariKode_Click(sender As Object, e As EventArgs) Handles btnCariKode.Click
        formCariBarang.ShowDialog()
        If txKodeBarang.Text IsNot "" Then
            txQty.Select()
        Else
            txKodeBarang.Select()
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If tabelDataKasir.RowCount > 0 Then
            If Integer.Parse(txBayar.Text) < Integer.Parse(txTotalBelanja.Text) Then
                MsgBox("Uang pembeli Tidak Cukup!", vbOKOnly, "The Bread Shop")
                txBayar.Focus()
            Else
                Header_penjualanTableAdapter.Insert(txStruk.Text, idAdmin, tglKasir.Value, Integer.Parse(txDiskonBelanja.Text), Integer.Parse(txTotalBelanja.Text))
                For i = 0 To tabelDataKasir.RowCount - 1
                    PenjualanTableAdapter.Insert(txStruk.Text, tabelDataKasir.Rows(i).Cells(1).Value, Integer.Parse(tabelDataKasir.Rows(i).Cells(4).Value), Integer.Parse(tabelDataKasir.Rows(i).Cells(5).Value))
                    BarangTableAdapter.terjual(Integer.Parse(tabelDataKasir.Rows(i).Cells(7).Value), tabelDataKasir.Rows(i).Cells(1).Value)
                Next
                ulangKasir()
            End If
        End If
    End Sub
    'banInt
    Sub banInt(e As KeyPressEventArgs)
        Dim i As Integer = Asc(e.KeyChar)
        If i <> 8 Then
            If i < 48 Or i > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txQty.KeyPress
        banInt(e)
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        banInt(e)
    End Sub

    Private Sub txDiskonBelanja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskonBelanja.KeyPress
        banInt(e)
    End Sub

    Private Sub txBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBayar.KeyPress
        banInt(e)
    End Sub

    'karyawan
    Private Sub PanelKontenKaryawan_VisibleChanged(sender As Object, e As EventArgs) Handles PanelKontenKaryawan.VisibleChanged
        If PanelKontenKaryawan.Visible Then
            refreshData()
            txCariKaryawan.Focus()
            If lvlAdmin = "Karyawan" Then
                btnTambahKaryawan.Enabled = False
                btnEditKaryawan.Enabled = False
                btnHapusKaryawan.Enabled = False
            Else
                btnTambahKaryawan.Enabled = True
                btnEditKaryawan.Enabled = True
                btnHapusKaryawan.Enabled = True
            End If
        End If
    End Sub

    Private Sub tabelDataKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKaryawan.CellClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            idKaryawan = tabelDataKaryawan.Rows(i).Cells(0).Value
            namaKaryawan = tabelDataKaryawan.Rows(i).Cells(1).Value
            lvlKaryawan = tabelDataKaryawan.Rows(i).Cells(2).Value
            password = tabelDataKaryawan.Rows(i).Cells(4).Value
            If IsDBNull(tabelDataKaryawan.Rows(i).Cells(3).Value) Then
                fotoKaryawan = Nothing
                fotoBoxKaryawan.BackgroundImage = Nothing
            Else
                fotoKaryawan = tabelDataKaryawan.Rows(i).Cells(3).Value
                Dim ms As New IO.MemoryStream(fotoKaryawan)
                fotoBoxKaryawan.BackgroundImage = Image.FromStream(ms)
            End If
        End If
    End Sub

    Private Sub txCariKaryawan_TextChanged(sender As Object, e As EventArgs) Handles txCariKaryawan.TextChanged
        If txCariKaryawan.Text = "" Then
            refreshData()
        Else
            Dim kataKunci As String = "%" & txCariKaryawan.Text & "%"
            KaryawanTableAdapter.FillByCari(SeleksiDataSet.karyawan, kataKunci, kataKunci)
        End If
    End Sub

    Private Sub btnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles btnTambahKaryawan.Click
        editKaryawan = False
        formKaryawan.ShowDialog()
        refreshData()
    End Sub

    Private Sub btnEditKaryawan_Click(sender As Object, e As EventArgs) Handles btnEditKaryawan.Click
        If idKaryawan = "" Then
            MsgBox("Mohon Pilih Data", vbOKOnly, "The Bread Shop")
        Else
            editKaryawan = True
            formKaryawan.ShowDialog()
            refreshData()
        End If
    End Sub

    Private Sub btnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles btnHapusKaryawan.Click
        If idKaryawan = "" Then
            MsgBox("Mohon Pilih Data", vbOKOnly, "The Bread Shop")
        Else
            If MsgBox("Apakah Anda Yakin Menghapus Data " & idKaryawan & "?", vbYesNo, "The Bread Shop") = vbYes Then
                KaryawanTableAdapter.hapus(idKaryawan)
                refreshData()
                idKaryawan = ""
            End If
        End If
    End Sub

    Private Sub btnLihatFotoKaryawan_Click(sender As Object, e As EventArgs) Handles btnLihatFotoKaryawan.Click
        lihatFotoKaryawan = Not lihatFotoKaryawan
        If lihatFotoKaryawan Then
            PanelFooterKaryawan.Visible = True
            btnLihatFotoKaryawan.Text = "v"
        Else
            PanelFooterKaryawan.Visible = False
            btnLihatFotoKaryawan.Text = "^"
        End If
    End Sub

    'laporan
    Private Sub txCariLaporan_TextChanged(sender As Object, e As EventArgs) Handles txCariLaporan.TextChanged
        If txCariLaporan.Text = "" Then
            refreshData()
        Else
            Dim kataKunci As String = "%" & txCariLaporan.Text & "%"
            LaporanTableAdapter.FillByCari(SeleksiDataSet.Laporan, kataKunci, kataKunci, Nothing)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            lihatSemuaLaporan = True
            CheckBox2.Checked = False
            refreshData()
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            lihatSemuaLaporan = False
            CheckBox1.Checked = False
            LaporanTableAdapter.FillByCari(SeleksiDataSet.Laporan, "", "", tglLaporan.Value)
        End If

    End Sub


    Private Sub PanelKontenLaporan_VisibleChanged(sender As Object, e As EventArgs) Handles PanelKontenLaporan.VisibleChanged
        CheckBox1.Checked = True
        lihatSemuaLaporan = True
    End Sub

    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim hk As Keys = e.KeyCode
        If PanelKontenKasir.Visible Then
            If hk = Keys.F1 Then
                btnCariKode_Click(sender, e)
            ElseIf hk = Keys.F2 Then
                If indexTabelKasir = -1 Then
                    MsgBox("Mohon Pilih Data", vbOKOnly, "The Bread Shop")
                Else
                    If MsgBox("Apakah Anda Yakin Menghapus Data " & tabelDataKasir.Rows(indexTabelKasir).Cells(2).Value & "?", vbYesNo, "The Bread Shop") = vbYes Then
                        Dim subtotal As Integer = Integer.Parse(tabelDataKasir.Rows(indexTabelKasir).Cells(6).Value)
                        totalan(subtotal)
                        tabelDataKasir.Rows.RemoveAt(indexTabelKasir)
                        indexTabelKasir = -1
                        For i = 0 To tabelDataKasir.RowCount - 1
                            tabelDataKasir.Rows(i).Cells(0).Value = i + 1
                        Next
                        indexTabelKasir = -1
                    End If
                End If
                    ElseIf hk = Keys.F3 Then
                ulangKasir()
            ElseIf hk = Keys.F4 Then
                btnBayar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub tglLaporan_TextChanged(sender As Object, e As EventArgs) Handles tglLaporan.TextChanged
        If lihatSemuaLaporan = False Then
            LaporanTableAdapter.FillByCari(SeleksiDataSet.Laporan, "", "", tglLaporan.Value)
        End If
    End Sub
End Class