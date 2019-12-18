<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysInfo
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
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnDisplayMessage = New System.Windows.Forms.Button()
        Me.LblSystemInfomation = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.BtnOK)
        Me.Panel1.Controls.Add(Me.BtnDisplayMessage)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 168)
        Me.Panel1.TabIndex = 0
        '
        'BtnOK
        '
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(12, 132)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(191, 23)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnDisplayMessage
        '
        Me.BtnDisplayMessage.Enabled = False
        Me.BtnDisplayMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisplayMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplayMessage.Location = New System.Drawing.Point(12, 13)
        Me.BtnDisplayMessage.Name = "BtnDisplayMessage"
        Me.BtnDisplayMessage.Size = New System.Drawing.Size(191, 112)
        Me.BtnDisplayMessage.TabIndex = 0
        Me.BtnDisplayMessage.Text = "Messages"
        Me.BtnDisplayMessage.UseVisualStyleBackColor = True
        '
        'LblSystemInfomation
        '
        Me.LblSystemInfomation.AutoSize = True
        Me.LblSystemInfomation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSystemInfomation.ForeColor = System.Drawing.Color.PeachPuff
        Me.LblSystemInfomation.Location = New System.Drawing.Point(13, 15)
        Me.LblSystemInfomation.Name = "LblSystemInfomation"
        Me.LblSystemInfomation.Size = New System.Drawing.Size(121, 16)
        Me.LblSystemInfomation.TabIndex = 1
        Me.LblSystemInfomation.Text = "System Information"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(242, 214)
        Me.Controls.Add(Me.LblSystemInfomation)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnDisplayMessage As Button
    Friend WithEvents LblSystemInfomation As Label
End Class
