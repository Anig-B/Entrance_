<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_mode
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Student_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Admin_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Student_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admin_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 100)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(301, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select User Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(625, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student"
        '
        'Student_PictureBox
        '
        Me.Student_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Student_PictureBox.Image = Global.Entrance_.My.Resources.Resources.student_pb
        Me.Student_PictureBox.Location = New System.Drawing.Point(532, 184)
        Me.Student_PictureBox.Name = "Student_PictureBox"
        Me.Student_PictureBox.Size = New System.Drawing.Size(295, 259)
        Me.Student_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Student_PictureBox.TabIndex = 1
        Me.Student_PictureBox.TabStop = False
        '
        'Admin_PictureBox
        '
        Me.Admin_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Admin_PictureBox.Image = Global.Entrance_.My.Resources.Resources.admin_login
        Me.Admin_PictureBox.Location = New System.Drawing.Point(149, 184)
        Me.Admin_PictureBox.Name = "Admin_PictureBox"
        Me.Admin_PictureBox.Size = New System.Drawing.Size(295, 259)
        Me.Admin_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Admin_PictureBox.TabIndex = 0
        Me.Admin_PictureBox.TabStop = False
        '
        'Select_mode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Student_PictureBox)
        Me.Controls.Add(Me.Admin_PictureBox)
        Me.MaximizeBox = False
        Me.Name = "Select_mode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Mode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Student_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admin_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Admin_PictureBox As PictureBox
    Friend WithEvents Student_PictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
