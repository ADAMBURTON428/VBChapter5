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
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.cboPlays = New System.Windows.Forms.ComboBox()
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cboCountry.Location = New System.Drawing.Point(120, 36)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(121, 21)
        Me.cboCountry.TabIndex = 0
        '
        'cboPlays
        '
        Me.cboPlays.FormattingEnabled = True
        Me.cboPlays.Items.AddRange(New Object() {"Hamlet", "Much Ado about Nothing", "Rameo and Juliet ", "A Comedy of Errors", "The  Merchant of Venice"})
        Me.cboPlays.Location = New System.Drawing.Point(120, 63)
        Me.cboPlays.Name = "cboPlays"
        Me.cboPlays.Size = New System.Drawing.Size(121, 21)
        Me.cboPlays.TabIndex = 1
        '
        'cboArtist
        '
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtist.Location = New System.Drawing.Point(120, 90)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(121, 21)
        Me.cboArtist.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose a Country"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose a play"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Choose an artist"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArtist)
        Me.GroupBox1.Controls.Add(Me.lblPlay)
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Location = New System.Drawing.Point(313, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 160)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Location = New System.Drawing.Point(22, 41)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(142, 23)
        Me.lblCountry.TabIndex = 0
        '
        'lblPlay
        '
        Me.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlay.Location = New System.Drawing.Point(22, 73)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(142, 23)
        Me.lblPlay.TabIndex = 1
        '
        'lblArtist
        '
        Me.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArtist.Location = New System.Drawing.Point(22, 106)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(145, 23)
        Me.lblArtist.TabIndex = 2
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(82, 195)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 44)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "Show Selection"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(182, 195)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 44)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 44)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboArtist)
        Me.Controls.Add(Me.cboPlays)
        Me.Controls.Add(Me.cboCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlays As System.Windows.Forms.ComboBox
    Friend WithEvents cboArtist As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArtist As System.Windows.Forms.Label
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
