Imports System.Data.SqlClient
Public Class fact
    Dim constring As String = "Data Source=MAROUANETAH\SQLEXPRESS;Initial Catalog=rest;Integrated Security=True"
    Private Sub fact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(930, 0)
        tb1.Text = "0"
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Dim p As Integer

        If lb1.SelectedItems.Count > 0 Then
            p = lb1.GetItemText(lb1.SelectedIndex)
            lb1.Items.Remove(lb1.SelectedItem)
            For i = p To p
                lb2.Items.RemoveAt(p)
            Next

        Else

            MsgBox("May you chose a sandwish ;)")

        End If

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        If MsgBox("ARe you sure you want to clear the list ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            lb1.Items.Clear()
            lb2.Items.Clear()
            tb1.Text = "0"
        End If

    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click
        Dim daten As String
        Dim total As Double
        Dim tt As Double
        daten = FormatDateTime(Now, DateFormat.ShortDate)
        For i As Integer = 0 To lb2.Items.Count - 1
            total += Val(lb2.Items.Item(i).ToString)
        Next

        tb1.Text = total.ToString
        tt = Val(tb1.Text)
        prixt += tt

        Dim cnn As SqlConnection
        cnn = New SqlConnection(constring)
        Dim cmd As New SqlCommand
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandText = "update fact set totalj = '" & prixt & "' where datej = '" & daten & "' and noms = '" & cmpt & "'  "
        cmd.ExecuteNonQuery()

    End Sub
End Class