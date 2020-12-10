Public Class FrmDisplayMessages

    Private Sub FrmDisplayMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySystemMessage.Enabled = False
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        'Resets Buttons On Forms
        If Form1.SelCheck = True Then
            Form1.DisplayMessageNumber = 2
            FrmAddCodersNames.BtnAddToList.Enabled = False
            FrmAddCodersNames.BtnSaveList.Enabled = False
            FrmAddCodersNames.BtnClear.Enabled = False
        ElseIf Form1.SelCheck = False Then
            Form1.DisplayMessageNumber = 7
            FrmEditCodersNames.BtnEdit.Enabled = False
            FrmEditCodersNames.BtnUpdate.Enabled = False
        End If

        Form1.UpdateDisplay()

        'Closes Form
        Me.Close()
    End Sub
End Class