<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.pemisahAta = New System.Windows.Forms.Label()
        Me.pemisahBawah = New System.Windows.Forms.Label()
        Me.pemisahKanan = New System.Windows.Forms.Label()
        Me.PemisahKiri = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txKode = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.lblKeteranganMenu = New System.Windows.Forms.Label()
        Me.PanelNamaMenu = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.txStok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fotoBoxBarang = New System.Windows.Forms.PictureBox()
        Me.btnUlang = New System.Windows.Forms.Button()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.KategoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeleksiDataSet = New seleksi.seleksiDataSet()
        Me.KategoriTableAdapter = New seleksi.seleksiDataSetTableAdapters.kategoriTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarangTableAdapter = New seleksi.seleksiDataSetTableAdapters.barangTableAdapter()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelNamaMenu.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        CType(Me.fotoBoxBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeleksiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(339, 497)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 40)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'pemisahAta
        '
        Me.pemisahAta.BackColor = System.Drawing.Color.Transparent
        Me.pemisahAta.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisahAta.Location = New System.Drawing.Point(25, 100)
        Me.pemisahAta.Name = "pemisahAta"
        Me.pemisahAta.Size = New System.Drawing.Size(400, 10)
        Me.pemisahAta.TabIndex = 16
        '
        'pemisahBawah
        '
        Me.pemisahBawah.BackColor = System.Drawing.Color.Transparent
        Me.pemisahBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisahBawah.Location = New System.Drawing.Point(25, 524)
        Me.pemisahBawah.Name = "pemisahBawah"
        Me.pemisahBawah.Size = New System.Drawing.Size(400, 25)
        Me.pemisahBawah.TabIndex = 17
        '
        'pemisahKanan
        '
        Me.pemisahKanan.BackColor = System.Drawing.Color.Transparent
        Me.pemisahKanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisahKanan.Location = New System.Drawing.Point(425, 100)
        Me.pemisahKanan.Name = "pemisahKanan"
        Me.pemisahKanan.Size = New System.Drawing.Size(25, 449)
        Me.pemisahKanan.TabIndex = 18
        '
        'PemisahKiri
        '
        Me.PemisahKiri.BackColor = System.Drawing.Color.Transparent
        Me.PemisahKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PemisahKiri.Location = New System.Drawing.Point(0, 100)
        Me.PemisahKiri.Name = "PemisahKiri"
        Me.PemisahKiri.Size = New System.Drawing.Size(25, 449)
        Me.PemisahKiri.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nama Barang"
        '
        'txKode
        '
        Me.txKode.Location = New System.Drawing.Point(98, 118)
        Me.txKode.Name = "txKode"
        Me.txKode.Size = New System.Drawing.Size(327, 20)
        Me.txKode.TabIndex = 0
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(420, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(450, 30)
        Me.PanelWindowBar.TabIndex = 0
        '
        'lblKeteranganMenu
        '
        Me.lblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.lblKeteranganMenu.Location = New System.Drawing.Point(0, 40)
        Me.lblKeteranganMenu.Name = "lblKeteranganMenu"
        Me.lblKeteranganMenu.Size = New System.Drawing.Size(450, 30)
        Me.lblKeteranganMenu.TabIndex = 1
        Me.lblKeteranganMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelNamaMenu
        '
        Me.PanelNamaMenu.Controls.Add(Me.lblKeteranganMenu)
        Me.PanelNamaMenu.Controls.Add(Me.lblMenu)
        Me.PanelNamaMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNamaMenu.Location = New System.Drawing.Point(0, 30)
        Me.PanelNamaMenu.Name = "PanelNamaMenu"
        Me.PanelNamaMenu.Size = New System.Drawing.Size(450, 70)
        Me.PanelNamaMenu.TabIndex = 1
        '
        'lblMenu
        '
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(0, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(450, 40)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Form Data Barang"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Kode Barang"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelNamaMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(450, 100)
        Me.PanelHeader.TabIndex = 11
        '
        'txNama
        '
        Me.txNama.Location = New System.Drawing.Point(98, 146)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(327, 20)
        Me.txNama.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Kategori"
        '
        'txHarga
        '
        Me.txHarga.Location = New System.Drawing.Point(98, 202)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(327, 20)
        Me.txHarga.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Stok"
        '
        'txDiskon
        '
        Me.txDiskon.Location = New System.Drawing.Point(98, 230)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(327, 20)
        Me.txDiskon.TabIndex = 4
        '
        'txStok
        '
        Me.txStok.Location = New System.Drawing.Point(98, 258)
        Me.txStok.Name = "txStok"
        Me.txStok.Size = New System.Drawing.Size(327, 20)
        Me.txStok.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Diskon (%)"
        '
        'fotoBoxBarang
        '
        Me.fotoBoxBarang.BackColor = System.Drawing.Color.White
        Me.fotoBoxBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoBoxBarang.Location = New System.Drawing.Point(25, 296)
        Me.fotoBoxBarang.Name = "fotoBoxBarang"
        Me.fotoBoxBarang.Size = New System.Drawing.Size(403, 188)
        Me.fotoBoxBarang.TabIndex = 20
        Me.fotoBoxBarang.TabStop = False
        '
        'btnUlang
        '
        Me.btnUlang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnUlang.FlatAppearance.BorderSize = 0
        Me.btnUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUlang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUlang.ForeColor = System.Drawing.Color.White
        Me.btnUlang.Location = New System.Drawing.Point(253, 497)
        Me.btnUlang.Name = "btnUlang"
        Me.btnUlang.Size = New System.Drawing.Size(80, 40)
        Me.btnUlang.TabIndex = 8
        Me.btnUlang.Text = "Ulang"
        Me.btnUlang.UseVisualStyleBackColor = False
        '
        'btnFoto
        '
        Me.btnFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoto.ForeColor = System.Drawing.Color.White
        Me.btnFoto.Location = New System.Drawing.Point(167, 497)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(80, 40)
        Me.btnFoto.TabIndex = 6
        Me.btnFoto.Text = "Foto"
        Me.btnFoto.UseVisualStyleBackColor = False
        '
        'cbKategori
        '
        Me.cbKategori.DataSource = Me.KategoriBindingSource
        Me.cbKategori.DisplayMember = "nama_kategori"
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Location = New System.Drawing.Point(98, 172)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(327, 21)
        Me.cbKategori.TabIndex = 2
        Me.cbKategori.ValueMember = "kode_kategori"
        '
        'KategoriBindingSource
        '
        Me.KategoriBindingSource.DataMember = "kategori"
        Me.KategoriBindingSource.DataSource = Me.SeleksiDataSet
        '
        'SeleksiDataSet
        '
        Me.SeleksiDataSet.DataSetName = "seleksiDataSet"
        Me.SeleksiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KategoriTableAdapter
        '
        Me.KategoriTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'formBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 549)
        Me.Controls.Add(Me.cbKategori)
        Me.Controls.Add(Me.fotoBoxBarang)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.btnUlang)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.pemisahAta)
        Me.Controls.Add(Me.pemisahBawah)
        Me.Controls.Add(Me.pemisahKanan)
        Me.Controls.Add(Me.PemisahKiri)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txStok)
        Me.Controls.Add(Me.txHarga)
        Me.Controls.Add(Me.txDiskon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txKode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBarang"
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelNamaMenu.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.fotoBoxBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeleksiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As Button
    Friend WithEvents pemisahAta As Label
    Friend WithEvents pemisahBawah As Label
    Friend WithEvents pemisahKanan As Label
    Friend WithEvents PemisahKiri As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txKode As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents PanelNamaMenu As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents txNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents txStok As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents fotoBoxBarang As PictureBox
    Friend WithEvents btnUlang As Button
    Friend WithEvents btnFoto As Button
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents SeleksiDataSet As seleksiDataSet
    Friend WithEvents KategoriBindingSource As BindingSource
    Friend WithEvents KategoriTableAdapter As seleksiDataSetTableAdapters.kategoriTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BarangTableAdapter As seleksiDataSetTableAdapters.barangTableAdapter
End Class
