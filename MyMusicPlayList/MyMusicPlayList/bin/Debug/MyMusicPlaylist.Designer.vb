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
        Me.MyMusicPlaylist = New System.Windows.Forms.ListBox()
        Me.BtnAddTrack = New System.Windows.Forms.Button()
        Me.BtnDeleteTrack = New System.Windows.Forms.Button()
        Me.TbxEnterBand = New System.Windows.Forms.TextBox()
        Me.LblDisplayName = New System.Windows.Forms.Label()
        Me.LblTeackCount = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSaveTrack = New System.Windows.Forms.Button()
        Me.BtnCtrl = New System.Windows.Forms.Button()
        Me.BtnV = New System.Windows.Forms.Button()
        Me.LblPlusSign = New System.Windows.Forms.Label()
        Me.LblPasteIntoMusic = New System.Windows.Forms.Label()
        Me.LblMyMusicPlaylist = New System.Windows.Forms.Label()
        Me.LblV1 = New System.Windows.Forms.Label()
        Me.LblHomeMade = New System.Windows.Forms.Label()
        Me.SniMyMusicPlayList = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'MyMusicPlaylist
        '
        Me.MyMusicPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyMusicPlaylist.FormattingEnabled = True
        Me.MyMusicPlaylist.ItemHeight = 20
        Me.MyMusicPlaylist.Location = New System.Drawing.Point(12, 36)
        Me.MyMusicPlaylist.Name = "MyMusicPlaylist"
        Me.MyMusicPlaylist.Size = New System.Drawing.Size(354, 124)
        Me.MyMusicPlaylist.TabIndex = 0
        '
        'BtnAddTrack
        '
        Me.BtnAddTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddTrack.Location = New System.Drawing.Point(205, 176)
        Me.BtnAddTrack.Name = "BtnAddTrack"
        Me.BtnAddTrack.Size = New System.Drawing.Size(75, 43)
        Me.BtnAddTrack.TabIndex = 6
        Me.BtnAddTrack.Text = "Add Track"
        Me.BtnAddTrack.UseVisualStyleBackColor = True
        '
        'BtnDeleteTrack
        '
        Me.BtnDeleteTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteTrack.Location = New System.Drawing.Point(291, 176)
        Me.BtnDeleteTrack.Name = "BtnDeleteTrack"
        Me.BtnDeleteTrack.Size = New System.Drawing.Size(75, 43)
        Me.BtnDeleteTrack.TabIndex = 7
        Me.BtnDeleteTrack.Text = "Delete Track"
        Me.BtnDeleteTrack.UseVisualStyleBackColor = True
        '
        'TbxEnterBand
        '
        Me.TbxEnterBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxEnterBand.ForeColor = System.Drawing.Color.Gray
        Me.TbxEnterBand.Location = New System.Drawing.Point(12, 225)
        Me.TbxEnterBand.Name = "TbxEnterBand"
        Me.TbxEnterBand.Size = New System.Drawing.Size(354, 26)
        Me.TbxEnterBand.TabIndex = 8
        Me.TbxEnterBand.Text = "Enter Band & Track"
        '
        'LblDisplayName
        '
        Me.LblDisplayName.AutoSize = True
        Me.LblDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplayName.Location = New System.Drawing.Point(12, 176)
        Me.LblDisplayName.Name = "LblDisplayName"
        Me.LblDisplayName.Size = New System.Drawing.Size(95, 20)
        Me.LblDisplayName.TabIndex = 9
        Me.LblDisplayName.Text = "Track Count"
        '
        'LblTeackCount
        '
        Me.LblTeackCount.AutoSize = True
        Me.LblTeackCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTeackCount.Location = New System.Drawing.Point(122, 176)
        Me.LblTeackCount.Name = "LblTeackCount"
        Me.LblTeackCount.Size = New System.Drawing.Size(18, 20)
        Me.LblTeackCount.TabIndex = 10
        Me.LblTeackCount.Text = "0"
        '
        'BtnClear
        '
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(12, 255)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 43)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSaveTrack
        '
        Me.BtnSaveTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveTrack.Location = New System.Drawing.Point(93, 255)
        Me.BtnSaveTrack.Name = "BtnSaveTrack"
        Me.BtnSaveTrack.Size = New System.Drawing.Size(75, 43)
        Me.BtnSaveTrack.TabIndex = 12
        Me.BtnSaveTrack.Text = "Save Tracks"
        Me.BtnSaveTrack.UseVisualStyleBackColor = True
        '
        'BtnCtrl
        '
        Me.BtnCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCtrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCtrl.Location = New System.Drawing.Point(174, 255)
        Me.BtnCtrl.Name = "BtnCtrl"
        Me.BtnCtrl.Size = New System.Drawing.Size(75, 43)
        Me.BtnCtrl.TabIndex = 13
        Me.BtnCtrl.Text = "Ctrl"
        Me.BtnCtrl.UseVisualStyleBackColor = True
        '
        'BtnV
        '
        Me.BtnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnV.Location = New System.Drawing.Point(284, 257)
        Me.BtnV.Name = "BtnV"
        Me.BtnV.Size = New System.Drawing.Size(75, 41)
        Me.BtnV.TabIndex = 14
        Me.BtnV.Text = "V"
        Me.BtnV.UseVisualStyleBackColor = True
        '
        'LblPlusSign
        '
        Me.LblPlusSign.AutoSize = True
        Me.LblPlusSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlusSign.Location = New System.Drawing.Point(258, 269)
        Me.LblPlusSign.Name = "LblPlusSign"
        Me.LblPlusSign.Size = New System.Drawing.Size(18, 20)
        Me.LblPlusSign.TabIndex = 15
        Me.LblPlusSign.Text = "+"
        '
        'LblPasteIntoMusic
        '
        Me.LblPasteIntoMusic.AutoSize = True
        Me.LblPasteIntoMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasteIntoMusic.Location = New System.Drawing.Point(191, 301)
        Me.LblPasteIntoMusic.Name = "LblPasteIntoMusic"
        Me.LblPasteIntoMusic.Size = New System.Drawing.Size(158, 20)
        Me.LblPasteIntoMusic.TabIndex = 16
        Me.LblPasteIntoMusic.Text = "To Paste Into #Music"
        '
        'LblMyMusicPlaylist
        '
        Me.LblMyMusicPlaylist.AutoSize = True
        Me.LblMyMusicPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMyMusicPlaylist.ForeColor = System.Drawing.Color.Gold
        Me.LblMyMusicPlaylist.Location = New System.Drawing.Point(12, 9)
        Me.LblMyMusicPlaylist.Name = "LblMyMusicPlaylist"
        Me.LblMyMusicPlaylist.Size = New System.Drawing.Size(141, 24)
        Me.LblMyMusicPlaylist.TabIndex = 17
        Me.LblMyMusicPlaylist.Text = "MyMusicPlaylist"
        '
        'LblV1
        '
        Me.LblV1.AutoSize = True
        Me.LblV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblV1.ForeColor = System.Drawing.Color.Gold
        Me.LblV1.Location = New System.Drawing.Point(311, 9)
        Me.LblV1.Name = "LblV1"
        Me.LblV1.Size = New System.Drawing.Size(48, 24)
        Me.LblV1.TabIndex = 18
        Me.LblV1.Text = "V1.0"
        '
        'LblHomeMade
        '
        Me.LblHomeMade.AutoSize = True
        Me.LblHomeMade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHomeMade.ForeColor = System.Drawing.Color.Gold
        Me.LblHomeMade.Location = New System.Drawing.Point(21, 353)
        Me.LblHomeMade.Name = "LblHomeMade"
        Me.LblHomeMade.Size = New System.Drawing.Size(320, 24)
        Me.LblHomeMade.TabIndex = 19
        Me.LblHomeMade.Text = "Home Made Software (c) 2019 - 2020"
        '
        'SniMyMusicPlayList
        '
        Me.SniMyMusicPlayList.Icon = CType(resources.GetObject("SniMyMusicPlayList.Icon"), System.Drawing.Icon)
        Me.SniMyMusicPlayList.Text = "MyMusicPlaylist"
        Me.SniMyMusicPlayList.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(378, 386)
        Me.Controls.Add(Me.LblHomeMade)
        Me.Controls.Add(Me.LblV1)
        Me.Controls.Add(Me.LblMyMusicPlaylist)
        Me.Controls.Add(Me.LblPasteIntoMusic)
        Me.Controls.Add(Me.LblPlusSign)
        Me.Controls.Add(Me.BtnV)
        Me.Controls.Add(Me.BtnCtrl)
        Me.Controls.Add(Me.BtnSaveTrack)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblTeackCount)
        Me.Controls.Add(Me.LblDisplayName)
        Me.Controls.Add(Me.TbxEnterBand)
        Me.Controls.Add(Me.BtnDeleteTrack)
        Me.Controls.Add(Me.BtnAddTrack)
        Me.Controls.Add(Me.MyMusicPlaylist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(394, 424)
        Me.MinimumSize = New System.Drawing.Size(394, 424)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyMusicPlaylist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyMusicPlaylist As ListBox
    Friend WithEvents BtnAddTrack As Button
    Friend WithEvents BtnDeleteTrack As Button
    Friend WithEvents TbxEnterBand As TextBox
    Friend WithEvents LblDisplayName As Label
    Friend WithEvents LblTeackCount As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSaveTrack As Button
    Friend WithEvents BtnCtrl As Button
    Friend WithEvents BtnV As Button
    Friend WithEvents LblPlusSign As Label
    Friend WithEvents LblPasteIntoMusic As Label
    Friend WithEvents LblMyMusicPlaylist As Label
    Friend WithEvents LblV1 As Label
    Friend WithEvents LblHomeMade As Label
    Friend WithEvents SniMyMusicPlayList As NotifyIcon
End Class
