'Using the following imports

Imports System.IO
Imports System.Drawing.Text
Imports System.Drawing.Printing
Imports System.Threading.Thread

Public Class LMv13
    'Sets the following as strings or integers
    Dim MyLabel As String
    Dim MouseClickMessage As String = "Printing Label(s), Please Wait...."
    Dim MouseHoverMessage As String = "Label Ready For Printing"
    Dim MouseHoverMessage2 As String = "No Label  Can Be Printed"
    Dim MouseLeaveMessage As String = "Print Label"
    Dim MBM As String = "Do You Want To Delete This File"
    Dim MBT As String = "System Message"
    Dim MBM2 As String = "Sorry, You Are Unable To Preview A Blank Label"
    Dim MBM3 As String = "Label Maker Directory Already Exists"
    Dim MBM4 As String = "Label Maker Directory Has Been Created"
    Dim FSize As Integer = 16
    Dim Count As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Saves your font, size
        FD.Font = My.Settings.MyFont

        'Check to see if directoy exists, if noy it creates one.
        'Shows correct message to user
        If Directory.Exists("C:\LabelMaker") Then
            Me.Show()
            MessageBox.Show(MBM3, MBT)
        Else
            Directory.CreateDirectory("C:\LabelMaker")
            Me.Show()
            MessageBox.Show(MBM4, MBT)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Clears label

        Me.RichTextBox1.Clear()
        Button16.Text = "Label Name"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Undo allow user to undo last action

        Me.RichTextBox1.Undo()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        'Redo last action, if you have undone the last action

        Me.RichTextBox1.Redo()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Display an Open dialogbox, so you can load a label file

        OFD.Title = "Open File"
        OFD.Filter = "MyFile Format (.mff) |*.mff" 'sets filter
        OFD.InitialDirectory = "C:\LabelMaker" 'Sets InitialDirectory
        If OFD.ShowDialog = DialogResult.OK Then
            RichTextBox1.LoadFile(OFD.FileName)
        End If

        'Display filename Without Extension
        'on the main screen

        Button16.Text = System.IO.Path.GetFileNameWithoutExtension(OFD.FileName)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Display an Save dialogbox, so you can save a label/file

        SFD.Title = "Save File"
        SFD.Filter = "MyFile Format (.mff) |*.mff" 'sets filter
        SFD.InitialDirectory = "C:\LabelMaker" 'Sets InitialDirectory
        If SFD.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(SFD.FileName)
        End If

        'Display filename Without Extension
        'on the on form1 (LMV13)

        Button16.Text = System.IO.Path.GetFileNameWithoutExtension(SFD.FileName)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        'Display a font dialogbox to the user, so they can
        'can change font, fontsize & style.

        FD.ShowDialog()
        RichTextBox1.Font = FD.Font
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        'Checks to see if text is entered into the text area
        'and when mouse hovers over the print label button,
        'displays the correct respose to the user.
        If RichTextBox1.TextLength > 0 Then
            Button5.ForeColor = Color.DarkGreen
            Button5.Text = MouseHoverMessage
        ElseIf RichTextBox1.TextLength = 0 Then
            Button5.ForeColor = Color.Red
            Button5.Text = MouseHoverMessage2
        End If
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave

        'Changes the text on the print label button
        'when the cursor moves away the print label button.

        Button5.ForeColor = Color.Black
        Button5.Text = MouseLeaveMessage
    End Sub

    'sets the print Document for printing

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font(RichTextBox1.Font.Name, RichTextBox1.Font.Size, RichTextBox1.Font.Style, RichTextBox1.Font.Unit)
        e.Graphics.DrawString(RichTextBox1.Text, font1, Brushes.Black, 100, 100)
    End Sub

    Private Sub Button5_MouseClick(sender As Object, e As MouseEventArgs) Handles Button5.MouseClick

        'Tells the user that they can print the label

        If RichTextBox1.Text <> "" Then
            Button5.ForeColor = Color.DarkGreen
            Button5.Text = MouseClickMessage
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        'Print previews label, else tells the user they are unenable
        'to print the label, and also disables the print label button.

        If RichTextBox1.TextLength > 0 Then
            Button5.Enabled = True
            PrintPreviewDialog1.ShowDialog()
        Else
            Dim Ask = MessageBox.Show(MBM2, MBT, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            If Ask = DialogResult.OK Then
                Button5.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button9_Click_2(sender As Object, e As EventArgs) Handles Button9.Click
        'Shows form2 and its controls
        Form2.Show()
    End Sub

    Private Sub LimeGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeGreenToolStripMenuItem.Click

        'Text highlght colour Lime Green
        RichTextBox1.SelectionBackColor = Color.LimeGreen
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click

        'Text highlght colour Yellow
        RichTextBox1.SelectionBackColor = Color.Yellow
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click

        'Text highlght colour Pink
        RichTextBox1.SelectionBackColor = Color.Pink
    End Sub

    Private Sub PaleGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaleGreenToolStripMenuItem.Click

        'Text highlght colour Pale Green
        RichTextBox1.SelectionBackColor = Color.PaleGreen
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click

        'Selects all the text
        RichTextBox1.SelectAll()
    End Sub

    Private Sub LMv13_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.MyFont = FD.Font

    End Sub
End Class
