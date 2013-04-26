Public Class MainForm

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        Game.Show()
        Me.Hide()
    End Sub
End Class