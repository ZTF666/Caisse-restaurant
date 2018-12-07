Imports System.Data.SqlClient
Public Class users
    Dim constring As String = "Data Source=MAROUANETAH\SQLEXPRESS;Initial Catalog=rest;Integrated Security=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmpt = "admin1" Or cmpt = "admin2" Then

            Dim cnn As SqlConnection
            cnn = New SqlConnection(constring)
            Dim cmd As New SqlCommand
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "insert into users (usr,password) values ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            cmd.ExecuteNonQuery()
            cnn.Close()
            MsgBox("done!")
            charger()
        End If

    End Sub

    Private Sub charger()
        If cmpt = "admin1" Or cmpt = "admin2" Then
            Dim cnn As SqlConnection
            cnn = New SqlConnection(constring)
            Dim cmd As New SqlCommand
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select * from users"
            dr = cmd.ExecuteReader
            bs1.DataSource = dr
            dr.Close()
            DataGridView2.DataSource = bs1
        End If
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        charger()
        Me.Location = New Point(0, 0)
        If cmpt = "admin1" Or cmpt = "admin2" Then
            Button1.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmpt = "admin1" Or cmpt = "admin2" Then
            Dim cnn As SqlConnection
            cnn = New SqlConnection(constring)
            Dim cmd As New SqlCommand
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "delete from users where usr = '" & TextBox1.Text & "' "
            cmd.ExecuteNonQuery()
            cnn.Close()
            MsgBox("done!")
            charger()
        End If

    End Sub
End Class