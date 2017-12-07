<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnRace = New System.Windows.Forms.Button()
        Me.btnRockPaperScissors = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDistance = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(90, 96)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 37)
        Me.btnRace.TabIndex = 0
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'btnRockPaperScissors
        '
        Me.btnRockPaperScissors.Location = New System.Drawing.Point(90, 139)
        Me.btnRockPaperScissors.Name = "btnRockPaperScissors"
        Me.btnRockPaperScissors.Size = New System.Drawing.Size(75, 41)
        Me.btnRockPaperScissors.TabIndex = 1
        Me.btnRockPaperScissors.Text = "Rock Paper Scissors"
        Me.btnRockPaperScissors.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Sum of Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(90, 236)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 42)
        Me.btnSum.TabIndex = 3
        Me.btnSum.Text = "Sum Numbers"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Menu"
        '
        'btnDistance
        '
        Me.btnDistance.Location = New System.Drawing.Point(90, 284)
        Me.btnDistance.Name = "btnDistance"
        Me.btnDistance.Size = New System.Drawing.Size(75, 39)
        Me.btnDistance.TabIndex = 5
        Me.btnDistance.Text = "Distance Calculator"
        Me.btnDistance.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(90, 330)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(75, 39)
        Me.btnRandom.TabIndex = 6
        Me.btnRandom.Text = "Random Number"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 410)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnDistance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRockPaperScissors)
        Me.Controls.Add(Me.btnRace)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents btnRockPaperScissors As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDistance As System.Windows.Forms.Button
    Friend WithEvents btnRandom As System.Windows.Forms.Button
End Class
