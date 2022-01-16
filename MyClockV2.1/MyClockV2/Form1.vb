Imports System.ComponentModel
Imports System.Threading.Thread
Public Class MyClockV2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False

        SubPreloadStuff()
        SubDisplayDay()

        '' Enables clock tick (Updates clock)
        TmClockTick.Enabled = True
        ''Runs in background
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub TmClockTick_Tick(sender As Object, e As EventArgs) Handles TmClockTick.Tick
        ''Displays time
        ShowTime.Text = DateAndTime.Now.ToString("HH:mm:ss")
        ''Checks for "Midnight" setting & then automatically
        ''updates date
        If ShowTime.Text = "00:00:00" Then
            SubChangeDate()
        End If
    End Sub

    Private Sub BtnIntChk_Click(sender As Object, e As EventArgs) Handles BtnIntChk.Click
        '' Re-runs backgroundWorker (Do work Routine)
        '' for checking internet connection
        If BackgroundWorker1.IsBusy Then
            BtnIntChk.Text = "Testing Please Wait..."
            Sleep(500)
        Else
            BtnIntChk.Text = "Please Wait..."
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        '' Checks for internet connection
        Try
            lblIntCheck.Text = "Testing Connection"
            lblIntCheck.ForeColor = Color.PeachPuff
            Using WebCheck = New System.Net.WebClient()
                Using stream = WebCheck.OpenRead("http:\\www.google.com")
                    Sleep(500)
                    lblIntCheck.Text = "Internet Access"
                End Using
            End Using
        Catch
            Sleep(500)
            lblIntCheck.Text = "No Internet Access"
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        '' Display current internet status
        If lblIntCheck.Text = "Internet Access" Then
            lblIntCheck.ForeColor = Color.Green
            BtnIntChk.Text = "Test Button"
        Else
            lblIntCheck.Text = "No Internet Access"
            lblIntCheck.ForeColor = Color.Red
            BtnIntChk.Text = "Test Button"
        End If
    End Sub

    Private Sub BtnIntChk_MouseHover(sender As Object, e As EventArgs) Handles BtnIntChk.MouseHover
        ''Changes button text
        BtnIntChk.Text = "Test Internet Connection"
    End Sub

    Private Sub BtnIntChk_MouseLeave(sender As Object, e As EventArgs) Handles BtnIntChk.MouseLeave
        ''Changes button text
        BtnIntChk.Text = "Test Button"
    End Sub

    Private Sub SubPreloadStuff()
        '' Time & date style
        ShowTime.Text = DateAndTime.Now.ToString("HH:mm:ss")
        BtnShowDate.Text = DateAndTime.Now.ToString("dd/MM/yy")

        '' Displays current day of the week
        lblDay.Text = Date.Today.DayOfWeek.ToString()
        lblDay.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub SubChangeDate()
        ''Changes date by 1 day & display day of the week
        Dim vConvertDate As DateTime = DateAdd(DateInterval.Day, 1, DateAndTime.Now).ToString("dd/MM/yy")
        lblDay.Text = vConvertDate.DayOfWeek.ToString

        ''Updates date by 1
        BtnShowDate.Text = DateAdd(DateInterval.Day, 1, DateAndTime.Now).ToString("dd/MM/yy")
        SubDisplayDay()
    End Sub

    Private Sub SubDisplayDay()

        ''Display 's day of the week & display a colour
        If lblDay.Text = "Monday" Then
            lblDay.ForeColor = Color.White
        ElseIf lblDay.Text = "Tuesday" Then
            lblDay.ForeColor = Color.Cyan
        ElseIf lblDay.Text = "Wednesday" Then
            lblDay.ForeColor = Color.Yellow
        ElseIf lblDay.Text = "Thursday" Then
            lblDay.ForeColor = Color.Pink
        ElseIf lblDay.Text = "Friday" Then
            lblDay.ForeColor = Color.Orange
        ElseIf lblDay.Text = "Saturday" Or lblDay.Text = "Sunday" Then
            lblDay.ForeColor = Color.Red
        End If
    End Sub
End Class
