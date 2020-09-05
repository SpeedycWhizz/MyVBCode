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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LBxNicknames = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNicknamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditNicknamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetRandomizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LblDisplay = New System.Windows.Forms.Label()
        Me.DisplayName = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Banner = New System.Windows.Forms.Button()
        Me.TBxcopy = New System.Windows.Forms.TextBox()
        Me.CmdDisplay = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBxNicknames
        '
        Me.LBxNicknames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBxNicknames.FormattingEnabled = True
        Me.LBxNicknames.ItemHeight = 16
        Me.LBxNicknames.Location = New System.Drawing.Point(50, 46)
        Me.LBxNicknames.Name = "LBxNicknames"
        Me.LBxNicknames.Size = New System.Drawing.Size(245, 132)
        Me.LBxNicknames.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(365, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNicknamesToolStripMenuItem, Me.EditNicknamesToolStripMenuItem, Me.ResetRandomizerToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AddNicknamesToolStripMenuItem
        '
        Me.AddNicknamesToolStripMenuItem.Name = "AddNicknamesToolStripMenuItem"
        Me.AddNicknamesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AddNicknamesToolStripMenuItem.Text = "Add Nicknames"
        '
        'EditNicknamesToolStripMenuItem
        '
        Me.EditNicknamesToolStripMenuItem.Name = "EditNicknamesToolStripMenuItem"
        Me.EditNicknamesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EditNicknamesToolStripMenuItem.Text = "Edit Nicknames"
        '
        'ResetRandomizerToolStripMenuItem
        '
        Me.ResetRandomizerToolStripMenuItem.Name = "ResetRandomizerToolStripMenuItem"
        Me.ResetRandomizerToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ResetRandomizerToolStripMenuItem.Text = "Reset Randomizer"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(50, 186)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(245, 40)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "START"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'LblDisplay
        '
        Me.LblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplay.Location = New System.Drawing.Point(50, 229)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(245, 24)
        Me.LblDisplay.TabIndex = 3
        Me.LblDisplay.Text = "Your Discord Nickname Is :"
        '
        'DisplayName
        '
        Me.DisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayName.Location = New System.Drawing.Point(50, 256)
        Me.DisplayName.Name = "DisplayName"
        Me.DisplayName.Size = New System.Drawing.Size(245, 37)
        Me.DisplayName.TabIndex = 4
        Me.DisplayName.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Banner
        '
        Me.Banner.BackColor = System.Drawing.Color.DarkGreen
        Me.Banner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banner.ForeColor = System.Drawing.Color.White
        Me.Banner.Location = New System.Drawing.Point(-1, 462)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(366, 32)
        Me.Banner.TabIndex = 5
        Me.Banner.Text = "THE GREAT MACHINE - Nickname Randomizer"
        Me.Banner.UseVisualStyleBackColor = False
        '
        'TBxcopy
        '
        Me.TBxcopy.Location = New System.Drawing.Point(50, 299)
        Me.TBxcopy.Name = "TBxcopy"
        Me.TBxcopy.Size = New System.Drawing.Size(245, 20)
        Me.TBxcopy.TabIndex = 6
        '
        'CmdDisplay
        '
        Me.CmdDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDisplay.Location = New System.Drawing.Point(52, 323)
        Me.CmdDisplay.Name = "CmdDisplay"
        Me.CmdDisplay.Size = New System.Drawing.Size(242, 40)
        Me.CmdDisplay.TabIndex = 7
        Me.CmdDisplay.Text = "Use Ctrl + V To Paste Nickname"
        Me.CmdDisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpeedysNicknameRandomizer.My.Resources.Resources.Clocks
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(365, 493)
        Me.Controls.Add(Me.CmdDisplay)
        Me.Controls.Add(Me.TBxcopy)
        Me.Controls.Add(Me.Banner)
        Me.Controls.Add(Me.DisplayName)
        Me.Controls.Add(Me.LblDisplay)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LBxNicknames)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBxNicknames As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnStart As Button
    Friend WithEvents LblDisplay As Label
    Friend WithEvents DisplayName As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNicknamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Banner As Button
    Friend WithEvents TBxcopy As TextBox
    Friend WithEvents ResetRandomizerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditNicknamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CmdDisplay As Button
End Class
