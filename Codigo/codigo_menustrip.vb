-> Form 1: <-

Public Class Form1
    Private Sub IrAAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IrAAyudaToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub BackinussrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackinussrToolStripMenuItem.Click
        Process.Start("http://back-in-ussr.com")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

-> Form 2: <-

Public Class Form2
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub BtnRecomendar_Click(sender As Object, e As EventArgs) Handles BtnRecomendar.Click
        PbxLibro.Show()
    End Sub
End Class