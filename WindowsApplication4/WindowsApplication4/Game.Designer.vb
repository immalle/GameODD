<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlSpeelveld = New System.Windows.Forms.Panel()
        Me.lblScoreInfo = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLevenInfo = New System.Windows.Forms.Label()
        Me.lblLeven = New System.Windows.Forms.Label()
        Me.lblProcent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlSpeelveld
        '
        Me.pnlSpeelveld.BackColor = System.Drawing.Color.Black
        Me.pnlSpeelveld.Location = New System.Drawing.Point(34, 12)
        Me.pnlSpeelveld.Name = "pnlSpeelveld"
        Me.pnlSpeelveld.Size = New System.Drawing.Size(638, 373)
        Me.pnlSpeelveld.TabIndex = 0
        '
        'lblScoreInfo
        '
        Me.lblScoreInfo.AutoSize = True
        Me.lblScoreInfo.Location = New System.Drawing.Point(769, 25)
        Me.lblScoreInfo.Name = "lblScoreInfo"
        Me.lblScoreInfo.Size = New System.Drawing.Size(38, 13)
        Me.lblScoreInfo.TabIndex = 1
        Me.lblScoreInfo.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(772, 53)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(31, 32)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        '
        'lblLevenInfo
        '
        Me.lblLevenInfo.AutoSize = True
        Me.lblLevenInfo.Location = New System.Drawing.Point(772, 193)
        Me.lblLevenInfo.Name = "lblLevenInfo"
        Me.lblLevenInfo.Size = New System.Drawing.Size(40, 13)
        Me.lblLevenInfo.TabIndex = 3
        Me.lblLevenInfo.Text = "Leven:"
        '
        'lblLeven
        '
        Me.lblLeven.AutoSize = True
        Me.lblLeven.Font = New System.Drawing.Font("Rockwell", 21.75!)
        Me.lblLeven.Location = New System.Drawing.Point(772, 233)
        Me.lblLeven.Name = "lblLeven"
        Me.lblLeven.Size = New System.Drawing.Size(0, 32)
        Me.lblLeven.TabIndex = 4
        '
        'lblProcent
        '
        Me.lblProcent.AutoSize = True
        Me.lblProcent.Location = New System.Drawing.Point(767, 315)
        Me.lblProcent.Name = "lblProcent"
        Me.lblProcent.Size = New System.Drawing.Size(15, 13)
        Me.lblProcent.TabIndex = 5
        Me.lblProcent.Text = "%"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 486)
        Me.Controls.Add(Me.lblProcent)
        Me.Controls.Add(Me.lblLeven)
        Me.Controls.Add(Me.lblLevenInfo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreInfo)
        Me.Controls.Add(Me.pnlSpeelveld)
        Me.Name = "frmGame"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSpeelveld As System.Windows.Forms.Panel
    Friend WithEvents lblScoreInfo As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblLevenInfo As System.Windows.Forms.Label
    Friend WithEvents lblLeven As System.Windows.Forms.Label
    Friend WithEvents lblProcent As System.Windows.Forms.Label

End Class
