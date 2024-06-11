<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Change_password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cancel_button = New System.Windows.Forms.Button()
        Me.Submit_button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Reenter_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Passkey_checkbox = New System.Windows.Forms.CheckBox()
        Me.newpass_textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cancel_button
        '
        Me.Cancel_button.BackColor = System.Drawing.Color.Tomato
        Me.Cancel_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_button.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Cancel_button.Location = New System.Drawing.Point(419, 323)
        Me.Cancel_button.Name = "Cancel_button"
        Me.Cancel_button.Size = New System.Drawing.Size(114, 41)
        Me.Cancel_button.TabIndex = 13
        Me.Cancel_button.Text = "Cancel"
        Me.Cancel_button.UseVisualStyleBackColor = False
        '
        'Submit_button
        '
        Me.Submit_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Submit_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_button.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Submit_button.Location = New System.Drawing.Point(611, 325)
        Me.Submit_button.Name = "Submit_button"
        Me.Submit_button.Size = New System.Drawing.Size(121, 39)
        Me.Submit_button.TabIndex = 12
        Me.Submit_button.Text = "Submit"
        Me.Submit_button.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Re-Enter New Password :"
        '
        'Reenter_TextBox
        '
        Me.Reenter_TextBox.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reenter_TextBox.Location = New System.Drawing.Point(318, 196)
        Me.Reenter_TextBox.Name = "Reenter_TextBox"
        Me.Reenter_TextBox.Size = New System.Drawing.Size(605, 40)
        Me.Reenter_TextBox.TabIndex = 2
        Me.Reenter_TextBox.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(290, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 49)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Change Password"
        '
        'Passkey_checkbox
        '
        Me.Passkey_checkbox.AutoSize = True
        Me.Passkey_checkbox.BackColor = System.Drawing.Color.Transparent
        Me.Passkey_checkbox.Font = New System.Drawing.Font("Rockwell", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passkey_checkbox.Location = New System.Drawing.Point(775, 261)
        Me.Passkey_checkbox.Name = "Passkey_checkbox"
        Me.Passkey_checkbox.Size = New System.Drawing.Size(148, 23)
        Me.Passkey_checkbox.TabIndex = 14
        Me.Passkey_checkbox.Text = "Show Password"
        Me.Passkey_checkbox.UseVisualStyleBackColor = False
        '
        'newpass_textbox
        '
        Me.newpass_textbox.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpass_textbox.Location = New System.Drawing.Point(318, 124)
        Me.newpass_textbox.Name = "newpass_textbox"
        Me.newpass_textbox.Size = New System.Drawing.Size(605, 40)
        Me.newpass_textbox.TabIndex = 1
        Me.newpass_textbox.UseSystemPasswordChar = True
        '
        'Admin_Change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.newpass_textbox)
        Me.Controls.Add(Me.Passkey_checkbox)
        Me.Controls.Add(Me.Cancel_button)
        Me.Controls.Add(Me.Submit_button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Reenter_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Admin_Change_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change_password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel_button As Button
    Friend WithEvents Submit_button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Reenter_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Passkey_checkbox As CheckBox
    Friend WithEvents newpass_textbox As TextBox
End Class
