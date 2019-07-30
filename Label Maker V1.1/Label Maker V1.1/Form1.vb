Public Class Form1
    Dim StoreCurrentLabel As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        StoreCurrentLabel = RichTextBox1.Text
        RichTextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If StoreCurrentLabel <> "" Then
            RichTextBox1.Text = StoreCurrentLabel
        Else
            MessageBox.Show("The Label Is Blank", "Error")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        RichTextBox1.Text = StoreCurrentLabel + Environment.NewLine
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Font1 As New Font("Ariel", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, Font1, Brushes.Black, 100, 100)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintDocument1.Print()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Home Made Software", "(c) 2018 - 2019")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class
