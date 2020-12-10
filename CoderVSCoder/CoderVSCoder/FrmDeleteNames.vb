Public Class FrmDeleteNames

    Private Sub BtnDeleteFromList_Click(sender As Object, e As EventArgs) Handles BtnDeleteFromList.Click
        'Runs Delete Subroutine
        Form1.DeleteCodersName()
        'Error Check
        LBxDeleteCodersNames.SelectedIndex = -1
        If LBxDeleteCodersNames.SelectedIndex = -1 Then
            LBLNC.Text = "Nickname Count"
        End If
    End Sub

    Private Sub LBxDeleteCodersNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBxDeleteCodersNames.SelectedIndexChanged
        'Displays The Number Of Nicknames Selected 
        'To be Deleted
        LBLNCR.Text = LBxDeleteCodersNames.SelectedItems.Count
        LBLNC.Text = "Nickname Selected"

        'Error Checks
        If Form1.DeleteCheck = True And
        LBxDeleteCodersNames.Items.Count > 0 Then
            'Enables Button
            BtnDeleteFromList.Enabled = True
        Else
            'Disables Button
            BtnDeleteFromList.Enabled = False
        End If

        'Error Check
        If LBxDeleteCodersNames.SelectedItems.Count > 0 Then
            'Enables Button
            BtnUpdateDeletedList.Enabled = True
        End If

        'Error Check & Disables
        LBLNCR.Text = LBxDeleteCodersNames.SelectedItems.Count
        If LBxDeleteCodersNames.SelectedIndex = -1 Then
            LBLNC.Text = "Nickname Count"
            'Disables Buttons
            BtnDeleteFromList.Enabled = False
            BtnUpdateDeletedList.Enabled = False
        End If
    End Sub

    Private Sub BtnUpdateDeletedList_Click(sender As Object, e As EventArgs) Handles BtnUpdateDeletedList.Click
        'Runs Subroutine
        Form1.SaveCodersNames()
        'Sets Message To Be Displayed
        Form1.DisplayMessageNumber = 7
        'Displays Messages
        Form1.DSM()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Closes Form
        Me.Close()
    End Sub
End Class