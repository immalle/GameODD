Public Class frmScore


    ' Er is geen bestandspad
    'Dim bestaandeTekst As String
    'Dim reader As New System.IO.StreamReader(bestandpad)
    '    bestaandeTekst = reader.ReadToEnd
    '    reader.Close()
    'Dim writer As New System.IO.StreamWriter(bestandpad)
    '    writer.Write(nickname & ": " & Score & " op " & frmMenu.MOEILIJKHEIDSGRAAD.ToString & " in " & TijdBezigMin & ":" & TijdBezigSec & " min." & vbCrLf & bestaandeTekst)
    '    writer.Close()
    '    MessageBox.Show("Uw score is succesvol opgeslagen!")


    Sub LaadScores()
        Dim bestandpad As String = "\Highscores.txt"
        Dim reader As New System.IO.StreamReader(bestandpad)
        rtxtScore.Text = reader.ReadToEnd
        reader.Close()
    End Sub
   

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmScore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblNaam.Text = Game.naam
        lblScore.Text = Game.score


    End Sub

    Private Sub btnVoegToe_Click(sender As System.Object, e As System.EventArgs) Handles btnVoegToe.Click

        rtxtScore.Text = "Speler " & Game.naam & " behaalde score " & Game.score & "."
    End Sub
End Class
