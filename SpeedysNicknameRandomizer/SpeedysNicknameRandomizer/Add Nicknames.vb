Imports System.IO
Public Class Add_Nicknames
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'Stores data from 'Add_Nicknames' form
        Dim SysDir As String = "C:\NicknameRandomizer\"
        Dim Sysfilename As String = "Nicknames.ptf"
        Form1.Show()

        Dim sw As New StreamWriter(SysDir & SysFilename)
        sw.WriteLine(TBxEdit.Text)
        sw.Close()
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        'Closes active window
        Me.Close()
    End Sub
End Class