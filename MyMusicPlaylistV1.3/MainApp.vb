Imports System.IO
Public Class MainApp

    'Pre-sets Strings And Other Stuff
    Dim MyMusicPlaylist As New ArrayList
    Dim SAPI = CreateObject("SAPI.Spvoice")
    Dim Musiclivebot As String = "Track Copied, Use Ctrl + V To Paste Into #Music-live"
    Dim VIPMusiclivebot As String = "Track Copied, Use Ctrl + V To Paste Into V.I.P Music-live"
    Dim SysFileDir As String = "C:\MyPlayList"
    Dim SysFilename As String = "\MyPlaylist.mpl"
    Dim ErrorMessage As String = "No Band And Track Title, Have Been Entered Here"
    Dim SysMessage As String = "Saving Playlist, Closing Application"
    Dim DiscordCommand As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Creates Directory
        If Not Directory.Exists(SysFileDir) Then
            Directory.CreateDirectory(SysFileDir)
        End If

        'Displays App Form To User
        Me.Show()
        'Reads Band Names & Track From File  
        If File.Exists(SysFileDir + SysFilename) Then
            Dim sr As New StreamReader(SysFileDir + SysFilename)
            Do Until sr.Peek = -1
                MyMusicPlaylist.Add(sr.ReadLine)
            Loop
            sr.Close()
        Else
                'Creates A File
                If Not File.Exists(SysFilename) Then
                    File.Create(SysFileDir + SysFilename).Close()
                End If
            End If

        'Sets SAPI Volume Level
        SAPI.volume = 75

        'Sets Background Colour
        BandAndTrackEntry.BackColor = Color.LightBlue
        LBxMyPlaylist.BackColor = Color.LightBlue

        'Displays Band Names & Tracks In Playlist
        UpdateDisplay()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'An Error Trap.  If No  Band Name & Track Title Is Entered, And
        'And The 'Enter Key' Is Pressed An Error Is Shown To The User
        If BandAndTrackEntry.Text = "" And e.KeyCode = Keys.Enter Then

            'Sets Error Message To Be Shown, If Required
            SysInfo.BtnDisplayMessage.Text = ErrorMessage

            'Display Error Message To The User, If Required
            SysInfo.Show()

            'Allow User To Enter Band Name & Track Title To The
            'Playlist
        ElseIf BandAndTrackEntry.Text <> "" And e.KeyCode = Keys.Enter Then
            MyMusicPlaylist.Add(BandAndTrackEntry.Text)
            BandAndTrackEntry.Clear()

            'Updates Display 
            UpdateDisplay()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Clears Text Entry Field
        BandAndTrackEntry.Clear()
    End Sub

    Private Sub BtnSortTracks_Click(sender As Object, e As EventArgs) Handles BtnSortTracks.Click
        MyMusicPlaylist.Sort()
        'Updates Display 
        UpdateDisplay()
    End Sub

    Private Sub BtnDeleteTracks_Click(sender As Object, e As EventArgs) Handles BtnDeleteTracks.Click
        'Delete Track From Playlist, If Users Has Selected One
        MyMusicPlaylist.Remove(LBxMyPlaylist.SelectedItem)
        'Re-Uses Update Display Routine
        UpdateDisplay()
    End Sub

    Private Sub UpdateDisplay()
        'Displays Tracks, To User And Any Updates 
        LBxMyPlaylist.Items.Clear()
        For Each MyTracks In MyMusicPlaylist
            LBxMyPlaylist.Items.Add(MyTracks)
        Next
        'Displays Track Count
        LblTrackCount.Text = LBxMyPlaylist.Items.Count
    End Sub
    'Save Tracks, When User Closes Appication
    Private Sub SaveMyMusicPlaylist()
        Dim sw As New StreamWriter(SysFileDir + SysFilename)
        For Each SaveTracks In MyMusicPlaylist
            sw.WriteLine(SaveTracks)
        Next
        sw.Close()
    End Sub

    Private Sub LBxMyPlaylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBxMyPlaylist.SelectedIndexChanged

        'Copies Selected Band & Track Title From Users Playlist
        BandAndTrackEntry.Text = DiscordCommand + LBxMyPlaylist.SelectedItem
        BandAndTrackEntry.SelectAll()
        BandAndTrackEntry.Copy()
        BandAndTrackEntry.Clear()

        'Alows User To Dispays Messsages Bot Selected, If Selected
        If ChBxOnOff.Checked = True Then
            SysInfo.Show()
        Else
            'Hides Messages From User, If Selected 
            SysInfo.Hide()
        End If
    End Sub

    'Allows User To select The 'Musiclivebot' And Sets That
    'Command For The User
    Private Sub RBtnMusicLive_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnMusicLive.CheckedChanged
        If RBtnMusicLive.Checked = True Then
            DiscordCommand = "!p "
            SysInfo.BtnDisplayMessage.Text = Musiclivebot
        End If
    End Sub

    'Allows User To select The 'VIPMusiclivebot' And Sets That
    'Command For The User
    Private Sub RBtnVIPMusicLive_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnVIPMusicLive.CheckedChanged
        If RBtnVIPMusicLive.Enabled = True Then
            DiscordCommand = ">p "
            SysInfo.BtnDisplayMessage.Text = VIPMusiclivebot
        End If
    End Sub

    Private Sub ChBxOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles ChBxOnOff.CheckedChanged
        'Allows User To Turn System Messages On / Off
        If ChBxOnOff.Checked = True Then
            LblBotOnOff.Text = "On"
        Else
            LblBotOnOff.Text = "Off"
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Tells User The App Is Closing With Speech And Saves Users Playlist
        SAPI.speak(SysMessage)
        SaveMyMusicPlaylist()
    End Sub
    'Minimizes Window Of Appication
    Private Sub PBxMini_Click(sender As Object, e As EventArgs) Handles PBxMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBxExit_Click(sender As Object, e As EventArgs) Handles PBxExit.Click
        'Closes Application
        Application.Exit()
    End Sub
End Class