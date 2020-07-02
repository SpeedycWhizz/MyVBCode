Imports System.IO
Imports System.Threading.Thread

Public Class MyPlaylistV15

    Dim MyPlaylist As New ArrayList
    Dim SysDir As String = "C:\Myplaylist\"
    Dim SysFilename As String = "MyTracks.txt"
    Dim SysFilename2 As String = "MyTracks.bak"
    Dim DiscordCommand As String
    Dim DiscordLogout As String
    Dim RecoverLastEntry As String
    Dim TrackFound As Integer = 0
    Dim DTM As System.Threading.Thread
    Dim DM As Integer
    Dim BotOnOff As Boolean

    Private Sub MyPlaylistV15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False

        'Sets Background Colour
        MenuStrip1.BackColor = Color.Maroon
        MenuStrip1.ForeColor = Color.PeachPuff
        TBxBandAndTrack.BackColor = Color.LightBlue
        LBx1MyTrackChoice.BackColor = Color.LightBlue
        LBx2SearchMyPlaylist.BackColor = Color.LightBlue

        'Disables Controls
        BtnEditTrack.Enabled = False
        BtnDeleteTrack.Enabled = False
        BtnSearchMyPlaylist.Enabled = False

        'Turns Off Some Controls
        DisplayMessages.Enabled = False
        'Creates Directory
        If Not Directory.Exists(SysDir) Then
            Directory.CreateDirectory(SysDir)
        End If

        'Creates A File
        If Not File.Exists(SysDir + SysFilename) Then
            File.Create(SysDir + SysFilename).Close()
        End If

        'Creates A File (For Filename2)
        If Not File.Exists(SysDir + SysFilename2) Then
            File.Create(SysDir + SysFilename2).Close()
        End If

        'Displays App Form To User
        Me.Show()

        'Checks To See If File Exists, And Loads File
        If File.Exists(SysDir + SysFilename) And
                File.ReadAllBytes(SysDir + SysFilename).Length > 0 Then
            LoadFile()
        End If

        'Check File Length
        If File.ReadAllBytes(SysDir + SysFilename).Length = 0 Then
            DM = 17

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()
        End If

        'Checks File Check
        If File.ReadAllBytes(SysDir + SysFilename).Length = 0 And
            File.ReadAllBytes(SysDir + SysFilename2).Length = 0 Then
            DM = 19

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()
        End If
    End Sub

    Private Sub BackupPlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupPlaylistToolStripMenuItem.Click
        'Makes A Backup Copie Of The Users
        'Playlist
        If File.Exists(SysDir + SysFilename) Then
            File.Delete(SysDir + SysFilename2)
            File.Copy(SysDir + SysFilename, SysDir + SysFilename2)
            DM = 14

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()
        End If
    End Sub

    Private Sub RecoverFromToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoverFromToolStripMenuItem.Click
        'Recovers Playlist From Backup File, If Playlist
        'As Been Deleted 
        If File.Exists(SysDir + SysFilename) Then
            File.Delete(SysDir + SysFilename)
            File.Copy(SysDir + SysFilename2, SysDir + SysFilename)
            MyPlaylist.Clear()
            LBx1MyTrackChoice.Items.Clear()
            LoadFile()
            DM = 15

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()
        End If
    End Sub

    Private Sub LeaveBotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveBotToolStripMenuItem.Click
        'Checks if Bot Is Selected, And Selects The Correct
        'Bot Leave Command For The User To Logout With
        'ie (The Music Live  Bot)
        If BotOnOff = True And RB1MusicLiveBot.Checked Then
            TBxBandAndTrack.Text = DiscordLogout
            TBxBandAndTrack.SelectAll()
            TBxBandAndTrack.Copy()
            DisplayMessages.Text = "Leaving Music Live Bot"
            TBxBandAndTrack.Clear()
        End If

        'Checks if Bot Is Selected, And Selects The Correct
        'Bot Leave Command For The User To Logout With
        'ie (he V.I.P Bot)
        If BotOnOff = True And RBnVIPBot.Checked Then
            TBxBandAndTrack.Text = DiscordLogout
            TBxBandAndTrack.SelectAll()
            TBxBandAndTrack.Copy()
            DisplayMessages.Text = "Leaving VIP Music Bot"
            TBxBandAndTrack.Clear()
        End If
    End Sub

    Private Sub BtnSaveTracks_Click(sender As Object, e As EventArgs) Handles BtnSaveTracks.Click
        'Saves Tracks
        DM = 5
        SaveTracks()

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub BtnDeleteTrack_Click(sender As Object, e As EventArgs) Handles BtnDeleteTrack.Click
        'Deletes Selected Track From List
        MyPlaylist.Remove(LBx1MyTrackChoice.SelectedItem)
        DM = 4
        UpdateDisplay()

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub BtnSortTrack_Click(sender As Object, e As EventArgs) Handles BtnSortTrack.Click
        'Sorts Tracks
        MyPlaylist.Sort()
        UpdateDisplay()
        TBxBandAndTrack.Focus()
        DM = 7

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub BtnSearchMyPlaylist_Click(sender As Object, e As EventArgs) Handles BtnSearchMyPlaylist.Click
        'Track Search Routine
        TrackFound = 0
        LBx2SearchMyPlaylist.Items.Clear()
        If TBxBandAndTrack.TextLength > 0 Then
            For s = 0 To MyPlaylist.Count - 1
                If MyPlaylist(s).ToString.Contains(TBxBandAndTrack.Text) Then
                    TrackFound = TrackFound + 1
                    LBx2SearchMyPlaylist.Items.Add(MyPlaylist(s))
                    DM = 1
                End If
            Next
        End If

        'Displays Message, If No Tracks found
        If TBxBandAndTrack.TextLength > 0 And TrackFound = 0 Then
            DM = 0
        End If

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub BtnRecoverLastEntry_Click(sender As Object, e As EventArgs) Handles BtnRecoverLastEntry.Click
        'Last Track Entry Recovery Routine
        TBxBandAndTrack.Text = RecoverLastEntry
        DM = 6

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub BtnEditTrack_Click(sender As Object, e As EventArgs) Handles BtnEditTrack.Click
        'Edit Track Routine
        EditTrack()
    End Sub

    Private Sub LoadFile()
        'Reads Band Names & Track From File  
        Dim sr As New StreamReader(SysDir + SysFilename)
        Do Until sr.Peek = -1
            MyPlaylist.Add(sr.ReadLine)
        Loop
        sr.Close()
        DM = 18
        UpdateDisplay()

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub SaveTracks()
        'Saves Tracks (and writes to a file)
        If File.Exists(SysDir + SysFilename) Then
            Dim sw As New StreamWriter(SysDir + SysFilename)
            For Each Track In MyPlaylist
                sw.WriteLine(Track)
            Next
            sw.Close()
        End If
    End Sub

    Private Sub EditTrack()
        'Checks The Following, If 'BotOnOff' Is Deselected
        'And Then Displays A Message To The User  
        If BotOnOff = False Then
            RecoverLastEntry = LBx1MyTrackChoice.SelectedItem
            TBxBandAndTrack.Text = RecoverLastEntry
            MyPlaylist.Remove(RecoverLastEntry)
            UpdateDisplay()
        End If
    End Sub

    Private Sub UpdateDisplay()

        'Updates Display
        LBx1MyTrackChoice.Items.Clear()
        For Each Track In MyPlaylist
            LBx1MyTrackChoice.Items.Add(Track)
        Next

        'Display The Number Of Tracks In Playlist
        MyPlaylisstTrackCount.Text = LBx1MyTrackChoice.Items.Count
    End Sub


    Private Sub TBxBandAndTrack_TextChanged(sender As Object, e As EventArgs) Handles TBxBandAndTrack.TextChanged
        'Enabled Controls
        If TBxBandAndTrack.TextLength > 0 Then
            BtnEditTrack.Enabled = True
            BtnDeleteTrack.Enabled = True
            BtnSearchMyPlaylist.Enabled = True

            'Disanbles Buttons
        ElseIf TBxBandAndTrack.TextLength = 0 Then
            BtnEditTrack.Enabled = False
            BtnDeleteTrack.Enabled = False
            BtnSearchMyPlaylist.Enabled = False
        End If
    End Sub

    Private Sub PlaylistV15_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Adds Track To Playlist
        If TBxBandAndTrack.TextLength > 0 And BotOnOff = True And
           e.KeyCode = Keys.Enter Then
            MyPlaylist.Add(TBxBandAndTrack.Text)
            RecoverLastEntry = TBxBandAndTrack.Text
            TBxBandAndTrack.Clear()
            DM = 8

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()

            'Upddates Playlist Display
            UpdateDisplay()
        ElseIf TBxBandAndTrack.TextLength = 0 And BotOnOff = True And
            e.KeyCode = Keys.Enter Then
            DM = 13

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()
        End If

        'Add Entry to Playlist
        If TBxBandAndTrack.TextLength > 0 And BotOnOff = False And
          e.KeyCode = Keys.Enter Then
            MyPlaylist.Add(TBxBandAndTrack.Text)

            'Keeps A Copy Of Last Of Entry        
            RecoverLastEntry = TBxBandAndTrack.Text
            TBxBandAndTrack.Clear()
            DM = 20
            UpdateDisplay()

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()

            ' Checks To See If Track Has Been Selecteed
            'For Editing
        ElseIf BotOnOff = False And TBxBandAndTrack.TextLength = 0 And
           e.KeyCode = Keys.Enter Then
        DM = 21

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
        End If
        'Displays Message

        'Clears Text
        If e.KeyCode = Keys.Delete Then
            TBxBandAndTrack.Clear()
        End If
    End Sub

    Private Sub LBx1MyTrackChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBx1MyTrackChoice.SelectedIndexChanged
        'Sets Boolean to True, Then Allows The Correct
        'Bot Command To Be Selected.  
        If BotOnOff = True Then

            'Copies Track Choice Of User, With Selected Bot
            TBxBandAndTrack.Text = DiscordCommand + LBx1MyTrackChoice.SelectedItem
            BtnEditTrack.Enabled = False
            TBxBandAndTrack.SelectAll()
            TBxBandAndTrack.Copy()
            DM = 7

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()
        End If

        'Disables Bot, And Enables Edit Mode
        If BotOnOff = False Then
            TBxBandAndTrack.Text = LBx1MyTrackChoice.SelectedItem
            BtnEditTrack.Enabled = True
            DM = 9

            'Displays Message
            DTM = New Threading.Thread(AddressOf DSM)
            DTM.Start()
        End If
    End Sub

    Private Sub LBx2SearchMyPlaylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBx2SearchMyPlaylist.SelectedIndexChanged
        'Copies Selected Track
        If BotOnOff = True Then
            TBxBandAndTrack.Text = DiscordCommand + LBx2SearchMyPlaylist.SelectedItem
            TBxBandAndTrack.SelectAll()
            TBxBandAndTrack.Copy()
            DM = 7
        End If

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub RB1MusicLiveBot_CheckedChanged(sender As Object, e As EventArgs) Handles RB1MusicLiveBot.CheckedChanged
        'Music Live Bot
        DM = 2
        DiscordCommand = "!p "
        DiscordLogout = "!leave"

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub RBnVIPBot_CheckedChanged(sender As Object, e As EventArgs) Handles RBnVIPBot.CheckedChanged
        'Vip music bot
        DM = 3
        DiscordCommand = ">p "
        DiscordLogout = ">Leave"

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub BotSelection_CheckedChanged(sender As Object, e As EventArgs) Handles BotSelection.CheckedChanged
        'Enables Music Bots
        If BotSelection.Checked = True Then
            BotSelection.Text = "Music Bot Enabled"
            BotOnOff = True
            RB1MusicLiveBot.Enabled = True
            RBnVIPBot.Enabled = True
            DM = 11

            'Disableds Music Bots
        ElseIf BotSelection.Checked = False Then
            BotSelection.Text = "Music Bot Disabled"
            BotOnOff = False
            RB1MusicLiveBot.Enabled = False
            RBnVIPBot.Enabled = False
            DM = 10
        End If

        'Displays Message
        DTM = New Threading.Thread(AddressOf DSM)
        DTM.Start()
    End Sub

    Private Sub DSM()
        'Displays System Messages Under Condictions
        If DM = 0 Then
            DisplayMessages.Text = "No Track(s) Found"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 1 Then
            DisplayMessages.Text = "Your Search Found " & TrackFound & "Tracks"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 2 Then
            DisplayMessages.Text = "Music Live Selected"
        ElseIf DM = 3 Then
            DisplayMessages.Text = "V.I.P Music Live Selected"
        ElseIf DM = 4 Then
            DisplayMessages.Text = "Track Deleted"
            TBxBandAndTrack.Clear()
            TBxBandAndTrack.Focus()
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 5 Then
            DisplayMessages.Text = "Saving Playlist"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 6 Then
            DisplayMessages.Text = "Recovered Last Entry"
            TBxBandAndTrack.Focus()
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 7 Then
            DisplayMessages.Text = "Track Copied"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 8 Then
            DisplayMessages.Text = "NEW Track Added"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 9 Then
            DisplayMessages.Text = "Track Selected For Editing"
            Sleep(3000)
            DisplayMessages.Text = "Click Edit Track, To Edit"
            Sleep(3000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 10 Then
            DisplayMessages.Text = "Edit Mode On"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 11 Then
            DisplayMessages.Text = "Edit Mode Off"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 12 Then
            DisplayMessages.Text = "No Track Selected"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 13 Then
            DisplayMessages.Text = "No Track Entered"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 14 Then
            DisplayMessages.Text = "Creating A Backup Of Your Playlist"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 15 Then
            DisplayMessages.Text = "Recovering Your Playlist"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 16 Then
            DisplayMessages.Text = "No Playlist Or Backup Created"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 17 Then
            DisplayMessages.Text = "No Playlist Exists,"
            Sleep(4000)
            DisplayMessages.Text = "Click Recover From Backup"
            Sleep(4000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 18 Then
            DisplayMessages.Text = "Playlist Loaded"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 19 Then
            DisplayMessages.Text = "No Playlist Exists,"
            Sleep(3000)
            DisplayMessages.Text = "Please Create A Playlist"
            Sleep(3000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 20 Then
            DisplayMessages.Text = "Track Edited"
            Sleep(2000)
            DisplayMessages.Text = "System Messages"
        ElseIf DM = 21 Then
            DisplayMessages.Text = "No Track Selected,"
            Sleep(3000)
            DisplayMessages.Text = "For Editing"
            Sleep(3000)
            DisplayMessages.Text = "Please Select One"
            Sleep(3000)
            DisplayMessages.Text = "System Messages"
        End If
    End Sub

    Private Sub MyPlaylistV15_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Save's Playlist On Closing
        SaveTracks()
        DTM.Abort()
        Clipboard.Clear()
    End Sub
End Class
