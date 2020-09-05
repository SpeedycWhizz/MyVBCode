Imports System.IO
Imports System.Threading.Thread

Public Class Form1

    Dim StorageOfYourNicknames As New ArrayList
    Dim Randomizer As New Random
    Public BtnMode As Boolean
    Dim SysDir As String = "C:\NicknameRandomizer\"
    Dim SysFilename As String = "Nicknames.ptf"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disables or enables display before
        'pre-loading stuff

        Me.Text = ""
        TBxcopy.Visible = False
        CmdDisplay.Visible = False
        DisplayName.Enabled = True
        CmdDisplay.Enabled = True

        'Creates Directory on drive C:
        If Not Directory.Exists(SysDir) Then
            Directory.CreateDirectory(SysDir)
        End If

        'Create a file
        If Not File.Exists(SysDir & SysFilename) Then
            File.Create(SysDir & SysFilename).Close()
        End If

        'Error checking routine, if no nicknames
        'entered, displays error message
        If File.ReadAllBytes(SysDir & SysFilename).Length = 0 Then
            Messages.ShowDialog()
        Else
            'Subroutine
            PopulateRandomizer()
        End If

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        'Select Nickname from list at random
        BtnStart.Text = "Thinking......."
        DisplayName.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Timer tick subrountine
        Choices()
    End Sub

    Private Sub Choices()

        'Randomizer Routine
        LBxNicknames.Enabled = False
        CmdDisplay.Visible = False
        For spin = 0 To 20
            Dim NamePos As Integer
            NamePos = Randomizer.Next(0, StorageOfYourNicknames.Count)
            LBxNicknames.SelectedItem = LBxNicknames.Items(NamePos)
            Sleep(200)
            DisplayName.Text = StorageOfYourNicknames(NamePos)
        Next
        Timer1.Stop()

        'Copies  the selected nickname
        TBxcopy.Text = DisplayName.Text
        TBxcopy.SelectAll()
        TBxcopy.Copy()
        BtnStart.Text = "START"

        'Displays a message to to the user
        CmdDisplay.Visible = True
    End Sub

    Private Sub AddNicknamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNicknamesToolStripMenuItem.Click

        'checks name of the form and displys it
        BtnMode = True

        If BtnMode = True Then
            Add_Nicknames.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub EditNicknamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditNicknamesToolStripMenuItem.Click
        'allows user to edit Nicknames
        'and allows user to add more

        BtnMode = False
        If BtnMode = False Then
            Add_Nicknames.Text = "Edit_Nicknames"
            Add_Nicknames.BtnAdd.Text = "Update"
            For Each n In StorageOfYourNicknames
                Add_Nicknames.TBxEdit.Text += n & vbCrLf
            Next
            Add_Nicknames.Show()
        End If
    End Sub

    Private Sub ResetRandomizerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetRandomizerToolStripMenuItem.Click
        'Subroutine
        PopulateRandomizer()
    End Sub

    Private Sub PopulateRandomizer()

        'Loads Nicknames from a file
        StorageOfYourNicknames.Clear()
        Dim sr As New StreamReader(SysDir & SysFilename)
        Do Until sr.Peek = -1
            StorageOfYourNicknames.Add(sr.ReadLine)
        Loop
        sr.Close()

        'Clears LBx before Adding any
        'names
        LBxNicknames.Items.Clear()

        'Adds names to LBx
        For Each LoadNicknames In StorageOfYourNicknames
            LBxNicknames.Items.Add(LoadNicknames)
        Next
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'Closes App
        Application.Exit()
    End Sub

End Class
