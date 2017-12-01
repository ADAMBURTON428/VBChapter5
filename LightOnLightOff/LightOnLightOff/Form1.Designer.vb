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
        Me.picLightOff = New System.Windows.Forms.PictureBox()
        Me.picLightOn = New System.Windows.Forms.PictureBox()
        Me.btnLightSwitch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLightOff
        '
        Me.picLightOff.Image = Global.LightOnLightOff.My.Resources.Resources.lights_off
        Me.picLightOff.Location = New System.Drawing.Point(289, 35)
        Me.picLightOff.Name = "picLightOff"
        Me.picLightOff.Size = New System.Drawing.Size(142, 118)
        Me.picLightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLightOff.TabIndex = 1
        Me.picLightOff.TabStop = False
        '
        'picLightOn
        '
        Me.picLightOn.Image = Global.LightOnLightOff.My.Resources.Resources.lights_on
        Me.picLightOn.Location = New System.Drawing.Point(72, 35)
        Me.picLightOn.Name = "picLightOn"
        Me.picLightOn.Size = New System.Drawing.Size(100, 118)
        Me.picLightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLightOn.TabIndex = 0
        Me.picLightOn.TabStop = False
        '
        'btnLightSwitch
        '
        Me.btnLightSwitch.Location = New System.Drawing.Point(97, 211)
        Me.btnLightSwitch.Name = "btnLightSwitch"
        Me.btnLightSwitch.Size = New System.Drawing.Size(75, 23)
        Me.btnLightSwitch.TabIndex = 2
        Me.btnLightSwitch.Text = "Light Switch"
        Me.btnLightSwitch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(356, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTimes
        '
        Me.lblTimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimes.Location = New System.Drawing.Point(250, 279)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(125, 23)
        Me.lblTimes.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "How many time you turn on the light."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 325)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimes)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLightSwitch)
        Me.Controls.Add(Me.picLightOff)
        Me.Controls.Add(Me.picLightOn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLightOn As System.Windows.Forms.PictureBox
    Friend WithEvents picLightOff As System.Windows.Forms.PictureBox
    Friend WithEvents btnLightSwitch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTimes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
