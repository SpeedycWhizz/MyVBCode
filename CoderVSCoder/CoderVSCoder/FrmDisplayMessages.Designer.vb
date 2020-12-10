<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDisplayMessages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDisplayMessages))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DisplaySystemMessage = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.LBLSystemMessages = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.DisplaySystemMessage)
        Me.Panel1.Location = New System.Drawing.Point(4, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 187)
        Me.Panel1.TabIndex = 1
        '
        'DisplaySystemMessage
        '
        Me.DisplaySystemMessage.BackColor = System.Drawing.Color.LightBlue
        Me.DisplaySystemMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySystemMessage.Location = New System.Drawing.Point(7, 10)
        Me.DisplaySystemMessage.Name = "DisplaySystemMessage"
        Me.DisplaySystemMessage.Size = New System.Drawing.Size(311, 168)
        Me.DisplaySystemMessage.TabIndex = 0
        Me.DisplaySystemMessage.Text = "Display System Messages"
        Me.DisplaySystemMessage.UseVisualStyleBackColor = False
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(4, 230)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(326, 30)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'LBLSystemMessages
        '
        Me.LBLSystemMessages.AutoSize = True
        Me.LBLSystemMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSystemMessages.Location = New System.Drawing.Point(11, 7)
        Me.LBLSystemMessages.Name = "LBLSystemMessages"
        Me.LBLSystemMessages.Size = New System.Drawing.Size(139, 20)
        Me.LBLSystemMessages.TabIndex = 3
        Me.LBLSystemMessages.Text = "System Messages"
        '
        'FrmDisplayMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(334, 272)
        Me.Controls.Add(Me.LBLSystemMessages)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDisplayMessages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DisplaySystemMessage As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents LBLSystemMessages As Label
End Class
