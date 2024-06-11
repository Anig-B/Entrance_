<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_login_panel
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
        Me.UserID_textbox = New System.Windows.Forms.TextBox()
        Me.Login_button = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.Label()
        Me.Name_texbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.faculty_dropbox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cancel_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserID_textbox
        '
        Me.UserID_textbox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UserID_textbox.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID_textbox.Location = New System.Drawing.Point(471, 114)
        Me.UserID_textbox.Name = "UserID_textbox"
        Me.UserID_textbox.Size = New System.Drawing.Size(221, 31)
        Me.UserID_textbox.TabIndex = 13
        Me.UserID_textbox.WordWrap = False
        '
        'Login_button
        '
        Me.Login_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Login_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_button.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Login_button.Location = New System.Drawing.Point(679, 257)
        Me.Login_button.Name = "Login_button"
        Me.Login_button.Size = New System.Drawing.Size(121, 39)
        Me.Login_button.TabIndex = 15
        Me.Login_button.Text = "Submit"
        Me.Login_button.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(311, 117)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(142, 22)
        Me.user.TabIndex = 18
        Me.user.Text = "Applicant ID : "
        '
        'Name_texbox
        '
        Me.Name_texbox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Name_texbox.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_texbox.Location = New System.Drawing.Point(471, 162)
        Me.Name_texbox.Name = "Name_texbox"
        Me.Name_texbox.Size = New System.Drawing.Size(221, 31)
        Me.Name_texbox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Applicant Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(313, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 50)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = " Student Login Panel   "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'faculty_dropbox
        '
        Me.faculty_dropbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.faculty_dropbox.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faculty_dropbox.ForeColor = System.Drawing.Color.Black
        Me.faculty_dropbox.FormattingEnabled = True
        Me.faculty_dropbox.Items.AddRange(New Object() {"BCA", "BBA", "BPH"})
        Me.faculty_dropbox.Location = New System.Drawing.Point(471, 211)
        Me.faculty_dropbox.Name = "faculty_dropbox"
        Me.faculty_dropbox.Size = New System.Drawing.Size(221, 30)
        Me.faculty_dropbox.TabIndex = 78
        Me.faculty_dropbox.Text = "BCA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(366, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Faculty :"
        '
        'Cancel_button
        '
        Me.Cancel_button.BackColor = System.Drawing.Color.Tomato
        Me.Cancel_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_button.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Cancel_button.Location = New System.Drawing.Point(829, 257)
        Me.Cancel_button.Name = "Cancel_button"
        Me.Cancel_button.Size = New System.Drawing.Size(97, 41)
        Me.Cancel_button.TabIndex = 80
        Me.Cancel_button.Text = "Cancel"
        Me.Cancel_button.UseVisualStyleBackColor = False
        '
        'Student_login_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Entrance_.My.Resources.Resources.login_panel_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Cancel_button)
        Me.Controls.Add(Me.faculty_dropbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UserID_textbox)
        Me.Controls.Add(Me.Login_button)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Name_texbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Student_login_panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_login_panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserID_textbox As TextBox
    Friend WithEvents Login_button As Button
    Friend WithEvents user As Label
    Friend WithEvents Name_texbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents faculty_dropbox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cancel_button As Button
End Class
