<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_view
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
        Me.Applicant_view = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        CType(Me.Applicant_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Applicant_view
        '
        Me.Applicant_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Applicant_view.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Applicant_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Applicant_view.Location = New System.Drawing.Point(12, 116)
        Me.Applicant_view.Name = "Applicant_view"
        Me.Applicant_view.ReadOnly = True
        Me.Applicant_view.RowHeadersWidth = 62
        Me.Applicant_view.RowTemplate.Height = 28
        Me.Applicant_view.Size = New System.Drawing.Size(954, 343)
        Me.Applicant_view.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(284, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Applicant Information"
        '
        'Back_Button
        '
        Me.Back_Button.BackColor = System.Drawing.Color.Gold
        Me.Back_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.Back_Button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.Location = New System.Drawing.Point(78, 492)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(114, 40)
        Me.Back_Button.TabIndex = 95
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseCompatibleTextRendering = True
        Me.Back_Button.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.LightCoral
        Me.Reset.Cursor = System.Windows.Forms.Cursors.Default
        Me.Reset.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(779, 492)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(114, 40)
        Me.Reset.TabIndex = 96
        Me.Reset.Text = "Reset"
        Me.Reset.UseCompatibleTextRendering = True
        Me.Reset.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Delete.Cursor = System.Windows.Forms.Cursors.Default
        Me.Delete.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Delete.Location = New System.Drawing.Point(440, 492)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(114, 40)
        Me.Delete.TabIndex = 97
        Me.Delete.Text = "Delete"
        Me.Delete.UseCompatibleTextRendering = True
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Student_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Applicant_view)
        Me.MaximizeBox = False
        Me.Name = "Student_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_info"
        CType(Me.Applicant_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Applicant_view As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Back_Button As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Delete As Button
End Class
