<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BBA_view_questions
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
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBA_Question_view = New System.Windows.Forms.DataGridView()
        Me.Update_bba_table = New System.Windows.Forms.Button()
        CType(Me.BBA_Question_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.BackColor = System.Drawing.Color.Gold
        Me.Back_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.Back_Button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.Location = New System.Drawing.Point(78, 513)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(114, 40)
        Me.Back_Button.TabIndex = 101
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseCompatibleTextRendering = True
        Me.Back_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(303, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 49)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "BBA Question Set"
        '
        'BBA_Question_view
        '
        Me.BBA_Question_view.AllowUserToAddRows = False
        Me.BBA_Question_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.BBA_Question_view.BackgroundColor = System.Drawing.SystemColors.Window
        Me.BBA_Question_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BBA_Question_view.Location = New System.Drawing.Point(12, 105)
        Me.BBA_Question_view.MultiSelect = False
        Me.BBA_Question_view.Name = "BBA_Question_view"
        Me.BBA_Question_view.RowHeadersWidth = 62
        Me.BBA_Question_view.RowTemplate.Height = 28
        Me.BBA_Question_view.Size = New System.Drawing.Size(954, 375)
        Me.BBA_Question_view.TabIndex = 99
        '
        'Update_bba_table
        '
        Me.Update_bba_table.BackColor = System.Drawing.Color.LightGreen
        Me.Update_bba_table.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update_bba_table.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_bba_table.Location = New System.Drawing.Point(813, 513)
        Me.Update_bba_table.Name = "Update_bba_table"
        Me.Update_bba_table.Size = New System.Drawing.Size(114, 40)
        Me.Update_bba_table.TabIndex = 102
        Me.Update_bba_table.Text = "Update"
        Me.Update_bba_table.UseCompatibleTextRendering = True
        Me.Update_bba_table.UseVisualStyleBackColor = False
        '
        'BBA_view_questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Update_bba_table)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BBA_Question_view)
        Me.Name = "BBA_view_questions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BBA_view_questions"
        CType(Me.BBA_Question_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BBA_Question_view As DataGridView
    Friend WithEvents Update_bba_table As Button
End Class
