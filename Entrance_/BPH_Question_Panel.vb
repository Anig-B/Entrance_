Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class BPH_Question_Panel
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub Bph_set_button_Click(sender As Object, e As EventArgs) Handles bph_set_button.Click
        Me.Hide()
        Bph_set_question.Show()
    End Sub

    Private Sub Bph_view_qn_button_Click(sender As Object, e As EventArgs) Handles bph_view_qn_button.Click

        BPH_view_questions.Show()
        Me.Close()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Select_Faculty.Show()
    End Sub
    Sub Reset()
        command.Connection = connection
        command.CommandText = "Truncate table tbl_bph_question "
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Bph_reset_button_Click(sender As Object, e As EventArgs) Handles bph_reset_button.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to reset the question set?",
                              "Warning",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If (result = DialogResult.Yes) Then
            Reset()
            MessageBox.Show("Question has been reset ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BPH_view_questions.Close()
        End If

    End Sub
End Class