Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class BCA_Question_Panel
    ReadOnly connection As New SqlConnection("Data Source = RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub bca_set_button_Click(sender As Object, e As EventArgs) Handles bca_set_button.Click
        Me.Hide()
        bca_set_question.Show()
    End Sub

    Private Sub bca_view_qn_button_Click(sender As Object, e As EventArgs) Handles bca_view_qn_button.Click
        Me.Hide()
        BCA_view_questions.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Select_Faculty.Show()
    End Sub
    Sub Reset()
        Command.Connection = connection
        command.CommandText = "Truncate table tbl_bca_question "
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub bca_reset_button_Click(sender As Object, e As EventArgs) Handles bca_reset_button.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to reset the question set?",
                              "Warning",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If (result = DialogResult.Yes) Then
            Reset()
            MessageBox.Show("Question has been reset ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BCA_view_questions.Close()
            bca_set_question.Close()
        End If

    End Sub
End Class