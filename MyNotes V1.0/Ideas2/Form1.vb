Imports System.IO
Public Class Form1
    Dim ask As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check for MyNotes Directory, if No Directory Found
        'The software will create one for you
        'and displays the correct system message to you      
        'Disables icons / buttons
        Button1.Enabled = False : Button3.Enabled = False : Button4.Enabled = False
        Dim MBM As String
        Dim MBT As String
        MBM = "MyNotes Directory Already Exists"
        MBT = "System Message"
        If Directory.Exists("C:\MyNotes") Then
            Me.Show()
            MessageBox.Show(MBM, MBT)
        Else
            MBM = "MyNotes Directory Has Been Created"
            MBT = "System Message"
            Directory.CreateDirectory("C:\MyNotes")
            Me.Show()
            MessageBox.Show(MBM, MBT)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clears note and disables Icos
        RichTextBox1.Clear()
        Label1.Text = "New"
        Label3.Text = "Untitled"
        Button1.Enabled = False : Button3.Enabled = False : Button4.Enabled = False
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'if note is not blank, then enables Icon, 1, 3 & disables Icon 4

        If RichTextBox1.Text <> "" Then
            Button1.Enabled = True : Button3.Enabled = True : Button4.Enabled = False
        Else
            'if note is blank, then Disables Icon, 1, 3 & disables Icon 4
            'When you start typing again, Icons 1 & 3 are enable once again
            If RichTextBox1.Text = "" Then
                Button1.Enabled = False : Button3.Enabled = False : Button4.Enabled = False
            End If
            'if you load a note, all Icons are enabled
        End If
        If RichTextBox1.Text <> "" And File.Exists(OFD.FileName) Then
            Button1.Enabled = True : Button3.Enabled = True : Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Display an Open dialogbox, so you can load a note/file
        OFD.Title = "Open File"
        OFD.Filter = "MyFile Format (.mff) |*.mff"
        OFD.InitialDirectory = "C:\MyNotes"
        If OFD.ShowDialog = DialogResult.OK Then
            Label1.Text = "Open"
            RichTextBox1.LoadFile(OFD.FileName)
        End If
        'Display filename Without Extension
        'on the main screen
        Label3.Text = System.IO.Path.GetFileNameWithoutExtension(OFD.FileName)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Display an Save dialogbox, so you can save a note/file
        SFD.Title = "Save File"
        SFD.Filter = "MyFile Format (.mff) |*.mff" 'sets filter
        SFD.InitialDirectory = "C:\MyNotes" 'Sets InitialDirectory
        SFD.FileName = Label3.Text 'Displays filename
        If SFD.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(SFD.FileName)
        End If
        'Display filename Without Extension
        'on the main screen
        Label3.Text = System.IO.Path.GetFileNameWithoutExtension(SFD.FileName)
    End Sub
    'Enables Icon 4
    'and allows you to delete the note/file, if user clicks 'yes' else does nothing
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MBM = "Do You Want To Delete This File"
        Dim MBT = "Delete File"
        Dim Ask As DialogResult = MessageBox.Show(MBM, MBT, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Ask = DialogResult.No Then

        ElseIf Ask = DialogResult.Yes Then
            File.Delete(OFD.FileName) ' Deletes note/file
            RichTextBox1.Clear() 'Clears note/file
            Label1.Text = "New" 'Sets label
            Label3.Text = "Untitled" 'Sets label
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Allow you to select your pen colour
        'from the colour dialog
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        'Allow you to select your font/size & style
        'from the font dialog
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub


    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        'Copies highlighted text
        RichTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        'Cuts highlighted text
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
        'Pastes from clipboard
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        'highlights all text
        RichTextBox1.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        'undo last action user did if required
        RichTextBox1.Undo()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes application
        Me.Close()
    End Sub

End Class
