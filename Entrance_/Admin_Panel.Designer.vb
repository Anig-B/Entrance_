<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Panel
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
        Me.ad = New System.Windows.Forms.Label()
        Me.Student_info = New System.Windows.Forms.Button()
        Me.Exit_button = New System.Windows.Forms.Button()
        Me.Register_button = New System.Windows.Forms.Button()
        Me.report = New System.Windows.Forms.Button()
        Me.Set_qn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ad
        '
        Me.ad.AutoSize = True
        Me.ad.BackColor = System.Drawing.Color.Transparent
        Me.ad.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ad.Location = New System.Drawing.Point(323, 49)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(305, 54)
        Me.ad.TabIndex = 17
        Me.ad.Text = "Admin Panel"
        Me.ad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Student_info
        '
        Me.Student_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Student_info.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_info.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Student_info.Location = New System.Drawing.Point(603, 311)
        Me.Student_info.Name = "Student_info"
        Me.Student_info.Size = New System.Drawing.Size(325, 51)
        Me.Student_info.TabIndex = 3
        Me.Student_info.Text = "Applicant Info"
        Me.Student_info.UseVisualStyleBackColor = False
        '
        'Exit_button
        '
        Me.Exit_button.BackColor = System.Drawing.Color.Tomato
        Me.Exit_button.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_button.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Exit_button.Location = New System.Drawing.Point(708, 450)
        Me.Exit_button.Name = "Exit_button"
        Me.Exit_button.Size = New System.Drawing.Size(117, 53)
        Me.Exit_button.TabIndex = 5
        Me.Exit_button.Text = "Exit"
        Me.Exit_button.UseVisualStyleBackColor = False
        '
        'Register_button
        '
        Me.Register_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Register_button.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_button.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Register_button.Location = New System.Drawing.Point(603, 244)
        Me.Register_button.Name = "Register_button"
        Me.Register_button.Size = New System.Drawing.Size(325, 51)
        Me.Register_button.TabIndex = 2
        Me.Register_button.Text = "Register Applicant"
        Me.Register_button.UseVisualStyleBackColor = False
        '
        'report
        '
        Me.report.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.report.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.report.ForeColor = System.Drawing.Color.MidnightBlue
        Me.report.Location = New System.Drawing.Point(603, 379)
        Me.report.Name = "report"
        Me.report.Size = New System.Drawing.Size(325, 51)
        Me.report.TabIndex = 4
        Me.report.Text = "Report"
        Me.report.UseVisualStyleBackColor = False
        '
        'Set_qn
        '
        Me.Set_qn.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Set_qn.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Set_qn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Set_qn.Location = New System.Drawing.Point(603, 178)
        Me.Set_qn.Name = "Set_qn"
        Me.Set_qn.Size = New System.Drawing.Size(325, 51)
        Me.Set_qn.TabIndex = 1
        Me.Set_qn.Text = "Question Set"
        Me.Set_qn.UseVisualStyleBackColor = False
        '
        'Admin_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Entrance_.My.Resources.Resources.Admin_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.Student_info)
        Me.Controls.Add(Me.Exit_button)
        Me.Controls.Add(Me.Register_button)
        Me.Controls.Add(Me.report)
        Me.Controls.Add(Me.Set_qn)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Admin_Panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ad As Label
    Friend WithEvents Student_info As Button
    Friend WithEvents Exit_button As Button
    Friend WithEvents Register_button As Button
    Friend WithEvents report As Button
    Friend WithEvents Set_qn As Button
End Class
