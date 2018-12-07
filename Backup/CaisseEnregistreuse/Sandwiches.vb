Public Class Sandwiches

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Sandwiches_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(1, 1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        prix = 23
        fact.lb1.Items.Add(Button1.Text)
        fact.lb2.Items.Add(prix)


    End Sub
End Class