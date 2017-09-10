<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.MasterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(758, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.BarangMasukToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "&Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataPenjualanToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataPenjualanToolStripMenuItem
        '
        Me.DataPenjualanToolStripMenuItem.Name = "DataPenjualanToolStripMenuItem"
        Me.DataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataPenjualanToolStripMenuItem.Text = "Data Penjualan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 331)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(758, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 353)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "home"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
End Class
