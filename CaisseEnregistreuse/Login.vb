Imports System.Data.SqlClient
Public Class Login

    Dim constring As String = "Data Source=MAROUANETAH\SQLEXPRESS;Initial Catalog=rest;Integrated Security=True"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prixi As Double
        Dim datei As String
        Dim connection As New SqlConnection("Data Source=MAROUANETAH\SQLEXPRESS;Initial Catalog=rest;Integrated Security=True")
        Dim command As New SqlCommand("select * from users where usr = @usr and password = @password", connection)

        command.Parameters.Add("@usr", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        prixi = 0
        datei = FormatDateTime(Now, DateFormat.ShortDate)
        If table.Rows.Count() <= 0 Then
            MsgBox("Username or password are invalid")
            Me.Close()
        Else
            MsgBox("Login Successfully")
            Me.Hide()
            cmpt = TextBox1.Text

            Dim cnn As SqlConnection
            cnn = New SqlConnection(constring)
            Dim cmd As New SqlCommand
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select * from fact where datej = '" & datei & "' and noms = '" & cmpt & "' "
            dr = cmd.ExecuteReader
            If dr.Read Then
                dr.Close()
                Menuu.Show()

            Else
                dr.Close()
                cmd.CommandText = "insert into fact (datej,totalj,noms) values( '" & datei & "' ,'" & prixi & "','" & cmpt & "' )"
                cmd.ExecuteNonQuery()
                cnn.Close()
                Menuu.Show()
            End If

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class