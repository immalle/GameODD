Public Class frmScore

    Sub SchrijfScore()
        Dim writer As New System.IO.StreamWriter("C:\ODD Highscore\Highscore.txt")
        writer.Write(rtxtScore.Text)
        writer.Close()
    End Sub

    Sub LaadScores()
        Dim reader As New System.IO.StreamReader("C:\ODD Highscore\Highscore.txt")
        rtxtScore.Text = reader.ReadToEnd
        reader.Close()
    End Sub
   

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmScore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblNaam.Text = frmGame.naam
        lblScore.Text = frmGame.score
        LaadScores()
        frmGame.Hide()
    End Sub

    Private Sub btnVoegToe_Click(sender As System.Object, e As System.EventArgs) Handles btnVoegToe.Click
        Dim tekst As String = rtxtScore.Text
        If tekst = "" Then
            rtxtScore.Text = tekst & "Speler " & frmGame.naam & " behaalde score " & frmGame.score & "."
        Else
            rtxtScore.Text = tekst & vbCrLf & "Speler " & frmGame.naam & " behaalde score " & frmGame.score & "."
        End If
        SchrijfScore()
        btnVoegToe.Visible = False
        btnNew.Visible = True
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        MainForm.Show()
        frmGame.Close()
        Me.Close()
    End Sub
End Class
