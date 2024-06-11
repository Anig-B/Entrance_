<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BPH_view_questions
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
        Me.BPH_Question_view = New System.Windows.Forms.DataGridView()
        Me.Update_bph_table = New System.Windows.Forms.Button()
        CType(Me.BPH_Question_view, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Back_Button.TabIndex = 104
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
        Me.Label1.Size = New System.Drawing.Size(367, 49)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "BPH Question Set"
        '
        'BPH_Question_view
        '
        Me.BPH_Question_view.AllowUserToAddRows = False
        Me.BPH_Question_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.BPH_Question_view.BackgroundColor = System.Drawing.SystemColors.Window
        Me.BPH_Question_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BPH_Question_view.Location = New System.Drawing.Point(12, 109)
        Me.BPH_Question_view.MultiSelect = False
        Me.BPH_Question_view.Name = "BPH_Question_view"
        Me.BPH_Question_view.RowHeadersWidth = 62
        Me.BPH_Question_view.RowTemplate.Height = 28
        Me.BPH_Question_view.Size = New System.Drawing.Size(954, 375)
        Me.BPH_Question_view.TabIndex = 102
        '
        'Update_bph_table
        '
        Me.Update_bph_table.BackColor = System.Drawing.Color.LightGreen
        Me.Update_bph_table.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update_bph_table.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_bph_table.Location = New System.Drawing.Point(804, 513)
        Me.Update_bph_table.Name = "Update_bph_table"
        Me.Update_bph_table.Size = New System.Drawing.Size(114, 40)
        Me.Update_bph_table.TabIndex = 105
        Me.Update_bph_table.Text = "Update"
        Me.Update_bph_table.UseCompatibleTextRendering = True
        Me.Update_bph_table.UseVisualStyleBackColor = False
        '
        'BPH_view_questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Update_bph_table)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BPH_Question_view)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BPH_view_questions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPH_view_questions"
        CType(Me.BPH_Question_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BPH_Question_view As DataGridView
    Friend WithEvents Update_bph_table As Button
End Class
