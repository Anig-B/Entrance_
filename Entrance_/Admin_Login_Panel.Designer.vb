<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Login_Panel
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
        Me.Login_button = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.Label()
        Me.pass_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserID_box = New System.Windows.Forms.TextBox()
        Me.Passkey_checkbox = New System.Windows.Forms.CheckBox()
        Me.Button_changepass = New System.Windows.Forms.Button()
        Me.Cancel_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Login_button
        '
        Me.Login_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Login_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_button.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Login_button.Location = New System.Drawing.Point(533, 215)
        Me.Login_button.Name = "Login_button"
        Me.Login_button.Size = New System.Drawing.Size(121, 39)
        Me.Login_button.TabIndex = 3
        Me.Login_button.Text = "Submit"
        Me.Login_button.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(309, 113)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(118, 22)
        Me.user.TabIndex = 10
        Me.user.Text = "Username : "
        '
        'pass_box
        '
        Me.pass_box.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pass_box.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_box.Location = New System.Drawing.Point(433, 152)
        Me.pass_box.Name = "pass_box"
        Me.pass_box.Size = New System.Drawing.Size(221, 31)
        Me.pass_box.TabIndex = 2
        Me.pass_box.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(319, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(287, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 50)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " Admin Login Panel   "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UserID_box
        '
        Me.UserID_box.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UserID_box.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID_box.Location = New System.Drawing.Point(433, 104)
        Me.UserID_box.Name = "UserID_box"
        Me.UserID_box.Size = New System.Drawing.Size(221, 31)
        Me.UserID_box.TabIndex = 1
        Me.UserID_box.WordWrap = False
        '
        'Passkey_checkbox
        '
        Me.Passkey_checkbox.AutoSize = True
        Me.Passkey_checkbox.BackColor = System.Drawing.Color.Transparent
        Me.Passkey_checkbox.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passkey_checkbox.Location = New System.Drawing.Point(680, 161)
        Me.Passkey_checkbox.Name = "Passkey_checkbox"
        Me.Passkey_checkbox.Size = New System.Drawing.Size(148, 23)
        Me.Passkey_checkbox.TabIndex = 11
        Me.Passkey_checkbox.Text = "Show Password"
        Me.Passkey_checkbox.UseVisualStyleBackColor = False
        '
        'Button_changepass
        '
        Me.Button_changepass.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button_changepass.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_changepass.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button_changepass.Location = New System.Drawing.Point(694, 215)
        Me.Button_changepass.Name = "Button_changepass"
        Me.Button_changepass.Size = New System.Drawing.Size(198, 39)
        Me.Button_changepass.TabIndex = 12
        Me.Button_changepass.Text = "Change Password"
        Me.Button_changepass.UseVisualStyleBackColor = False
        Me.Button_changepass.Visible = False
        '
        'Cancel_button
        '
        Me.Cancel_button.BackColor = System.Drawing.Color.Tomato
        Me.Cancel_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_button.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Cancel_button.Location = New System.Drawing.Point(385, 213)
        Me.Cancel_button.Name = "Cancel_button"
        Me.Cancel_button.Size = New System.Drawing.Size(97, 41)
        Me.Cancel_button.TabIndex = 97
        Me.Cancel_button.Text = "Cancel"
        Me.Cancel_button.UseVisualStyleBackColor = False
        '
        'Admin_Login_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Entrance_.My.Resources.Resources.login_panel_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Cancel_button)
        Me.Controls.Add(Me.Button_changepass)
        Me.Controls.Add(Me.Passkey_checkbox)
        Me.Controls.Add(Me.UserID_box)
        Me.Controls.Add(Me.Login_button)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.pass_box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Admin_Login_Panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_button As Button
    Friend WithEvents user As Label
    Friend WithEvents pass_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UserID_box As TextBox
    Friend WithEvents Passkey_checkbox As CheckBox
    Friend WithEvents Button_changepass As Button
    Friend WithEvents Cancel_button As Button
End Class
