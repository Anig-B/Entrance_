Imports System.Data.SqlClient

Public Class BBA_Question_Panel
    ReadOnly connection As New SqlConnection("Data Source =DEVIL\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub Bca_set_button_Click(sender As Object, e As EventArgs) Handles bba_set_button.Click
        Me.Hide()
        BBA_set_question.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Select_Faculty.Show()
    End Sub

    Private Sub Bca_view_qn_button_Click(sender As Object, e As EventArgs) Handles bba_view_qn_button.Click
        Me.Hide()
        BBA_view_questions.Show()
    End Sub
    Sub Reset()
        command.Connection = connection
        command.CommandText = "Truncate table tbl_bba_question "
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Bba_reset_button_Click(sender As Object, e As EventArgs) Handles bba_reset_button.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to reset the question set?",
                              "Warning",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If (result = DialogResult.Yes) Then
            Reset()
            MessageBox.Show("Question has been reset ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BBA_view_questions.Close()
            BBA_set_question.Close()

        End If

    End Sub
End Class