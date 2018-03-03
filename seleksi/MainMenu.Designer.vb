<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.PanelKontenDashboard = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblDataKaryawan = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblStokBarang = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblPenjualan = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblStokRoti = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblStokMinuman = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblDataBarang = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.PanelKontenKasir = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PanelFooterKasir = New System.Windows.Forms.Panel()
        Me.txKembalian = New System.Windows.Forms.TextBox()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txBayar = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txDiskonBelanja = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabelDataKasir = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PanelHeaderKasir = New System.Windows.Forms.Panel()
        Me.txStok = New System.Windows.Forms.TextBox()
        Me.btnCariKode = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txTotalBelanja = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.txQty = New System.Windows.Forms.TextBox()
        Me.txHargaKasir = New System.Windows.Forms.TextBox()
        Me.txNamaBarang = New System.Windows.Forms.TextBox()
        Me.txKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tglKasir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txStruk = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelKontenLaporan = New System.Windows.Forms.Panel()
        Me.tabelDataLaporan = New System.Windows.Forms.DataGridView()
        Me.NostrukDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NopenjualanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodebarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaporanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeleksiDataSet = New seleksi.seleksiDataSet()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.PanelHeaderLaporan = New System.Windows.Forms.Panel()
        Me.tglLaporan = New System.Windows.Forms.DateTimePicker()
        Me.txCariLaporan = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.PanelKontenKaryawan = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnLihatFotoKaryawan = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PanelFooterKaryawan = New System.Windows.Forms.Panel()
        Me.fotoBoxKaryawan = New System.Windows.Forms.PictureBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tabelDataKaryawan = New System.Windows.Forms.DataGridView()
        Me.IdkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PanelHeaderKaryawan = New System.Windows.Forms.Panel()
        Me.btnEditKaryawan = New System.Windows.Forms.Button()
        Me.btnTambahKaryawan = New System.Windows.Forms.Button()
        Me.btnHapusKaryawan = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txCariKaryawan = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PanelKontenBarang = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLihatFotoBarang = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PanelFooterBarang = New System.Windows.Forms.Panel()
        Me.fotoBoxBarang = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tabelDataBarang = New System.Windows.Forms.DataGridView()
        Me.KodebarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.KodekategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LihatBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PanelHeaderBarang = New System.Windows.Forms.Panel()
        Me.btnEditBarang = New System.Windows.Forms.Button()
        Me.btnTambahBarang = New System.Windows.Forms.Button()
        Me.btnHapusBarang = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txCariBarang = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.pemisahAta = New System.Windows.Forms.Label()
        Me.pemisahBawah = New System.Windows.Forms.Label()
        Me.pemisahKanan = New System.Windows.Forms.Label()
        Me.PemisahKiri = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelNamaMenu = New System.Windows.Forms.Panel()
        Me.lblKeteranganMenu = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PanelSideBar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKaryawan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnKasir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCornet = New System.Windows.Forms.Panel()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.iconAdmin = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New seleksi.seleksiDataSetTableAdapters.barangTableAdapter()
        Me.HeaderpenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Header_penjualanTableAdapter = New seleksi.seleksiDataSetTableAdapters.header_penjualanTableAdapter()
        Me.KaryawanTableAdapter = New seleksi.seleksiDataSetTableAdapters.karyawanTableAdapter()
        Me.PenjualanTableAdapter = New seleksi.seleksiDataSetTableAdapters.penjualanTableAdapter()
        Me.LihatBarangTableAdapter = New seleksi.seleksiDataSetTableAdapters.lihatBarangTableAdapter()
        Me.LaporanTableAdapter = New seleksi.seleksiDataSetTableAdapters.LaporanTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PanelForm.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        Me.PanelKontenDashboard.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelKontenKasir.SuspendLayout()
        Me.PanelFooterKasir.SuspendLayout()
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderKasir.SuspendLayout()
        Me.PanelKontenLaporan.SuspendLayout()
        CType(Me.tabelDataLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaporanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeleksiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderLaporan.SuspendLayout()
        Me.PanelKontenKaryawan.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.PanelFooterKaryawan.SuspendLayout()
        CType(Me.fotoBoxKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelDataKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderKaryawan.SuspendLayout()
        Me.PanelKontenBarang.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelFooterBarang.SuspendLayout()
        CType(Me.fotoBoxBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderBarang.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelNamaMenu.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelSideBar.SuspendLayout()
        Me.PanelCornet.SuspendLayout()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderpenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.PanelKonten)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Controls.Add(Me.PanelSideBar)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(870, 670)
        Me.PanelForm.TabIndex = 0
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.PanelKontenLaporan)
        Me.PanelKonten.Controls.Add(Me.PanelKontenKasir)
        Me.PanelKonten.Controls.Add(Me.PanelKontenDashboard)
        Me.PanelKonten.Controls.Add(Me.PanelKontenKaryawan)
        Me.PanelKonten.Controls.Add(Me.PanelKontenBarang)
        Me.PanelKonten.Controls.Add(Me.pemisahAta)
        Me.PanelKonten.Controls.Add(Me.pemisahBawah)
        Me.PanelKonten.Controls.Add(Me.pemisahKanan)
        Me.PanelKonten.Controls.Add(Me.PemisahKiri)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(200, 100)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(668, 568)
        Me.PanelKonten.TabIndex = 0
        '
        'PanelKontenDashboard
        '
        Me.PanelKontenDashboard.Controls.Add(Me.Panel14)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel13)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel12)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel11)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel10)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel9)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel8)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel4)
        Me.PanelKontenDashboard.Controls.Add(Me.Label39)
        Me.PanelKontenDashboard.Controls.Add(Me.Label40)
        Me.PanelKontenDashboard.Controls.Add(Me.Label41)
        Me.PanelKontenDashboard.Controls.Add(Me.Label42)
        Me.PanelKontenDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenDashboard.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenDashboard.Name = "PanelKontenDashboard"
        Me.PanelKontenDashboard.Size = New System.Drawing.Size(648, 548)
        Me.PanelKontenDashboard.TabIndex = 10
        '
        'Panel14
        '
        Me.Panel14.Location = New System.Drawing.Point(19, 238)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(603, 250)
        Me.Panel14.TabIndex = 15
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.lblDataKaryawan)
        Me.Panel13.Controls.Add(Me.Label64)
        Me.Panel13.Controls.Add(Me.Label65)
        Me.Panel13.Location = New System.Drawing.Point(268, 20)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(200, 100)
        Me.Panel13.TabIndex = 13
        '
        'lblDataKaryawan
        '
        Me.lblDataKaryawan.BackColor = System.Drawing.Color.White
        Me.lblDataKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDataKaryawan.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataKaryawan.Location = New System.Drawing.Point(30, 0)
        Me.lblDataKaryawan.Name = "lblDataKaryawan"
        Me.lblDataKaryawan.Size = New System.Drawing.Size(170, 54)
        Me.lblDataKaryawan.TabIndex = 1
        Me.lblDataKaryawan.Text = "100"
        Me.lblDataKaryawan.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.White
        Me.Label64.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label64.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(30, 54)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(170, 46)
        Me.Label64.TabIndex = 2
        Me.Label64.Text = "Data Karyawan"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.White
        Me.Label65.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label65.Location = New System.Drawing.Point(0, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(30, 100)
        Me.Label65.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.lblStokBarang)
        Me.Panel12.Controls.Add(Me.Label61)
        Me.Panel12.Controls.Add(Me.Label62)
        Me.Panel12.Location = New System.Drawing.Point(474, 20)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(148, 100)
        Me.Panel12.TabIndex = 12
        '
        'lblStokBarang
        '
        Me.lblStokBarang.BackColor = System.Drawing.Color.White
        Me.lblStokBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStokBarang.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokBarang.Location = New System.Drawing.Point(30, 0)
        Me.lblStokBarang.Name = "lblStokBarang"
        Me.lblStokBarang.Size = New System.Drawing.Size(118, 54)
        Me.lblStokBarang.TabIndex = 1
        Me.lblStokBarang.Text = "100"
        Me.lblStokBarang.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.White
        Me.Label61.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(30, 54)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(118, 46)
        Me.Label61.TabIndex = 2
        Me.Label61.Text = "Stok Barang"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.White
        Me.Label62.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label62.Location = New System.Drawing.Point(0, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(30, 100)
        Me.Label62.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.lblPenjualan)
        Me.Panel11.Controls.Add(Me.Label58)
        Me.Panel11.Controls.Add(Me.Label59)
        Me.Panel11.Location = New System.Drawing.Point(19, 126)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(167, 100)
        Me.Panel11.TabIndex = 11
        '
        'lblPenjualan
        '
        Me.lblPenjualan.BackColor = System.Drawing.Color.White
        Me.lblPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPenjualan.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenjualan.Location = New System.Drawing.Point(30, 0)
        Me.lblPenjualan.Name = "lblPenjualan"
        Me.lblPenjualan.Size = New System.Drawing.Size(137, 54)
        Me.lblPenjualan.TabIndex = 1
        Me.lblPenjualan.Text = "100"
        Me.lblPenjualan.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.White
        Me.Label58.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label58.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(30, 54)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(137, 46)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Penjualan Hari Ini"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.White
        Me.Label59.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label59.Location = New System.Drawing.Point(0, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(30, 100)
        Me.Label59.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.lblStokRoti)
        Me.Panel10.Controls.Add(Me.Label55)
        Me.Panel10.Controls.Add(Me.Label56)
        Me.Panel10.Location = New System.Drawing.Point(192, 126)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(200, 100)
        Me.Panel10.TabIndex = 10
        '
        'lblStokRoti
        '
        Me.lblStokRoti.BackColor = System.Drawing.Color.White
        Me.lblStokRoti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStokRoti.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokRoti.Location = New System.Drawing.Point(30, 0)
        Me.lblStokRoti.Name = "lblStokRoti"
        Me.lblStokRoti.Size = New System.Drawing.Size(170, 54)
        Me.lblStokRoti.TabIndex = 1
        Me.lblStokRoti.Text = "100"
        Me.lblStokRoti.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.White
        Me.Label55.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(30, 54)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(170, 46)
        Me.Label55.TabIndex = 2
        Me.Label55.Text = "Stok Roti"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.White
        Me.Label56.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label56.Location = New System.Drawing.Point(0, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(30, 100)
        Me.Label56.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.lblStokMinuman)
        Me.Panel9.Controls.Add(Me.Label52)
        Me.Panel9.Controls.Add(Me.Label53)
        Me.Panel9.Location = New System.Drawing.Point(398, 126)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(224, 100)
        Me.Panel9.TabIndex = 9
        '
        'lblStokMinuman
        '
        Me.lblStokMinuman.BackColor = System.Drawing.Color.White
        Me.lblStokMinuman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStokMinuman.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMinuman.Location = New System.Drawing.Point(30, 0)
        Me.lblStokMinuman.Name = "lblStokMinuman"
        Me.lblStokMinuman.Size = New System.Drawing.Size(194, 54)
        Me.lblStokMinuman.TabIndex = 1
        Me.lblStokMinuman.Text = "100"
        Me.lblStokMinuman.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.White
        Me.Label52.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(30, 54)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(194, 46)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "Stok Minuman"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.White
        Me.Label53.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label53.Location = New System.Drawing.Point(0, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(30, 100)
        Me.Label53.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lblDataBarang)
        Me.Panel8.Controls.Add(Me.Label50)
        Me.Panel8.Controls.Add(Me.Label48)
        Me.Panel8.Location = New System.Drawing.Point(19, 20)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(243, 100)
        Me.Panel8.TabIndex = 8
        '
        'lblDataBarang
        '
        Me.lblDataBarang.BackColor = System.Drawing.Color.White
        Me.lblDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDataBarang.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataBarang.Location = New System.Drawing.Point(30, 0)
        Me.lblDataBarang.Name = "lblDataBarang"
        Me.lblDataBarang.Size = New System.Drawing.Size(213, 54)
        Me.lblDataBarang.TabIndex = 1
        Me.lblDataBarang.Text = "100"
        Me.lblDataBarang.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(30, 54)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(213, 46)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Data Barang"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label48.Location = New System.Drawing.Point(0, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(30, 100)
        Me.Label48.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label47)
        Me.Panel4.Controls.Add(Me.Label46)
        Me.Panel4.Location = New System.Drawing.Point(26, 498)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(424, 49)
        Me.Panel4.TabIndex = 7
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label47.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(0, 23)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(228, 21)
        Me.Label47.TabIndex = 6
        Me.Label47.Text = "√Lezat  √Sehat  √Terjangkau"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(0, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(283, 23)
        Me.Label46.TabIndex = 6
        Me.Label46.Text = "Toko Roti Terbaik Di Indonesia"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label39.Location = New System.Drawing.Point(20, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(608, 10)
        Me.Label39.TabIndex = 2
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label40.Location = New System.Drawing.Point(20, 538)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(608, 10)
        Me.Label40.TabIndex = 3
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label41.Location = New System.Drawing.Point(628, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(20, 548)
        Me.Label41.TabIndex = 4
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label42.Location = New System.Drawing.Point(0, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(20, 548)
        Me.Label42.TabIndex = 5
        '
        'PanelKontenKasir
        '
        Me.PanelKontenKasir.Controls.Add(Me.Label23)
        Me.PanelKontenKasir.Controls.Add(Me.PanelFooterKasir)
        Me.PanelKontenKasir.Controls.Add(Me.tabelDataKasir)
        Me.PanelKontenKasir.Controls.Add(Me.Label17)
        Me.PanelKontenKasir.Controls.Add(Me.PanelHeaderKasir)
        Me.PanelKontenKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenKasir.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenKasir.Name = "PanelKontenKasir"
        Me.PanelKontenKasir.Size = New System.Drawing.Size(648, 548)
        Me.PanelKontenKasir.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label23.Location = New System.Drawing.Point(0, 478)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(648, 10)
        Me.Label23.TabIndex = 5
        '
        'PanelFooterKasir
        '
        Me.PanelFooterKasir.Controls.Add(Me.txKembalian)
        Me.PanelFooterKasir.Controls.Add(Me.btnBayar)
        Me.PanelFooterKasir.Controls.Add(Me.Label22)
        Me.PanelFooterKasir.Controls.Add(Me.txBayar)
        Me.PanelFooterKasir.Controls.Add(Me.Label21)
        Me.PanelFooterKasir.Controls.Add(Me.txDiskonBelanja)
        Me.PanelFooterKasir.Controls.Add(Me.Label20)
        Me.PanelFooterKasir.Controls.Add(Me.txTotal)
        Me.PanelFooterKasir.Controls.Add(Me.Label19)
        Me.PanelFooterKasir.Controls.Add(Me.Label18)
        Me.PanelFooterKasir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooterKasir.Location = New System.Drawing.Point(0, 488)
        Me.PanelFooterKasir.Name = "PanelFooterKasir"
        Me.PanelFooterKasir.Size = New System.Drawing.Size(648, 60)
        Me.PanelFooterKasir.TabIndex = 4
        '
        'txKembalian
        '
        Me.txKembalian.Enabled = False
        Me.txKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txKembalian.Location = New System.Drawing.Point(338, 37)
        Me.txKembalian.Name = "txKembalian"
        Me.txKembalian.Size = New System.Drawing.Size(200, 20)
        Me.txKembalian.TabIndex = 4
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBayar.FlatAppearance.BorderSize = 0
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Location = New System.Drawing.Point(558, 13)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(80, 40)
        Me.btnBayar.TabIndex = 9
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(272, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Kembalian"
        '
        'txBayar
        '
        Me.txBayar.Location = New System.Drawing.Point(338, 13)
        Me.txBayar.Name = "txBayar"
        Me.txBayar.Size = New System.Drawing.Size(200, 20)
        Me.txBayar.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(272, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Dibayar"
        '
        'txDiskonBelanja
        '
        Me.txDiskonBelanja.Location = New System.Drawing.Point(58, 37)
        Me.txDiskonBelanja.Name = "txDiskonBelanja"
        Me.txDiskonBelanja.Size = New System.Drawing.Size(200, 20)
        Me.txDiskonBelanja.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Diskon"
        '
        'txTotal
        '
        Me.txTotal.Enabled = False
        Me.txTotal.Location = New System.Drawing.Point(58, 13)
        Me.txTotal.Name = "txTotal"
        Me.txTotal.Size = New System.Drawing.Size(200, 20)
        Me.txTotal.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Total"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(648, 60)
        Me.Label18.TabIndex = 9
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabelDataKasir
        '
        Me.tabelDataKasir.AllowUserToAddRows = False
        Me.tabelDataKasir.AllowUserToDeleteRows = False
        Me.tabelDataKasir.AllowUserToOrderColumns = True
        Me.tabelDataKasir.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataKasir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataKasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode_barang, Me.nama_barang, Me.harga, Me.qty, Me.diskon, Me.sub_total, Me.stok})
        Me.tabelDataKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataKasir.Location = New System.Drawing.Point(0, 183)
        Me.tabelDataKasir.MultiSelect = False
        Me.tabelDataKasir.Name = "tabelDataKasir"
        Me.tabelDataKasir.ReadOnly = True
        Me.tabelDataKasir.RowHeadersVisible = False
        Me.tabelDataKasir.Size = New System.Drawing.Size(648, 365)
        Me.tabelDataKasir.TabIndex = 3
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 40
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.ReadOnly = True
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.ReadOnly = True
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'diskon
        '
        Me.diskon.HeaderText = "Diskon (%)"
        Me.diskon.Name = "diskon"
        Me.diskon.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'stok
        '
        Me.stok.HeaderText = "stok"
        Me.stok.Name = "stok"
        Me.stok.ReadOnly = True
        Me.stok.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Location = New System.Drawing.Point(0, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(648, 10)
        Me.Label17.TabIndex = 2
        '
        'PanelHeaderKasir
        '
        Me.PanelHeaderKasir.Controls.Add(Me.txStok)
        Me.PanelHeaderKasir.Controls.Add(Me.btnCariKode)
        Me.PanelHeaderKasir.Controls.Add(Me.Label16)
        Me.PanelHeaderKasir.Controls.Add(Me.txTotalBelanja)
        Me.PanelHeaderKasir.Controls.Add(Me.Label15)
        Me.PanelHeaderKasir.Controls.Add(Me.Label24)
        Me.PanelHeaderKasir.Controls.Add(Me.Label14)
        Me.PanelHeaderKasir.Controls.Add(Me.Label13)
        Me.PanelHeaderKasir.Controls.Add(Me.txDiskon)
        Me.PanelHeaderKasir.Controls.Add(Me.txQty)
        Me.PanelHeaderKasir.Controls.Add(Me.txHargaKasir)
        Me.PanelHeaderKasir.Controls.Add(Me.txNamaBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.txKodeBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.Label12)
        Me.PanelHeaderKasir.Controls.Add(Me.Label11)
        Me.PanelHeaderKasir.Controls.Add(Me.tglKasir)
        Me.PanelHeaderKasir.Controls.Add(Me.Label10)
        Me.PanelHeaderKasir.Controls.Add(Me.Label9)
        Me.PanelHeaderKasir.Controls.Add(Me.txStruk)
        Me.PanelHeaderKasir.Controls.Add(Me.Label8)
        Me.PanelHeaderKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderKasir.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderKasir.Name = "PanelHeaderKasir"
        Me.PanelHeaderKasir.Size = New System.Drawing.Size(648, 173)
        Me.PanelHeaderKasir.TabIndex = 1
        '
        'txStok
        '
        Me.txStok.Location = New System.Drawing.Point(290, 109)
        Me.txStok.Name = "txStok"
        Me.txStok.Size = New System.Drawing.Size(34, 20)
        Me.txStok.TabIndex = 4
        Me.txStok.Visible = False
        '
        'btnCariKode
        '
        Me.btnCariKode.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCariKode.FlatAppearance.BorderSize = 0
        Me.btnCariKode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariKode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariKode.ForeColor = System.Drawing.Color.White
        Me.btnCariKode.Location = New System.Drawing.Point(294, 51)
        Me.btnCariKode.Name = "btnCariKode"
        Me.btnCariKode.Size = New System.Drawing.Size(30, 20)
        Me.btnCariKode.TabIndex = 9
        Me.btnCariKode.Text = "..."
        Me.btnCariKode.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 141)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Diskon (%)"
        '
        'txTotalBelanja
        '
        Me.txTotalBelanja.Enabled = False
        Me.txTotalBelanja.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotalBelanja.Location = New System.Drawing.Point(359, 80)
        Me.txTotalBelanja.Name = "txTotalBelanja"
        Me.txTotalBelanja.Size = New System.Drawing.Size(279, 80)
        Me.txTotalBelanja.TabIndex = 4
        Me.txTotalBelanja.Text = "50000"
        Me.txTotalBelanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "QTY"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(443, 51)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 21)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Total Belanja"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Nama Barang"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Kode Barang"
        '
        'txDiskon
        '
        Me.txDiskon.Location = New System.Drawing.Point(88, 138)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(236, 20)
        Me.txDiskon.TabIndex = 4
        '
        'txQty
        '
        Me.txQty.Location = New System.Drawing.Point(88, 109)
        Me.txQty.Name = "txQty"
        Me.txQty.Size = New System.Drawing.Size(236, 20)
        Me.txQty.TabIndex = 4
        '
        'txHargaKasir
        '
        Me.txHargaKasir.Location = New System.Drawing.Point(290, 80)
        Me.txHargaKasir.Name = "txHargaKasir"
        Me.txHargaKasir.Size = New System.Drawing.Size(34, 20)
        Me.txHargaKasir.TabIndex = 4
        Me.txHargaKasir.Visible = False
        '
        'txNamaBarang
        '
        Me.txNamaBarang.Enabled = False
        Me.txNamaBarang.Location = New System.Drawing.Point(88, 80)
        Me.txNamaBarang.Name = "txNamaBarang"
        Me.txNamaBarang.Size = New System.Drawing.Size(236, 20)
        Me.txNamaBarang.TabIndex = 4
        '
        'txKodeBarang
        '
        Me.txKodeBarang.Location = New System.Drawing.Point(88, 51)
        Me.txKodeBarang.Name = "txKodeBarang"
        Me.txKodeBarang.Size = New System.Drawing.Size(200, 20)
        Me.txKodeBarang.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(648, 130)
        Me.Label12.TabIndex = 8
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Location = New System.Drawing.Point(0, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(648, 1)
        Me.Label11.TabIndex = 7
        '
        'tglKasir
        '
        Me.tglKasir.Location = New System.Drawing.Point(406, 10)
        Me.tglKasir.Name = "tglKasir"
        Me.tglKasir.Size = New System.Drawing.Size(236, 20)
        Me.tglKasir.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(356, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Tanggal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "No Struk"
        '
        'txStruk
        '
        Me.txStruk.Enabled = False
        Me.txStruk.Location = New System.Drawing.Point(88, 10)
        Me.txStruk.Name = "txStruk"
        Me.txStruk.Size = New System.Drawing.Size(236, 20)
        Me.txStruk.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(648, 40)
        Me.Label8.TabIndex = 1
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelKontenLaporan
        '
        Me.PanelKontenLaporan.Controls.Add(Me.tabelDataLaporan)
        Me.PanelKontenLaporan.Controls.Add(Me.ReportViewer1)
        Me.PanelKontenLaporan.Controls.Add(Me.Label43)
        Me.PanelKontenLaporan.Controls.Add(Me.PanelHeaderLaporan)
        Me.PanelKontenLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenLaporan.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenLaporan.Name = "PanelKontenLaporan"
        Me.PanelKontenLaporan.Size = New System.Drawing.Size(648, 548)
        Me.PanelKontenLaporan.TabIndex = 13
        '
        'tabelDataLaporan
        '
        Me.tabelDataLaporan.AllowUserToAddRows = False
        Me.tabelDataLaporan.AllowUserToDeleteRows = False
        Me.tabelDataLaporan.AllowUserToOrderColumns = True
        Me.tabelDataLaporan.AutoGenerateColumns = False
        Me.tabelDataLaporan.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataLaporan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataLaporan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NostrukDataGridViewTextBoxColumn, Me.NopenjualanDataGridViewTextBoxColumn, Me.KodebarangDataGridViewTextBoxColumn1, Me.QtyDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn1, Me.TanggalDataGridViewTextBoxColumn})
        Me.tabelDataLaporan.DataSource = Me.LaporanBindingSource
        Me.tabelDataLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataLaporan.Location = New System.Drawing.Point(0, 50)
        Me.tabelDataLaporan.MultiSelect = False
        Me.tabelDataLaporan.Name = "tabelDataLaporan"
        Me.tabelDataLaporan.ReadOnly = True
        Me.tabelDataLaporan.RowHeadersVisible = False
        Me.tabelDataLaporan.Size = New System.Drawing.Size(648, 349)
        Me.tabelDataLaporan.TabIndex = 4
        '
        'NostrukDataGridViewTextBoxColumn
        '
        Me.NostrukDataGridViewTextBoxColumn.DataPropertyName = "no_struk"
        Me.NostrukDataGridViewTextBoxColumn.HeaderText = "No Struk"
        Me.NostrukDataGridViewTextBoxColumn.Name = "NostrukDataGridViewTextBoxColumn"
        Me.NostrukDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NopenjualanDataGridViewTextBoxColumn
        '
        Me.NopenjualanDataGridViewTextBoxColumn.DataPropertyName = "no_penjualan"
        Me.NopenjualanDataGridViewTextBoxColumn.HeaderText = "No Penjualan"
        Me.NopenjualanDataGridViewTextBoxColumn.Name = "NopenjualanDataGridViewTextBoxColumn"
        Me.NopenjualanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodebarangDataGridViewTextBoxColumn1
        '
        Me.KodebarangDataGridViewTextBoxColumn1.DataPropertyName = "kode_barang"
        Me.KodebarangDataGridViewTextBoxColumn1.HeaderText = "Kode Barang"
        Me.KodebarangDataGridViewTextBoxColumn1.Name = "KodebarangDataGridViewTextBoxColumn1"
        Me.KodebarangDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "QTY"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiskonDataGridViewTextBoxColumn1
        '
        Me.DiskonDataGridViewTextBoxColumn1.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn1.HeaderText = "Diskon (%)"
        Me.DiskonDataGridViewTextBoxColumn1.Name = "DiskonDataGridViewTextBoxColumn1"
        Me.DiskonDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        Me.TanggalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LaporanBindingSource
        '
        Me.LaporanBindingSource.DataMember = "Laporan"
        Me.LaporanBindingSource.DataSource = Me.SeleksiDataSet
        '
        'SeleksiDataSet
        '
        Me.SeleksiDataSet.DataSetName = "seleksiDataSet"
        Me.SeleksiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label43.Location = New System.Drawing.Point(0, 40)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(648, 10)
        Me.Label43.TabIndex = 2
        '
        'PanelHeaderLaporan
        '
        Me.PanelHeaderLaporan.Controls.Add(Me.tglLaporan)
        Me.PanelHeaderLaporan.Controls.Add(Me.txCariLaporan)
        Me.PanelHeaderLaporan.Controls.Add(Me.CheckBox2)
        Me.PanelHeaderLaporan.Controls.Add(Me.CheckBox1)
        Me.PanelHeaderLaporan.Controls.Add(Me.Label44)
        Me.PanelHeaderLaporan.Controls.Add(Me.Label45)
        Me.PanelHeaderLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderLaporan.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderLaporan.Name = "PanelHeaderLaporan"
        Me.PanelHeaderLaporan.Size = New System.Drawing.Size(648, 40)
        Me.PanelHeaderLaporan.TabIndex = 0
        '
        'tglLaporan
        '
        Me.tglLaporan.Location = New System.Drawing.Point(462, 10)
        Me.tglLaporan.Name = "tglLaporan"
        Me.tglLaporan.Size = New System.Drawing.Size(180, 20)
        Me.tglLaporan.TabIndex = 11
        '
        'txCariLaporan
        '
        Me.txCariLaporan.Location = New System.Drawing.Point(39, 10)
        Me.txCariLaporan.Name = "txCariLaporan"
        Me.txCariLaporan.Size = New System.Drawing.Size(180, 20)
        Me.txCariLaporan.TabIndex = 10
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.White
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(341, 12)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Tampil Tanggal"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(237, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Tampil Semua"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(6, 14)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(27, 13)
        Me.Label44.TabIndex = 7
        Me.Label44.Text = "Cari"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(0, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(648, 40)
        Me.Label45.TabIndex = 8
        '
        'PanelKontenKaryawan
        '
        Me.PanelKontenKaryawan.Controls.Add(Me.Panel5)
        Me.PanelKontenKaryawan.Controls.Add(Me.PanelFooterKaryawan)
        Me.PanelKontenKaryawan.Controls.Add(Me.tabelDataKaryawan)
        Me.PanelKontenKaryawan.Controls.Add(Me.Label36)
        Me.PanelKontenKaryawan.Controls.Add(Me.PanelHeaderKaryawan)
        Me.PanelKontenKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenKaryawan.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenKaryawan.Name = "PanelKontenKaryawan"
        Me.PanelKontenKaryawan.Size = New System.Drawing.Size(648, 548)
        Me.PanelKontenKaryawan.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnLihatFotoKaryawan)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 328)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(648, 20)
        Me.Panel5.TabIndex = 5
        '
        'btnLihatFotoKaryawan
        '
        Me.btnLihatFotoKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnLihatFotoKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLihatFotoKaryawan.FlatAppearance.BorderSize = 0
        Me.btnLihatFotoKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLihatFotoKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihatFotoKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnLihatFotoKaryawan.Location = New System.Drawing.Point(310, 0)
        Me.btnLihatFotoKaryawan.Name = "btnLihatFotoKaryawan"
        Me.btnLihatFotoKaryawan.Size = New System.Drawing.Size(28, 20)
        Me.btnLihatFotoKaryawan.TabIndex = 10
        Me.btnLihatFotoKaryawan.Text = "^"
        Me.btnLihatFotoKaryawan.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label32)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(338, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(310, 20)
        Me.Panel6.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label32.Location = New System.Drawing.Point(0, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(310, 10)
        Me.Label32.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label33)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(310, 20)
        Me.Panel7.TabIndex = 6
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label33.Location = New System.Drawing.Point(0, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(310, 10)
        Me.Label33.TabIndex = 4
        '
        'PanelFooterKaryawan
        '
        Me.PanelFooterKaryawan.Controls.Add(Me.fotoBoxKaryawan)
        Me.PanelFooterKaryawan.Controls.Add(Me.Label34)
        Me.PanelFooterKaryawan.Controls.Add(Me.Label35)
        Me.PanelFooterKaryawan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooterKaryawan.Location = New System.Drawing.Point(0, 348)
        Me.PanelFooterKaryawan.Name = "PanelFooterKaryawan"
        Me.PanelFooterKaryawan.Size = New System.Drawing.Size(648, 200)
        Me.PanelFooterKaryawan.TabIndex = 5
        Me.PanelFooterKaryawan.Visible = False
        '
        'fotoBoxKaryawan
        '
        Me.fotoBoxKaryawan.BackColor = System.Drawing.Color.White
        Me.fotoBoxKaryawan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoBoxKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fotoBoxKaryawan.Location = New System.Drawing.Point(100, 0)
        Me.fotoBoxKaryawan.Name = "fotoBoxKaryawan"
        Me.fotoBoxKaryawan.Size = New System.Drawing.Size(448, 200)
        Me.fotoBoxKaryawan.TabIndex = 0
        Me.fotoBoxKaryawan.TabStop = False
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label34.Location = New System.Drawing.Point(548, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 200)
        Me.Label34.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label35.Location = New System.Drawing.Point(0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(100, 200)
        Me.Label35.TabIndex = 3
        '
        'tabelDataKaryawan
        '
        Me.tabelDataKaryawan.AllowUserToAddRows = False
        Me.tabelDataKaryawan.AllowUserToDeleteRows = False
        Me.tabelDataKaryawan.AllowUserToOrderColumns = True
        Me.tabelDataKaryawan.AutoGenerateColumns = False
        Me.tabelDataKaryawan.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdkaryawanDataGridViewTextBoxColumn, Me.NamakaryawanDataGridViewTextBoxColumn, Me.LevelkaryawanDataGridViewTextBoxColumn, Me.FotoDataGridViewImageColumn1, Me.PasswordDataGridViewTextBoxColumn})
        Me.tabelDataKaryawan.DataSource = Me.KaryawanBindingSource
        Me.tabelDataKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataKaryawan.Location = New System.Drawing.Point(0, 70)
        Me.tabelDataKaryawan.MultiSelect = False
        Me.tabelDataKaryawan.Name = "tabelDataKaryawan"
        Me.tabelDataKaryawan.ReadOnly = True
        Me.tabelDataKaryawan.RowHeadersVisible = False
        Me.tabelDataKaryawan.Size = New System.Drawing.Size(648, 478)
        Me.tabelDataKaryawan.TabIndex = 4
        '
        'IdkaryawanDataGridViewTextBoxColumn
        '
        Me.IdkaryawanDataGridViewTextBoxColumn.DataPropertyName = "id_karyawan"
        Me.IdkaryawanDataGridViewTextBoxColumn.HeaderText = "ID Karyawan"
        Me.IdkaryawanDataGridViewTextBoxColumn.Name = "IdkaryawanDataGridViewTextBoxColumn"
        Me.IdkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamakaryawanDataGridViewTextBoxColumn
        '
        Me.NamakaryawanDataGridViewTextBoxColumn.DataPropertyName = "nama_karyawan"
        Me.NamakaryawanDataGridViewTextBoxColumn.HeaderText = "Nama Karyawan"
        Me.NamakaryawanDataGridViewTextBoxColumn.Name = "NamakaryawanDataGridViewTextBoxColumn"
        Me.NamakaryawanDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamakaryawanDataGridViewTextBoxColumn.Width = 120
        '
        'LevelkaryawanDataGridViewTextBoxColumn
        '
        Me.LevelkaryawanDataGridViewTextBoxColumn.DataPropertyName = "level_karyawan"
        Me.LevelkaryawanDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelkaryawanDataGridViewTextBoxColumn.Name = "LevelkaryawanDataGridViewTextBoxColumn"
        Me.LevelkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FotoDataGridViewImageColumn1
        '
        Me.FotoDataGridViewImageColumn1.DataPropertyName = "foto"
        Me.FotoDataGridViewImageColumn1.HeaderText = "foto"
        Me.FotoDataGridViewImageColumn1.Name = "FotoDataGridViewImageColumn1"
        Me.FotoDataGridViewImageColumn1.ReadOnly = True
        Me.FotoDataGridViewImageColumn1.Visible = False
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "karyawan"
        Me.KaryawanBindingSource.DataSource = Me.SeleksiDataSet
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label36.Location = New System.Drawing.Point(0, 60)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(648, 10)
        Me.Label36.TabIndex = 2
        '
        'PanelHeaderKaryawan
        '
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnEditKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnTambahKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnHapusKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label37)
        Me.PanelHeaderKaryawan.Controls.Add(Me.txCariKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label38)
        Me.PanelHeaderKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderKaryawan.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderKaryawan.Name = "PanelHeaderKaryawan"
        Me.PanelHeaderKaryawan.Size = New System.Drawing.Size(648, 60)
        Me.PanelHeaderKaryawan.TabIndex = 0
        '
        'btnEditKaryawan
        '
        Me.btnEditKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEditKaryawan.FlatAppearance.BorderSize = 0
        Me.btnEditKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnEditKaryawan.Location = New System.Drawing.Point(479, 10)
        Me.btnEditKaryawan.Name = "btnEditKaryawan"
        Me.btnEditKaryawan.Size = New System.Drawing.Size(80, 40)
        Me.btnEditKaryawan.TabIndex = 10
        Me.btnEditKaryawan.Text = "Edit"
        Me.btnEditKaryawan.UseVisualStyleBackColor = False
        '
        'btnTambahKaryawan
        '
        Me.btnTambahKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnTambahKaryawan.FlatAppearance.BorderSize = 0
        Me.btnTambahKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnTambahKaryawan.Location = New System.Drawing.Point(393, 10)
        Me.btnTambahKaryawan.Name = "btnTambahKaryawan"
        Me.btnTambahKaryawan.Size = New System.Drawing.Size(80, 40)
        Me.btnTambahKaryawan.TabIndex = 10
        Me.btnTambahKaryawan.Text = "Tambah"
        Me.btnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'btnHapusKaryawan
        '
        Me.btnHapusKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnHapusKaryawan.FlatAppearance.BorderSize = 0
        Me.btnHapusKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnHapusKaryawan.Location = New System.Drawing.Point(565, 10)
        Me.btnHapusKaryawan.Name = "btnHapusKaryawan"
        Me.btnHapusKaryawan.Size = New System.Drawing.Size(80, 40)
        Me.btnHapusKaryawan.TabIndex = 10
        Me.btnHapusKaryawan.Text = "Hapus"
        Me.btnHapusKaryawan.UseVisualStyleBackColor = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(16, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(27, 13)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Cari"
        '
        'txCariKaryawan
        '
        Me.txCariKaryawan.Location = New System.Drawing.Point(49, 20)
        Me.txCariKaryawan.Name = "txCariKaryawan"
        Me.txCariKaryawan.Size = New System.Drawing.Size(236, 20)
        Me.txCariKaryawan.TabIndex = 6
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(0, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(648, 60)
        Me.Label38.TabIndex = 8
        '
        'PanelKontenBarang
        '
        Me.PanelKontenBarang.Controls.Add(Me.Panel2)
        Me.PanelKontenBarang.Controls.Add(Me.PanelFooterBarang)
        Me.PanelKontenBarang.Controls.Add(Me.tabelDataBarang)
        Me.PanelKontenBarang.Controls.Add(Me.Label27)
        Me.PanelKontenBarang.Controls.Add(Me.PanelHeaderBarang)
        Me.PanelKontenBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenBarang.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenBarang.Name = "PanelKontenBarang"
        Me.PanelKontenBarang.Size = New System.Drawing.Size(648, 548)
        Me.PanelKontenBarang.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnLihatFotoBarang)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 328)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 20)
        Me.Panel2.TabIndex = 5
        '
        'btnLihatFotoBarang
        '
        Me.btnLihatFotoBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnLihatFotoBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLihatFotoBarang.FlatAppearance.BorderSize = 0
        Me.btnLihatFotoBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLihatFotoBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihatFotoBarang.ForeColor = System.Drawing.Color.White
        Me.btnLihatFotoBarang.Location = New System.Drawing.Point(310, 0)
        Me.btnLihatFotoBarang.Name = "btnLihatFotoBarang"
        Me.btnLihatFotoBarang.Size = New System.Drawing.Size(28, 20)
        Me.btnLihatFotoBarang.TabIndex = 10
        Me.btnLihatFotoBarang.Text = "^"
        Me.btnLihatFotoBarang.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(338, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 20)
        Me.Panel3.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label31.Location = New System.Drawing.Point(0, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(310, 10)
        Me.Label31.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 20)
        Me.Panel1.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label30.Location = New System.Drawing.Point(0, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(310, 10)
        Me.Label30.TabIndex = 4
        '
        'PanelFooterBarang
        '
        Me.PanelFooterBarang.Controls.Add(Me.fotoBoxBarang)
        Me.PanelFooterBarang.Controls.Add(Me.Label28)
        Me.PanelFooterBarang.Controls.Add(Me.Label29)
        Me.PanelFooterBarang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooterBarang.Location = New System.Drawing.Point(0, 348)
        Me.PanelFooterBarang.Name = "PanelFooterBarang"
        Me.PanelFooterBarang.Size = New System.Drawing.Size(648, 200)
        Me.PanelFooterBarang.TabIndex = 5
        Me.PanelFooterBarang.Visible = False
        '
        'fotoBoxBarang
        '
        Me.fotoBoxBarang.BackColor = System.Drawing.Color.White
        Me.fotoBoxBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoBoxBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fotoBoxBarang.Location = New System.Drawing.Point(100, 0)
        Me.fotoBoxBarang.Name = "fotoBoxBarang"
        Me.fotoBoxBarang.Size = New System.Drawing.Size(448, 200)
        Me.fotoBoxBarang.TabIndex = 0
        Me.fotoBoxBarang.TabStop = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label28.Location = New System.Drawing.Point(548, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 200)
        Me.Label28.TabIndex = 2
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label29.Location = New System.Drawing.Point(0, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 200)
        Me.Label29.TabIndex = 3
        '
        'tabelDataBarang
        '
        Me.tabelDataBarang.AllowUserToAddRows = False
        Me.tabelDataBarang.AllowUserToDeleteRows = False
        Me.tabelDataBarang.AllowUserToOrderColumns = True
        Me.tabelDataBarang.AutoGenerateColumns = False
        Me.tabelDataBarang.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebarangDataGridViewTextBoxColumn, Me.NamabarangDataGridViewTextBoxColumn, Me.NamakategoriDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn, Me.FotoDataGridViewImageColumn, Me.KodekategoriDataGridViewTextBoxColumn})
        Me.tabelDataBarang.DataSource = Me.LihatBarangBindingSource
        Me.tabelDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataBarang.Location = New System.Drawing.Point(0, 70)
        Me.tabelDataBarang.MultiSelect = False
        Me.tabelDataBarang.Name = "tabelDataBarang"
        Me.tabelDataBarang.ReadOnly = True
        Me.tabelDataBarang.RowHeadersVisible = False
        Me.tabelDataBarang.Size = New System.Drawing.Size(648, 478)
        Me.tabelDataBarang.TabIndex = 4
        '
        'KodebarangDataGridViewTextBoxColumn
        '
        Me.KodebarangDataGridViewTextBoxColumn.DataPropertyName = "kode_barang"
        Me.KodebarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodebarangDataGridViewTextBoxColumn.Name = "KodebarangDataGridViewTextBoxColumn"
        Me.KodebarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamabarangDataGridViewTextBoxColumn
        '
        Me.NamabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang"
        Me.NamabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamabarangDataGridViewTextBoxColumn.Name = "NamabarangDataGridViewTextBoxColumn"
        Me.NamabarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamakategoriDataGridViewTextBoxColumn
        '
        Me.NamakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori"
        Me.NamakategoriDataGridViewTextBoxColumn.HeaderText = "Kategori"
        Me.NamakategoriDataGridViewTextBoxColumn.Name = "NamakategoriDataGridViewTextBoxColumn"
        Me.NamakategoriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        Me.DiskonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        Me.StokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FotoDataGridViewImageColumn
        '
        Me.FotoDataGridViewImageColumn.DataPropertyName = "foto"
        Me.FotoDataGridViewImageColumn.HeaderText = "foto"
        Me.FotoDataGridViewImageColumn.Name = "FotoDataGridViewImageColumn"
        Me.FotoDataGridViewImageColumn.ReadOnly = True
        Me.FotoDataGridViewImageColumn.Visible = False
        '
        'KodekategoriDataGridViewTextBoxColumn
        '
        Me.KodekategoriDataGridViewTextBoxColumn.DataPropertyName = "kode_kategori"
        Me.KodekategoriDataGridViewTextBoxColumn.HeaderText = "kode_kategori"
        Me.KodekategoriDataGridViewTextBoxColumn.Name = "KodekategoriDataGridViewTextBoxColumn"
        Me.KodekategoriDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodekategoriDataGridViewTextBoxColumn.Visible = False
        '
        'LihatBarangBindingSource
        '
        Me.LihatBarangBindingSource.DataMember = "lihatBarang"
        Me.LihatBarangBindingSource.DataSource = Me.SeleksiDataSet
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label27.Location = New System.Drawing.Point(0, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(648, 10)
        Me.Label27.TabIndex = 2
        '
        'PanelHeaderBarang
        '
        Me.PanelHeaderBarang.Controls.Add(Me.btnEditBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.btnTambahBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.btnHapusBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.Label25)
        Me.PanelHeaderBarang.Controls.Add(Me.txCariBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.Label26)
        Me.PanelHeaderBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderBarang.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderBarang.Name = "PanelHeaderBarang"
        Me.PanelHeaderBarang.Size = New System.Drawing.Size(648, 60)
        Me.PanelHeaderBarang.TabIndex = 0
        '
        'btnEditBarang
        '
        Me.btnEditBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEditBarang.FlatAppearance.BorderSize = 0
        Me.btnEditBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBarang.ForeColor = System.Drawing.Color.White
        Me.btnEditBarang.Location = New System.Drawing.Point(479, 10)
        Me.btnEditBarang.Name = "btnEditBarang"
        Me.btnEditBarang.Size = New System.Drawing.Size(80, 40)
        Me.btnEditBarang.TabIndex = 10
        Me.btnEditBarang.Text = "Edit"
        Me.btnEditBarang.UseVisualStyleBackColor = False
        '
        'btnTambahBarang
        '
        Me.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnTambahBarang.FlatAppearance.BorderSize = 0
        Me.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahBarang.ForeColor = System.Drawing.Color.White
        Me.btnTambahBarang.Location = New System.Drawing.Point(393, 10)
        Me.btnTambahBarang.Name = "btnTambahBarang"
        Me.btnTambahBarang.Size = New System.Drawing.Size(80, 40)
        Me.btnTambahBarang.TabIndex = 10
        Me.btnTambahBarang.Text = "Tambah"
        Me.btnTambahBarang.UseVisualStyleBackColor = False
        '
        'btnHapusBarang
        '
        Me.btnHapusBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnHapusBarang.FlatAppearance.BorderSize = 0
        Me.btnHapusBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusBarang.ForeColor = System.Drawing.Color.White
        Me.btnHapusBarang.Location = New System.Drawing.Point(565, 10)
        Me.btnHapusBarang.Name = "btnHapusBarang"
        Me.btnHapusBarang.Size = New System.Drawing.Size(80, 40)
        Me.btnHapusBarang.TabIndex = 10
        Me.btnHapusBarang.Text = "Hapus"
        Me.btnHapusBarang.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Cari"
        '
        'txCariBarang
        '
        Me.txCariBarang.Location = New System.Drawing.Point(49, 20)
        Me.txCariBarang.Name = "txCariBarang"
        Me.txCariBarang.Size = New System.Drawing.Size(236, 20)
        Me.txCariBarang.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(0, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(648, 60)
        Me.Label26.TabIndex = 8
        '
        'pemisahAta
        '
        Me.pemisahAta.BackColor = System.Drawing.Color.Transparent
        Me.pemisahAta.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisahAta.Location = New System.Drawing.Point(10, 0)
        Me.pemisahAta.Name = "pemisahAta"
        Me.pemisahAta.Size = New System.Drawing.Size(648, 10)
        Me.pemisahAta.TabIndex = 1
        '
        'pemisahBawah
        '
        Me.pemisahBawah.BackColor = System.Drawing.Color.Transparent
        Me.pemisahBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisahBawah.Location = New System.Drawing.Point(10, 558)
        Me.pemisahBawah.Name = "pemisahBawah"
        Me.pemisahBawah.Size = New System.Drawing.Size(648, 10)
        Me.pemisahBawah.TabIndex = 1
        '
        'pemisahKanan
        '
        Me.pemisahKanan.BackColor = System.Drawing.Color.Transparent
        Me.pemisahKanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisahKanan.Location = New System.Drawing.Point(658, 0)
        Me.pemisahKanan.Name = "pemisahKanan"
        Me.pemisahKanan.Size = New System.Drawing.Size(10, 568)
        Me.pemisahKanan.TabIndex = 1
        '
        'PemisahKiri
        '
        Me.PemisahKiri.BackColor = System.Drawing.Color.Transparent
        Me.PemisahKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PemisahKiri.Location = New System.Drawing.Point(0, 0)
        Me.PemisahKiri.Name = "PemisahKiri"
        Me.PemisahKiri.Size = New System.Drawing.Size(10, 568)
        Me.PemisahKiri.TabIndex = 1
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelNamaMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(200, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(668, 100)
        Me.PanelHeader.TabIndex = 0
        '
        'PanelNamaMenu
        '
        Me.PanelNamaMenu.Controls.Add(Me.lblKeteranganMenu)
        Me.PanelNamaMenu.Controls.Add(Me.lblMenu)
        Me.PanelNamaMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNamaMenu.Location = New System.Drawing.Point(0, 30)
        Me.PanelNamaMenu.Name = "PanelNamaMenu"
        Me.PanelNamaMenu.Size = New System.Drawing.Size(668, 70)
        Me.PanelNamaMenu.TabIndex = 1
        '
        'lblKeteranganMenu
        '
        Me.lblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.lblKeteranganMenu.Location = New System.Drawing.Point(0, 40)
        Me.lblKeteranganMenu.Name = "lblKeteranganMenu"
        Me.lblKeteranganMenu.Size = New System.Drawing.Size(668, 30)
        Me.lblKeteranganMenu.TabIndex = 1
        Me.lblKeteranganMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMenu
        '
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(0, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(668, 40)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Halaman Awal"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnMinimize)
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(668, 30)
        Me.PanelWindowBar.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(608, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(638, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PanelSideBar
        '
        Me.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.btnLogout)
        Me.PanelSideBar.Controls.Add(Me.Label6)
        Me.PanelSideBar.Controls.Add(Me.btnLaporan)
        Me.PanelSideBar.Controls.Add(Me.Label5)
        Me.PanelSideBar.Controls.Add(Me.btnKaryawan)
        Me.PanelSideBar.Controls.Add(Me.Label4)
        Me.PanelSideBar.Controls.Add(Me.btnBarang)
        Me.PanelSideBar.Controls.Add(Me.Label3)
        Me.PanelSideBar.Controls.Add(Me.btnKasir)
        Me.PanelSideBar.Controls.Add(Me.Label2)
        Me.PanelSideBar.Controls.Add(Me.btnDashboard)
        Me.PanelSideBar.Controls.Add(Me.Label1)
        Me.PanelSideBar.Controls.Add(Me.PanelCornet)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(200, 668)
        Me.PanelSideBar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(0, 608)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 60)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "Keluar Sesi"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 1)
        Me.Label6.TabIndex = 11
        '
        'btnLaporan
        '
        Me.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.Color.White
        Me.btnLaporan.Location = New System.Drawing.Point(0, 344)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(200, 60)
        Me.btnLaporan.TabIndex = 10
        Me.btnLaporan.Text = "     Laporan Penjualan"
        Me.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 1)
        Me.Label5.TabIndex = 9
        '
        'btnKaryawan
        '
        Me.btnKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKaryawan.FlatAppearance.BorderSize = 0
        Me.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaryawan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnKaryawan.Location = New System.Drawing.Point(0, 283)
        Me.btnKaryawan.Name = "btnKaryawan"
        Me.btnKaryawan.Size = New System.Drawing.Size(200, 60)
        Me.btnKaryawan.TabIndex = 8
        Me.btnKaryawan.Text = "     Data Karyawan"
        Me.btnKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaryawan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 1)
        Me.Label4.TabIndex = 7
        '
        'btnBarang
        '
        Me.btnBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.White
        Me.btnBarang.Location = New System.Drawing.Point(0, 222)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(200, 60)
        Me.btnBarang.TabIndex = 6
        Me.btnBarang.Text = "     Data Barang"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 1)
        Me.Label3.TabIndex = 5
        '
        'btnKasir
        '
        Me.btnKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKasir.FlatAppearance.BorderSize = 0
        Me.btnKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKasir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKasir.ForeColor = System.Drawing.Color.White
        Me.btnKasir.Location = New System.Drawing.Point(0, 161)
        Me.btnKasir.Name = "btnKasir"
        Me.btnKasir.Size = New System.Drawing.Size(200, 60)
        Me.btnKasir.TabIndex = 4
        Me.btnKasir.Text = "     Kasir"
        Me.btnKasir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKasir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 1)
        Me.Label2.TabIndex = 3
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 100)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 60)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "     Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 1)
        Me.Label1.TabIndex = 0
        '
        'PanelCornet
        '
        Me.PanelCornet.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanelCornet.Controls.Add(Me.lblAdmin)
        Me.PanelCornet.Controls.Add(Me.iconAdmin)
        Me.PanelCornet.Controls.Add(Me.Label7)
        Me.PanelCornet.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCornet.Location = New System.Drawing.Point(0, 0)
        Me.PanelCornet.Name = "PanelCornet"
        Me.PanelCornet.Size = New System.Drawing.Size(200, 99)
        Me.PanelCornet.TabIndex = 1
        '
        'lblAdmin
        '
        Me.lblAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblAdmin.Location = New System.Drawing.Point(75, 60)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(46, 39)
        Me.lblAdmin.TabIndex = 2
        Me.lblAdmin.Text = "Admin"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iconAdmin
        '
        Me.iconAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.iconAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconAdmin.ForeColor = System.Drawing.Color.White
        Me.iconAdmin.Image = CType(resources.GetObject("iconAdmin.Image"), System.Drawing.Image)
        Me.iconAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.iconAdmin.Location = New System.Drawing.Point(0, 60)
        Me.iconAdmin.Name = "iconAdmin"
        Me.iconAdmin.Size = New System.Drawing.Size(75, 39)
        Me.iconAdmin.TabIndex = 1
        Me.iconAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 60)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bread" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shop"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataMember = "penjualan"
        Me.PenjualanBindingSource.DataSource = Me.SeleksiDataSet
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.SeleksiDataSet
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'HeaderpenjualanBindingSource
        '
        Me.HeaderpenjualanBindingSource.DataMember = "header_penjualan"
        Me.HeaderpenjualanBindingSource.DataSource = Me.SeleksiDataSet
        '
        'Header_penjualanTableAdapter
        '
        Me.Header_penjualanTableAdapter.ClearBeforeFill = True
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'LihatBarangTableAdapter
        '
        Me.LihatBarangTableAdapter.ClearBeforeFill = True
        '
        'LaporanTableAdapter
        '
        Me.LaporanTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LaporanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "seleksi.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 399)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(648, 149)
        Me.ReportViewer1.TabIndex = 5
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 670)
        Me.Controls.Add(Me.PanelForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.PanelForm.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelKontenDashboard.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelKontenKasir.ResumeLayout(False)
        Me.PanelFooterKasir.ResumeLayout(False)
        Me.PanelFooterKasir.PerformLayout()
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderKasir.ResumeLayout(False)
        Me.PanelHeaderKasir.PerformLayout()
        Me.PanelKontenLaporan.ResumeLayout(False)
        CType(Me.tabelDataLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaporanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeleksiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderLaporan.ResumeLayout(False)
        Me.PanelHeaderLaporan.PerformLayout()
        Me.PanelKontenKaryawan.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.PanelFooterKaryawan.ResumeLayout(False)
        CType(Me.fotoBoxKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelDataKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderKaryawan.ResumeLayout(False)
        Me.PanelHeaderKaryawan.PerformLayout()
        Me.PanelKontenBarang.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelFooterBarang.ResumeLayout(False)
        CType(Me.fotoBoxBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderBarang.ResumeLayout(False)
        Me.PanelHeaderBarang.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelNamaMenu.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelSideBar.ResumeLayout(False)
        Me.PanelCornet.ResumeLayout(False)
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderpenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents pemisahAta As Label
    Friend WithEvents pemisahBawah As Label
    Friend WithEvents pemisahKanan As Label
    Friend WithEvents PemisahKiri As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelNamaMenu As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLaporan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKaryawan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKasir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCornet As Panel
    Friend WithEvents lblAdmin As Label
    Friend WithEvents iconAdmin As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SeleksiDataSet As seleksiDataSet
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As seleksiDataSetTableAdapters.barangTableAdapter
    Friend WithEvents HeaderpenjualanBindingSource As BindingSource
    Friend WithEvents Header_penjualanTableAdapter As seleksiDataSetTableAdapters.header_penjualanTableAdapter
    Friend WithEvents KaryawanBindingSource As BindingSource
    Friend WithEvents KaryawanTableAdapter As seleksiDataSetTableAdapters.karyawanTableAdapter
    Friend WithEvents PenjualanBindingSource As BindingSource
    Friend WithEvents PenjualanTableAdapter As seleksiDataSetTableAdapters.penjualanTableAdapter
    Friend WithEvents LihatBarangBindingSource As BindingSource
    Friend WithEvents LihatBarangTableAdapter As seleksiDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents PanelKontenKasir As Panel
    Friend WithEvents PanelHeaderKasir As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txStruk As TextBox
    Friend WithEvents btnCariKode As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents txQty As TextBox
    Friend WithEvents txNamaBarang As TextBox
    Friend WithEvents txKodeBarang As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tglKasir As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txStok As TextBox
    Friend WithEvents txHargaKasir As TextBox
    Friend WithEvents PanelFooterKasir As Panel
    Friend WithEvents txKembalian As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txBayar As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txDiskonBelanja As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txTotal As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tabelDataKasir As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents btnBayar As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents diskon As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents txTotalBelanja As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents PanelKontenDashboard As Panel
    Friend WithEvents PanelKontenBarang As Panel
    Friend WithEvents tabelDataBarang As DataGridView
    Friend WithEvents Label27 As Label
    Friend WithEvents PanelHeaderBarang As Panel
    Friend WithEvents btnEditBarang As Button
    Friend WithEvents btnTambahBarang As Button
    Friend WithEvents btnHapusBarang As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents txCariBarang As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelFooterBarang As Panel
    Friend WithEvents fotoBoxBarang As PictureBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnLihatFotoBarang As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents KodebarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents KodekategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PanelKontenKaryawan As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnLihatFotoKaryawan As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents PanelFooterKaryawan As Panel
    Friend WithEvents fotoBoxKaryawan As PictureBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents tabelDataKaryawan As DataGridView
    Friend WithEvents IdkaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LevelkaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label36 As Label
    Friend WithEvents PanelHeaderKaryawan As Panel
    Friend WithEvents btnEditKaryawan As Button
    Friend WithEvents btnTambahKaryawan As Button
    Friend WithEvents btnHapusKaryawan As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents txCariKaryawan As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents PanelKontenLaporan As Panel
    Friend WithEvents tabelDataLaporan As DataGridView
    Friend WithEvents Label43 As Label
    Friend WithEvents PanelHeaderLaporan As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents tglLaporan As DateTimePicker
    Friend WithEvents txCariLaporan As TextBox
    Friend WithEvents LaporanBindingSource As BindingSource
    Friend WithEvents LaporanTableAdapter As seleksiDataSetTableAdapters.LaporanTableAdapter
    Friend WithEvents NostrukDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NopenjualanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodebarangDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lblDataKaryawan As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lblStokBarang As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblPenjualan As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblStokRoti As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblStokMinuman As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblDataBarang As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
