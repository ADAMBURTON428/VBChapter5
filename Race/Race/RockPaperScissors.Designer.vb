<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissors
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
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnScissors
        '
        Me.btnScissors.Location = New System.Drawing.Point(75, 52)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(75, 23)
        Me.btnScissors.TabIndex = 0
        Me.btnScissors.Text = "Scissors"
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Location = New System.Drawing.Point(75, 97)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(75, 23)
        Me.btnPaper.TabIndex = 1
        Me.btnPaper.Text = "Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.Location = New System.Drawing.Point(75, 145)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(75, 23)
        Me.btnRock.TabIndex = 2
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(222, 78)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(92, 57)
        Me.lblResult.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(233, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWins
        '
        Me.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWins.Location = New System.Drawing.Point(95, 213)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(100, 23)
        Me.lblWins.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Wins"
        '
        'RockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnScissors)
        Me.Name = "RockPaperScissors"
        Me.Text = "RockPaperScissors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
