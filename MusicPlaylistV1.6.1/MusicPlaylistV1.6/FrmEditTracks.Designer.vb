<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditTracks
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RTBEditTracks = New System.Windows.Forms.RichTextBox()
        Me.BtnEditTrackClose = New System.Windows.Forms.Button()
        Me.BtnEditUpdate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.RTBEditTracks)
        Me.Panel1.Location = New System.Drawing.Point(16, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 294)
        Me.Panel1.TabIndex = 0
        '
        'RTBEditTracks
        '
        Me.RTBEditTracks.BackColor = System.Drawing.Color.SkyBlue
        Me.RTBEditTracks.Location = New System.Drawing.Point(13, 33)
        Me.RTBEditTracks.Name = "RTBEditTracks"
        Me.RTBEditTracks.Size = New System.Drawing.Size(385, 245)
        Me.RTBEditTracks.TabIndex = 0
        Me.RTBEditTracks.TabStop = False
        Me.RTBEditTracks.Text = ""
        '
        'BtnEditTrackClose
        '
        Me.BtnEditTrackClose.Location = New System.Drawing.Point(294, 332)
        Me.BtnEditTrackClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditTrackClose.Name = "BtnEditTrackClose"
        Me.BtnEditTrackClose.Size = New System.Drawing.Size(133, 39)
        Me.BtnEditTrackClose.TabIndex = 2
        Me.BtnEditTrackClose.Text = "Close"
        Me.BtnEditTrackClose.UseVisualStyleBackColor = True
        '
        'BtnEditUpdate
        '
        Me.BtnEditUpdate.Location = New System.Drawing.Point(153, 332)
        Me.BtnEditUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditUpdate.Name = "BtnEditUpdate"
        Me.BtnEditUpdate.Size = New System.Drawing.Size(133, 39)
        Me.BtnEditUpdate.TabIndex = 3
        Me.BtnEditUpdate.Text = "Update Tracks"
        Me.BtnEditUpdate.UseVisualStyleBackColor = True
        '
        'FrmEditTracks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(443, 379)
        Me.Controls.Add(Me.BtnEditUpdate)
        Me.Controls.Add(Me.BtnEditTrackClose)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEditTracks"
        Me.Text = "FrmEditTracks"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEditTrackClose As Button
    Friend WithEvents RTBEditTracks As RichTextBox
    Friend WithEvents BtnEditUpdate As Button
End Class
