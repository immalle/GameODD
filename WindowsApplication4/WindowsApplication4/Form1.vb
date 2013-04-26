Public Class frmScore


    Sub SlaScoreOp()
        Dim bestandpad As String = "D:\5I\SO De Doncker Toon\GitHub\GameODD\WindowsApplication4\WindowsApplication4\Highscores.txt"
        Dim bestaandeTekst As String
        Dim reader As New System.IO.StreamReader(bestandpad)
        bestaandeTekst = reader.ReadToEnd
        reader.Close()
        Dim writer As New System.IO.StreamWriter(bestandpad)
        writer.Write(rtxtScore.Text)
        writer.Close()
        MessageBox.Show("Uw score is succesvol opgeslagen!")

    End Sub

    'http://social.msdn.microsoft.com/Forums/en-US/vbgeneral/thread/b926a443-13ec-4bb7-a662-b36267f1474d/

    Sub LaadScores()
        Dim reader As New System.IO.StreamReader(Application.StartupPath.Remove(Application.StartupPath.Length - 9) & "Highscores.txt")
        rtxtScore.Text = reader.ReadToEnd
        reader.Close()
    End Sub
   

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmScore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblNaam.Text = Game.naam
        lblScore.Text = Game.score
        rtxtScore.Text = My.Resources.Score
    End Sub

    Private Sub btnVoegToe_Click(sender As System.Object, e As System.EventArgs) Handles btnVoegToe.Click
        Dim tekst As String = rtxtScore.Text
        If tekst = "" Then
            rtxtScore.Text = tekst & "Speler " & Game.naam & " behaalde score " & Game.score & "."
        Else
            rtxtScore.Text = tekst & vbCrLf & "Speler " & Game.naam & " behaalde score " & Game.score & "."
        End If

        btnVoegToe.Visible = False
        btnNew.Visible = True
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        MainForm.Show()
        Game.Close()
        Me.Close()
    End Sub
End Class
