Public Class MainForm

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        frmGame.Show()
        frmScore.Close()
        Me.Hide()
    End Sub
End Class