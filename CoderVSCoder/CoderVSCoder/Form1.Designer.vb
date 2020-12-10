<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCodersNicknamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteNicknameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditNicknameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnReEnableStart = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DispVsHeader = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBxCodersEntered = New System.Windows.Forms.ListBox()
        Me.DispCoder2Header = New System.Windows.Forms.Button()
        Me.DispCoder1Header = New System.Windows.Forms.Button()
        Me.DspAppTitle = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBLCreatedBy = New System.Windows.Forms.Label()
        Me.LBLCopyRight = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(943, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCodersNicknamesToolStripMenuItem, Me.DeleteNicknameToolStripMenuItem, Me.EditNicknameToolStripMenuItem, Me.ReToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(82, 25)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AddCodersNicknamesToolStripMenuItem
        '
        Me.AddCodersNicknamesToolStripMenuItem.Name = "AddCodersNicknamesToolStripMenuItem"
        Me.AddCodersNicknamesToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.AddCodersNicknamesToolStripMenuItem.Text = "Add Coders Nicknames"
        '
        'DeleteNicknameToolStripMenuItem
        '
        Me.DeleteNicknameToolStripMenuItem.Name = "DeleteNicknameToolStripMenuItem"
        Me.DeleteNicknameToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.DeleteNicknameToolStripMenuItem.Text = "Delete Nicknames"
        '
        'EditNicknameToolStripMenuItem
        '
        Me.EditNicknameToolStripMenuItem.Name = "EditNicknameToolStripMenuItem"
        Me.EditNicknameToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.EditNicknameToolStripMenuItem.Text = "Edit Nickname"
        '
        'ReToolStripMenuItem
        '
        Me.ReToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ReToolStripMenuItem.Name = "ReToolStripMenuItem"
        Me.ReToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.ReToolStripMenuItem.Text = "Reset Randomizer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(253, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnReEnableStart)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DispVsHeader)
        Me.Panel1.Controls.Add(Me.BtnStart)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DispCoder2Header)
        Me.Panel1.Controls.Add(Me.DispCoder1Header)
        Me.Panel1.Controls.Add(Me.DspAppTitle)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(9, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 426)
        Me.Panel1.TabIndex = 1
        '
        'BtnReEnableStart
        '
        Me.BtnReEnableStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReEnableStart.Location = New System.Drawing.Point(296, 376)
        Me.BtnReEnableStart.Name = "BtnReEnableStart"
        Me.BtnReEnableStart.Size = New System.Drawing.Size(328, 31)
        Me.BtnReEnableStart.TabIndex = 9
        Me.BtnReEnableStart.Text = "Re-Enable Start"
        Me.BtnReEnableStart.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(630, 122)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(275, 285)
        Me.Panel4.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 285)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DisplayCoders2Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(15, 122)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(275, 285)
        Me.Panel3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 285)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DisplayCoders1Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DispVsHeader
        '
        Me.DispVsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DispVsHeader.Location = New System.Drawing.Point(296, 74)
        Me.DispVsHeader.Name = "DispVsHeader"
        Me.DispVsHeader.Size = New System.Drawing.Size(328, 77)
        Me.DispVsHeader.TabIndex = 6
        Me.DispVsHeader.Text = "Vs"
        Me.DispVsHeader.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(296, 329)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(328, 42)
        Me.BtnStart.TabIndex = 4
        Me.BtnStart.Text = "START"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LBxCodersEntered)
        Me.Panel2.Location = New System.Drawing.Point(296, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 166)
        Me.Panel2.TabIndex = 3
        '
        'LBxCodersEntered
        '
        Me.LBxCodersEntered.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBxCodersEntered.FormattingEnabled = True
        Me.LBxCodersEntered.ItemHeight = 24
        Me.LBxCodersEntered.Location = New System.Drawing.Point(15, 22)
        Me.LBxCodersEntered.Name = "LBxCodersEntered"
        Me.LBxCodersEntered.Size = New System.Drawing.Size(300, 124)
        Me.LBxCodersEntered.TabIndex = 0
        '
        'DispCoder2Header
        '
        Me.DispCoder2Header.Location = New System.Drawing.Point(630, 74)
        Me.DispCoder2Header.Name = "DispCoder2Header"
        Me.DispCoder2Header.Size = New System.Drawing.Size(275, 42)
        Me.DispCoder2Header.TabIndex = 2
        Me.DispCoder2Header.Text = "Coder 2"
        Me.DispCoder2Header.UseVisualStyleBackColor = True
        '
        'DispCoder1Header
        '
        Me.DispCoder1Header.Location = New System.Drawing.Point(15, 74)
        Me.DispCoder1Header.Name = "DispCoder1Header"
        Me.DispCoder1Header.Size = New System.Drawing.Size(275, 42)
        Me.DispCoder1Header.TabIndex = 1
        Me.DispCoder1Header.Text = "Coder 1"
        Me.DispCoder1Header.UseVisualStyleBackColor = True
        '
        'DspAppTitle
        '
        Me.DspAppTitle.Location = New System.Drawing.Point(15, 12)
        Me.DspAppTitle.Name = "DspAppTitle"
        Me.DspAppTitle.Size = New System.Drawing.Size(890, 37)
        Me.DspAppTitle.TabIndex = 0
        Me.DspAppTitle.Text = "The One Lone Coder - Coder Vs Coder Randomizer"
        Me.DspAppTitle.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'LBLCreatedBy
        '
        Me.LBLCreatedBy.AutoSize = True
        Me.LBLCreatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCreatedBy.Location = New System.Drawing.Point(12, 471)
        Me.LBLCreatedBy.Name = "LBLCreatedBy"
        Me.LBLCreatedBy.Size = New System.Drawing.Size(302, 20)
        Me.LBLCreatedBy.TabIndex = 1
        Me.LBLCreatedBy.Text = "Software Created By SpeedyOnAGoSlow"
        '
        'LBLCopyRight
        '
        Me.LBLCopyRight.AutoSize = True
        Me.LBLCopyRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCopyRight.Location = New System.Drawing.Point(705, 471)
        Me.LBLCopyRight.Name = "LBLCopyRight"
        Me.LBLCopyRight.Size = New System.Drawing.Size(226, 20)
        Me.LBLCopyRight.TabIndex = 2
        Me.LBLCopyRight.Text = "Home Made Software (c) 2020"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(943, 500)
        Me.Controls.Add(Me.LBLCopyRight)
        Me.Controls.Add(Me.LBLCreatedBy)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DispCoder1Header As Button
    Friend WithEvents DspAppTitle As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DispCoder2Header As Button
    Friend WithEvents BtnStart As Button
    Friend WithEvents DispVsHeader As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBxCodersEntered As ListBox
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddCodersNicknamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBLCreatedBy As Label
    Friend WithEvents LBLCopyRight As Label
    Friend WithEvents BtnReEnableStart As Button
    Friend WithEvents DeleteNicknameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditNicknameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
