Imports MySql.Data.MySqlClient
Imports System.Data
Public Class brgmasuk

    Sub tampil()
        Dim dttbl As New DataTable
        Try
            query = "select barang_masuk.no_masuk, barang_masuk.kd_barang, barang_detail.nama_brg," _
                & " barang_masuk.tgl_masuk, barang_masuk.jumlah, user.username " _
                & "  from barang_masuk, barang_detail, " _
                & "user where barang_detail.kd_barang=barang_masuk.kd_barang and " _
                & "barang_masuk.iduser=user.iduser " _
                & "order by barang_masuk.no_masuk desc"
            dta = New MySqlDataAdapter(query, con)
            dttbl.Clear()
            dta.Fill(dttbl)
            dgv.DataSource = dttbl
            dgvset()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub dgvset()
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Width = 600
        dgv.Columns(0).Width = 50
        dgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(0).HeaderText = "No. Masuk"
        dgv.Columns(1).Width = 80
        dgv.Columns(1).HeaderText = "Kode Barang"
        dgv.Columns(2).Width = 170
        dgv.Columns(2).HeaderText = "Nama Barang"
        dgv.Columns(3).Width = 100
        dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(3).HeaderText = "Tangggal"
        dgv.Columns(4).Width = 60
        dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(4).HeaderText = "Jumlah"
        dgv.Columns(5).Width = 100
        dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(5).HeaderText = "Pengguna"
    End Sub

    Sub inputset()
        ComboBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox1.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        DateTimePicker1.Value = Today
        notif.Text = ""
        GroupBox1.Visible = True
    End Sub

    Sub inputset2()
        ComboBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        DateTimePicker1.Enabled = True
        notif.Text = ""
    End Sub

    Sub combo1()
        ComboBox1.Items.Clear()
        Try
            query = "select kd_barang from barang_detail"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            While dtr.Read()
                ComboBox1.Items.Add(dtr("kd_barang"))
            End While
            dtr.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub combo2()
        ComboBox1.Items.Clear()
        Try
            query = "select no_masuk from barang_masuk"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            While dtr.Read()
                ComboBox1.Items.Add(dtr("no_masuk"))
            End While
            dtr.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub cari1()
        Try
            query = "select nama_brg from barang_detail where kd_barang='" & ComboBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader()
            If dtr.Read = True Then
                TextBox2.Text = dtr("nama_brg").ToString()
                ComboBox1.Enabled = False
                DateTimePicker1.Enabled = True
                TextBox3.Enabled = True
            Else
                notif.Text = "Data tidak ditemukan"
            End If
            dtr.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub cari2()
        Try
            query = "select kd_barang from barang_masuk where no_masuk='" & ComboBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader()
            If dtr.Read = True Then
                TextBox2.Text = dtr("kd_barang").ToString()
                ComboBox1.Enabled = False
                DateTimePicker1.Enabled = True
                TextBox3.Enabled = True
            Else
                notif.Text = "Data tidak ditemukan"
            End If
            dtr.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub


    Sub inputan()
        Try
            Dim usr As String
            query = "select iduser from user where username='" & TextBox4.Text & "'"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            dtr.Read()
            usr = dtr("iduser").ToString()
            dtr.Close()

            query = "insert into barang_masuk values('','" & ComboBox1.Text & "'," _
                & "'" & DateTimePicker1.Text & "','" & TextBox3.Text & "','" _
                & usr & "')"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub edit()
        Try
            query = "update barang_masuk set kd_barang='" & TextBox2.Text & "', tgl_masuk=" _
            & "'" & DateTimePicker1.Text & "', jumlah='" & TextBox3.Text & "' " _
            & "where no_masuk='" & ComboBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        
    End Sub

    Sub delete()
        
    End Sub


    Private Sub brgmasuk_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        home.Enabled = True
    End Sub


    Private Sub brgmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        TextBox4.Text = user
        inputset()
        dgv.Hide()
        koneksi()
        combo1()
    End Sub

    Private Sub lihat_Click(sender As Object, e As EventArgs) Handles lihat.Click
        tampil()
        If lihat.Text = "Show" Then
            dgv.Show()
            lihat.Text = "Hide"
        ElseIf lihat.Text = "Hide" Then
            dgv.Hide()
            lihat.Text = "Show"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Kode Barang"
        Label3.Text = "Nama Barang"
        GroupBox1.Text = "Form Input"
        inputset()
        combo1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "Nomor Masuk"
        Label3.Text = "Kode Barang"
        GroupBox1.Text = "Form Edit"
        inputset()
        combo2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inputset()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Visible = False
        dgv.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If GroupBox1.Text = "Form Input" Then
            cari1()
        ElseIf GroupBox1.Text = "Form Edit" Then
            cari2()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or DateTimePicker1.Text = "" Then
            notif.Text = "Form tidak boleh ada yang kosong"
        ElseIf GroupBox1.Text = "Form Input" Then
            inputan()
            tampil()
            inputset()
            notif.Text = "Data berhasil di input"
        ElseIf GroupBox1.Text = "Form Edit" Then
            edit()
            tampil()
            inputset()
            notif.Text = "Data berhasil di edit"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nom As String
        nom = InputBox("Masukan no masuk yang akan dihapus", "Input")
        Try
            query = "delete from barang_masuk where no_masuk='" & nom & "'"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        tampil()
    End Sub

End Class