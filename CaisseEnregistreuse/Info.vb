Imports System.Data.SqlClient
Public Class Info
    Dim constring As String = "Data Source=MAROUANETAH\SQLEXPRESS;Initial Catalog=rest;Integrated Security=True"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(930, 490)
        charger()
    End Sub

    Private Sub charger()
        If cmpt = "admin1" Or cmpt = "admin2" Then
            Dim cnn As SqlConnection
            cnn = New SqlConnection(constring)
            Dim cmd As New SqlCommand
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select * from fact"
            dr = cmd.ExecuteReader
            bs.DataSource = dr
            dr.Close()
            DataGridView1.DataSource = bs
        End If
    End Sub
End Class