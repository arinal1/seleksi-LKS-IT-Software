<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelNamaMenu = New System.Windows.Forms.Panel()
        Me.lblKeteranganMenu = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWarn = New System.Windows.Forms.Label()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.pemisahAta = New System.Windows.Forms.Label()
        Me.pemisahBawah = New System.Windows.Forms.Label()
        Me.pemisahKanan = New System.Windows.Forms.Label()
        Me.PemisahKiri = New System.Windows.Forms.Label()
        Me.KaryawanTableAdapter = New seleksi.seleksiDataSetTableAdapters.karyawanTableAdapter()
        Me.PanelHeader.SuspendLayout()
        Me.PanelNamaMenu.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelNamaMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(353, 100)
        Me.PanelHeader.TabIndex = 1
        '
        'PanelNamaMenu
        '
        Me.PanelNamaMenu.Controls.Add(Me.lblKeteranganMenu)
        Me.PanelNamaMenu.Controls.Add(Me.lblMenu)
        Me.PanelNamaMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNamaMenu.Location = New System.Drawing.Point(0, 30)
        Me.PanelNamaMenu.Name = "PanelNamaMenu"
        Me.PanelNamaMenu.Size = New System.Drawing.Size(353, 70)
        Me.PanelNamaMenu.TabIndex = 1
        '
        'lblKeteranganMenu
        '
        Me.lblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.lblKeteranganMenu.Location = New System.Drawing.Point(0, 40)
        Me.lblKeteranganMenu.Name = "lblKeteranganMenu"
        Me.lblKeteranganMenu.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.lblKeteranganMenu.Size = New System.Drawing.Size(353, 30)
        Me.lblKeteranganMenu.TabIndex = 1
        Me.lblKeteranganMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMenu
        '
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(0, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(353, 40)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Masuk"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(353, 30)
        Me.PanelWindowBar.TabIndex = 0
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(323, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'txID
        '
        Me.txID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txID.Location = New System.Drawing.Point(50, 155)
        Me.txID.Name = "txID"
        Me.txID.Size = New System.Drawing.Size(253, 22)
        Me.txID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID Karyawan"
        '
        'txPass
        '
        Me.txPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPass.Location = New System.Drawing.Point(50, 217)
        Me.txPass.Name = "txPass"
        Me.txPass.Size = New System.Drawing.Size(253, 22)
        Me.txPass.TabIndex = 1
        Me.txPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'lblWarn
        '
        Me.lblWarn.AutoSize = True
        Me.lblWarn.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarn.ForeColor = System.Drawing.Color.Red
        Me.lblWarn.Location = New System.Drawing.Point(48, 242)
        Me.lblWarn.Name = "lblWarn"
        Me.lblWarn.Size = New System.Drawing.Size(128, 12)
        Me.lblWarn.TabIndex = 3
        Me.lblWarn.Text = "*Password Minimal 5 Karaketer"
        Me.lblWarn.Visible = False
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMasuk.FlatAppearance.BorderSize = 0
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(50, 304)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(253, 40)
        Me.btnMasuk.TabIndex = 2
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'pemisahAta
        '
        Me.pemisahAta.BackColor = System.Drawing.Color.Transparent
        Me.pemisahAta.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisahAta.Location = New System.Drawing.Point(50, 100)
        Me.pemisahAta.Name = "pemisahAta"
        Me.pemisahAta.Size = New System.Drawing.Size(253, 10)
        Me.pemisahAta.TabIndex = 5
        '
        'pemisahBawah
        '
        Me.pemisahBawah.BackColor = System.Drawing.Color.Transparent
        Me.pemisahBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisahBawah.Location = New System.Drawing.Point(50, 318)
        Me.pemisahBawah.Name = "pemisahBawah"
        Me.pemisahBawah.Size = New System.Drawing.Size(253, 50)
        Me.pemisahBawah.TabIndex = 6
        '
        'pemisahKanan
        '
        Me.pemisahKanan.BackColor = System.Drawing.Color.Transparent
        Me.pemisahKanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisahKanan.Location = New System.Drawing.Point(303, 100)
        Me.pemisahKanan.Name = "pemisahKanan"
        Me.pemisahKanan.Size = New System.Drawing.Size(50, 268)
        Me.pemisahKanan.TabIndex = 7
        '
        'PemisahKiri
        '
        Me.PemisahKiri.BackColor = System.Drawing.Color.Transparent
        Me.PemisahKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PemisahKiri.Location = New System.Drawing.Point(0, 100)
        Me.PemisahKiri.Name = "PemisahKiri"
        Me.PemisahKiri.Size = New System.Drawing.Size(50, 268)
        Me.PemisahKiri.TabIndex = 8
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 368)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.pemisahAta)
        Me.Controls.Add(Me.pemisahBawah)
        Me.Controls.Add(Me.pemisahKanan)
        Me.Controls.Add(Me.PemisahKiri)
        Me.Controls.Add(Me.lblWarn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txID)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLogin"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelNamaMenu.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelNamaMenu As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblWarn As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents pemisahAta As Label
    Friend WithEvents pemisahBawah As Label
    Friend WithEvents pemisahKanan As Label
    Friend WithEvents PemisahKiri As Label
    Friend WithEvents KaryawanTableAdapter As seleksiDataSetTableAdapters.karyawanTableAdapter
End Class
