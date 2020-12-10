Imports System.IO
Imports System.Threading.Thread

Public Class Form1

    Public CoderVsCoderNames As New ArrayList
    Dim CoderRandominzer As New Random
    Public SelCheck As Boolean
    Public DeleteCheck As Boolean
    Public DisplayMessageNumber As Integer
    Public RemovedCoder As Integer
    Public Messtext As String
    Dim SysDir As String = "C:\CoderVsCoder\"
    Dim SysFilename As String = "CodersNickmames.cnf"
    Dim Credited As String = "Software Created By SpeedyOnAGoSlow"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enables keyboard input / Disables other stuff 
        KeyPreview = True
        DspAppTitle.Enabled = False
        LBxCodersEntered.Enabled = False
        DispCoder1Header.Enabled = False
        DispVsHeader.Enabled = False
        DispCoder2Header.Enabled = False
        BtnReEnableStart.Enabled = False

        'Creates a directory
        If Not File.Exists(SysDir) Then
            Directory.CreateDirectory(SysDir)
        End If

        'Creates A File If No File 
        'Can Be Found
        If Not File.Exists(SysDir & SysFilename) Then
            'Creates A File
            File.Create(SysDir & SysFilename).Close()
        End If

        'Checks The Number Of Bytes Written To The
        'File, If Any
        If File.ReadAllBytes(SysDir & SysFilename).Length = 0 Then

            'Displays Main App Form
            Me.Show()

            'Displays A System Message To The User,
            'If No Data Can Read From The File
            Frm2SysMessages.ShowDialog()
        Else
            'Runs LoadFile Routine
            LoadFile()
            'Runs UpdateDisplay Routine 
            UpdateDisplay()
            'Sets "DisplayMessageNumber"
            DisplayMessageNumber = 1
            'Runs Subroutine
            DSM()
        End If
        'Programmer's Name (Speedy)
        LBLCreatedBy.Text = Credited
    End Sub

    Public Sub LoadFile()
        'Reads Data from a file
        CoderVsCoderNames.Clear() 'Clears Array
        LBxCodersEntered.Items.Clear() 'Clears Listbox
        'Sets Object To Read Data From The File
        'Also Sets SysDir = "C:\CoderVsCoder\" &
        'Sets SysFilename = "CodersNickmames.cnf"
        Dim sr As New StreamReader(SysDir & SysFilename)
        'Runs a loop
        Do Until sr.Peek = -1
            'Loads Data Into The Array, Until 
            'All Data Is Loaded
            CoderVsCoderNames.Add(sr.ReadLine)
            'Stops loop
        Loop
        'Closes Data File
        sr.Close()
        'Displays The Main Form
        Me.Show()
    End Sub

    Private Sub AddCodersNicknamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCodersNicknamesToolStripMenuItem.Click
        'Sets SelCheck & DeleteCheck Flags
        SelCheck = True
        DeleteCheck = False
        'Runs Subroutine
        UpdateDisplay()
        'Displays Form
        FrmAddCodersNames.Show()
    End Sub

    Private Sub DeleteNicknameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteNicknameToolStripMenuItem.Click
        'Runs Subroutine
        UpdateDisplay()
        'Displays DeteleNames Form
        FrmDeleteNames.Show()
        'Sets DeleteCheck Flag
        DeleteCheck = True
        'Displays The Number Of Nicknames To Be Removed
        'If No Names Are Selected The Delete Function
        'Is Disabled 

        If DeleteCheck = True And FrmDeleteNames.LBxDeleteCodersNames.Items.Count = 0 Then
            FrmDeleteNames.BtnUpdateDeletedList.Enabled = False
            FrmDeleteNames.BtnDeleteFromList.Enabled = False
            DisplayMessageNumber = 9
            DSM()
        Else
            FrmDeleteNames.BtnDeleteFromList.Enabled = True
            FrmDeleteNames.BtnUpdateDeletedList.Enabled = True
        End If

        If FrmDeleteNames.LBxDeleteCodersNames.SelectedItems.Count = 0 Then
            'Sets Delete Button To Be Non-Active
            'At The Time, On The Form
            FrmDeleteNames.BtnDeleteFromList.Enabled = False
            FrmDeleteNames.BtnUpdateDeletedList.Enabled = False
        End If
    End Sub

    Private Sub EditNicknameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditNicknameToolStripMenuItem.Click
        'Sets SelCheck Flag
        SelCheck = False
        'Runs Subroutine
        UpdateDisplay()
        'Displays Form
        FrmEditCodersNames.Show()

        If SelCheck = False And
            FrmEditCodersNames.LBxEditCodersNames.Items.Count = 0 Then
            DisplayMessageNumber = 11
            DSM()
        Else

            If FrmEditCodersNames.LBxEditCodersNames.SelectedItems.Count = 0 Then
                DisplayMessageNumber = 12
                DSM()
            End If
        End If
    End Sub

    Private Sub ReToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReToolStripMenuItem.Click
        'Resets App
        LoadFile()
        UpdateDisplay()
        BtnStart.Enabled = True
        BtnReEnableStart.Enabled = True
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes App
        Me.Close()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        'Starts Timer To Randomly Select Coders Into
        'The Program
        Timer1.Start()
    End Sub

    Private Sub Choices()
        'Randomizer Routine
        'Randomizer Coders One Name

        'Disables Button
        BtnStart.Enabled = False

        'Runs For Next Loop
        For spin = 0 To 20
            Dim NamePos As Integer
            'Gets The Coders Name Positition
            NamePos = CoderRandominzer.Next(0, CoderVsCoderNames.Count)
            LBxCodersEntered.SelectedItem = LBxCodersEntered.Items(NamePos)
            Sleep(200)
            'Displays Coders Nickname In Coder 1
            Label1.Text = CoderVsCoderNames(NamePos)
        Next
        'Stops Subroutine
        Timer1.Stop()
        'Removes Coders Name From The Arry
        CoderVsCoderNames.RemoveAt(LBxCodersEntered.SelectedIndex)
        LBxCodersEntered.Items.RemoveAt(LBxCodersEntered.SelectedIndex)

        'Randomizer Coders Two Name
        For spin = 0 To 20
            Dim NamePos As Integer
            'Gets The Coders Name Positition
            NamePos = CoderRandominzer.Next(0, CoderVsCoderNames.Count)
            LBxCodersEntered.SelectedItem = LBxCodersEntered.Items(NamePos)
            Sleep(200)
            'Displays Coders Nickname In Coder 1
            Label2.Text = CoderVsCoderNames(NamePos)
        Next
        'Stops Timer
        Timer1.Stop()

        'Removes Coder's Name From Coder's Entered From List
        CoderVsCoderNames.RemoveAt(LBxCodersEntered.SelectedIndex)
        LBxCodersEntered.Items.RemoveAt(LBxCodersEntered.SelectedIndex)
        BtnStart.Enabled = False
        BtnReEnableStart.Enabled = True

        'Resets All Buttons
        If LBxCodersEntered.Items.Count = 0 Then
            BtnStart.Enabled = False
            BtnReEnableStart.Enabled = False
            DisplayMessageNumber = 10
            DSM()
        ElseIf LBxCodersEntered.Items.Count = 1 Then
            BtnStart.Enabled = False
            BtnReEnableStart.Enabled = False
            DisplayMessageNumber = 10
            DSM()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Selects Coders Nickname To Displayed
        'in Coder 1 Or 2, And runs Subroutine
        '(All Subroutines Can Be Found At The
        'The Bottom Of Code)

        'Runs Subroutine
        Choices()
    End Sub

    Private Sub BtnReEnableStart_Click(sender As Object, e As EventArgs) Handles BtnReEnableStart.Click
        'Enables Start Button
        BtnStart.Enabled = True
        'Disables Re-EnableStart Button
        BtnReEnableStart.Enabled = False
    End Sub

    Public Sub UpdateDisplay()
        'Updates LBxCodersEntered
        LBxCodersEntered.Items.Clear()
        For Each CodersNameLoaded In CoderVsCoderNames
            LBxCodersEntered.Items.Add(CodersNameLoaded)
        Next

        'Updates LBxAddCodersNames
        FrmAddCodersNames.LBxAddCodersNames.Items.Clear()
        For Each CodersNameLoaded In CoderVsCoderNames
            FrmAddCodersNames.LBxAddCodersNames.Items.Add(CodersNameLoaded)
        Next
        FrmAddCodersNames.LBLNCR.Text = FrmAddCodersNames.LBxAddCodersNames.Items.Count

        'Updates LBxEditCodersNames
        FrmEditCodersNames.LBxEditCodersNames.Items.Clear()
        For Each CodersNameLoaded In CoderVsCoderNames
            FrmEditCodersNames.LBxEditCodersNames.Items.Add(CodersNameLoaded)
        Next
        FrmEditCodersNames.LBLNCR.Text = FrmEditCodersNames.LBxEditCodersNames.Items.Count

        'Updates LBxDeleteCodersNames
        FrmDeleteNames.LBxDeleteCodersNames.Items.Clear()
        For Each CodersNameLoaded In CoderVsCoderNames
            FrmDeleteNames.LBxDeleteCodersNames.Items.Add(CodersNameLoaded)
        Next
        FrmDeleteNames.LBLNCR.Text = FrmDeleteNames.LBxDeleteCodersNames.Items.Count
    End Sub

    Public Sub AddCoders()
        'Adds Coder's Nickname To A list
        CoderVsCoderNames.Add(FrmAddCodersNames.TBxEntCodersName.Text)
        FrmAddCodersNames.TBxEntCodersName.Clear()

        'Runs Update Display Routine
        UpdateDisplay()
        FrmAddCodersNames.LBLNCR.Text = FrmAddCodersNames.LBxAddCodersNames.Items.Count
    End Sub

    Public Sub DeleteCodersName()
        'Deletes Selected Coders Nickname 
        'Or Other Coders names
        RemovedCoder = 0
        Dim DeleteSelectedCoders = (From i In FrmDeleteNames.LBxDeleteCodersNames.SelectedItems).ToList
        For Each DeleteDiscordUsername In DeleteSelectedCoders
            RemovedCoder = RemovedCoder + 1
            CoderVsCoderNames.Remove(DeleteDiscordUsername)
        Next

        'Runs Subroutine
        UpdateDisplay()

        'Displays Infomation On "FrmDeleteNames"
        FrmDeleteNames.LBLNCR.Text = FrmDeleteNames.LBxDeleteCodersNames.SelectedItems.Count = 0
        FrmDeleteNames.LBLNCR.Text = 0
        FrmDeleteNames.BtnDeleteFromList.Enabled = False

        'Set DisplayMessageNumber
        DisplayMessageNumber = 3

        'Runs Subroutine that Displays Correct Message
        'Asighned with To The User
        DSM()
    End Sub

    Public Sub EditCodersName()
        'This Routoine Allows You to Edit Coder's Nicknames
        'If Required  And Removes The Nickname From The List.
        'And Returns It To The Text Enter Field

        Dim EditSelectedCoder = (From i In FrmEditCodersNames.LBxEditCodersNames.SelectedItems).ToList
        For Each EditDiscordUsername In EditSelectedCoder
            CoderVsCoderNames.Remove(EditDiscordUsername)
        Next

        'Runs "UpDateDisplay"
        UpdateDisplay()

        'This section Places The Cursor At The End
        'Of The Text Entered In The Text Field.
        'Once The Text as been Edited, Press The 'Enter Key
        'Replace It In The List
        FrmEditCodersNames.TBxEditCodersName.SelectionStart = FrmEditCodersNames.TBxEditCodersName.Text.Length + 1
        FrmEditCodersNames.TBxEditCodersName.Focus()
    End Sub

    Public Sub SaveCodersNames()
        'Saves Data To A File
        Dim sr As New StreamWriter(SysDir & SysFilename)
        'Checks SelCheck Status, Then SAves Data
        'To The File 
        If SelCheck = True Or SelCheck = False Then
            For Each SaveData In CoderVsCoderNames
                sr.WriteLineAsync(SaveData)
            Next
            'Closes File
            sr.Close()
        End If

        'Checks If "SelCheck Flag Is Active Or Not
        'And Checks If "DeleteCheck Flag" Is Also
        'Active Or Not
        If SelCheck = True And DeleteCheck = True Then
            'Displays The Correct Messages
            DisplayMessageNumber = 7
        ElseIf SelCheck = True And DeleteCheck = False Then
            DisplayMessageNumber = 6
        End If
    End Sub

    Public Sub DSM()
        'Displays All Screen Messages The User
        'Each One Asigned To Each DisplayMessageNumber
        If DisplayMessageNumber = 1 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "Coder's Names Have Been Loaded"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 2 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "Coder's Name(s) Has Been Saved"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 3 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = RemovedCoder & " Coder's Name(s) Have Been Removed From The List, Click Update To Update List"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 4 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "No Coder Nickname Entered"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 5 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "Coder's Nickname Edited, Click Update To Save Changes"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 6 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "Coder's Name Has Been Saved And Updated"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 7 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "Coder's Nickname(s), Has Been Updated"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 8 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "No Coder's Nickname, Selected"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 9 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "There Are No Nicknames To Delete"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 10 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "Please Reset Randomizer"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 11 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "There Are No Nicknames To Edit"
            FrmDisplayMessages.ShowDialog()
        ElseIf DisplayMessageNumber = 12 Then
            FrmDisplayMessages.DisplaySystemMessage.Text = "No Nicknames Selected For Editing, Please Select One.  Then Click On Edit To Make Changes, Then Click Update When Finished"
            FrmDisplayMessages.ShowDialog()
        End If
    End Sub
End Class