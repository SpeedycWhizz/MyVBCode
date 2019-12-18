Public Class SysInfo
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        'Sets Second Form, to False. This Form Display All Messages To The User
        Me.Visible = False
        'hides Second Form, When 'OK' Is Pressed
        Me.Hide()

    End Sub
End Class