<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblBandAndTrack = New System.Windows.Forms.Label()
        Me.LblCreatedBy = New System.Windows.Forms.Label()
        Me.GBxDiscordMusicBotAndExtras = New System.Windows.Forms.GroupBox()
        Me.LblBotOnOff = New System.Windows.Forms.Label()
        Me.ChBxOnOff = New System.Windows.Forms.CheckBox()
        Me.RBtnMusicLive = New System.Windows.Forms.RadioButton()
        Me.RBtnVIPMusicLive = New System.Windows.Forms.RadioButton()
        Me.LblTrackCount = New System.Windows.Forms.Label()
        Me.LblTracks = New System.Windows.Forms.Label()
        Me.BtnDeleteTracks = New System.Windows.Forms.Button()
        Me.BtnSortTracks = New System.Windows.Forms.Button()
        Me.LBxMyPlaylist = New System.Windows.Forms.ListBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BandAndTrackEntry = New System.Windows.Forms.TextBox()
        Me.PBxExit = New System.Windows.Forms.PictureBox()
        Me.PBxMini = New System.Windows.Forms.PictureBox()
        Me.LblAppName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GBxDiscordMusicBotAndExtras.SuspendLayout()
        CType(Me.PBxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.LblBandAndTrack)
        Me.Panel1.Controls.Add(Me.LblCreatedBy)
        Me.Panel1.Controls.Add(Me.GBxDiscordMusicBotAndExtras)
        Me.Panel1.Controls.Add(Me.LblTrackCount)
        Me.Panel1.Controls.Add(Me.LblTracks)
        Me.Panel1.Controls.Add(Me.BtnDeleteTracks)
        Me.Panel1.Controls.Add(Me.BtnSortTracks)
        Me.Panel1.Controls.Add(Me.LBxMyPlaylist)
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Controls.Add(Me.BandAndTrackEntry)
        Me.Panel1.Location = New System.Drawing.Point(12, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 375)
        Me.Panel1.TabIndex = 0
        '
        'LblBandAndTrack
        '
        Me.LblBandAndTrack.AutoSize = True
        Me.LblBandAndTrack.Location = New System.Drawing.Point(19, 17)
        Me.LblBandAndTrack.Name = "LblBandAndTrack"
        Me.LblBandAndTrack.Size = New System.Drawing.Size(175, 16)
        Me.LblBandAndTrack.TabIndex = 11
        Me.LblBandAndTrack.Text = "Enter Band And Track Titles"
        '
        'LblCreatedBy
        '
        Me.LblCreatedBy.AutoSize = True
        Me.LblCreatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCreatedBy.ForeColor = System.Drawing.Color.DarkRed
        Me.LblCreatedBy.Location = New System.Drawing.Point(241, 343)
        Me.LblCreatedBy.Name = "LblCreatedBy"
        Me.LblCreatedBy.Size = New System.Drawing.Size(256, 18)
        Me.LblCreatedBy.TabIndex = 10
        Me.LblCreatedBy.Text = "Home Made Software (c) 2019 - 2020"
        '
        'GBxDiscordMusicBotAndExtras
        '
        Me.GBxDiscordMusicBotAndExtras.Controls.Add(Me.LblBotOnOff)
        Me.GBxDiscordMusicBotAndExtras.Controls.Add(Me.ChBxOnOff)
        Me.GBxDiscordMusicBotAndExtras.Controls.Add(Me.RBtnMusicLive)
        Me.GBxDiscordMusicBotAndExtras.Controls.Add(Me.RBtnVIPMusicLive)
        Me.GBxDiscordMusicBotAndExtras.Location = New System.Drawing.Point(17, 228)
        Me.GBxDiscordMusicBotAndExtras.Name = "GBxDiscordMusicBotAndExtras"
        Me.GBxDiscordMusicBotAndExtras.Size = New System.Drawing.Size(162, 133)
        Me.GBxDiscordMusicBotAndExtras.TabIndex = 9
        Me.GBxDiscordMusicBotAndExtras.TabStop = False
        Me.GBxDiscordMusicBotAndExtras.Text = "Discord Music Bot"
        '
        'LblBotOnOff
        '
        Me.LblBotOnOff.AutoSize = True
        Me.LblBotOnOff.Location = New System.Drawing.Point(99, 101)
        Me.LblBotOnOff.Name = "LblBotOnOff"
        Me.LblBotOnOff.Size = New System.Drawing.Size(25, 16)
        Me.LblBotOnOff.TabIndex = 3
        Me.LblBotOnOff.Text = "On"
        '
        'ChBxOnOff
        '
        Me.ChBxOnOff.AutoSize = True
        Me.ChBxOnOff.Checked = True
        Me.ChBxOnOff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBxOnOff.Location = New System.Drawing.Point(6, 101)
        Me.ChBxOnOff.Name = "ChBxOnOff"
        Me.ChBxOnOff.Size = New System.Drawing.Size(91, 20)
        Me.ChBxOnOff.TabIndex = 2
        Me.ChBxOnOff.Text = "Messages"
        Me.ChBxOnOff.UseVisualStyleBackColor = True
        '
        'RBtnMusicLive
        '
        Me.RBtnMusicLive.AutoSize = True
        Me.RBtnMusicLive.Checked = True
        Me.RBtnMusicLive.Location = New System.Drawing.Point(9, 33)
        Me.RBtnMusicLive.Name = "RBtnMusicLive"
        Me.RBtnMusicLive.Size = New System.Drawing.Size(94, 20)
        Me.RBtnMusicLive.TabIndex = 0
        Me.RBtnMusicLive.TabStop = True
        Me.RBtnMusicLive.Text = "#Muaic-live"
        Me.RBtnMusicLive.UseVisualStyleBackColor = True
        '
        'RBtnVIPMusicLive
        '
        Me.RBtnVIPMusicLive.AutoSize = True
        Me.RBtnVIPMusicLive.Location = New System.Drawing.Point(9, 55)
        Me.RBtnVIPMusicLive.Name = "RBtnVIPMusicLive"
        Me.RBtnVIPMusicLive.Size = New System.Drawing.Size(124, 20)
        Me.RBtnVIPMusicLive.TabIndex = 1
        Me.RBtnVIPMusicLive.Text = "#V.I.P Muaic-live"
        Me.RBtnVIPMusicLive.UseVisualStyleBackColor = True
        '
        'LblTrackCount
        '
        Me.LblTrackCount.AutoSize = True
        Me.LblTrackCount.Location = New System.Drawing.Point(354, 275)
        Me.LblTrackCount.Name = "LblTrackCount"
        Me.LblTrackCount.Size = New System.Drawing.Size(15, 16)
        Me.LblTrackCount.TabIndex = 8
        Me.LblTrackCount.Text = "0"
        '
        'LblTracks
        '
        Me.LblTracks.AutoSize = True
        Me.LblTracks.Location = New System.Drawing.Point(298, 275)
        Me.LblTracks.Name = "LblTracks"
        Me.LblTracks.Size = New System.Drawing.Size(50, 16)
        Me.LblTracks.TabIndex = 7
        Me.LblTracks.Text = "Tracks"
        '
        'BtnDeleteTracks
        '
        Me.BtnDeleteTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteTracks.Location = New System.Drawing.Point(397, 228)
        Me.BtnDeleteTracks.Name = "BtnDeleteTracks"
        Me.BtnDeleteTracks.Size = New System.Drawing.Size(97, 44)
        Me.BtnDeleteTracks.TabIndex = 6
        Me.BtnDeleteTracks.Text = "Delete Track"
        Me.BtnDeleteTracks.UseVisualStyleBackColor = True
        '
        'BtnSortTracks
        '
        Me.BtnSortTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSortTracks.Location = New System.Drawing.Point(301, 228)
        Me.BtnSortTracks.Name = "BtnSortTracks"
        Me.BtnSortTracks.Size = New System.Drawing.Size(90, 44)
        Me.BtnSortTracks.TabIndex = 5
        Me.BtnSortTracks.Text = "Sort Tracks"
        Me.BtnSortTracks.UseVisualStyleBackColor = True
        '
        'LBxMyPlaylist
        '
        Me.LBxMyPlaylist.FormattingEnabled = True
        Me.LBxMyPlaylist.ItemHeight = 16
        Me.LBxMyPlaylist.Location = New System.Drawing.Point(17, 64)
        Me.LBxMyPlaylist.Name = "LBxMyPlaylist"
        Me.LBxMyPlaylist.Size = New System.Drawing.Size(480, 148)
        Me.LBxMyPlaylist.TabIndex = 2
        '
        'BtnClear
        '
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Location = New System.Drawing.Point(422, 36)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 1
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BandAndTrackEntry
        '
        Me.BandAndTrackEntry.Location = New System.Drawing.Point(17, 36)
        Me.BandAndTrackEntry.Name = "BandAndTrackEntry"
        Me.BandAndTrackEntry.Size = New System.Drawing.Size(399, 22)
        Me.BandAndTrackEntry.TabIndex = 0
        '
        'PBxExit
        '
        Me.PBxExit.ErrorImage = Nothing
        Me.PBxExit.Image = CType(resources.GetObject("PBxExit.Image"), System.Drawing.Image)
        Me.PBxExit.Location = New System.Drawing.Point(487, 8)
        Me.PBxExit.Name = "PBxExit"
        Me.PBxExit.Size = New System.Drawing.Size(34, 32)
        Me.PBxExit.TabIndex = 10
        Me.PBxExit.TabStop = False
        '
        'PBxMini
        '
        Me.PBxMini.ErrorImage = Nothing
        Me.PBxMini.Image = CType(resources.GetObject("PBxMini.Image"), System.Drawing.Image)
        Me.PBxMini.Location = New System.Drawing.Point(446, 8)
        Me.PBxMini.Name = "PBxMini"
        Me.PBxMini.Size = New System.Drawing.Size(34, 32)
        Me.PBxMini.TabIndex = 11
        Me.PBxMini.TabStop = False
        '
        'LblAppName
        '
        Me.LblAppName.AutoSize = True
        Me.LblAppName.BackColor = System.Drawing.Color.DarkRed
        Me.LblAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAppName.ForeColor = System.Drawing.Color.PeachPuff
        Me.LblAppName.Location = New System.Drawing.Point(9, 14)
        Me.LblAppName.Name = "LblAppName"
        Me.LblAppName.Size = New System.Drawing.Size(155, 20)
        Me.LblAppName.TabIndex = 11
        Me.LblAppName.Text = "MyMusicPlaylist V1.2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(533, 433)
        Me.Controls.Add(Me.LblAppName)
        Me.Controls.Add(Me.PBxMini)
        Me.Controls.Add(Me.PBxExit)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBxDiscordMusicBotAndExtras.ResumeLayout(False)
        Me.GBxDiscordMusicBotAndExtras.PerformLayout()
        CType(Me.PBxExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDeleteTracks As Button
    Friend WithEvents BtnSortTracks As Button
    Friend WithEvents LBxMyPlaylist As ListBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BandAndTrackEntry As TextBox
    Friend WithEvents LblTrackCount As Label
    Friend WithEvents LblTracks As Label
    Friend WithEvents RBtnVIPMusicLive As RadioButton
    Friend WithEvents RBtnMusicLive As RadioButton
    Friend WithEvents GBxDiscordMusicBotAndExtras As GroupBox
    Friend WithEvents ChBxOnOff As CheckBox
    Friend WithEvents LblBotOnOff As Label
    Friend WithEvents PBxExit As PictureBox
    Friend WithEvents PBxMini As PictureBox
    Friend WithEvents LblBandAndTrack As Label
    Friend WithEvents LblCreatedBy As Label
    Friend WithEvents LblAppName As Label
End Class
