<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Security_Question
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SecurityQues_textbox = New System.Windows.Forms.TextBox()
        Me.Securityans_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Submit_button = New System.Windows.Forms.Button()
        Me.Cancel_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Security Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Question :"
        '
        'SecurityQues_textbox
        '
        Me.SecurityQues_textbox.BackColor = System.Drawing.SystemColors.Window
        Me.SecurityQues_textbox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SecurityQues_textbox.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQues_textbox.HideSelection = False
        Me.SecurityQues_textbox.Location = New System.Drawing.Point(143, 98)
        Me.SecurityQues_textbox.Name = "SecurityQues_textbox"
        Me.SecurityQues_textbox.ReadOnly = True
        Me.SecurityQues_textbox.Size = New System.Drawing.Size(755, 40)
        Me.SecurityQues_textbox.TabIndex = 2
        '
        'Securityans_TextBox
        '
        Me.Securityans_TextBox.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Securityans_TextBox.Location = New System.Drawing.Point(143, 164)
        Me.Securityans_TextBox.Name = "Securityans_TextBox"
        Me.Securityans_TextBox.Size = New System.Drawing.Size(755, 40)
        Me.Securityans_TextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Answer :"
        '
        'Submit_button
        '
        Me.Submit_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Submit_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_button.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Submit_button.Location = New System.Drawing.Point(477, 251)
        Me.Submit_button.Name = "Submit_button"
        Me.Submit_button.Size = New System.Drawing.Size(121, 39)
        Me.Submit_button.TabIndex = 5
        Me.Submit_button.Text = "Submit"
        Me.Submit_button.UseVisualStyleBackColor = False
        '
        'Cancel_button
        '
        Me.Cancel_button.BackColor = System.Drawing.Color.Tomato
        Me.Cancel_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_button.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Cancel_button.Location = New System.Drawing.Point(335, 249)
        Me.Cancel_button.Name = "Cancel_button"
        Me.Cancel_button.Size = New System.Drawing.Size(97, 41)
        Me.Cancel_button.TabIndex = 6
        Me.Cancel_button.Text = "Cancel"
        Me.Cancel_button.UseVisualStyleBackColor = False
        '
        'Security_Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Cancel_button)
        Me.Controls.Add(Me.Submit_button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Securityans_TextBox)
        Me.Controls.Add(Me.SecurityQues_textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Security_Question"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security Question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SecurityQues_textbox As TextBox
    Friend WithEvents Securityans_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Submit_button As Button
    Friend WithEvents Cancel_button As Button
End Class
