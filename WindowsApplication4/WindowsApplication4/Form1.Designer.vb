<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScore
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
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnVoegToe = New System.Windows.Forms.Button()
        Me.rtxtScore = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(12, 9)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(59, 13)
        Me.lblNaam.TabIndex = 1
        Me.lblNaam.Text = "'Naam hier'"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(203, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(59, 13)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "'Score hier'"
        '
        'btnVoegToe
        '
        Me.btnVoegToe.Location = New System.Drawing.Point(400, 9)
        Me.btnVoegToe.Name = "btnVoegToe"
        Me.btnVoegToe.Size = New System.Drawing.Size(75, 23)
        Me.btnVoegToe.TabIndex = 3
        Me.btnVoegToe.Text = "Voeg mij toe"
        Me.btnVoegToe.UseVisualStyleBackColor = True
        '
        'rtxtScore
        '
        Me.rtxtScore.Location = New System.Drawing.Point(12, 64)
        Me.rtxtScore.Name = "rtxtScore"
        Me.rtxtScore.ReadOnly = True
        Me.rtxtScore.Size = New System.Drawing.Size(869, 392)
        Me.rtxtScore.TabIndex = 4
        Me.rtxtScore.Text = ""
        '
        'frmScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 639)
        Me.Controls.Add(Me.rtxtScore)
        Me.Controls.Add(Me.btnVoegToe)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblNaam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmScore"
        Me.Text = "Scorelijst"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNaam As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnVoegToe As System.Windows.Forms.Button
    Friend WithEvents rtxtScore As System.Windows.Forms.RichTextBox

End Class
