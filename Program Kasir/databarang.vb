Imports System.Data
Imports MySql.Data.MySqlClient
Public Class databarang

    Sub tampil()
        Dim dttbl As New DataTable
        konstat()
        Try
            query = "select * from barang_detail order by kd_barang"
            dta = New MySqlDataAdapter(query, con)
            dttbl.Clear()
            dta.Fill(dttbl)
            dgv.DataSource = dttbl
            dgvset()
            bersih()
        Catch ex As Exception
            MsgBox("TAMPIL " & ex.Message.ToString())
        End Try
    End Sub

    Sub dgvset()
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.Width = 800
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(0).Width = 120
        dgv.Columns(0).HeaderText = "Kode Barang"
        dgv.Columns(1).Width = 230
        dgv.Columns(1).HeaderText = "Nama Barang"
        dgv.Columns(2).Width = 50
        dgv.Columns(2).HeaderText = "Qty"
        dgv.Columns(3).Width = 115
        dgv.Columns(3).HeaderText = "Satuan"
        dgv.Columns(4).Width = 120
        dgv.Columns(4).HeaderText = "Harga Beli"
        dgv.Columns(5).Width = 120
        dgv.Columns(5).HeaderText = "Harga Jual"
    End Sub

    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.Text = ""
    End Sub

    Sub updatemode()
        GroupBox1.Visible = True
        GroupBox1.Text = "Update Data"
        TextBox1.Enabled = True
        TextBox1.Focus()
        TextBox1.Select()
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False
        Button7.Visible = True
        Button8.Text = "Update"
        bersih()
    End Sub

    Sub inputmode()
        GroupBox1.Visible = True
        GroupBox1.Text = "Input Data"
        TextBox1.Enabled = True
        TextBox1.Focus()
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
        Button7.Visible = False
        Button8.Text = "Submit"
        bersih()
    End Sub


    Sub inputbarang()
        Try
            query = "insert into barang_detail values('" & TextBox1.Text & "'," _
                & "'" & TextBox2.Text & "','" & TextBox3.Text & "','" _
                & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()

            tampil()
            bersih()
            notif.Text = "Data telah berhasil dimasukan"
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub updatebarang()
        Try
            query = "update barang_detail set nama_brg='" & TextBox2.Text & "', jumlah='" & TextBox3.Text _
                & "', satuan='" & ComboBox1.Text & "', harga_beli='" & TextBox4.Text & "', " _
                & "harga_jual='" & TextBox5.Text & "' where kd_barang='" & TextBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            tampil()
            notif.Text = "Data berhasil dirubah"
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub cari()
        Try
            query = "select * from barang_detail where kd_barang like '" & TextBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                TextBox1.Enabled = False
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                TextBox4.Enabled = True
                TextBox5.Enabled = True
                ComboBox1.Enabled = True
                TextBox2.Text = dtr("nama_brg").ToString()
                TextBox3.Text = dtr("jumlah").ToString()
                ComboBox1.Text = dtr("satuan").ToString()
                TextBox4.Text = dtr("harga_beli").ToString()
                TextBox5.Text = dtr("harga_jual").ToString()
                dtr.Close()
            Else
                notif.Text = "data tidak ditemukan"
                TextBox1.Clear()
                dtr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub hapus()
        Dim inputan As String
        Try
            inputan = InputBox("Masukan kode barang yang akan dihapus", "Konfirmasi Penghapusan")
            If inputan <> "" Then
                If MsgBox("Yakin akan menghapus data dengan kode barang " & inputan & " ???", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    query = "delete from barang_detail where kd_barang='" & inputan & "'"
                    cmd = New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil dihapus", vbOKOnly, "Pemberitahuan")
                End If
            End If
            tampil()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Sub pencarian()
        Dim search As String
        Dim dttbl As New DataTable
        Try
            search = InputBox("Masukan kunci pencarian", "Pencarian")
            query = "select * from barang_detail where kd_barang like '%" & search & "%' " _
                & "or nama_brg like '%" & search & "%' " _
                & "or satuan like '%" & search & "%' " _
                & "or jumlah like '%" & search & "%' " _
                & "or harga_beli like '%" & search & "%' " _
                & "or harga_jual like '%" & search & "%'"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                dtr.Close()
                dta = New MySqlDataAdapter(cmd)
                dttbl.Clear()
                dta.Fill(dttbl)
                dgv.DataSource = dttbl
            Else
                dtr.Close()
                MsgBox("Data pencarian tidak ditemukan", vbOKOnly, "Pemberitahuan")
            End If
        Catch ex As Exception
            MsgBox("cari " & ex.Message.ToString())
        End Try
    End Sub


    Private Sub databarang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        home.Enabled = True
    End Sub

    Private Sub databarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        GroupBox1.Visible = False
        notif.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        notif.Text = ""
        If Button8.Text = "Update" Then
            updatemode()
        ElseIf Button8.Text = "Submit" Then
            inputmode()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        notif.Text = ""
        inputmode()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        notif.Text = ""
        updatemode()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Visible = False
        hapus()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" _
                Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            notif.Text = "Pastikan tidak ada yang kosong"
        ElseIf GroupBox1.Text = "Input Data" And Button8.Text = "Submit" Then
            inputbarang()
            tampil()
            notif.Text = "Data berhasil disimpan"
        ElseIf GroupBox1.Text = "Update Data" And Button8.Text = "Update" Then
            updatebarang()
            updatemode()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Visible = False
        tampil()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cari()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Visible = False
        pencarian()
    End Sub
End Class