Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Login

    Public Sub masuk()
        Try
            query = "select * from user where username='" & uname.Text & "' and password='" & TextBox2.Text & "'"
            cmd = New MySqlCommand(query, con)
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                user = uname.Text
                home.Show()
                Me.Hide()
                dtr.Close()
            Else
                dtr.Close()
                notif.Text = "Password atau Username yang anda masukan salah."
                bersih()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Sub bersih()
        uname.Clear()
        TextBox2.Clear()
        uname.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uname.Focus()
        koneksi()
        bersih()
        notif.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If uname.Text = "" Or TextBox2.Text = "" Then
            notif.Text = "Masukan Username dan Password anda."
        Else
            masuk()
        End If
        bersih()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
