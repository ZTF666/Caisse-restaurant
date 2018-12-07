Imports System.IO
Imports System.Data.SqlClient
Public Class Menuu

    Dim constring As String = "Data Source=MAROUANETAH\SQLEXPRESS;Initial Catalog=rest;Integrated Security=True"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fact.MdiParent = Me
        fact.Show()
        Info.MdiParent = Me
        Info.Show()



    End Sub

    Private Sub SandwichsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SandwichsToolStripMenuItem.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from sandwiches", cnn)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select count(ID) from sandwiches"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            tcount = sqlresult
            MsgBox("sandwiches table has " & tcount & " sandwiches")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("table is empty!")
        End Try

        Sandwiches.MdiParent = Me
        users.Close()
        Pizzas.Close()
        Plats.Close()
        Specials.Close()
        Saldes.Close()
        Boissons.Close()
        Glaces.Close()
        Sandwiches.Show()
    End Sub

    Private Sub PlatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlatsToolStripMenuItem.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from plats", cnn)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select count(ID) from plats"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            tcount = sqlresult
            MsgBox("Plats table has " & tcount & " Pats")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("table is empty!")
        End Try

        Plats.MdiParent = Me
        Sandwiches.Close()
        Pizzas.Close()
        users.Close()
        Specials.Close()
        Saldes.Close()
        Boissons.Close()
        Glaces.Close()
        Plats.Show()
    End Sub

    Private Sub PizzasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzasToolStripMenuItem.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from pizzas", cnn)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select count(ID) from pizzas"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            tcount = sqlresult
            MsgBox("Pizzas table has " & tcount & " Pizzas")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("table is empty!")
        End Try

        Pizzas.MdiParent = Me
        Sandwiches.Close()
        users.Close()
        Plats.Close()
        Specials.Close()
        Saldes.Close()
        Boissons.Close()
        Glaces.Close()
        Pizzas.Show()
    End Sub

    Private Sub SaladesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaladesToolStripMenuItem.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from salades", cnn)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select count(ID) from salades"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            tcount = sqlresult
            MsgBox("salades table has " & tcount & " salades")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("table is empty!")
        End Try

        Saldes.MdiParent = Me
        Sandwiches.Close()
        Pizzas.Close()
        Plats.Close()
        Specials.Close()
        users.Close()
        Boissons.Close()
        Glaces.Close()
        Saldes.Show()
    End Sub

    Private Sub SpecialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialsToolStripMenuItem.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from specials", cnn)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select count(ID) from specials"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            tcount = sqlresult
            MsgBox("specials table has " & tcount & " specials")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("table is empty!")
        End Try


        Specials.MdiParent = Me
        Sandwiches.Close()
        Pizzas.Close()
        Plats.Close()
        users.Close()
        Saldes.Close()
        Boissons.Close()
        Glaces.Close()
        Specials.Show()
    End Sub

    Private Sub BoissonsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoissonsToolStripMenuItem.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from boissons", cnn)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select count(ID) from boissons"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            tcount = sqlresult
            MsgBox("boissons table has " & tcount & " boissons")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("table is empty!")
        End Try

        Boissons.MdiParent = Me
        Sandwiches.Close()
        Pizzas.Close()
        Plats.Close()
        Specials.Close()
        Saldes.Close()
        users.Close()
        Glaces.Close()
        Boissons.Show()
    End Sub

    Private Sub GlacesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlacesToolStripMenuItem.Click
        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)

        Dim cmd As New SqlCommand("select * from glaces", cnn)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select count(ID) from glaces"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            tcount = sqlresult
            MsgBox("glaces table has " & tcount & " glaces")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("table is empty!")
        End Try

        Glaces.MdiParent = Me
        Sandwiches.Close()
        Pizzas.Close()
        Plats.Close()
        Specials.Close()
        Saldes.Close()
        Boissons.Close()
        users.Close()
        Glaces.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Application.Exit()
        End If
    End Sub

    Private Sub UersManagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UersManagToolStripMenuItem.Click


        users.MdiParent = Me
        Sandwiches.Close()
        Pizzas.Close()
        Plats.Close()
        Specials.Close()
        Saldes.Close()
        Boissons.Close()
        Glaces.Close()
        users.Show()
    End Sub
End Class
