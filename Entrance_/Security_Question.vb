Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Security_Question
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    ReadOnly adapter As New SqlDataAdapter(command)
    Dim datareader As SqlDataReader
    ReadOnly table As New DataTable()
    Private Sub Submit_button_Click(sender As Object, e As EventArgs) Handles Submit_button.Click
        command.Connection = connection
        command.CommandText = "Select security_question, security_answer from tbl_admin where security_question = '" & SecurityQues_textbox.Text & "'and security_answer = '" & Securityans_TextBox.Text & "' "

        adapter.Fill(table)
        If table.Rows.Count = 0 Then
            MessageBox.Show("Wrong Answer !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("Correct Answer ! You can change your Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Admin_Change_password.Show()
            Me.Close()
        End If

    End Sub



    Private Sub Security_Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        command.Connection = connection
        command.CommandText = "Select security_question from tbl_admin"
        datareader = command.ExecuteReader
        If datareader.Read() Then
            SecurityQues_textbox.Text = datareader.GetValue(0).ToString()
        End If
        connection.Close()

    End Sub

    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        Me.Hide()
        Admin_Login_Panel.Show()
    End Sub

End Class