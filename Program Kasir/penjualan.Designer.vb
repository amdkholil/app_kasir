<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penjualan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.notif = New System.Windows.Forms.Label()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jumlah"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.Column4, Me.Column6})
        Me.dgv.Location = New System.Drawing.Point(33, 164)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(642, 222)
        Me.dgv.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(145, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(154, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(646, 412)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(572, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Belanja"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(180, 410)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(88, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Submit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'notif
        '
        Me.notif.AutoSize = True
        Me.notif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.notif.Location = New System.Drawing.Point(45, 98)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(0, 13)
        Me.notif.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.HeaderText = "No"
        Me.Column5.Name = "Column5"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jumlah"
        Me.Column3.Name = "Column3"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Harga Satuan"
        Me.Column7.Name = "Column7"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total Harga"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(145, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 520)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.notif)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "penjualan"
        Me.Text = "Transaksi Penjualan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents notif As System.Windows.Forms.Label
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
