<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admit_card
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admit_card))
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Print_button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name_textbox = New System.Windows.Forms.TextBox()
        Me.f_name = New System.Windows.Forms.Label()
        Me.Id_textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Faculty_textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Contact_Textbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.BackColor = System.Drawing.Color.Gold
        Me.Back_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.Back_Button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.Location = New System.Drawing.Point(108, 515)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(114, 40)
        Me.Back_Button.TabIndex = 95
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseCompatibleTextRendering = True
        Me.Back_Button.UseVisualStyleBackColor = False
        '
        'Print_button
        '
        Me.Print_button.BackColor = System.Drawing.Color.LightGreen
        Me.Print_button.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Print_button.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print_button.Location = New System.Drawing.Point(729, 515)
        Me.Print_button.Name = "Print_button"
        Me.Print_button.Size = New System.Drawing.Size(114, 40)
        Me.Print_button.TabIndex = 96
        Me.Print_button.Text = "Print"
        Me.Print_button.UseCompatibleTextRendering = True
        Me.Print_button.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(395, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 50)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Admit Card"
        '
        'Name_textbox
        '
        Me.Name_textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name_textbox.Location = New System.Drawing.Point(404, 238)
        Me.Name_textbox.Name = "Name_textbox"
        Me.Name_textbox.ReadOnly = True
        Me.Name_textbox.Size = New System.Drawing.Size(321, 29)
        Me.Name_textbox.TabIndex = 99
        '
        'f_name
        '
        Me.f_name.AutoSize = True
        Me.f_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.f_name.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.f_name.Location = New System.Drawing.Point(233, 247)
        Me.f_name.Name = "f_name"
        Me.f_name.Size = New System.Drawing.Size(152, 20)
        Me.f_name.TabIndex = 98
        Me.f_name.Text = "Applicant Name :"
        '
        'Id_textbox
        '
        Me.Id_textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Id_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Id_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Id_textbox.Location = New System.Drawing.Point(404, 179)
        Me.Id_textbox.Name = "Id_textbox"
        Me.Id_textbox.ReadOnly = True
        Me.Id_textbox.Size = New System.Drawing.Size(321, 29)
        Me.Id_textbox.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(268, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Applicant ID:"
        '
        'Faculty_textbox
        '
        Me.Faculty_textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Faculty_textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Faculty_textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faculty_textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Faculty_textbox.Location = New System.Drawing.Point(404, 357)
        Me.Faculty_textbox.Name = "Faculty_textbox"
        Me.Faculty_textbox.ReadOnly = True
        Me.Faculty_textbox.Size = New System.Drawing.Size(321, 29)
        Me.Faculty_textbox.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(223, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Applicant Faculty :"
        '
        'Contact_Textbox
        '
        Me.Contact_Textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Contact_Textbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Contact_Textbox.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_Textbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Contact_Textbox.Location = New System.Drawing.Point(404, 302)
        Me.Contact_Textbox.Name = "Contact_Textbox"
        Me.Contact_Textbox.ReadOnly = True
        Me.Contact_Textbox.Size = New System.Drawing.Size(321, 29)
        Me.Contact_Textbox.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(219, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Applicant Contact :"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Admit_card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 594)
        Me.Controls.Add(Me.Contact_Textbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Faculty_textbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Id_textbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Name_textbox)
        Me.Controls.Add(Me.f_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Print_button)
        Me.Controls.Add(Me.Back_Button)
        Me.Name = "Admit_card"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admit_card"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Print_button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Name_textbox As TextBox
    Friend WithEvents f_name As Label
    Friend WithEvents Id_textbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Faculty_textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Contact_Textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
