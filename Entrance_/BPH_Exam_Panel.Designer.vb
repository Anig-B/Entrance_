<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BPH_Exam_Panel
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
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Load_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Opt_box4 = New System.Windows.Forms.Label()
        Me.Opt_box3 = New System.Windows.Forms.Label()
        Me.Opt_box2 = New System.Windows.Forms.Label()
        Me.Opt_box1 = New System.Windows.Forms.Label()
        Me.Qn_nobox = New System.Windows.Forms.Label()
        Me.Question_box = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Previous_button = New System.Windows.Forms.Button()
        Me.TimerBox = New System.Windows.Forms.TextBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.opt_lab4 = New System.Windows.Forms.Label()
        Me.opt_lab3 = New System.Windows.Forms.Label()
        Me.opt_lab2 = New System.Windows.Forms.Label()
        Me.opt_lab1 = New System.Windows.Forms.Label()
        Me.Next_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Load_Timer
        '
        Me.Load_Timer.Interval = 500
        '
        'Opt_box4
        '
        Me.Opt_box4.AutoSize = True
        Me.Opt_box4.BackColor = System.Drawing.SystemColors.Control
        Me.Opt_box4.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.Opt_box4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Opt_box4.Location = New System.Drawing.Point(122, 327)
        Me.Opt_box4.Name = "Opt_box4"
        Me.Opt_box4.Size = New System.Drawing.Size(107, 27)
        Me.Opt_box4.TabIndex = 101
        Me.Opt_box4.Text = "Option 4"
        '
        'Opt_box3
        '
        Me.Opt_box3.AutoSize = True
        Me.Opt_box3.BackColor = System.Drawing.SystemColors.Control
        Me.Opt_box3.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.Opt_box3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Opt_box3.Location = New System.Drawing.Point(123, 286)
        Me.Opt_box3.Name = "Opt_box3"
        Me.Opt_box3.Size = New System.Drawing.Size(107, 27)
        Me.Opt_box3.TabIndex = 100
        Me.Opt_box3.Text = "Option 3"
        '
        'Opt_box2
        '
        Me.Opt_box2.AutoSize = True
        Me.Opt_box2.BackColor = System.Drawing.SystemColors.Control
        Me.Opt_box2.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.Opt_box2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Opt_box2.Location = New System.Drawing.Point(123, 245)
        Me.Opt_box2.Name = "Opt_box2"
        Me.Opt_box2.Size = New System.Drawing.Size(107, 27)
        Me.Opt_box2.TabIndex = 99
        Me.Opt_box2.Text = "Option 2"
        '
        'Opt_box1
        '
        Me.Opt_box1.AutoSize = True
        Me.Opt_box1.BackColor = System.Drawing.SystemColors.Control
        Me.Opt_box1.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.Opt_box1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Opt_box1.Location = New System.Drawing.Point(123, 206)
        Me.Opt_box1.Name = "Opt_box1"
        Me.Opt_box1.Size = New System.Drawing.Size(107, 27)
        Me.Opt_box1.TabIndex = 98
        Me.Opt_box1.Text = "Option 1"
        '
        'Qn_nobox
        '
        Me.Qn_nobox.AutoSize = True
        Me.Qn_nobox.BackColor = System.Drawing.SystemColors.Control
        Me.Qn_nobox.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qn_nobox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Qn_nobox.Location = New System.Drawing.Point(37, 68)
        Me.Qn_nobox.Name = "Qn_nobox"
        Me.Qn_nobox.Size = New System.Drawing.Size(44, 31)
        Me.Qn_nobox.TabIndex = 97
        Me.Qn_nobox.Text = "10"
        '
        'Question_box
        '
        Me.Question_box.BackColor = System.Drawing.SystemColors.Control
        Me.Question_box.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_box.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Question_box.Location = New System.Drawing.Point(91, 68)
        Me.Question_box.Name = "Question_box"
        Me.Question_box.Size = New System.Drawing.Size(819, 96)
        Me.Question_box.TabIndex = 96
        Me.Question_box.Text = "Question"
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.LawnGreen
        Me.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Submit.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(786, 437)
        Me.Submit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(122, 49)
        Me.Submit.TabIndex = 95
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        Me.Submit.Visible = False
        '
        'Previous_button
        '
        Me.Previous_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Previous_button.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Previous_button.Location = New System.Drawing.Point(602, 437)
        Me.Previous_button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Previous_button.Name = "Previous_button"
        Me.Previous_button.Size = New System.Drawing.Size(145, 49)
        Me.Previous_button.TabIndex = 94
        Me.Previous_button.Text = "<<Previous"
        Me.Previous_button.UseVisualStyleBackColor = False
        '
        'TimerBox
        '
        Me.TimerBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TimerBox.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerBox.Location = New System.Drawing.Point(43, 422)
        Me.TimerBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TimerBox.Multiline = True
        Me.TimerBox.Name = "TimerBox"
        Me.TimerBox.ReadOnly = True
        Me.TimerBox.Size = New System.Drawing.Size(173, 64)
        Me.TimerBox.TabIndex = 93
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton4.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.RadioButton4.Location = New System.Drawing.Point(582, 323)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(71, 31)
        Me.RadioButton4.TabIndex = 87
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "d . "
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton3.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.RadioButton3.Location = New System.Drawing.Point(582, 282)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(63, 31)
        Me.RadioButton3.TabIndex = 86
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "c ."
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton2.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(582, 241)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(66, 31)
        Me.RadioButton2.TabIndex = 85
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "b ."
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton1.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(582, 204)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 31)
        Me.RadioButton1.TabIndex = 84
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "a ."
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'opt_lab4
        '
        Me.opt_lab4.AutoSize = True
        Me.opt_lab4.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.opt_lab4.Location = New System.Drawing.Point(75, 327)
        Me.opt_lab4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.opt_lab4.Name = "opt_lab4"
        Me.opt_lab4.Size = New System.Drawing.Size(40, 27)
        Me.opt_lab4.TabIndex = 92
        Me.opt_lab4.Text = "d :"
        '
        'opt_lab3
        '
        Me.opt_lab3.AutoSize = True
        Me.opt_lab3.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.opt_lab3.Location = New System.Drawing.Point(75, 286)
        Me.opt_lab3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.opt_lab3.Name = "opt_lab3"
        Me.opt_lab3.Size = New System.Drawing.Size(38, 27)
        Me.opt_lab3.TabIndex = 91
        Me.opt_lab3.Text = "c :"
        '
        'opt_lab2
        '
        Me.opt_lab2.AutoSize = True
        Me.opt_lab2.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.opt_lab2.Location = New System.Drawing.Point(75, 245)
        Me.opt_lab2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.opt_lab2.Name = "opt_lab2"
        Me.opt_lab2.Size = New System.Drawing.Size(41, 27)
        Me.opt_lab2.TabIndex = 90
        Me.opt_lab2.Text = "b :"
        '
        'opt_lab1
        '
        Me.opt_lab1.AutoSize = True
        Me.opt_lab1.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.opt_lab1.Location = New System.Drawing.Point(79, 206)
        Me.opt_lab1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.opt_lab1.Name = "opt_lab1"
        Me.opt_lab1.Size = New System.Drawing.Size(38, 27)
        Me.opt_lab1.TabIndex = 89
        Me.opt_lab1.Text = "a :"
        '
        'Next_button
        '
        Me.Next_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Next_button.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_button.Location = New System.Drawing.Point(786, 437)
        Me.Next_button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Next_button.Name = "Next_button"
        Me.Next_button.Size = New System.Drawing.Size(122, 49)
        Me.Next_button.TabIndex = 88
        Me.Next_button.Text = "Next >>"
        Me.Next_button.UseVisualStyleBackColor = False
        '
        'BPH_Exam_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Opt_box4)
        Me.Controls.Add(Me.Opt_box3)
        Me.Controls.Add(Me.Opt_box2)
        Me.Controls.Add(Me.Opt_box1)
        Me.Controls.Add(Me.Qn_nobox)
        Me.Controls.Add(Me.Question_box)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Previous_button)
        Me.Controls.Add(Me.TimerBox)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.opt_lab4)
        Me.Controls.Add(Me.opt_lab3)
        Me.Controls.Add(Me.opt_lab2)
        Me.Controls.Add(Me.opt_lab1)
        Me.Controls.Add(Me.Next_button)
        Me.MaximizeBox = False
        Me.Name = "BPH_Exam_Panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents Load_Timer As Timer
    Friend WithEvents Opt_box4 As Label
    Friend WithEvents Opt_box3 As Label
    Friend WithEvents Opt_box2 As Label
    Friend WithEvents Opt_box1 As Label
    Friend WithEvents Qn_nobox As Label
    Friend WithEvents Question_box As Label
    Friend WithEvents Submit As Button
    Friend WithEvents Previous_button As Button
    Friend WithEvents TimerBox As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents opt_lab4 As Label
    Friend WithEvents opt_lab3 As Label
    Friend WithEvents opt_lab2 As Label
    Friend WithEvents opt_lab1 As Label
    Friend WithEvents Next_button As Button
End Class
