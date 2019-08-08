'
Imports System.IO
Imports System.Threading.Thread
Public Class Form2
    Dim FCount As Integer 'Counts the files saved
    Dim Count As Integer 'Counts the files saved into the list
    Dim FName As String 'Stores the filenames
    Dim MyFiles(20) As String ' Sets the and size to 20

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Loads your saved files into an array, so you can
        'search your files, by highlighting it in the list
        Button17.Text = "Select A File"
        For Each FName As String In Directory.GetFiles("C:\LabelMaker")
            Count = Count + 1
            MyFiles(Count) = FName
        Next
        For FCount = 1 To Count
            ListBox1.Items.Add(MyFiles(FCount))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        'Allows you to search label files, before deleting it
        For Pos As Integer = 0 To Count
            If ListBox1.SelectedItem = MyFiles(Pos) And ListBox1.SelectedIndex >= 0 Then
                FName = MyFiles(Pos)
                Button17.Text = "Delete " & FName
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Deletes the selected from the search routine
        'Deletes the selected from the directory
        'updates the search routine
        'resets the text entery area
        'tells you the as been deleted
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        ListBox1.Refresh()
        LMv13.RichTextBox1.Clear()
        LMv13.Button16.Text = "Label Name"
        File.Delete(FName)
        Button17.Text = "File Deleted"
        Sleep(500)
        Button17.Text = "Select A File"
    End Sub

    ' Closes the application
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class