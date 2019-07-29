Imports System.IO  'Imports system i.o for reading files
Imports System.Threading.Thread 'Enables treading for sleep
Public Class Tam
    Dim MessagesFile As String = "Messages.smg" 'Sets messagefile to filename
    Dim StoreMessage(100) As String 'Set number of messages in array
    Dim MessageCount As Integer ' Counts messages into the array
    Dim Pos As Integer 'Gets message position in the array
    Dim NoVol As Integer = 0 'Set NoVol to 0
    Dim HalfVol As Integer = 50 'Set Half Volume to 50
    Dim MaximumVol As Integer = 100 'Set maximum Volume to 100
    Dim Fadeout As Boolean 'Set boolean flag 
    Dim SAPI As Object ' Sets Sapi object
    Dim MBM As String 'Sets Sapi messages

    'Fade In/Opacity Level
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity = 1 Then
            Timer1.Enabled = False
        Else
            Me.Opacity = Me.Opacity + 0.01
        End If
    End Sub

    'Fade Out/Opacity Level
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity = 0 Then
            Fadeout = True
            End
        Else
            Me.Opacity = Me.Opacity - 0.01
        End If
    End Sub
    'Presets load form events & loads messages routine
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Value = HalfVol
        Label10.Text = TrackBar1.Value
        SAPI = CreateObject("SAPI.Spvoice")
        Button1.Visible = False : Button2.Visible = False
        RadioButton1.Checked = True
        LoadMessages()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SAPI.volume = TrackBar1.Value
        SaveMassages() 'save routine
        BackupMessages() ' Backup Messages routine
        ClosingApplication() 'Closes Application 
        NotifyIcon1.Dispose() ' Revomes system tray icom

        'Set Fadeout flag
        If Fadeout = True Then
            End
        Else
            Timer2.Enabled = True
            e.Cancel = True
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Label5.Text = RichTextBox1.TextLength 'Display text length
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        'Message listbox search routine
        For Pos As Integer = 0 To MessageCount
            If ListBox1.SelectedItem = StoreMessage(Pos) And ListBox1.SelectedIndex >= 0 Then
                RichTextBox1.Text = StoreMessage(Pos)
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Removes Message(s) from the Listbox 
        RichTextBox1.Clear()
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        MessageCount = MessageCount - 1
        Label2.Text = MessageCount
        ListBox1.Refresh()
    End Sub

    Private Sub AddMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMessageToolStripMenuItem.Click

        'Adds Message to the Array & Listbox
        'Speak message, and stop app lockingup
        MBM = "Adding New Message"
        SAPI.speak(MBM, AudioPlayMode.Background)
        MessageCount = MessageCount + 1
        Label2.Text = MessageCount 'Displays message count
        ListBox1.Items.Add(RichTextBox1.Text) 'Adds entered message into list of messges
        StoreMessage(MessageCount) = RichTextBox1.Text 'Add message to the array
        RichTextBox1.Clear() 'Clears text richtextnox
        RichTextBox1.Focus() ' Focus cursor
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll() '
    End Sub

    Private Sub SaveMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMessageToolStripMenuItem.Click
        SaveMassages()
    End Sub

    Private Sub CopyMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyMessageToolStripMenuItem.Click
        'Copies Text 
        If RichTextBox1.TextLength = 0 Then
            MBM = "No Message Written"
            SAPI.speak(MBM)
        Else
            ' Highlights all text
            RichTextBox1.SelectAll()
            RichTextBox1.SelectionBackColor = Color.Yellow
            RichTextBox1.Copy()
            MBM = "Copying, Selected Message"
            SAPI.speak(MBM, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub DeleteMessageFromListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMessageFromListToolStripMenuItem.Click
        'Checks if all messages have been deleted
        If ListBox1.SelectedIndex = -1 Then
            MBM = "No Message Highlighted For Deletion"
            SAPI.speak(MBM) 'Speak message
        Else
            'Displays 'Yes or No buttons
            MBM = "Do You Want To Delete This Message"
            SAPI.speak(MBM)
            Sleep(1)
            Button1.Visible = True : Button2.Visible = True
        End If
    End Sub
    'Removes 'Yes or No buttons from display
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RemovesMessage() 'Remove message 
        Sleep(1)
        Button1.Visible = False : Button2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Removes 'Yes or No buttons from display
        MBM = "No Message Was Deleted"
        SAPI.speak(MBM)
        Sleep(1)
        Button1.Visible = False : Button2.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'Enables Speech
        If RadioButton1.Checked = True Then
            TrackBar1.Value = HalfVol
            SAPI.volume = TrackBar1.Value
            Button3.Text = "Speech Volume Level Check"
            Label10.Text = SAPI.volume
            Button3.Enabled = True
            TrackBar1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'Disables Speech
        If RadioButton2.Checked = True Then
            Button3.Text = "Speech Off"
            SAPI.volume = NoVol
            TrackBar1.Value = SAPI.volume
            Label10.Text = SAPI.volume
            Button3.Enabled = False
            TrackBar1.Enabled = False
        End If
    End Sub

    Private Sub ClearMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMessageToolStripMenuItem.Click

        'Highlights Text & Clears Text
        If RichTextBox1.SelectionBackColor = Color.Yellow Then
            MBM = "Clearing Highlighted Message"
            Clipboard.Clear()
            SAPI.speak(MBM)
            Sleep(0.5)
            RichTextBox1.Clear()
        ElseIf RichTextBox1.TextLength > 0 Then
            MBM = "Clearing Message"
            Clipboard.Clear()
            SAPI.speak(MBM)
            Sleep(0.5)
            RichTextBox1.Clear()
        ElseIf RichTextBox1.TextLength = 0 Then
            MBM = "No Message To Clear"
            Clipboard.Clear()
            SAPI.speak(MBM)
            Sleep(0.5)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'Controls Speech Volume
        SAPI.volume = TrackBar1.Value
        Label10.Text = TrackBar1.Value
        If TrackBar1.Value = NoVol Then
            Button3.Text = "Speech Volume Level Too Low"
            Button3.Enabled = False

        ElseIf TrackBar1.Value > NoVol And TrackBar1.Value < HalfVol Or TrackBar1.Value > HalfVol And TrackBar1.Value < MaximumVol Then

            Button3.Text = "Speech Volume Level Check"
            Button3.Enabled = True
        ElseIf TrackBar1.Value = HalfVol Then
            Button3.Text = "Speech Volume Level Is At Half Volume"
        ElseIf TrackBar1.Value = MaximumVol Then
            Button3.Text = "Speech Volume Level Is As At Maximum"
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Speaks volume level message
        MBM = "Speech Volume Level Check"
        SAPI.speak(MBM, AudioPlayMode.Background)
    End Sub

    Private Sub LoadMessages()
        'Checks file routine
        Me.Show()
        If Not File.Exists(MessagesFile) Then
            File.Create(MessagesFile)
        End If
        'loads file, if bytesize is more than 0
        If File.ReadAllBytes(MessagesFile).Length > 0 Then
            Dim sr As New StreamReader(MessagesFile)
            Do Until sr.Peek = -1
                MessageCount = MessageCount + 1
                StoreMessage(MessageCount) = sr.ReadLine
                ListBox1.Items.Add(StoreMessage(MessageCount))
            Loop
            sr.Close()
            Label2.Text = MessageCount
        Else
            Me.Opacity = 100
            Me.Show()
            'Remove messages file, bytesize is 0 & replaces it with the backup
            'Then reloads the messages file
            If File.ReadAllBytes(MessagesFile).Length = 0 Then
                MBM = "No Messages Loaded"
                SAPI.speak(MBM)
                Sleep(2)
                MBM = "Loading Messages From Backup"
                SAPI.speak(MBM)
                Sleep(2)
                File.Delete("Messages.smg")
                File.Copy("Messages.bak", "Messages.smg")
                MBM = "Loading Complete"
                SAPI.speak(MBM)
                LoadMessages()
            End If
        End If
    End Sub

    Private Sub SaveMassages()
        'Save message routine
        MBM = "Saving Messages"
        SAPI.speak(MBM, AudioPlayMode.Background)
        Dim sw As New StreamWriter(MessagesFile)
        For nm As Integer = 0 To MessageCount
            sw.WriteLineAsync(StoreMessage(nm))
        Next
        sw.Close()
    End Sub

    Private Sub RemovesMessage()
        'remove messages routine
        MBM = "Deleting Message"
        SAPI.speak(MBM, AudioPlayMode.Background)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        RichTextBox1.Clear()
        MessageCount = MessageCount - 1
        Label2.Text = MessageCount
        ListBox1.Refresh()
    End Sub

    Private Sub BackupMessages()
        'Creates backup files
        MBM = "Creating A Backup Of All Messages"
        SAPI.speak(MBM, AudioPlayMode.Background)
        Dim sw As New StreamWriter("Messages.bak")
        For nm As Integer = 0 To MessageCount
            sw.WriteLineAsync(StoreMessage(nm))
        Next
        sw.Close()
    End Sub

    Private Sub ClosingApplication()
        MBM = "Closing Application"
        SAPI.speak(MBM, AudioPlayMode.WaitToComplete)
    End Sub
End Class
