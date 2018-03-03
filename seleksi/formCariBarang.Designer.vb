<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCariBarang
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
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.tabelDataBarang = New System.Windows.Forms.DataGridView()
        Me.KodebarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LihatBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeleksiDataSet = New seleksi.seleksiDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPilih = New System.Windows.Forms.Button()
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
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.LihatBarangTableAdapter = New seleksi.seleksiDataSetTableAdapters.lihatBarangTableAdapter()
        Me.PanelForm.SuspendLayout()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeleksiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.PanelNamaMenu.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.tabelDataBarang)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Controls.Add(Me.btnPilih)
        Me.PanelForm.Controls.Add(Me.Label25)
        Me.PanelForm.Controls.Add(Me.txCariBarang)
        Me.PanelForm.Controls.Add(Me.Label26)
        Me.PanelForm.Controls.Add(Me.pemisahAta)
        Me.PanelForm.Controls.Add(Me.pemisahBawah)
        Me.PanelForm.Controls.Add(Me.pemisahKanan)
        Me.PanelForm.Controls.Add(Me.PemisahKiri)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(450, 450)
        Me.PanelForm.TabIndex = 0
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
        Me.tabelDataBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebarangDataGridViewTextBoxColumn, Me.NamabarangDataGridViewTextBoxColumn, Me.NamakategoriDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn})
        Me.tabelDataBarang.DataSource = Me.LihatBarangBindingSource
        Me.tabelDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataBarang.Location = New System.Drawing.Point(10, 180)
        Me.tabelDataBarang.MultiSelect = False
        Me.tabelDataBarang.Name = "tabelDataBarang"
        Me.tabelDataBarang.ReadOnly = True
        Me.tabelDataBarang.RowHeadersVisible = False
        Me.tabelDataBarang.Size = New System.Drawing.Size(428, 258)
        Me.tabelDataBarang.TabIndex = 23
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
        'LihatBarangBindingSource
        '
        Me.LihatBarangBindingSource.DataMember = "lihatBarang"
        Me.LihatBarangBindingSource.DataSource = Me.SeleksiDataSet
        '
        'SeleksiDataSet
        '
        Me.SeleksiDataSet.DataSetName = "seleksiDataSet"
        Me.SeleksiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(10, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 10)
        Me.Label1.TabIndex = 22
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPilih.FlatAppearance.BorderSize = 0
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.ForeColor = System.Drawing.Color.White
        Me.btnPilih.Location = New System.Drawing.Point(352, 120)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(80, 40)
        Me.btnPilih.TabIndex = 21
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 134)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 13)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Cari"
        '
        'txCariBarang
        '
        Me.txCariBarang.Location = New System.Drawing.Point(49, 130)
        Me.txCariBarang.Name = "txCariBarang"
        Me.txCariBarang.Size = New System.Drawing.Size(236, 20)
        Me.txCariBarang.TabIndex = 17
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(10, 110)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(428, 60)
        Me.Label26.TabIndex = 19
        '
        'pemisahAta
        '
        Me.pemisahAta.BackColor = System.Drawing.Color.Transparent
        Me.pemisahAta.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisahAta.Location = New System.Drawing.Point(10, 100)
        Me.pemisahAta.Name = "pemisahAta"
        Me.pemisahAta.Size = New System.Drawing.Size(428, 10)
        Me.pemisahAta.TabIndex = 13
        '
        'pemisahBawah
        '
        Me.pemisahBawah.BackColor = System.Drawing.Color.Transparent
        Me.pemisahBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisahBawah.Location = New System.Drawing.Point(10, 438)
        Me.pemisahBawah.Name = "pemisahBawah"
        Me.pemisahBawah.Size = New System.Drawing.Size(428, 10)
        Me.pemisahBawah.TabIndex = 14
        '
        'pemisahKanan
        '
        Me.pemisahKanan.BackColor = System.Drawing.Color.Transparent
        Me.pemisahKanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisahKanan.Location = New System.Drawing.Point(438, 100)
        Me.pemisahKanan.Name = "pemisahKanan"
        Me.pemisahKanan.Size = New System.Drawing.Size(10, 348)
        Me.pemisahKanan.TabIndex = 15
        '
        'PemisahKiri
        '
        Me.PemisahKiri.BackColor = System.Drawing.Color.Transparent
        Me.PemisahKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PemisahKiri.Location = New System.Drawing.Point(0, 100)
        Me.PemisahKiri.Name = "PemisahKiri"
        Me.PemisahKiri.Size = New System.Drawing.Size(10, 348)
        Me.PemisahKiri.TabIndex = 16
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelNamaMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(448, 100)
        Me.PanelHeader.TabIndex = 12
        '
        'PanelNamaMenu
        '
        Me.PanelNamaMenu.Controls.Add(Me.lblKeteranganMenu)
        Me.PanelNamaMenu.Controls.Add(Me.lblMenu)
        Me.PanelNamaMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNamaMenu.Location = New System.Drawing.Point(0, 30)
        Me.PanelNamaMenu.Name = "PanelNamaMenu"
        Me.PanelNamaMenu.Size = New System.Drawing.Size(448, 70)
        Me.PanelNamaMenu.TabIndex = 1
        '
        'lblKeteranganMenu
        '
        Me.lblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.lblKeteranganMenu.Location = New System.Drawing.Point(0, 40)
        Me.lblKeteranganMenu.Name = "lblKeteranganMenu"
        Me.lblKeteranganMenu.Size = New System.Drawing.Size(448, 30)
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
        Me.lblMenu.Size = New System.Drawing.Size(448, 40)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Cari Data barang"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(448, 30)
        Me.PanelWindowBar.TabIndex = 0
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(418, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'LihatBarangTableAdapter
        '
        Me.LihatBarangTableAdapter.ClearBeforeFill = True
        '
        'formCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.PanelForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formCariBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formCariBarang"
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeleksiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelNamaMenu.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelNamaMenu As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pemisahAta As Label
    Friend WithEvents pemisahBawah As Label
    Friend WithEvents pemisahKanan As Label
    Friend WithEvents PemisahKiri As Label
    Friend WithEvents btnPilih As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents txCariBarang As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tabelDataBarang As DataGridView
    Friend WithEvents SeleksiDataSet As seleksiDataSet
    Friend WithEvents LihatBarangBindingSource As BindingSource
    Friend WithEvents LihatBarangTableAdapter As seleksiDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents KodebarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
