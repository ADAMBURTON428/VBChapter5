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
        Me.btnCoin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(63, 32)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 0
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'btnCoin
        '
        Me.btnCoin.Location = New System.Drawing.Point(63, 88)
        Me.btnCoin.Name = "btnCoin"
        Me.btnCoin.Size = New System.Drawing.Size(75, 23)
        Me.btnCoin.TabIndex = 1
        Me.btnCoin.Text = "Coin filp"
        Me.btnCoin.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCoin)
        Me.Controls.Add(Me.btnRace)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents btnCoin As System.Windows.Forms.Button
End Class
