Imports System.Threading
Imports System.Threading.Thread

Public Class FrmEditCodersNames

    Private Sub FrmEditCodersNames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enables Fotm Controls
        KeyPreview = True
        BtnUpdate.Enabled = False
        BtnEdit.Enabled = False

    End Sub

    Private Sub FrmEditCodersNames_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Checks SelCheck Status
        If Form1.SelCheck = False And
            TBxEditCodersName.Text <> "" And
         e.KeyCode = Keys.Enter Then
            'Adds Text Entry To A Array
            Form1.CoderVsCoderNames.Add(TBxEditCodersName.Text)
            'Runs Routine
            Form1.UpdateDisplay()
            'Clears Text Entry
            TBxEditCodersName.Clear()
            'Sets Message To Be Display
            Form1.DisplayMessageNumber = 5
            'Runs Subroutine To Display Message
            Form1.DSM()
            'Disables Button
            BtnEdit.Enabled = False
            'Enables Button
            BtnUpdate.Enabled = True
            'Checks SelCheck Status
        ElseIf Form1.SelCheck = False And
            TBxEditCodersName.Text = "" And
         e.KeyCode = Keys.Enter Then
            'Sets Message To Be Display
            Form1.DisplayMessageNumber = 8
            'Runs Subroutine To Display Message
            Form1.DSM()
        End If
    End Sub

    Private Sub LBxEditCodersNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBxEditCodersNames.SelectedIndexChanged
        'Checks To See If A Name Is Selected
        TBxEditCodersName.Text = LBxEditCodersNames.SelectedItem
        If LBxEditCodersNames.SelectedIndex = -1 Then
            'Sets Message To Be Displayed
            Form1.DisplayMessageNumber = 8
            'Runs Subroutine 
            Form1.DSM()
            'Disables Buttons
            BtnEdit.Enabled = False
            BtnUpdate.Enabled = False
        Else
            'Enables Buttons
            BtnEdit.Enabled = True
            BtnUpdate.Enabled = True
        End If

        'Counts Selected Name
        LBLNCR.Text = LBxEditCodersNames.SelectedItems.Count
        LBLNC.Text = "Nickname Selected"

        'Enables Buttons
        If Form1.SelCheck = False And
        LBxEditCodersNames.Items.Count > 0 Then
            BtnEdit.Enabled = True
        Else
            'Disables Button
            BtnEdit.Enabled = False
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'Runs Subroutine
        Form1.EditCodersName()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'Updates Coder Count
        LBLNC.Visible = True
        LBLNCR.Visible = True
        LBLNC.Text = "Coder's Nickname Count"
        LBLNCR.Text = LBxEditCodersNames.Items.Count
        'Runs Subroutine
        Form1.SaveCodersNames()
        'Sets Message To Be Displayed
        Form1.DisplayMessageNumber = 6
        'Runs Subroutine
        Form1.DSM()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        'Clears Text Field
        TBxEditCodersName.Clear()
        'Deselect Coders Nickname
        LBxEditCodersNames.SelectedIndex = -1
    End Sub

    Private Sub TBxEditCodersName_TextChanged(sender As Object, e As EventArgs) Handles TBxEditCodersName.TextChanged
        'Enables Buttons
        If TBxEditCodersName.Text <> "" Then
            BtnUpdate.Enabled = True
            BtnEdit.Enabled = True
        Else
            'Disables Buttons
            BtnUpdate.Enabled = False
            BtnEdit.Enabled = False
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Close Form
        Me.Close()
    End Sub
End Class