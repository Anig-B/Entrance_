Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Channels

Public Class Student_login_panel
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command, command2 As New SqlCommand
    ReadOnly adapter As New SqlDataAdapter(command2)
    ReadOnly table As New DataTable()
    'Dim datareader As SqlDataReader
    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles Login_button.Click

        'Try
        command2.Connection = connection
        command2.CommandText = "Select student_id,student_faculty,student_firstname + ' ' + student_middlename + ' ' + student_lastname  from student_record where student_id = '" & UserID_textbox.Text & "' and student_faculty='" & faculty_dropbox.Text & "' and student_firstname + ' ' + student_lastname = '" & Name_texbox.Text & "' or  student_firstname + ' ' + student_middlename + ' ' + student_lastname ='" & Name_texbox.Text & "' "
        adapter.Fill(table)
        If table.Rows.Count <> 0 Then
            If Check_login() = False Then
                Exit Sub
            Else
                'MessageBox.Show("Welcome!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                command2.ExecuteNonQuery()
                connection.Close()
                Select Case faculty_dropbox.Text
                    Case "BCA"
                        MessageBox.Show("Examination will finished in 10 mins. Timer will be running in the screen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If (DialogResult.OK) Then
                            Me.Close()
                            BCA_Exam_Panel.Show()
                        End If

                    Case "BBA"
                        MessageBox.Show("Examination will finished in 10 mins. Timer will be running in the screen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If (DialogResult.OK) Then
                            Me.Close()
                            BBA_Exam_Panel.Show()
                        End If
                    Case "BPH"
                        MessageBox.Show("Examination will finished in 10 mins. Timer will be running in the screen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If (DialogResult.OK) Then
                            Me.Close()
                            BPH_Exam_Panel.Show()
                        End If
                End Select
            End If
        Else
            MessageBox.Show("Applicant ID, Name or Faculty donot Match! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'Catch ex As Exception
        '    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        connection.Close()
    End Sub

    Private Function Check_login() As Boolean
        Try
            command.Connection = connection
            'command.CommandText = "Select tbl_login login_id, student_name from  where login_id = '" & UserID_textbox.Text & "','" & Name_texbox.Text & "' "
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            command.CommandText = "insert into tbl_login_student values ( '" & UserID_textbox.Text & "',  '" & Name_texbox.Text & "') "
            command.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Applicant Already Logged In!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Select_mode.Show()
            Return False
            'InitializeComponent()
        End Try
        connection.Close()
    End Function

    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        Me.Close()
        Select_mode.Show()
    End Sub
End Class


