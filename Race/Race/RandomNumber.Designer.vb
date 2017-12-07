<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RandomNumber
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
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblGuessWrong = New System.Windows.Forms.Label()
        Me.lblComputerGuess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(92, 178)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 0
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(80, 111)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'lblGuessWrong
        '
        Me.lblGuessWrong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGuessWrong.Location = New System.Drawing.Point(172, 217)
        Me.lblGuessWrong.Name = "lblGuessWrong"
        Me.lblGuessWrong.Size = New System.Drawing.Size(100, 23)
        Me.lblGuessWrong.TabIndex = 2
        '
        'lblComputerGuess
        '
        Me.lblComputerGuess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputerGuess.Location = New System.Drawing.Point(185, 41)
        Me.lblComputerGuess.Name = "lblComputerGuess"
        Me.lblComputerGuess.Size = New System.Drawing.Size(74, 27)
        Me.lblComputerGuess.TabIndex = 3
        '
        'RandomNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblComputerGuess)
        Me.Controls.Add(Me.lblGuessWrong)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "RandomNumber"
        Me.Text = "RandomNumber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblGuessWrong As System.Windows.Forms.Label
    Friend WithEvents lblComputerGuess As System.Windows.Forms.Label
End Class
