<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Race
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
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.picBillNye = New System.Windows.Forms.PictureBox()
        Me.picRunnerGuy = New System.Windows.Forms.PictureBox()
        Me.picOldrunner = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblWinner = New System.Windows.Forms.Label()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBillNye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRunnerGuy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOldrunner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Race.My.Resources.Resources.on_track
        Me.PictureBox6.Location = New System.Drawing.Point(271, -2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(362, 403)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'picBillNye
        '
        Me.picBillNye.Image = Global.Race.My.Resources.Resources.runner_3
        Me.picBillNye.Location = New System.Drawing.Point(2, 259)
        Me.picBillNye.Name = "picBillNye"
        Me.picBillNye.Size = New System.Drawing.Size(100, 118)
        Me.picBillNye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBillNye.TabIndex = 4
        Me.picBillNye.TabStop = False
        '
        'picRunnerGuy
        '
        Me.picRunnerGuy.Image = Global.Race.My.Resources.Resources.guy
        Me.picRunnerGuy.Location = New System.Drawing.Point(2, 142)
        Me.picRunnerGuy.Name = "picRunnerGuy"
        Me.picRunnerGuy.Size = New System.Drawing.Size(111, 111)
        Me.picRunnerGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRunnerGuy.TabIndex = 3
        Me.picRunnerGuy.TabStop = False
        '
        'picOldrunner
        '
        Me.picOldrunner.Image = Global.Race.My.Resources.Resources.runner_1
        Me.picOldrunner.Location = New System.Drawing.Point(2, 29)
        Me.picOldrunner.Name = "picOldrunner"
        Me.picOldrunner.Size = New System.Drawing.Size(111, 117)
        Me.picOldrunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOldrunner.TabIndex = 2
        Me.picOldrunner.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Race.My.Resources.Resources.finishline
        Me.PictureBox2.Location = New System.Drawing.Point(630, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(252, 403)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Race.My.Resources.Resources.finishline
        Me.PictureBox1.Location = New System.Drawing.Point(23, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 403)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(557, 422)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 23)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Let the Race Begin "
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(784, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(687, 422)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(231, 404)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(191, 44)
        Me.lblWinner.TabIndex = 9
        '
        'Race
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 457)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picBillNye)
        Me.Controls.Add(Me.picRunnerGuy)
        Me.Controls.Add(Me.picOldrunner)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Name = "Race"
        Me.Text = "Race"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBillNye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRunnerGuy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOldrunner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picOldrunner As System.Windows.Forms.PictureBox
    Friend WithEvents picRunnerGuy As System.Windows.Forms.PictureBox
    Friend WithEvents picBillNye As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblWinner As System.Windows.Forms.Label

End Class
