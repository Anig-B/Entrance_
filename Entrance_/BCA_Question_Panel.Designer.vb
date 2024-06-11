<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCA_Question_Panel
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
        Me.bca_reset_button = New System.Windows.Forms.Button()
        Me.bca_view_qn_button = New System.Windows.Forms.Button()
        Me.bca_set_button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bca_reset_button
        '
        Me.bca_reset_button.BackColor = System.Drawing.Color.MidnightBlue
        Me.bca_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bca_reset_button.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bca_reset_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bca_reset_button.Location = New System.Drawing.Point(653, 379)
        Me.bca_reset_button.Name = "bca_reset_button"
        Me.bca_reset_button.Size = New System.Drawing.Size(262, 72)
        Me.bca_reset_button.TabIndex = 8
        Me.bca_reset_button.Text = "Reset Question"
        Me.bca_reset_button.UseVisualStyleBackColor = False
        '
        'bca_view_qn_button
        '
        Me.bca_view_qn_button.BackColor = System.Drawing.Color.MidnightBlue
        Me.bca_view_qn_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bca_view_qn_button.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bca_view_qn_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bca_view_qn_button.Location = New System.Drawing.Point(653, 261)
        Me.bca_view_qn_button.Name = "bca_view_qn_button"
        Me.bca_view_qn_button.Size = New System.Drawing.Size(262, 72)
        Me.bca_view_qn_button.TabIndex = 7
        Me.bca_view_qn_button.Text = "View / Update Question"
        Me.bca_view_qn_button.UseVisualStyleBackColor = False
        '
        'bca_set_button
        '
        Me.bca_set_button.BackColor = System.Drawing.Color.MidnightBlue
        Me.bca_set_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bca_set_button.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bca_set_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bca_set_button.Location = New System.Drawing.Point(653, 138)
        Me.bca_set_button.Name = "bca_set_button"
        Me.bca_set_button.Size = New System.Drawing.Size(262, 72)
        Me.bca_set_button.TabIndex = 6
        Me.bca_set_button.Text = "Set Questions"
        Me.bca_set_button.UseVisualStyleBackColor = False
        '
        'Back_Button
        '
        Me.Back_Button.BackColor = System.Drawing.Color.MidnightBlue
        Me.Back_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Back_Button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Back_Button.Location = New System.Drawing.Point(725, 484)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(114, 40)
        Me.Back_Button.TabIndex = 100
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseCompatibleTextRendering = True
        Me.Back_Button.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 100)
        Me.Panel1.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(253, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 54)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "BCA QUESTION PANEL"
        '
        'Bca_qn_set
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.Entrance_.My.Resources.Resources.COMP3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.bca_reset_button)
        Me.Controls.Add(Me.bca_view_qn_button)
        Me.Controls.Add(Me.bca_set_button)
        Me.Name = "Bca_qn_set"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bca_qn_set"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bca_reset_button As Button
    Friend WithEvents bca_view_qn_button As Button
    Friend WithEvents bca_set_button As Button
    Friend WithEvents Back_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
