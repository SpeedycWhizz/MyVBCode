Imports System.IO
Imports System.Threading.Thread

Public Class FrnMusicPlaylistV16
    Dim MyPlayLists As New ArrayList
    Dim MyTracks As New ArrayList
    Dim AppThread As Threading.Thread
    Dim SysDir As String = "C:\Myplaylist\"
    Dim SysMyTracksFilename As String = "MyTracks.mst"
    Dim DisplayMessage As String
    Dim DisplayMessageNumber As Integer
    Dim SysMessageDelay As Integer = 1500
    Dim DiscordCommand As String
    Dim BtnCheck As Boolean = False
    Dim DeletePlaylistCheck As Boolean = False
    Dim CheckPlaylistType As Boolean
    Dim EditCheck As Boolean

    Private Sub FrnMusicPlaylistV16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KeyPreview = True
        BtnAddTrack.Enabled = False
        BtnDeleteTrack.Enabled = False
        BtnClearSelectedTrack.Enabled = False
        BtnClearBandTrack.Enabled = False
        BtnSearchTracks.Enabled = False
        BtnSortTracks.Enabled = False
        BtnCreatePlaylist.Enabled = False
        BtnDeletePlaylist.Enabled = False
        BtnCopyPlaylistLink.Enabled = False
        BtnClearSelected.Enabled = False
        BtnClearPlaylistName.Enabled = False

        If Not Directory.Exists(SysDir) Then
            Directory.CreateDirectory(SysDir)
        End If

        'Creates a file
        If Not File.Exists(SysDir & SysMyTracksFilename) Then
            File.Create(SysDir & SysMyTracksFilename).Close()
        Else
            'Runs Subroutines
            SubLoadFile()
            SubUpdateDisplay()
            DisplayMessageNumber = 1
        End If

        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BtnAddTrack_Click(sender As Object, e As EventArgs) Handles BtnAddTrack.Click
        SubAddTrack()
        BtnSortTracks.Enabled = True
        DisplayMessageNumber = 7
        SubSysThread()
    End Sub

    Private Sub BtnClearText_Click(sender As Object, e As EventArgs) Handles BtnClearBandTrack.Click
        TBxBandTrackdEntry.Clear()
    End Sub

    Private Sub RBVipMusicBot_CheckedChanged(sender As Object, e As EventArgs) Handles RBVipMusicBot.CheckedChanged
        DiscordCommand = ">p "
        DisplayMessageNumber = 10
        SubSysThread()
    End Sub

    Private Sub RBMusicLiveBot_CheckedChanged(sender As Object, e As EventArgs) Handles RBMusicLiveBot.CheckedChanged
        DiscordCommand = "!p "
        DisplayMessageNumber = 11
        SubSysThread()
    End Sub

    Private Sub BtnEditTracks_Click(sender As Object, e As EventArgs) Handles BtnEditTracks.Click
        If EditCheck = True Then
            Dim EditTracks = File.ReadAllText(SysDir & SysMyTracksFilename)
            FrmEditTracks.RTBEditTracks.Text = EditTracks
            FrmEditTracks.Show()
            FrmEditTracks.Activate()
            FrmEditTracks.RTBEditTracks.SelectionStart = FrmEditTracks.RTBEditTracks.Text.Length + 1
            FrmEditTracks.RTBEditTracks.Focus()
        Else
            EditCheck = False
        End If
    End Sub

    Private Sub BtnDeleteTrack_Click(sender As Object, e As EventArgs) Handles BtnDeleteTrack.Click
        MyTracks.Remove(LBxTracks.SelectedItem)
        DisplayMessageNumber = 8
        TBxBandTrackdEntry.Clear()
        SubUpdateDisplay()
        SubSysThread()
    End Sub

    Private Sub TBxBandTrackdEntry_TextChanged(sender As Object, e As EventArgs) Handles TBxBandTrackdEntry.TextChanged

        If TBxBandTrackdEntry.TextLength > 0 Then
            BtnAddTrack.Enabled = True
            BtnClearBandTrack.Enabled = True
            BtnSearchTracks.Enabled = True
        Else
            BtnAddTrack.Enabled = False
            BtnDeleteTrack.Enabled = False
            BtnClearBandTrack.Enabled = False
            BtnSearchTracks.Enabled = False
        End If
    End Sub

    Private Sub LBxTracks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBxTracks.SelectedIndexChanged

        TBxBandTrackdEntry.Text = DiscordCommand & LBxTracks.SelectedItem
        TBxBandTrackdEntry.SelectAll()
        TBxBandTrackdEntry.Copy()
        DisplayMessageNumber = 13
        SubSysThread()

        If LBxTracks.SelectedItems.Count > 0 Then
            BtnAddTrack.Enabled = False
            BtnDeleteTrack.Enabled = True
            BtnClearSelectedTrack.Enabled = True
            BtnClearBandTrack.Enabled = True
            BtnSearchTracks.Enabled = False
        ElseIf LBxTracks.SelectedItems.Count = 0 Then
            BtnAddTrack.Enabled = False
            BtnDeleteTrack.Enabled = False
            BtnClearBandTrack.Enabled = False
            BtnClearSelectedTrack.Enabled = False
        End If
    End Sub

    Private Sub LBxMyPlaylists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBxMyPlaylists.SelectedIndexChanged
        ''''''
        If RBVipMusicBot.Checked = True Then
            DiscordCommand = ">p "
            SubCopyPlaylistLink()
        ElseIf RBMusicLiveBot.Checked = True Then
            DiscordCommand = "!p "
            SubCopyPlaylistLink()
        End If

        If RTBxPlaylistLink.Text <> "" Then
            BtnCreatePlaylist.Enabled = False
            BtnCopyPlaylistLink.Enabled = True
        Else
            BtnCreatePlaylist.Enabled = False
            BtnCopyPlaylistLink.Enabled = False
        End If

        If LBxMyPlaylists.SelectedItems.Count > 0 Then
            BtnClearSelected.Enabled = True
        Else
            BtnClearSelected.Enabled = False
        End If
    End Sub

    Private Sub TBxPlaylistName_MouseEnter(sender As Object, e As EventArgs) Handles TBxPlaylistName.MouseEnter
        TBxPlaylistName.Focus()
    End Sub

    Private Sub TBxBandTrackdEntry_MouseEnter(sender As Object, e As EventArgs) Handles TBxBandTrackdEntry.MouseEnter
        TBxBandTrackdEntry.Focus()
    End Sub

    Private Sub RTBxPlaylistLink_MouseEnter(sender As Object, e As EventArgs) Handles RTBxPlaylistLink.MouseEnter
        RTBxPlaylistLink.Focus()

    End Sub

    Private Sub BtnClearPlaylistName_Click(sender As Object, e As EventArgs) Handles BtnClearPlaylistName.Click
        TBxPlaylistName.Clear()
        DisplayMessageNumber = 2
        SubSysThread()
    End Sub

    Private Sub BtnSortTracks_Click(sender As Object, e As EventArgs) Handles BtnSortTracks.Click

        MyTracks.Sort()
        DisplayMessageNumber = 12
        SubUpdateDisplay()
        BtnSortTracks.Enabled = False
        SubSysThread()
    End Sub

    Private Sub BtnCopyPlaylistLink_Click(sender As Object, e As EventArgs) Handles BtnCopyPlaylistLink.Click
        SubCopyPlaylistLink()
        RTBxPlaylistLink.SelectAll()
        RTBxPlaylistLink.SelectionBackColor = Color.Yellow
        RTBxPlaylistLink.Copy()

        DisplayMessageNumber = 6

        If RTBxPlaylistLink.SelectionBackColor = Color.Yellow Then
            BtnCreatePlaylist.Enabled = False
        End If
        SubSysThread()
    End Sub

    Private Sub FrnMusicPlaylistV16_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If TBxBandTrackdEntry.TextLength > 0 And e.KeyCode = Keys.Enter Then
            SubAddTrack()
        Else
            BtnAddTrack.Enabled = False
        End If
    End Sub

    Private Sub BtnCreatePlaylist_Click(sender As Object, e As EventArgs) Handles BtnCreatePlaylist.Click
        'Runs the following Subroutines
        DisplayMessageNumber = 4
        SubCreatePlayListFile()
        SubUpdateDisplay()
        SubSysThread()

    End Sub

    Private Sub BtnDeletePlaylist_Click(sender As Object, e As EventArgs) Handles BtnDeletePlaylist.Click
        DisplayMessageNumber = 5
        SubDeletePlayList()
        SubUpdateDisplay()
        SubSysThread()
    End Sub

    Private Sub BtnClearSelectedTrack_Click(sender As Object, e As EventArgs) Handles BtnClearSelectedTrack.Click
        DisplayMessageNumber = 9
        LBxTracks.ClearSelected()
        TBxBandTrackdEntry.Clear()
        SubSysThread()
    End Sub

    Private Sub RTBxPlaylistLink_TextChanged(sender As Object, e As EventArgs) Handles RTBxPlaylistLink.TextChanged
        If RTBxPlaylistLink.TextLength > 0 Then
            BtnCreatePlaylist.Enabled = True
        Else
            BtnCreatePlaylist.Enabled = False
        End If

        If LBxMyPlaylists.SelectedItems.Count > 0 Then
            BtnDeletePlaylist.Enabled = True
            BtnClearSelected.Enabled = True
        Else
            BtnDeletePlaylist.Enabled = False
            BtnClearSelected.Enabled = False
        End If

        If RTBxPlaylistLink.TextLength = 0 Then
            BtnDeletePlaylist.Enabled = False
            TBxPlaylistName.Focus()
        End If
    End Sub

    Private Sub BtnClearSelected_Click(sender As Object, e As EventArgs) Handles BtnClearSelected.Click
        DisplayMessageNumber = 3
        RTBxPlaylistLink.Clear()
        LBxMyPlaylists.ClearSelected()
        TBxPlaylistName.Clear()
        SubSysThread()
    End Sub

    Private Sub TBxPlaylistName_TextChanged(sender As Object, e As EventArgs) Handles TBxPlaylistName.TextChanged
        'Error trapping routine
        If TBxPlaylistName.TextLength > 0 And
                RTBxPlaylistLink.TextLength > 0 Then
            BtnCreatePlaylist.Enabled = True
        Else
            BtnCreatePlaylist.Enabled = False
            BtnCopyPlaylistLink.Enabled = False
            BtnClearSelected.Enabled = False
        End If

        If TBxPlaylistName.TextLength > 0 Then
            BtnClearPlaylistName.Enabled = True
        Else
            BtnClearPlaylistName.Enabled = False
            BtnCreatePlaylist.Enabled = False
        End If
    End Sub

    Private Sub BtnNowPlaying_Click(sender As Object, e As EventArgs) Handles BtnNowPlaying.Click
        'NowPlaying Command
        If RBVipMusicBot.Checked = True Then
            DisplayMessageNumber = 14
            DiscordCommand = ">np"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        ElseIf RBMusicLiveBot.Checked = True Then
            DisplayMessageNumber = 14
            DiscordCommand = "!np"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        End If

        SubSysThread()
    End Sub

    Private Sub BtnSkipTrack_Click(sender As Object, e As EventArgs) Handles BtnSkipTrack.Click
        'Skip Command
        If RBVipMusicBot.Checked = True Then
            DisplayMessageNumber = 15
            DiscordCommand = ">skip"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        ElseIf RBMusicLiveBot.Checked = True Then
            DisplayMessageNumber = 15
            DiscordCommand = "!skip"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        End If

        SubSysThread()
    End Sub

    Private Sub BtnTrackQueue_Click(sender As Object, e As EventArgs) Handles BtnTrackQueue.Click
        'TrackQueue Command
        If RBVipMusicBot.Checked = True Then
            DisplayMessageNumber = 16
            DiscordCommand = ">q"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        ElseIf RBMusicLiveBot.Checked = True Then
            DisplayMessageNumber = 16
            DiscordCommand = "!q"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        End If

        SubSysThread()
    End Sub

    Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles BtnResume.Click
        'Track Resume Command
        If RBVipMusicBot.Checked = True Then
            DisplayMessageNumber = 17
            DiscordCommand = ">resume"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        ElseIf RBMusicLiveBot.Checked = True Then
            DisplayMessageNumber = 17
            DiscordCommand = "!resume"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        End If

        SubSysThread()
    End Sub

    Private Sub BtnTrackStop_Click(sender As Object, e As EventArgs) Handles BtnTrackStop.Click
        'Track Resume Command
        If RBVipMusicBot.Checked = True Then
            DisplayMessageNumber = 18
            DiscordCommand = ">stop"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        ElseIf RBMusicLiveBot.Checked = True Then
            DisplayMessageNumber = 18
            DiscordCommand = "!stop"
            RTBxPlaylistLink.Text = DiscordCommand
            RTBxPlaylistLink.SelectAll()
            RTBxPlaylistLink.SelectionBackColor = Color.Magenta
            RTBxPlaylistLink.Copy()
        End If

        SubSysThread()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes Application
        Application.Exit()
    End Sub

    Private Sub FrnMusicPlaylistV16_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SubSaveTracks()
        AppThread.Abort()
    End Sub

    Public Sub SubSysThread()
        AppThread = New Threading.Thread(AddressOf DSM)
        AppThread.Start()
    End Sub

    'Subroutine
    Private Sub SubLoadFile()
        MyTracks.Clear()
        MyPlayLists.Clear()
        Dim srMyTracks As New StreamReader(SysDir & SysMyTracksFilename)
        Do Until srMyTracks.Peek = -1
            MyTracks.Add(srMyTracks.ReadLine)
        Loop

        For Each LoadedFile As String In Directory.GetFiles(SysDir)
            If Path.GetFileName(LoadedFile.Contains(".plf")) Then
                MyPlayLists.Add(Path.GetFileName(LoadedFile))
            End If
        Next
    End Sub

    'Subroutine
    Public Sub SubUpdateDisplay()
        LBxTracks.Items.Clear()
        For Each DisplayMyTracks In MyTracks
            LBxTracks.Items.Add(DisplayMyTracks)
        Next
        LblTrackCountResualt.Text = LBxTracks.Items.Count

        LBxMyPlaylists.Items.Clear()
        For Each DisplayPlaylists In MyPlayLists
            LBxMyPlaylists.Items.Add(DisplayPlaylists)
        Next
        LblPlaylistCountResualts.Text = LBxMyPlaylists.Items.Count
    End Sub

    'Subroutine
    Private Sub SubAddTrack()
        MyTracks.Add(TBxBandTrackdEntry.Text)
        SubUpdateDisplay()
        TBxBandTrackdEntry.Clear()
    End Sub

    Private Sub SubCreatePlayListFile()
        'Creates playlist file
        Dim CreatePlaylistFilename As String
        Dim WebLink As String
        CreatePlaylistFilename = TBxPlaylistName.Text & ".plf"
        If File.Exists(SysDir) Then
            File.Create(SysDir & CreatePlaylistFilename).Close()
        End If

        'Save playlist infomation
        Dim wl As New StreamWriter(SysDir & CreatePlaylistFilename)
        WebLink = RTBxPlaylistLink.Text
        wl.WriteLineAsync(WebLink)
        wl.Close()
        TBxPlaylistName.Clear()
        RTBxPlaylistLink.Clear()
        SubLoadFile()
        SubUpdateDisplay()
    End Sub
    Private Sub SubCopyPlaylistLink()
        'Opens playlist link, from selected playlist
        If LBxMyPlaylists.SelectedItems.Count > 0 Then
            Dim PlaylistSelected = LBxMyPlaylists.SelectedItem
            If PlaylistSelected = LBxMyPlaylists.SelectedItem Then
                Dim FoundLink As String = File.ReadAllText(SysDir & LBxMyPlaylists.SelectedItem.ToString)
                RTBxPlaylistLink.Text = DiscordCommand & FoundLink
            Else
                LBxMyPlaylists.ClearSelected()
            End If
        End If
    End Sub

    Private Sub SubSaveTracks()
        Dim sw As New StreamWriter(SysDir & SysMyTracksFilename)
        For Each TrackInList In MyTracks
            sw.WriteLine(TrackInList)
        Next
        sw.Close()
    End Sub

    Private Sub SubDeletePlayList()
        'Delete playlist routine
        MyPlayLists.RemoveAt(LBxMyPlaylists.SelectedIndex)

        File.Delete(SysDir & LBxMyPlaylists.SelectedItem.ToString)
        TBxPlaylistName.Clear()
        RTBxPlaylistLink.Clear()
        SubUpdateDisplay()

        'Button Error Trapping
        If DeletePlaylistCheck = False Then
            BtnDeletePlaylist.Enabled = False
        End If
    End Sub

    Private Sub BtnSearchTracks_Click(sender As Object, e As EventArgs) Handles BtnSearchTracks.Click
        BtnCheck = True
        'Track Search Routine
        If BtnCheck = True And BtnSearchTracks.Enabled = True Then
            BtnAddTrack.Enabled = False
            Dim TracksFound As String
            LBxTracks.Items.Clear()
            TracksFound = 0
            If TBxBandTrackdEntry.TextLength > 0 Then
                For s = 0 To MyTracks.Count - 1
                    If MyTracks(s).ToString.Contains(TBxBandTrackdEntry.Text) Then
                        TracksFound += 1
                        LBxTracks.Items.Add(MyTracks(s))
                    End If
                Next
            End If
            LblTrackCountResualt.Text = TracksFound
            TBxBandTrackdEntry.Clear()
            TBxBandTrackdEntry.Focus()
        Else
            BtnCheck = False
        End If

        If BtnCheck = False Then
            SubUpdateDisplay()
        End If
    End Sub


    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RTBxPlaylistLink.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RTBxPlaylistLink.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RTBxPlaylistLink.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RTBxPlaylistLink.SelectAll()
    End Sub

    Private Sub BackupMyTracksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupMyTracksToolStripMenuItem.Click

        DisplayMessageNumber = 21
        If Directory.Exists(SysDir) Then
            Dim Backup As String = "MyTracks.bak"
            File.Delete(SysDir & Backup)
            File.Copy(SysDir & SysMyTracksFilename, SysDir & Backup)
        End If

        SubSysThread()
    End Sub

    Private Sub CBRandomizePlaylist_CheckedChanged(sender As Object, e As EventArgs) Handles CBRandomizePlaylist.CheckedChanged

        If CBRandomizePlaylist.Checked = True Then
            DisplayMessageNumber = 19
            CBRandomizePlaylist.Text = "Random On"
            CheckPlaylistType = True
            RBRandomPlaylist.Visible = True
            RBRandomTrack.Visible = True
            BtnSelection.Visible = True
        Else
            CBRandomizePlaylist.Text = "Random Off"
            DisplayMessageNumber = 20
            RBRandomPlaylist.Visible = False
            RBRandomTrack.Visible = False
            BtnSelection.Visible = False
        End If

        SubSysThread()
    End Sub

    Private Sub RBRandomPlaylist_CheckedChanged(sender As Object, e As EventArgs) Handles RBRandomPlaylist.CheckedChanged
        BtnSelection.Text = "Pick Random Playlist"
        DisplayMessageNumber = 22

        SubSysThread()
    End Sub

    Private Sub RBRandomTrack_CheckedChanged(sender As Object, e As EventArgs) Handles RBRandomTrack.CheckedChanged
        BtnSelection.Text = "Pick Random Track"
        DisplayMessageNumber = 23

        SubSysThread()
    End Sub

    Private Sub LBxTracks_MouseEnter(sender As Object, e As EventArgs) Handles LBxTracks.MouseEnter
        CBRandomizePlaylist.Checked = False
    End Sub

    Private Sub LBxTracks_MouseLeave(sender As Object, e As EventArgs) Handles LBxTracks.MouseLeave
        CBRandomizePlaylist.Checked = True
    End Sub

    Private Sub LBxMyPlaylists_MouseEnter(sender As Object, e As EventArgs) Handles LBxMyPlaylists.MouseEnter
        CBRandomizePlaylist.Checked = False
    End Sub

    Private Sub LBxMyPlaylists_MouseLeave(sender As Object, e As EventArgs) Handles LBxMyPlaylists.MouseLeave
        CBRandomizePlaylist.Checked = True
    End Sub

    Private Sub BtnSelection_Click(sender As Object, e As EventArgs) Handles BtnSelection.Click
        If CheckPlaylistType = True And
            RBRandomPlaylist.Checked = True Then
            Dim RandomPlaylistSelected As New Random
            For ThinkingTime = 0 To 20
                Dim PlaylistPos As Integer
                PlaylistPos = RandomPlaylistSelected.Next(0, LBxMyPlaylists.Items.Count)
                LBxMyPlaylists.SelectedItem = LBxMyPlaylists.Items(PlaylistPos)
                Sleep(300)
            Next
        ElseIf CheckPlaylistType = True And
            RBRandomTrack.Checked = True Then
            Dim RandomPlaylistSelected As New Random
            For ThinkingTime = 0 To 20
                Dim PlaylistPos As Integer
                PlaylistPos = RandomPlaylistSelected.Next(0, LBxTracks.Items.Count)
                LBxTracks.SelectedItem = LBxTracks.Items(PlaylistPos)
                Sleep(300)
            Next
        End If
    End Sub

    Private Sub DSM()
        'System Messages Routine

        'All Tracks & Playlists Loaded (On Startup)
        'Playlist Cleared
        If DisplayMessageNumber = 1 Then
            DisplayMessage = "All Playlists Have Been Loaded"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
        ElseIf DisplayMessageNumber = 2 Then
            DisplayMessage = "Playlist Name Cleared"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Playlist Has Been Unselected
        ElseIf DisplayMessageNumber = 3 Then
            DisplayMessage = "Playlist Has Been Unselected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Playlist Has Been Created
        ElseIf DisplayMessageNumber = 4 Then
            DisplayMessage = "Playlist Has Been Created"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            'Playlist Link Deleted
        ElseIf DisplayMessageNumber = 5 Then
            DisplayMessage = "Playlist Link Deleted"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            'Playlist Link Copied
            BtnSysDisplayMessages.Text = DisplayMessage
        ElseIf DisplayMessageNumber = 6 Then
            DisplayMessage = "Playlist Link Copied"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'New Track Added
        ElseIf DisplayMessageNumber = 7 Then
            DisplayMessage = "New Track Added"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Track Deleted
        ElseIf DisplayMessageNumber = 8 Then
            DisplayMessage = "Track Deleted"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Track Unselected
        ElseIf DisplayMessageNumber = 9 Then
            DisplayMessage = "Track Unselected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Music V.I.P Bot Active
        ElseIf DisplayMessageNumber = 10 Then
            DisplayMessage = "Music V.I.P Bot Active"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Music Live Bot Active
        ElseIf DisplayMessageNumber = 11 Then
            DisplayMessage = "Music Live Bot Active"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Tracks Sorted
        ElseIf DisplayMessageNumber = 12 Then
            DisplayMessage = "Track Sorted"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Track Copied
        ElseIf DisplayMessageNumber = 13 Then
            DisplayMessage = "Track Copied"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Track Now Playing
        ElseIf DisplayMessageNumber = 14 Then
            DisplayMessage = "Now Playing Command Selected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Skip Playing Track
        ElseIf DisplayMessageNumber = 15 Then
            DisplayMessage = "Skip Command Selected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Queue Command
        ElseIf DisplayMessageNumber = 16 Then
            DisplayMessage = "Queue Command Selected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Resume Command
        ElseIf DisplayMessageNumber = 17 Then
            DisplayMessage = "Resume Command Selected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Stop Command
        ElseIf DisplayMessageNumber = 18 Then
            DisplayMessage = "Stop Command Selected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Random Playlist Selection - Turn On
        ElseIf DisplayMessageNumber = 19 Then
            DisplayMessage = "Random On"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Random Playlist Selection - Turn Off
        ElseIf DisplayMessageNumber = 20 Then
            DisplayMessage = "Random Off"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
            'Backup
        ElseIf DisplayMessageNumber = 21 Then
            DisplayMessage = "Creating A Backup"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
        ElseIf DisplayMessageNumber = 22 Then
            DisplayMessage = "Random Playlist Selected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
        ElseIf DisplayMessageNumber = 23 Then
            DisplayMessage = "Random Track Selected"
            BtnSysDisplayMessages.Text = DisplayMessage
            Sleep(SysMessageDelay)
            DisplayMessage = "No System Message"
            BtnSysDisplayMessages.Text = DisplayMessage
        End If
    End Sub

End Class
