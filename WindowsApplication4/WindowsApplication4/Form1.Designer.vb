<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
        Me.lsv = New System.Windows.Forms.ListView
        Me.Naam = New System.Windows.Forms.ColumnHeader
        Me.Score = New System.Windows.Forms.ColumnHeader
        Me.Tijd = New System.Windows.Forms.ColumnHeader
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnRestart = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.lblLevens = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lsv
        '
        Me.lsv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Naam, Me.Score, Me.Tijd})
        Me.lsv.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lsv.Location = New System.Drawing.Point(0, 41)
        Me.lsv.Name = "lsv"
        Me.lsv.Size = New System.Drawing.Size(945, 597)
        Me.lsv.TabIndex = 0
        Me.lsv.UseCompatibleStateImageBehavior = False
        Me.lsv.View = System.Windows.Forms.View.Details
        '
        'Naam
        '
        Me.Naam.Text = "Naam"
        Me.Naam.Width = 431
        '
        'Score
        '
        Me.Score.Text = "Score"
        Me.Score.Width = 282
        '
        'Tijd
        '
        Me.Tijd.Text = "Tijd"
        Me.Tijd.Width = 852
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Voeg toe"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(861, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Sluiten"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(780, 12)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 3
        Me.btnRestart.Text = "Herstarten"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(699, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblLevens
        '
        Me.lblLevens.AutoSize = True
        Me.lblLevens.Location = New System.Drawing.Point(337, 13)
        Me.lblLevens.Name = "lblLevens"
        Me.lblLevens.Size = New System.Drawing.Size(39, 13)
        Me.lblLevens.TabIndex = 5
        Me.lblLevens.Text = "Label1"
        Me.lblLevens.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 639)
        Me.Controls.Add(Me.lblLevens)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lsv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Scorelijst"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv As System.Windows.Forms.ListView
    Friend WithEvents Naam As System.Windows.Forms.ColumnHeader
    Friend WithEvents Score As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tijd As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblLevens As System.Windows.Forms.Label

End Class
