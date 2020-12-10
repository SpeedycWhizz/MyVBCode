<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeleteNames
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeleteNames))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBxDeleteCodersNames = New System.Windows.Forms.ListBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDeleteFromList = New System.Windows.Forms.Button()
        Me.BtnUpdateDeletedList = New System.Windows.Forms.Button()
        Me.LBLNCR = New System.Windows.Forms.Label()
        Me.LBLNC = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Delete Coders Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBxDeleteCodersNames)
        Me.Panel1.Location = New System.Drawing.Point(12, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 218)
        Me.Panel1.TabIndex = 2
        '
        'LBxDeleteCodersNames
        '
        Me.LBxDeleteCodersNames.BackColor = System.Drawing.Color.LightBlue
        Me.LBxDeleteCodersNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBxDeleteCodersNames.FormattingEnabled = True
        Me.LBxDeleteCodersNames.ItemHeight = 20
        Me.LBxDeleteCodersNames.Location = New System.Drawing.Point(13, 16)
        Me.LBxDeleteCodersNames.Name = "LBxDeleteCodersNames"
        Me.LBxDeleteCodersNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LBxDeleteCodersNames.Size = New System.Drawing.Size(363, 184)
        Me.LBxDeleteCodersNames.TabIndex = 2
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(261, 263)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(134, 31)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnDeleteFromList
        '
        Me.BtnDeleteFromList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteFromList.Location = New System.Drawing.Point(119, 263)
        Me.BtnDeleteFromList.Name = "BtnDeleteFromList"
        Me.BtnDeleteFromList.Size = New System.Drawing.Size(134, 31)
        Me.BtnDeleteFromList.TabIndex = 6
        Me.BtnDeleteFromList.Text = "Delete From List"
        Me.BtnDeleteFromList.UseVisualStyleBackColor = True
        '
        'BtnUpdateDeletedList
        '
        Me.BtnUpdateDeletedList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateDeletedList.Location = New System.Drawing.Point(19, 263)
        Me.BtnUpdateDeletedList.Name = "BtnUpdateDeletedList"
        Me.BtnUpdateDeletedList.Size = New System.Drawing.Size(94, 31)
        Me.BtnUpdateDeletedList.TabIndex = 5
        Me.BtnUpdateDeletedList.Text = "Update"
        Me.BtnUpdateDeletedList.UseVisualStyleBackColor = True
        '
        'LBLNCR
        '
        Me.LBLNCR.AutoSize = True
        Me.LBLNCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNCR.Location = New System.Drawing.Point(163, 311)
        Me.LBLNCR.Name = "LBLNCR"
        Me.LBLNCR.Size = New System.Drawing.Size(18, 20)
        Me.LBLNCR.TabIndex = 11
        Me.LBLNCR.Text = "0"
        '
        'LBLNC
        '
        Me.LBLNC.AutoSize = True
        Me.LBLNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNC.Location = New System.Drawing.Point(12, 311)
        Me.LBLNC.Name = "LBLNC"
        Me.LBLNC.Size = New System.Drawing.Size(126, 20)
        Me.LBLNC.TabIndex = 12
        Me.LBLNC.Text = "Nickname Count"
        '
        'FrmDeleteNames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(417, 341)
        Me.Controls.Add(Me.LBLNCR)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LBLNC)
        Me.Controls.Add(Me.BtnDeleteFromList)
        Me.Controls.Add(Me.BtnUpdateDeletedList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDeleteNames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBxDeleteCodersNames As ListBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDeleteFromList As Button
    Friend WithEvents BtnUpdateDeletedList As Button
    Friend WithEvents LBLNCR As Label
    Friend WithEvents LBLNC As Label

End Class
