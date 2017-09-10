Imports System.Data
Imports MySql.Data.MySqlClient
Public Class penjualan
    Dim dttbl As New DataTable
    Dim dts As New DataSet
    Dim dvm As DataViewManager
    Dim dv As DataView

    Sub setdgv()
        dgv.EditMode = DataGridViewEditMode.EditOnF2
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Width = 700
        dgv.Columns(0).Width = 30
        dgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(1).Width = 100
        dgv.Columns(2).Width = 220
        dgv.Columns(3).Width = 60
        dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(4).Width = 120
        dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(5).Width = 120
        dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        TextBox3.Enabled = False
    End Sub

    Sub bersih()
        ComboBox1.SelectedValue = ""
        TextBox2.Clear()
        TextBox3.Clear()
        notif.Text = ""
        dgv.Rows.Clear()
    End Sub

    Sub hitung()
        Dim total = Aggregate row As DataGridViewRow In dgv.Rows _
                    Into Sum(Convert.ToDouble(row.Cells(6).Value))
        TextBox3.Text = "Rp. " + Format(total, "###,###.00")
    End Sub


    Sub simpan()
        Dim query1, query2 As String
        Dim nojual As Integer
        Dim tgl As String = Format(Now, "yyyy-MM-dd")
        Dim total = Aggregate row As DataGridViewRow In dgv.Rows _
                    Into Sum(Convert.ToDouble(row.Cells(6).Value))
        Try
            query = "select no_jual from penjualan order by no_jual desc limit 1"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            dtr.Read()
            nojual = Val(dtr("no_jual")) + 1
            dtr.Close()

            query1 = "Insert into penjualan values('" & nojual & "', '" & tgl & "'" _
                    & ",'" & total & "', '" & user & "')"
            cmd = New MySqlCommand(query1, con)
            cmd.ExecuteNonQuery()

            For bar As Integer = 0 To dgv.Rows.Count - 2
                query2 = "insert into barang_keluar values('', '" & nojual & "'," _
                    & "'" & dgv.Rows(bar).Cells(1).Value & "', '" & dgv.Rows(bar).Cells(3).Value & "')"
                cmd = New MySqlCommand(query2, con)
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception

        End Try

    End Sub


    Sub trans()
        Try
            query = "select nama_brg, harga_jual from barang_detail where kd_barang='" & ComboBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            Dim jmlh As Integer = Val(TextBox2.Text)
            If dtr.Read = True And jmlh <> 0 Then
                notif.Text = ""
                dgv.Rows.Add(1)
                Dim bar As Integer = dgv.Rows.Count - 2
                dgv.Rows(bar).Cells(0).Value = CStr(dgv.Rows.Count - 1)
                dgv.Rows(bar).Cells(1).Value = ComboBox1.Text
                dgv.Rows(bar).Cells(2).Value = dtr("nama_brg")
                dgv.Rows(bar).Cells(3).Value = jmlh
                dgv.Rows(bar).Cells(4).Value = "Rp. " + Format(dtr("harga_jual"), "###,###.00")
                dgv.Rows(bar).Cells(5).Value = "Rp. " + Format(dtr("harga_jual") * jmlh, "###,###.00")
                dgv.Rows(bar).Cells(6).Value = dtr("harga_jual") * jmlh
            ElseIf dtr.Read = False Then
                notif.Text = "Data tidak ditemukan"
            ElseIf jmlh = 0 Then
                notif.Text = "Masukan jumalah dengan benar"
            End If
            dtr.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Sub alist()
        query = "select kd_barang from barang_detail order by kd_barang asc"
        dta = New MySqlDataAdapter(query, con)
        dta.Fill(dts, "barang_detail")
        dvm = New DataViewManager(dts)
        dv = dvm.CreateDataView(dts.Tables("barang_detail"))

        For Each DataRow In dts.Tables(0).Rows

        Next

    End Sub

    Private Sub penjualan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        home.Enabled = True
    End Sub


    Private Sub penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setdgv()
        koneksi()
        alist()
        notif.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        trans()
        hitung()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bersih()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class