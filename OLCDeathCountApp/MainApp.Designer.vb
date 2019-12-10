<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApp))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnDeathCount = New System.Windows.Forms.Button()
        Me.BtnResetDeathCount = New System.Windows.Forms.Button()
        Me.DisplayDeathCount = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(307, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(37, 25)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnDeathCount)
        Me.Panel1.Controls.Add(Me.BtnResetDeathCount)
        Me.Panel1.Controls.Add(Me.DisplayDeathCount)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 212)
        Me.Panel1.TabIndex = 1
        '
        'BtnDeathCount
        '
        Me.BtnDeathCount.BackColor = System.Drawing.Color.Black
        Me.BtnDeathCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeathCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeathCount.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDeathCount.Location = New System.Drawing.Point(167, 154)
        Me.BtnDeathCount.Name = "BtnDeathCount"
        Me.BtnDeathCount.Size = New System.Drawing.Size(148, 51)
        Me.BtnDeathCount.TabIndex = 2
        Me.BtnDeathCount.Text = "Death Count Button"
        Me.BtnDeathCount.UseVisualStyleBackColor = False
        '
        'BtnResetDeathCount
        '
        Me.BtnResetDeathCount.BackColor = System.Drawing.Color.Black
        Me.BtnResetDeathCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetDeathCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetDeathCount.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnResetDeathCount.Location = New System.Drawing.Point(13, 154)
        Me.BtnResetDeathCount.Name = "BtnResetDeathCount"
        Me.BtnResetDeathCount.Size = New System.Drawing.Size(148, 51)
        Me.BtnResetDeathCount.TabIndex = 1
        Me.BtnResetDeathCount.Text = "Reset Death Count"
        Me.BtnResetDeathCount.UseVisualStyleBackColor = False
        '
        'DisplayDeathCount
        '
        Me.DisplayDeathCount.BackColor = System.Drawing.Color.Black
        Me.DisplayDeathCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayDeathCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayDeathCount.ForeColor = System.Drawing.Color.DarkRed
        Me.DisplayDeathCount.Location = New System.Drawing.Point(13, 8)
        Me.DisplayDeathCount.Name = "DisplayDeathCount"
        Me.DisplayDeathCount.Size = New System.Drawing.Size(304, 144)
        Me.DisplayDeathCount.TabIndex = 0
        Me.DisplayDeathCount.Text = "0"
        Me.DisplayDeathCount.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(15, 43)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(329, 51)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "The OLC Shouty Coders" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Death Count App"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(12, 328)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(332, 32)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Created By Speedy C - (c) 2019 - 2020"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MainApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(356, 379)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDeathCount As Button
    Friend WithEvents BtnResetDeathCount As Button
    Friend WithEvents DisplayDeathCount As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
