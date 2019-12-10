Public Class MainApp
    'Stores Mouse Position
    Dim Mouse_Move As System.Drawing.Point

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'Gets Mouse Position When Mouse Is Pressed
        Mouse_Move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub MainApp_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'This Routine Allows Boardless Form To Be Moved Around The Screen
        If e.Button = MouseButtons.Left Then
            Dim MousePos As Point
            MousePos = Control.MousePosition
            MousePos.Offset(Mouse_Move.X, Mouse_Move.Y)
            Me.Location = MousePos
        End If
    End Sub

    Private Sub BtnDeathCount_Click(sender As Object, e As EventArgs) Handles BtnDeathCount.Click
        'If Death Count Gets To 500, Then Death Count Button Is Disabled
        If DisplayDeathCount.Text = 500 Then
            BtnDeathCount.BackColor = Color.DarkRed
            BtnDeathCount.ForeColor = Color.Black
            BtnDeathCount.Enabled = False
        Else
            'When The Death Is Pressed The Count Increases Bt 1
            DisplayDeathCount.Text = DisplayDeathCount.Text + 1
        End If
    End Sub

    Private Sub BtnResetDeathCount_Click(sender As Object, e As EventArgs) Handles BtnResetDeathCount.Click
        'Resets Death Count To Zero & Re-Enables Death Button
        If BtnDeathCount.Enabled = False Then
            BtnDeathCount.Enabled = True
            DisplayDeathCount.Text = 0
            BtnDeathCount.BackColor = Color.Black
            BtnDeathCount.ForeColor = Color.DarkRed
        Else
            'Resets Death Count To Zero
            DisplayDeathCount.Text = 0
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Closes Application
        Me.Close()
        Me.Dispose()
    End Sub
End Class
