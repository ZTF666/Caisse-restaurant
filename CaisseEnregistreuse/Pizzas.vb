Imports System.IO
Imports System.Data.SqlClient

Public Class Pizzas

    Dim constring As String = "Data Source=MAROUANETAH\SQLEXPRESS;Initial Catalog=rest;Integrated Security=True"



    Private Sub Pizzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Location = New Point(0, 0)

        If cmpt = "admin1" Or cmpt = "admin2" Then
            GB1.Visible = True
        Else
            GB1.Visible = False
        End If

        Dim cnn As SqlConnection

        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from pizzas", cnn)
        Dim table As New DataTable()

        Dim adapter As New SqlDataAdapter(cmd)

        adapter.Fill(table)

        Dim buttons() As Control = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20, Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30}
        For i = 0 To tcount - 1
            buttons(i).Show()
            Dim img() As Byte
            img = table.Rows(i)(2)
            Dim ms As New MemoryStream(img)
            buttons(i).BackgroundImage = New Bitmap(Image.FromStream(ms))
            px = Val(table.Rows(i)(3).ToString())
            buttons(i).Text = table.Rows(i)(1).ToString()
        Next

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Dim con As New SqlConnection(constring)
        Dim cmd As New SqlCommand

        cmd.Connection = con

        cmd.CommandText = "insert into pizzas (Nom,Image,prix) values (@Nom,@Image,@prix)"
        If TB1.Text = "" Then
            MsgBox("donner un NOM SVP!")
        Else
            cmd.Parameters.AddWithValue("Nom", TB1.Text)
            If PictureBox1.ImageLocation <> "" Then
                cmd.Parameters.AddWithValue("Image", SqlDbType.VarBinary).Value = IO.File.ReadAllBytes(PictureBox1.ImageLocation)
            End If
            cmd.Parameters.AddWithValue("prix", Val(TB2.Text))
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("done")

            TB1.Clear()
            TB2.Clear()
            PictureBox1.ImageLocation = ""
        End If

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        PictureBox1.ImageLocation = ""
        TB1.Text = ""
        TB2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click

        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection
        Dim nom As String

        If sender Is Button1 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 1 "
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            px = sqlresult

            cmd.CommandText = "select Nom from pizzas where ID = 1"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button2 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 2 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 2"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button3 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 3 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 3"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button4 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 4 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 4"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button5 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 5 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 5"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button6 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 6 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 6"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button7 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 7 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 7"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button8 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 8 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 8"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button9 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 9 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 9"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button10 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 10 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 10"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button11 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 11 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 11"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button12 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 12 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 12"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button13 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 13 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 13"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button14 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 14 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 14"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button15 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 15 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 15"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button16 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 16 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 16"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button17 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 17 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 17"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button18 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 18 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 18"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button19 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 19 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 19"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button20 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 20"
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 20"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button21 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 21 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 21"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button22 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 22 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 22"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button23 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 23 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 23"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button24 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 24 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 24"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button25 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 25 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 25"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button26 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 26 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 26"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button27 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 27 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 27"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button28 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 28 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 28"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button29 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 29"
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 29"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        If sender Is Button30 Then
            cnn = New SqlConnection(constring)
            cnn.Open()
            cmd.Connection = cnn

            cmd.CommandText = "select prix from pizzas where ID = 30 "
            Dim sqlresultp As Object
            sqlresultp = cmd.ExecuteScalar
            px = sqlresultp

            cmd.CommandText = "select Nom from pizzas where ID = 30"
            Dim sqlresultn As Object

            sqlresultn = cmd.ExecuteScalar
            nom = sqlresultn
        End If

        fact.lb1.Items.Add(nom)
        fact.lb2.Items.Add(px)
    End Sub
End Class