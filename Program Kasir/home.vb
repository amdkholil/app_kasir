Imports System.Data
Imports MySql.Data.MySqlClient

Public Class home

    Private Sub home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = " | "
        ToolStripStatusLabel3.Text = "Logged on as " & user

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = FormatDateTime(Now, DateFormat.LongTime)
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        databarang.Show()
        Me.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        brgmasuk.Show()
        Me.Enabled = False
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        penjualan.Show()
        Me.Enabled = False
    End Sub
End Class