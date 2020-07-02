<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyPlaylistV15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyPlaylistV15))
        Me.PPDisplay = New System.Windows.Forms.Panel()
        Me.LblAppInfo = New System.Windows.Forms.Label()
        Me.BtnEditTrack = New System.Windows.Forms.Button()
        Me.BtnRecoverLastEntry = New System.Windows.Forms.Button()
        Me.BtnSearchMyPlaylist = New System.Windows.Forms.Button()
        Me.MyPlaylisstTrackCount = New System.Windows.Forms.Label()
        Me.LBx2SearchMyPlaylist = New System.Windows.Forms.ListBox()
        Me.BtnSortTrack = New System.Windows.Forms.Button()
        Me.LblNumberOfTracks = New System.Windows.Forms.Label()
        Me.BtnDeleteTrack = New System.Windows.Forms.Button()
        Me.BtnSaveTracks = New System.Windows.Forms.Button()
        Me.GBBotStuff = New System.Windows.Forms.GroupBox()
        Me.BotSelection = New System.Windows.Forms.CheckBox()
        Me.DisplayMessages = New System.Windows.Forms.Button()
        Me.RBnVIPBot = New System.Windows.Forms.RadioButton()
        Me.RB1MusicLiveBot = New System.Windows.Forms.RadioButton()
        Me.LblBandArt = New System.Windows.Forms.Label()
        Me.TBxBandAndTrack = New System.Windows.Forms.TextBox()
        Me.LBx1MyTrackChoice = New System.Windows.Forms.ListBox()
        Me.LblAppTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackupRecoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupPlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoverFromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveBotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PPDisplay.SuspendLayout()
        Me.GBBotStuff.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PPDisplay
        '
        Me.PPDisplay.BackColor = System.Drawing.Color.PeachPuff
        Me.PPDisplay.Controls.Add(Me.LblAppInfo)
        Me.PPDisplay.Controls.Add(Me.BtnEditTrack)
        Me.PPDisplay.Controls.Add(Me.BtnRecoverLastEntry)
        Me.PPDisplay.Controls.Add(Me.BtnSearchMyPlaylist)
        Me.PPDisplay.Controls.Add(Me.MyPlaylisstTrackCount)
        Me.PPDisplay.Controls.Add(Me.LBx2SearchMyPlaylist)
        Me.PPDisplay.Controls.Add(Me.BtnSortTrack)
        Me.PPDisplay.Controls.Add(Me.LblNumberOfTracks)
        Me.PPDisplay.Controls.Add(Me.BtnDeleteTrack)
        Me.PPDisplay.Controls.Add(Me.BtnSaveTracks)
        Me.PPDisplay.Controls.Add(Me.GBBotStuff)
        Me.PPDisplay.Controls.Add(Me.LblBandArt)
        Me.PPDisplay.Controls.Add(Me.TBxBandAndTrack)
        Me.PPDisplay.Controls.Add(Me.LBx1MyTrackChoice)
        Me.PPDisplay.Location = New System.Drawing.Point(8, 32)
        Me.PPDisplay.Name = "PPDisplay"
        Me.PPDisplay.Size = New System.Drawing.Size(406, 510)
        Me.PPDisplay.TabIndex = 3
        '
        'LblAppInfo
        '
        Me.LblAppInfo.AutoSize = True
        Me.LblAppInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAppInfo.ForeColor = System.Drawing.Color.Maroon
        Me.LblAppInfo.Location = New System.Drawing.Point(9, 488)
        Me.LblAppInfo.Name = "LblAppInfo"
        Me.LblAppInfo.Size = New System.Drawing.Size(392, 13)
        Me.LblAppInfo.TabIndex = 20
        Me.LblAppInfo.Text = "Home Made Software (c) 2020 - 2021 Created By Speedy C (SpeedyOnAGoSlow)"
        '
        'BtnEditTrack
        '
        Me.BtnEditTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditTrack.Location = New System.Drawing.Point(12, 340)
        Me.BtnEditTrack.Name = "BtnEditTrack"
        Me.BtnEditTrack.Size = New System.Drawing.Size(75, 47)
        Me.BtnEditTrack.TabIndex = 19
        Me.BtnEditTrack.Text = "Edit Track"
        Me.BtnEditTrack.UseVisualStyleBackColor = True
        '
        'BtnRecoverLastEntry
        '
        Me.BtnRecoverLastEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecoverLastEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecoverLastEntry.Location = New System.Drawing.Point(12, 268)
        Me.BtnRecoverLastEntry.Name = "BtnRecoverLastEntry"
        Me.BtnRecoverLastEntry.Size = New System.Drawing.Size(75, 66)
        Me.BtnRecoverLastEntry.TabIndex = 17
        Me.BtnRecoverLastEntry.Text = "Recover Last Entry"
        Me.BtnRecoverLastEntry.UseVisualStyleBackColor = True
        '
        'BtnSearchMyPlaylist
        '
        Me.BtnSearchMyPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchMyPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchMyPlaylist.Location = New System.Drawing.Point(15, 217)
        Me.BtnSearchMyPlaylist.Name = "BtnSearchMyPlaylist"
        Me.BtnSearchMyPlaylist.Size = New System.Drawing.Size(75, 45)
        Me.BtnSearchMyPlaylist.TabIndex = 16
        Me.BtnSearchMyPlaylist.Text = "Search For Track"
        Me.BtnSearchMyPlaylist.UseVisualStyleBackColor = True
        '
        'MyPlaylisstTrackCount
        '
        Me.MyPlaylisstTrackCount.AutoSize = True
        Me.MyPlaylisstTrackCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyPlaylisstTrackCount.Location = New System.Drawing.Point(228, 194)
        Me.MyPlaylisstTrackCount.Name = "MyPlaylisstTrackCount"
        Me.MyPlaylisstTrackCount.Size = New System.Drawing.Size(15, 16)
        Me.MyPlaylisstTrackCount.TabIndex = 14
        Me.MyPlaylisstTrackCount.Text = "0"
        '
        'LBx2SearchMyPlaylist
        '
        Me.LBx2SearchMyPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBx2SearchMyPlaylist.ForeColor = System.Drawing.Color.Black
        Me.LBx2SearchMyPlaylist.FormattingEnabled = True
        Me.LBx2SearchMyPlaylist.ItemHeight = 16
        Me.LBx2SearchMyPlaylist.Location = New System.Drawing.Point(103, 217)
        Me.LBx2SearchMyPlaylist.Name = "LBx2SearchMyPlaylist"
        Me.LBx2SearchMyPlaylist.Size = New System.Drawing.Size(288, 164)
        Me.LBx2SearchMyPlaylist.TabIndex = 13
        '
        'BtnSortTrack
        '
        Me.BtnSortTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSortTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortTrack.Location = New System.Drawing.Point(15, 148)
        Me.BtnSortTrack.Name = "BtnSortTrack"
        Me.BtnSortTrack.Size = New System.Drawing.Size(75, 45)
        Me.BtnSortTrack.TabIndex = 12
        Me.BtnSortTrack.Text = "Sort Track"
        Me.BtnSortTrack.UseVisualStyleBackColor = True
        '
        'LblNumberOfTracks
        '
        Me.LblNumberOfTracks.AutoSize = True
        Me.LblNumberOfTracks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumberOfTracks.Location = New System.Drawing.Point(105, 194)
        Me.LblNumberOfTracks.Name = "LblNumberOfTracks"
        Me.LblNumberOfTracks.Size = New System.Drawing.Size(117, 16)
        Me.LblNumberOfTracks.TabIndex = 13
        Me.LblNumberOfTracks.Text = "Number Of Tracks"
        '
        'BtnDeleteTrack
        '
        Me.BtnDeleteTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteTrack.Location = New System.Drawing.Point(15, 95)
        Me.BtnDeleteTrack.Name = "BtnDeleteTrack"
        Me.BtnDeleteTrack.Size = New System.Drawing.Size(75, 47)
        Me.BtnDeleteTrack.TabIndex = 9
        Me.BtnDeleteTrack.Text = "Delete Track"
        Me.BtnDeleteTrack.UseVisualStyleBackColor = True
        '
        'BtnSaveTracks
        '
        Me.BtnSaveTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveTracks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveTracks.Location = New System.Drawing.Point(15, 43)
        Me.BtnSaveTracks.Name = "BtnSaveTracks"
        Me.BtnSaveTracks.Size = New System.Drawing.Size(75, 46)
        Me.BtnSaveTracks.TabIndex = 8
        Me.BtnSaveTracks.Text = "Save Tracks"
        Me.BtnSaveTracks.UseVisualStyleBackColor = True
        '
        'GBBotStuff
        '
        Me.GBBotStuff.Controls.Add(Me.BotSelection)
        Me.GBBotStuff.Controls.Add(Me.DisplayMessages)
        Me.GBBotStuff.Controls.Add(Me.RBnVIPBot)
        Me.GBBotStuff.Controls.Add(Me.RB1MusicLiveBot)
        Me.GBBotStuff.Location = New System.Drawing.Point(12, 393)
        Me.GBBotStuff.Name = "GBBotStuff"
        Me.GBBotStuff.Size = New System.Drawing.Size(379, 92)
        Me.GBBotStuff.TabIndex = 7
        Me.GBBotStuff.TabStop = False
        Me.GBBotStuff.Text = "Bots"
        '
        'BotSelection
        '
        Me.BotSelection.AutoSize = True
        Me.BotSelection.Checked = True
        Me.BotSelection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BotSelection.Location = New System.Drawing.Point(3, 69)
        Me.BotSelection.Name = "BotSelection"
        Me.BotSelection.Size = New System.Drawing.Size(120, 17)
        Me.BotSelection.TabIndex = 18
        Me.BotSelection.Text = "Music Bots Enabled"
        Me.BotSelection.UseVisualStyleBackColor = True
        '
        'DisplayMessages
        '
        Me.DisplayMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayMessages.Location = New System.Drawing.Point(114, 19)
        Me.DisplayMessages.Name = "DisplayMessages"
        Me.DisplayMessages.Size = New System.Drawing.Size(245, 40)
        Me.DisplayMessages.TabIndex = 17
        Me.DisplayMessages.UseVisualStyleBackColor = True
        '
        'RBnVIPBot
        '
        Me.RBnVIPBot.AutoSize = True
        Me.RBnVIPBot.Location = New System.Drawing.Point(6, 42)
        Me.RBnVIPBot.Name = "RBnVIPBot"
        Me.RBnVIPBot.Size = New System.Drawing.Size(102, 17)
        Me.RBnVIPBot.TabIndex = 1
        Me.RBnVIPBot.Text = "V.I.P Music Live"
        Me.RBnVIPBot.UseVisualStyleBackColor = True
        '
        'RB1MusicLiveBot
        '
        Me.RB1MusicLiveBot.AutoSize = True
        Me.RB1MusicLiveBot.Checked = True
        Me.RB1MusicLiveBot.Location = New System.Drawing.Point(6, 19)
        Me.RB1MusicLiveBot.Name = "RB1MusicLiveBot"
        Me.RB1MusicLiveBot.Size = New System.Drawing.Size(76, 17)
        Me.RB1MusicLiveBot.TabIndex = 0
        Me.RB1MusicLiveBot.TabStop = True
        Me.RB1MusicLiveBot.Text = "Music Live"
        Me.RB1MusicLiveBot.UseVisualStyleBackColor = True
        '
        'LblBandArt
        '
        Me.LblBandArt.AutoSize = True
        Me.LblBandArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBandArt.Location = New System.Drawing.Point(12, 15)
        Me.LblBandArt.Name = "LblBandArt"
        Me.LblBandArt.Size = New System.Drawing.Size(85, 16)
        Me.LblBandArt.TabIndex = 2
        Me.LblBandArt.Text = "Band / Track"
        '
        'TBxBandAndTrack
        '
        Me.TBxBandAndTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBxBandAndTrack.Location = New System.Drawing.Point(103, 15)
        Me.TBxBandAndTrack.Name = "TBxBandAndTrack"
        Me.TBxBandAndTrack.Size = New System.Drawing.Size(288, 22)
        Me.TBxBandAndTrack.TabIndex = 0
        '
        'LBx1MyTrackChoice
        '
        Me.LBx1MyTrackChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBx1MyTrackChoice.FormattingEnabled = True
        Me.LBx1MyTrackChoice.ItemHeight = 16
        Me.LBx1MyTrackChoice.Location = New System.Drawing.Point(103, 43)
        Me.LBx1MyTrackChoice.Name = "LBx1MyTrackChoice"
        Me.LBx1MyTrackChoice.Size = New System.Drawing.Size(288, 148)
        Me.LBx1MyTrackChoice.TabIndex = 0
        '
        'LblAppTitle
        '
        Me.LblAppTitle.AutoSize = True
        Me.LblAppTitle.BackColor = System.Drawing.Color.Maroon
        Me.LblAppTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAppTitle.ForeColor = System.Drawing.Color.PeachPuff
        Me.LblAppTitle.Location = New System.Drawing.Point(298, 4)
        Me.LblAppTitle.Name = "LblAppTitle"
        Me.LblAppTitle.Size = New System.Drawing.Size(121, 16)
        Me.LblAppTitle.TabIndex = 21
        Me.LblAppTitle.Text = "Music Playlist V 1.5"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupRecoverToolStripMenuItem, Me.LeaveBotToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(423, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackupRecoverToolStripMenuItem
        '
        Me.BackupRecoverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupPlaylistToolStripMenuItem, Me.RecoverFromToolStripMenuItem})
        Me.BackupRecoverToolStripMenuItem.Name = "BackupRecoverToolStripMenuItem"
        Me.BackupRecoverToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.BackupRecoverToolStripMenuItem.Text = "Backup / Recover"
        '
        'BackupPlaylistToolStripMenuItem
        '
        Me.BackupPlaylistToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.BackupPlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.PeachPuff
        Me.BackupPlaylistToolStripMenuItem.Name = "BackupPlaylistToolStripMenuItem"
        Me.BackupPlaylistToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.BackupPlaylistToolStripMenuItem.Text = "Backup Playlist"
        '
        'RecoverFromToolStripMenuItem
        '
        Me.RecoverFromToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.RecoverFromToolStripMenuItem.ForeColor = System.Drawing.Color.PeachPuff
        Me.RecoverFromToolStripMenuItem.Name = "RecoverFromToolStripMenuItem"
        Me.RecoverFromToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RecoverFromToolStripMenuItem.Text = "Recover From Backup"
        '
        'LeaveBotToolStripMenuItem
        '
        Me.LeaveBotToolStripMenuItem.Name = "LeaveBotToolStripMenuItem"
        Me.LeaveBotToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.LeaveBotToolStripMenuItem.Text = "Leave Bot"
        '
        'MyPlaylistV15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(423, 552)
        Me.Controls.Add(Me.LblAppTitle)
        Me.Controls.Add(Me.PPDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MyPlaylistV15"
        Me.PPDisplay.ResumeLayout(False)
        Me.PPDisplay.PerformLayout()
        Me.GBBotStuff.ResumeLayout(False)
        Me.GBBotStuff.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PPDisplay As Panel
    Friend WithEvents LblAppTitle As Label
    Friend WithEvents LblAppInfo As Label
    Friend WithEvents BtnEditTrack As Button
    Friend WithEvents BtnRecoverLastEntry As Button
    Friend WithEvents BtnSearchMyPlaylist As Button
    Friend WithEvents MyPlaylisstTrackCount As Label
    Friend WithEvents LBx2SearchMyPlaylist As ListBox
    Friend WithEvents BtnSortTrack As Button
    Friend WithEvents LblNumberOfTracks As Label
    Friend WithEvents BtnDeleteTrack As Button
    Friend WithEvents BtnSaveTracks As Button
    Friend WithEvents GBBotStuff As GroupBox
    Friend WithEvents BotSelection As CheckBox
    Friend WithEvents DisplayMessages As Button
    Friend WithEvents RBnVIPBot As RadioButton
    Friend WithEvents RB1MusicLiveBot As RadioButton
    Friend WithEvents LblBandArt As Label
    Friend WithEvents TBxBandAndTrack As TextBox
    Friend WithEvents LBx1MyTrackChoice As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackupRecoverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupPlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoverFromToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveBotToolStripMenuItem As ToolStripMenuItem
End Class
