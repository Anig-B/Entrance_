<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Register
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
        Me.Other_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Female_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Male_RadioButton = New System.Windows.Forms.RadioButton()
        Me.cont = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Label()
        Me.faculty_dropbox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Submit_button = New System.Windows.Forms.Button()
        Me.Reset_button = New System.Windows.Forms.Button()
        Me.Gder = New System.Windows.Forms.Label()
        Me.l_name = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.f_name = New System.Windows.Forms.Label()
        Me.lastname_textbox = New System.Windows.Forms.TextBox()
        Me.midname_textbox = New System.Windows.Forms.TextBox()
        Me.firstname_textbox = New System.Windows.Forms.TextBox()
        Me.contact_textbox = New System.Windows.Forms.TextBox()
        Me.address_textbox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Other_RadioButton
        '
        Me.Other_RadioButton.AccessibleName = "gd_m"
        Me.Other_RadioButton.AutoSize = True
        Me.Other_RadioButton.Checked = True
        Me.Other_RadioButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.Other_RadioButton.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other_RadioButton.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Other_RadioButton.Location = New System.Drawing.Point(236, 377)
        Me.Other_RadioButton.Name = "Other_RadioButton"
        Me.Other_RadioButton.Size = New System.Drawing.Size(81, 24)
        Me.Other_RadioButton.TabIndex = 86
        Me.Other_RadioButton.TabStop = True
        Me.Other_RadioButton.Text = "Other"
        Me.Other_RadioButton.UseVisualStyleBackColor = True
        '
        'Female_RadioButton
        '
        Me.Female_RadioButton.AccessibleName = "gd_m"
        Me.Female_RadioButton.AutoSize = True
        Me.Female_RadioButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.Female_RadioButton.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female_RadioButton.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Female_RadioButton.Location = New System.Drawing.Point(236, 346)
        Me.Female_RadioButton.Name = "Female_RadioButton"
        Me.Female_RadioButton.Size = New System.Drawing.Size(95, 24)
        Me.Female_RadioButton.TabIndex = 85
        Me.Female_RadioButton.Text = "Female"
        Me.Female_RadioButton.UseVisualStyleBackColor = True
        '
        'Male_RadioButton
        '
        Me.Male_RadioButton.AccessibleName = "gd_m"
        Me.Male_RadioButton.AutoSize = True
        Me.Male_RadioButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.Male_RadioButton.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male_RadioButton.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Male_RadioButton.Location = New System.Drawing.Point(236, 315)
        Me.Male_RadioButton.Name = "Male_RadioButton"
        Me.Male_RadioButton.Size = New System.Drawing.Size(75, 24)
        Me.Male_RadioButton.TabIndex = 84
        Me.Male_RadioButton.Text = "Male"
        Me.Male_RadioButton.UseVisualStyleBackColor = True
        '
        'cont
        '
        Me.cont.AutoSize = True
        Me.cont.Cursor = System.Windows.Forms.Cursors.Default
        Me.cont.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cont.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cont.Location = New System.Drawing.Point(562, 174)
        Me.cont.Name = "cont"
        Me.cont.Size = New System.Drawing.Size(82, 20)
        Me.cont.TabIndex = 79
        Me.cont.Text = "Contact :"
        '
        'add
        '
        Me.add.AutoSize = True
        Me.add.Cursor = System.Windows.Forms.Cursors.Default
        Me.add.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.ForeColor = System.Drawing.Color.MidnightBlue
        Me.add.Location = New System.Drawing.Point(562, 118)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(88, 20)
        Me.add.TabIndex = 77
        Me.add.Text = "Address :"
        '
        'faculty_dropbox
        '
        Me.faculty_dropbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.faculty_dropbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faculty_dropbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.faculty_dropbox.FormattingEnabled = True
        Me.faculty_dropbox.Items.AddRange(New Object() {"BCA", "BBA", "BPH"})
        Me.faculty_dropbox.Location = New System.Drawing.Point(677, 229)
        Me.faculty_dropbox.Name = "faculty_dropbox"
        Me.faculty_dropbox.Size = New System.Drawing.Size(136, 28)
        Me.faculty_dropbox.TabIndex = 76
        Me.faculty_dropbox.Text = "BCA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(567, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Faculty :"
        '
        'Submit_button
        '
        Me.Submit_button.BackColor = System.Drawing.Color.LightGreen
        Me.Submit_button.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Submit_button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_button.Location = New System.Drawing.Point(699, 465)
        Me.Submit_button.Name = "Submit_button"
        Me.Submit_button.Size = New System.Drawing.Size(114, 40)
        Me.Submit_button.TabIndex = 74
        Me.Submit_button.Text = "Submit"
        Me.Submit_button.UseCompatibleTextRendering = True
        Me.Submit_button.UseVisualStyleBackColor = False
        '
        'Reset_button
        '
        Me.Reset_button.BackColor = System.Drawing.Color.LightCoral
        Me.Reset_button.Cursor = System.Windows.Forms.Cursors.Default
        Me.Reset_button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_button.Location = New System.Drawing.Point(528, 465)
        Me.Reset_button.Name = "Reset_button"
        Me.Reset_button.Size = New System.Drawing.Size(114, 40)
        Me.Reset_button.TabIndex = 73
        Me.Reset_button.Text = "Reset"
        Me.Reset_button.UseCompatibleTextRendering = True
        Me.Reset_button.UseVisualStyleBackColor = False
        '
        'Gder
        '
        Me.Gder.AutoSize = True
        Me.Gder.Cursor = System.Windows.Forms.Cursors.Default
        Me.Gder.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gder.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Gder.Location = New System.Drawing.Point(127, 315)
        Me.Gder.Name = "Gder"
        Me.Gder.Size = New System.Drawing.Size(82, 20)
        Me.Gder.TabIndex = 72
        Me.Gder.Text = "Gender :"
        '
        'l_name
        '
        Me.l_name.AutoSize = True
        Me.l_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_name.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.l_name.Location = New System.Drawing.Point(104, 237)
        Me.l_name.Name = "l_name"
        Me.l_name.Size = New System.Drawing.Size(105, 20)
        Me.l_name.TabIndex = 70
        Me.l_name.Text = "Last Name :"
        '
        'm_name
        '
        Me.m_name.AutoSize = True
        Me.m_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.m_name.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.m_name.Location = New System.Drawing.Point(78, 174)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(131, 20)
        Me.m_name.TabIndex = 68
        Me.m_name.Text = "Middle Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(255, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 46)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Student Register Form"
        '
        'f_name
        '
        Me.f_name.AutoSize = True
        Me.f_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.f_name.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.f_name.Location = New System.Drawing.Point(100, 118)
        Me.f_name.Name = "f_name"
        Me.f_name.Size = New System.Drawing.Size(109, 20)
        Me.f_name.TabIndex = 66
        Me.f_name.Text = "First Name :"
        '
        'lastname_textbox
        '
        Me.lastname_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.lastname_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lastname_textbox.Location = New System.Drawing.Point(236, 237)
        Me.lastname_textbox.Name = "lastname_textbox"
        Me.lastname_textbox.Size = New System.Drawing.Size(136, 29)
        Me.lastname_textbox.TabIndex = 87
        '
        'midname_textbox
        '
        Me.midname_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.midname_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midname_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.midname_textbox.Location = New System.Drawing.Point(236, 171)
        Me.midname_textbox.Name = "midname_textbox"
        Me.midname_textbox.Size = New System.Drawing.Size(136, 29)
        Me.midname_textbox.TabIndex = 88
        '
        'firstname_textbox
        '
        Me.firstname_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.firstname_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.firstname_textbox.Location = New System.Drawing.Point(236, 115)
        Me.firstname_textbox.Name = "firstname_textbox"
        Me.firstname_textbox.Size = New System.Drawing.Size(136, 29)
        Me.firstname_textbox.TabIndex = 89
        '
        'contact_textbox
        '
        Me.contact_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.contact_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.contact_textbox.Location = New System.Drawing.Point(677, 174)
        Me.contact_textbox.Name = "contact_textbox"
        Me.contact_textbox.Size = New System.Drawing.Size(136, 29)
        Me.contact_textbox.TabIndex = 90
        '
        'address_textbox
        '
        Me.address_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.address_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.address_textbox.Location = New System.Drawing.Point(677, 115)
        Me.address_textbox.Name = "address_textbox"
        Me.address_textbox.Size = New System.Drawing.Size(136, 29)
        Me.address_textbox.TabIndex = 91
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarFont = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(677, 296)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(136, 26)
        Me.DateTimePicker.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(524, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Date of Birth :"
        '
        'Back_Button
        '
        Me.Back_Button.BackColor = System.Drawing.Color.Gold
        Me.Back_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.Back_Button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.Location = New System.Drawing.Point(131, 465)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(114, 40)
        Me.Back_Button.TabIndex = 94
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseCompatibleTextRendering = True
        Me.Back_Button.UseVisualStyleBackColor = False
        '
        'Student_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.address_textbox)
        Me.Controls.Add(Me.contact_textbox)
        Me.Controls.Add(Me.firstname_textbox)
        Me.Controls.Add(Me.midname_textbox)
        Me.Controls.Add(Me.lastname_textbox)
        Me.Controls.Add(Me.Other_RadioButton)
        Me.Controls.Add(Me.Female_RadioButton)
        Me.Controls.Add(Me.Male_RadioButton)
        Me.Controls.Add(Me.cont)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.faculty_dropbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Submit_button)
        Me.Controls.Add(Me.Reset_button)
        Me.Controls.Add(Me.Gder)
        Me.Controls.Add(Me.l_name)
        Me.Controls.Add(Me.m_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.f_name)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = False
        Me.Name = "Student_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Other_RadioButton As RadioButton
    Friend WithEvents Female_RadioButton As RadioButton
    Friend WithEvents Male_RadioButton As RadioButton
    Friend WithEvents cont As Label
    Friend WithEvents add As Label
    Friend WithEvents faculty_dropbox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Submit_button As Button
    Friend WithEvents Reset_button As Button
    Friend WithEvents Gder As Label
    Friend WithEvents l_name As Label
    Friend WithEvents m_name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents f_name As Label
    Friend WithEvents lastname_textbox As TextBox
    Friend WithEvents midname_textbox As TextBox
    Friend WithEvents firstname_textbox As TextBox
    Friend WithEvents contact_textbox As TextBox
    Friend WithEvents address_textbox As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Back_Button As Button
End Class
