<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyClockV2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyClockV2))
        Me.BtnShowDate = New System.Windows.Forms.Button()
        Me.ShowTime = New System.Windows.Forms.Button()
        Me.TmClockTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblDay = New System.Windows.Forms.Label()
        Me.BtnIntChk = New System.Windows.Forms.Button()
        Me.lblIntCheck = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblCodedBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnShowDate
        '
        Me.BtnShowDate.BackColor = System.Drawing.Color.Black
        Me.BtnShowDate.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowDate.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnShowDate.Location = New System.Drawing.Point(7, 207)
        Me.BtnShowDate.Name = "BtnShowDate"
        Me.BtnShowDate.Size = New System.Drawing.Size(205, 57)
        Me.BtnShowDate.TabIndex = 2
        Me.BtnShowDate.Text = "Date Display"
        Me.BtnShowDate.UseVisualStyleBackColor = False
        '
        'ShowTime
        '
        Me.ShowTime.BackColor = System.Drawing.Color.Black
        Me.ShowTime.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowTime.ForeColor = System.Drawing.Color.Gold
        Me.ShowTime.Location = New System.Drawing.Point(7, 5)
        Me.ShowTime.Name = "ShowTime"
        Me.ShowTime.Size = New System.Drawing.Size(204, 118)
        Me.ShowTime.TabIndex = 3
        Me.ShowTime.Text = "Clock Display"
        Me.ShowTime.UseVisualStyleBackColor = False
        '
        'TmClockTick
        '
        Me.TmClockTick.Enabled = True
        Me.TmClockTick.Interval = 1000
        '
        'lblDay
        '
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(12, 96)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(195, 20)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnIntChk
        '
        Me.BtnIntChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIntChk.Location = New System.Drawing.Point(7, 177)
        Me.BtnIntChk.Name = "BtnIntChk"
        Me.BtnIntChk.Size = New System.Drawing.Size(204, 23)
        Me.BtnIntChk.TabIndex = 7
        Me.BtnIntChk.Text = "Test Button"
        Me.BtnIntChk.UseVisualStyleBackColor = True
        '
        'lblIntCheck
        '
        Me.lblIntCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntCheck.ForeColor = System.Drawing.Color.White
        Me.lblIntCheck.Location = New System.Drawing.Point(6, 150)
        Me.lblIntCheck.Name = "lblIntCheck"
        Me.lblIntCheck.Size = New System.Drawing.Size(206, 20)
        Me.lblIntCheck.TabIndex = 8
        Me.lblIntCheck.Text = "Internet Test"
        Me.lblIntCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(9, 127)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(198, 20)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodedBy
        '
        Me.lblCodedBy.AutoSize = True
        Me.lblCodedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodedBy.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblCodedBy.Location = New System.Drawing.Point(6, 271)
        Me.lblCodedBy.Name = "lblCodedBy"
        Me.lblCodedBy.Size = New System.Drawing.Size(206, 16)
        Me.lblCodedBy.TabIndex = 10
        Me.lblCodedBy.Text = "Coded By Speedy (c) 2022 - 2023"
        '
        'MyClockV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(219, 298)
        Me.Controls.Add(Me.lblCodedBy)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblIntCheck)
        Me.Controls.Add(Me.BtnIntChk)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.ShowTime)
        Me.Controls.Add(Me.BtnShowDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MyClockV2"
        Me.Text = "Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnShowDate As Button
    Friend WithEvents ShowTime As Button
    Friend WithEvents TmClockTick As Timer
    Friend WithEvents lblDay As Label
    Friend WithEvents BtnIntChk As Button
    Friend WithEvents lblIntCheck As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCodedBy As Label
End Class
