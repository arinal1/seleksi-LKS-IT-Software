<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKaryawan
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
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.txPassword = New System.Windows.Forms.TextBox()
        Me.txID = New System.Windows.Forms.TextBox()
        Me.cbLevel = New System.Windows.Forms.ComboBox()
        Me.fotoBox = New System.Windows.Forms.PictureBox()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.btnUlang = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.pemisahAta = New System.Windows.Forms.Label()
        Me.pemisahBawah = New System.Windows.Forms.Label()
        Me.pemisahKanan = New System.Windows.Forms.Label()
        Me.PemisahKiri = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelNamaMenu = New System.Windows.Forms.Panel()
        Me.lblKeteranganMenu = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.KaryawanTableAdapter = New seleksi.seleksiDataSetTableAdapters.karyawanTableAdapter()
        Me.PanelForm.SuspendLayout()
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.PanelNamaMenu.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.txNama)
        Me.PanelForm.Controls.Add(Me.txPassword)
        Me.PanelForm.Controls.Add(Me.txID)
        Me.PanelForm.Controls.Add(Me.cbLevel)
        Me.PanelForm.Controls.Add(Me.fotoBox)
        Me.PanelForm.Controls.Add(Me.btnFoto)
        Me.PanelForm.Controls.Add(Me.btnUlang)
        Me.PanelForm.Controls.Add(Me.btnSimpan)
        Me.PanelForm.Controls.Add(Me.pemisahAta)
        Me.PanelForm.Controls.Add(Me.pemisahBawah)
        Me.PanelForm.Controls.Add(Me.pemisahKanan)
        Me.PanelForm.Controls.Add(Me.PemisahKiri)
        Me.PanelForm.Controls.Add(Me.Label4)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.Label3)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(450, 500)
        Me.PanelForm.TabIndex = 0
        '
        'txNama
        '
        Me.txNama.Location = New System.Drawing.Point(98, 146)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(327, 20)
        Me.txNama.TabIndex = 22
        '
        'txPassword
        '
        Me.txPassword.Location = New System.Drawing.Point(98, 202)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.Size = New System.Drawing.Size(327, 20)
        Me.txPassword.TabIndex = 24
        Me.txPassword.UseSystemPasswordChar = True
        '
        'txID
        '
        Me.txID.Location = New System.Drawing.Point(98, 118)
        Me.txID.Name = "txID"
        Me.txID.Size = New System.Drawing.Size(327, 20)
        Me.txID.TabIndex = 21
        '
        'cbLevel
        '
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Items.AddRange(New Object() {"Karyawan", "Admin"})
        Me.cbLevel.Location = New System.Drawing.Point(98, 172)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(327, 21)
        Me.cbLevel.TabIndex = 23
        '
        'fotoBox
        '
        Me.fotoBox.BackColor = System.Drawing.Color.White
        Me.fotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoBox.Location = New System.Drawing.Point(25, 243)
        Me.fotoBox.Name = "fotoBox"
        Me.fotoBox.Size = New System.Drawing.Size(403, 188)
        Me.fotoBox.TabIndex = 41
        Me.fotoBox.TabStop = False
        '
        'btnFoto
        '
        Me.btnFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoto.ForeColor = System.Drawing.Color.White
        Me.btnFoto.Location = New System.Drawing.Point(173, 446)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(80, 40)
        Me.btnFoto.TabIndex = 27
        Me.btnFoto.Text = "Foto"
        Me.btnFoto.UseVisualStyleBackColor = False
        '
        'btnUlang
        '
        Me.btnUlang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnUlang.FlatAppearance.BorderSize = 0
        Me.btnUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUlang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUlang.ForeColor = System.Drawing.Color.White
        Me.btnUlang.Location = New System.Drawing.Point(259, 446)
        Me.btnUlang.Name = "btnUlang"
        Me.btnUlang.Size = New System.Drawing.Size(80, 40)
        Me.btnUlang.TabIndex = 29
        Me.btnUlang.Text = "Ulang"
        Me.btnUlang.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(345, 446)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 40)
        Me.btnSimpan.TabIndex = 28
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'pemisahAta
        '
        Me.pemisahAta.BackColor = System.Drawing.Color.Transparent
        Me.pemisahAta.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisahAta.Location = New System.Drawing.Point(25, 100)
        Me.pemisahAta.Name = "pemisahAta"
        Me.pemisahAta.Size = New System.Drawing.Size(398, 10)
        Me.pemisahAta.TabIndex = 37
        '
        'pemisahBawah
        '
        Me.pemisahBawah.BackColor = System.Drawing.Color.Transparent
        Me.pemisahBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisahBawah.Location = New System.Drawing.Point(25, 473)
        Me.pemisahBawah.Name = "pemisahBawah"
        Me.pemisahBawah.Size = New System.Drawing.Size(398, 25)
        Me.pemisahBawah.TabIndex = 38
        '
        'pemisahKanan
        '
        Me.pemisahKanan.BackColor = System.Drawing.Color.Transparent
        Me.pemisahKanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisahKanan.Location = New System.Drawing.Point(423, 100)
        Me.pemisahKanan.Name = "pemisahKanan"
        Me.pemisahKanan.Size = New System.Drawing.Size(25, 398)
        Me.pemisahKanan.TabIndex = 39
        '
        'PemisahKiri
        '
        Me.PemisahKiri.BackColor = System.Drawing.Color.Transparent
        Me.PemisahKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PemisahKiri.Location = New System.Drawing.Point(0, 100)
        Me.PemisahKiri.Name = "PemisahKiri"
        Me.PemisahKiri.Size = New System.Drawing.Size(25, 398)
        Me.PemisahKiri.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nama "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID Karyawan"
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
        Me.PanelHeader.TabIndex = 30
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
        Me.lblMenu.Text = "Form Data Karyawan"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'formKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 500)
        Me.Controls.Add(Me.PanelForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formKaryawan"
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelNamaMenu.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents cbLevel As ComboBox
    Friend WithEvents fotoBox As PictureBox
    Friend WithEvents btnFoto As Button
    Friend WithEvents btnUlang As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents pemisahAta As Label
    Friend WithEvents pemisahBawah As Label
    Friend WithEvents pemisahKanan As Label
    Friend WithEvents PemisahKiri As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txNama As TextBox
    Friend WithEvents txPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelNamaMenu As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txID As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents KaryawanTableAdapter As seleksiDataSetTableAdapters.karyawanTableAdapter
End Class
