<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinToss
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
        Me.btnCoinFlip = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.lblHeadScore = New System.Windows.Forms.Label()
        Me.lblTailsScore = New System.Windows.Forms.Label()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCoinFlip
        '
        Me.btnCoinFlip.Location = New System.Drawing.Point(35, 212)
        Me.btnCoinFlip.Name = "btnCoinFlip"
        Me.btnCoinFlip.Size = New System.Drawing.Size(84, 23)
        Me.btnCoinFlip.TabIndex = 0
        Me.btnCoinFlip.Text = "Toss the Coin"
        Me.btnCoinFlip.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(145, 212)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picTails
        '
        Me.picTails.Image = Global.CoinFlip.My.Resources.Resources.coin_back
        Me.picTails.Location = New System.Drawing.Point(145, 42)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(127, 142)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTails.TabIndex = 3
        Me.picTails.TabStop = False
        '
        'picHeads
        '
        Me.picHeads.Image = Global.CoinFlip.My.Resources.Resources.coin_front
        Me.picHeads.Location = New System.Drawing.Point(12, 42)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(127, 142)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeads.TabIndex = 2
        Me.picHeads.TabStop = False
        '
        'lblHeadScore
        '
        Me.lblHeadScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeadScore.Location = New System.Drawing.Point(55, 187)
        Me.lblHeadScore.Name = "lblHeadScore"
        Me.lblHeadScore.Size = New System.Drawing.Size(33, 23)
        Me.lblHeadScore.TabIndex = 4
        '
        'lblTailsScore
        '
        Me.lblTailsScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTailsScore.Location = New System.Drawing.Point(186, 186)
        Me.lblTailsScore.Name = "lblTailsScore"
        Me.lblTailsScore.Size = New System.Drawing.Size(33, 23)
        Me.lblTailsScore.TabIndex = 5
        '
        'CoinToss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblTailsScore)
        Me.Controls.Add(Me.lblHeadScore)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCoinFlip)
        Me.Name = "CoinToss"
        Me.Text = "Coin Toss"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCoinFlip As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeadScore As System.Windows.Forms.Label
    Friend WithEvents lblTailsScore As System.Windows.Forms.Label

End Class
