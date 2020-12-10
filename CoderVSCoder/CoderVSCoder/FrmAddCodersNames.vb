Public Class FrmAddCodersNames

    Private Sub FrmAddCodersNames_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Sets Buttons On Form
        KeyPreview = True
        LBxAddCodersNames.Enabled = False
        BtnAddToList.Enabled = False
        BtnSaveList.Enabled = False
        BtnClear.Enabled = False
    End Sub

    Private Sub BtnAddToList_Click(sender As Object, e As EventArgs) Handles BtnAddToList.Click
        'Runs Subroutines
        Form1.AddCoders()
        Form1.UpdateDisplay()

        'Resets Buttons On Form
        BtnSaveList.Enabled = True
        BtnAddToList.Enabled = False

        'Resets Focus In Text Field
        TBxEntCodersName.Focus()
    End Sub

    Private Sub FrmAddCodersNames_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'If The 'ENTER Key Is Pressed And Then Runs
        'Subroutines
        If Form1.SelCheck = True And
            TBxEntCodersName.Text <> "" And
         e.KeyCode = Keys.Enter Then
            Form1.AddCoders()
            Form1.UpdateDisplay()
            TBxEntCodersName.Clear()
            BtnAddToList.Enabled = False
            BtnSaveList.Enabled = True

            'If The 'ENTER Key Is Pressed And No
            'Text Entered In the Text Field Then
            'An Error Message is Diaplayed 
        ElseIf TBxEntCodersName.Text = "" And
         e.KeyCode = Keys.Enter Then
            BtnAddToList.Enabled = False
            BtnSaveList.Enabled = False
            Form1.DisplayMessageNumber = 5
            Form1.DSM()
        End If
    End Sub

    Private Sub TBxEntCodersName_TextChanged(sender As Object, e As EventArgs) Handles TBxEntCodersName.TextChanged
        'Enables Buttons If Text Field Is Active
        If TBxEntCodersName.Text <> "" Then
            BtnAddToList.Enabled = True
            BtnClear.Enabled = True
        Else
            'Disables Buttons If Text Field Is Not Active
            BtnAddToList.Enabled = False
            BtnClear.Enabled = False
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Clears Text Field
        TBxEntCodersName.Clear()
    End Sub

    Private Sub BtnSaveList_Click(sender As Object, e As EventArgs) Handles BtnSaveList.Click
        'Runs Subroutine
        Form1.SaveCodersNames()
        Form1.DisplayMessageNumber = 2
        Form1.DSM()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Closes Form
        Me.Close()
    End Sub
End Class