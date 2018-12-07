Public Class Menu

    Private Sub SandwichsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SandwichsToolStripMenuItem.Click
        Sandwiches.MdiParent = Me
        Sandwiches.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fact.MdiParent = Me
        fact.Show()
    End Sub
End Class
