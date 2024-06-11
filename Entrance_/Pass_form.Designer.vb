<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pass_form
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
        Me.Interview_date = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Login_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Interview_date
        '
        Me.Interview_date.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Interview_date.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Interview_date.Cursor = System.Windows.Forms.Cursors.Default
        Me.Interview_date.Enabled = False
        Me.Interview_date.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interview_date.ForeColor = System.Drawing.Color.Green
        Me.Interview_date.Location = New System.Drawing.Point(333, 162)
        Me.Interview_date.Multiline = True
        Me.Interview_date.Name = "Interview_date"
        Me.Interview_date.ReadOnly = True
        Me.Interview_date.Size = New System.Drawing.Size(313, 267)
        Me.Interview_date.TabIndex = 3
        Me.Interview_date.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Interview_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(341, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Interview Date : July 17 2023"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Location = New System.Drawing.Point(346, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 39)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "History"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Login_button
        '
        Me.Login_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Login_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_button.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Login_button.Location = New System.Drawing.Point(529, 470)
        Me.Login_button.Name = "Login_button"
        Me.Login_button.Size = New System.Drawing.Size(121, 39)
        Me.Login_button.TabIndex = 11
        Me.Login_button.Text = "OK"
        Me.Login_button.UseVisualStyleBackColor = False
        '
        'Pass_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Entrance_.My.Resources.Resources.Accepted_image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Login_button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Interview_date)
        Me.Name = "Pass_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pass_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Interview_date As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Login_button As Button
End Class
