<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCodersNames
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddCodersNames))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBxAddCodersNames = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBxEntCodersName = New System.Windows.Forms.TextBox()
        Me.BtnSaveList = New System.Windows.Forms.Button()
        Me.BtnAddToList = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LBLNCR = New System.Windows.Forms.Label()
        Me.LBLNC = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Coders Nicknames"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBxAddCodersNames)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TBxEntCodersName)
        Me.Panel1.Location = New System.Drawing.Point(12, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 266)
        Me.Panel1.TabIndex = 1
        '
        'LBxAddCodersNames
        '
        Me.LBxAddCodersNames.BackColor = System.Drawing.Color.LightBlue
        Me.LBxAddCodersNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBxAddCodersNames.FormattingEnabled = True
        Me.LBxAddCodersNames.ItemHeight = 20
        Me.LBxAddCodersNames.Location = New System.Drawing.Point(16, 62)
        Me.LBxAddCodersNames.Name = "LBxAddCodersNames"
        Me.LBxAddCodersNames.Size = New System.Drawing.Size(363, 184)
        Me.LBxAddCodersNames.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coder's Nickname :"
        '
        'TBxEntCodersName
        '
        Me.TBxEntCodersName.BackColor = System.Drawing.Color.LightBlue
        Me.TBxEntCodersName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBxEntCodersName.Location = New System.Drawing.Point(163, 20)
        Me.TBxEntCodersName.Name = "TBxEntCodersName"
        Me.TBxEntCodersName.Size = New System.Drawing.Size(216, 26)
        Me.TBxEntCodersName.TabIndex = 0
        Me.TBxEntCodersName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSaveList
        '
        Me.BtnSaveList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveList.Location = New System.Drawing.Point(16, 311)
        Me.BtnSaveList.Name = "BtnSaveList"
        Me.BtnSaveList.Size = New System.Drawing.Size(94, 31)
        Me.BtnSaveList.TabIndex = 2
        Me.BtnSaveList.Text = "Save List"
        Me.BtnSaveList.UseVisualStyleBackColor = True
        '
        'BtnAddToList
        '
        Me.BtnAddToList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddToList.Location = New System.Drawing.Point(116, 311)
        Me.BtnAddToList.Name = "BtnAddToList"
        Me.BtnAddToList.Size = New System.Drawing.Size(134, 31)
        Me.BtnAddToList.TabIndex = 3
        Me.BtnAddToList.Text = "Add To List"
        Me.BtnAddToList.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(257, 311)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(134, 31)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(257, 348)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(134, 31)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LBLNCR
        '
        Me.LBLNCR.AutoSize = True
        Me.LBLNCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNCR.Location = New System.Drawing.Point(198, 351)
        Me.LBLNCR.Name = "LBLNCR"
        Me.LBLNCR.Size = New System.Drawing.Size(18, 20)
        Me.LBLNCR.TabIndex = 6
        Me.LBLNCR.Text = "0"
        '
        'LBLNC
        '
        Me.LBLNC.AutoSize = True
        Me.LBLNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNC.Location = New System.Drawing.Point(8, 353)
        Me.LBLNC.Name = "LBLNC"
        Me.LBLNC.Size = New System.Drawing.Size(184, 20)
        Me.LBLNC.TabIndex = 7
        Me.LBLNC.Text = "Coder's Nickname Count"
        '
        'FrmAddCodersNames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(417, 388)
        Me.Controls.Add(Me.LBLNCR)
        Me.Controls.Add(Me.LBLNC)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAddToList)
        Me.Controls.Add(Me.BtnSaveList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddCodersNames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBxAddCodersNames As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBxEntCodersName As TextBox
    Friend WithEvents BtnSaveList As Button
    Friend WithEvents BtnAddToList As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LBLNCR As Label
    Friend WithEvents LBLNC As Label
End Class
