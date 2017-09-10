Imports System.Data
Imports MySql.Data.MySqlClient

Module modul
    Public con As New MySqlConnection
    Public server As String = "Server=localhost; user=root; password=kholil;database=dbkasir"
    Public query As String
    Public cmd As New MySqlCommand
    Public dta As New MySqlDataAdapter
    Public dtr As MySqlDataReader
    Public user As String

    Public Sub koneksi()
        Dim strpath As String
        strpath = Application.StartupPath
        Try
            con = New MySqlConnection(server)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub konstat()
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        Else
            con.Open()
        End If
    End Sub
End Module
