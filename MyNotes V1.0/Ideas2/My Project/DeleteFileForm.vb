Imports System.IO
Public Class DeleteFileForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.Delete(Form1.Label3.Text + "mff")
    End Sub
End Class