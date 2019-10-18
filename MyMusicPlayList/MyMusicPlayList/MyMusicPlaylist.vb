'###################################################################################
'#                                                                                 #
'#                              My MusicPlayList V1.0                              #
'#                                 (c) 2019 - 2020                                 #
'#                                                                                 #
'#                                                                                 #
'###################################################################################                                                                                #

Imports System.IO 'Imports system input output features

Public Class Form1
    Dim TrackList(9999) As String 'Sets number of tracks in the array
    Dim Action As String = "!p " 'Set action to 'play command for Discord
    Dim TrackCount As Integer 'Sets trackcount
    Dim SystemFilename As String = "MyPlayList.mpl" 'Set System filename

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Shows software icon system tray
        SniMyMusicPlayList.Visible = True

        'This routine checks to see if the following
        'file exists, if so then reads the file
        If File.Exists(SystemFilename) Then
            Dim SR As New StreamReader(SystemFilename)
            Do Until SR.Peek = -1
                TrackCount = TrackCount + 1
                TrackList(TrackCount) = SR.ReadLine
                MyMusicPlaylist.Items.Add(TrackList(TrackCount))
            Loop
            LblTeackCount.Text = TrackCount
            SR.Close()
            'Creates the following file, if the following
            'file does not exists
        Else
            File.Create(SystemFilename)
        End If
        'This subroutine turns off from the display
        BtnsOff()
    End Sub

    Private Sub BtnAddTrack_Click(sender As Object, e As EventArgs) Handles BtnAddTrack.Click
        'Adds Message to the Array & Listbox
        TrackCount = TrackCount + 1
        TrackList(TrackCount) = TbxEnterBand.Text
        MyMusicPlaylist.Items.Add(TrackList(TrackCount))
        LblTeackCount.Text = TrackCount
    End Sub

    Private Sub MyMusic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyMusicPlaylist.SelectedIndexChanged
        ' Search a track routine & copy selected track from list
        'and adds play command for Discord
        For TrackSelected As Integer = 0 To TrackCount
            If MyMusicPlaylist.SelectedItem = TrackList(TrackSelected) And MyMusicPlaylist.SelectedIndex >= 0 Then
                TbxEnterBand.Text = Action + TrackList(TrackSelected)
            End If
        Next
        'Copies the selected track to the clipbord
        'So you cam paste it to Discord '#Music, and play the track
        'using the '!p' command
        TbxEnterBand.SelectAll()
        TbxEnterBand.Copy()
        TbxEnterBand.Text = "Enter Band & Track"
        'Displays buttons on screen
        BtnsOn()
    End Sub

    Private Sub BtnDeleteTrack_Click(sender As Object, e As EventArgs) Handles BtnDeleteTrack.Click
        'Removes Message(s) from the Listbox 
        TbxEnterBand.Clear()
        MyMusicPlaylist.Items.RemoveAt(MyMusicPlaylist.SelectedIndex)
        TrackCount = TrackCount - 1
        LblTeackCount.Text = TrackCount
        MyMusicPlaylist.Refresh()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Clears text from text entry field
        TbxEnterBand.Clear()
    End Sub

    Private Sub BtnSaveTrack_Click(sender As Object, e As EventArgs) Handles BtnSaveTrack.Click
        'Runs SaveTracks subroutine
        SaveTracks()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Runs SaveTracks subroutine before closing program 
        SaveTracks()

        ' Removes software icon from system tray
        SniMyMusicPlayList.Dispose()
    End Sub

    Private Sub SaveTracks()
        'Writes track list to file
        Dim sw As New StreamWriter(SystemFilename)
        For Stored As Integer = 0 To TrackCount
            sw.WriteLineAsync(TrackList(Stored))
        Next
        sw.Close()
    End Sub

    Private Sub TbxEnterBand_Enter(sender As Object, e As EventArgs) Handles TbxEnterBand.Enter
        'Removes text prompt and changes text colour
        'back to black
        If TbxEnterBand.Text = "Enter Band & Track" Then
            TbxEnterBand.Text = ""
            TbxEnterBand.ForeColor = Color.Black
        End If
        'Turns off the Ctrl and the 'V' key fron
        'the screen
        BtnsOff()
    End Sub

    Private Sub TbxEnterBand_Leave(sender As Object, e As EventArgs) Handles TbxEnterBand.Leave
        'Inserts text prompt again and changes text colour
        'back to gray
        If TbxEnterBand.Text = "" Then
            TbxEnterBand.Text = "Enter Band & Track"
            TbxEnterBand.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnsOff()
        'Disables the following controls
        BtnCtrl.Visible = False
        LblPlusSign.Visible = False
        BtnV.Visible = False
        LblPasteIntoMusic.Visible = False
        BtnCtrl.Enabled = False
        BtnV.Enabled = False
    End Sub

    Private Sub BtnsOn()
        'Displays the following controls
        BtnCtrl.Visible = True
        LblPlusSign.Visible = True
        BtnV.Visible = True
        LblPasteIntoMusic.Visible = True
    End Sub
End Class
