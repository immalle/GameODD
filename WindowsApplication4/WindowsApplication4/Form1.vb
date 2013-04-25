Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim naam As String
        Dim score As Integer
        Dim tijd As DateTime
        Dim item As New ListViewItem
        naam = InputBox("Geef je naam op: ", "Add new score")
        tijd = System.DateTime.Now

        item = lsv.Items.Add(naam)
        item.SubItems.Add(score.ToString)
        item.SubItems.Add(tijd.ToString)

        lsv.Sort()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim levenstest As Integer
        levenstest = Integer.Parse(InputBox("Levens?"))
        lblLevens.Text = levenstest.ToString
        Game.Show()
        btnStart.Visible = False

    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        Game.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
