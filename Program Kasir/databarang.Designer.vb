<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class databarang
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.notif = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(40, 36)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(696, 333)
        Me.dgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Barang Detail"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Input Data Baru"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Update Data Barang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(97, 526)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 57)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Hapus Data Barang"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(720, 441)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 57)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "&Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(720, 519)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 57)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "&Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(97, 589)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 57)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "&Cari Data Barang"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Stok Awal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Harga Jual (Rp)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Harga Beli (Rp)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Satuan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(108, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(108, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(67, 20)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(108, 129)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(108, 155)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PCS"})
        Me.ComboBox1.Location = New System.Drawing.Point(108, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.notif)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(324, 387)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 262)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opersi"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(161, 216)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 29)
        Me.Button9.TabIndex = 24
        Me.Button9.Text = "Reset "
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(81, 216)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 29)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "Lakukan"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'notif
        '
        Me.notif.AutoSize = True
        Me.notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.notif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.notif.ForeColor = System.Drawing.Color.Green
        Me.notif.Location = New System.Drawing.Point(18, 185)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(30, 15)
        Me.notif.TabIndex = 22
        Me.notif.Text = "notif"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(230, 27)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(53, 23)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Cari"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'databarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "databarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents notif As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
