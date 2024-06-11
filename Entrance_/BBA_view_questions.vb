Imports System.Data.SqlClient

Public Class BBA_view_questions
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub BBA_view_questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT * from tbl_bba_question ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        BBA_Question_view.DataSource = table
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        BBA_Question_Panel.Show()

    End Sub
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update_bba_table.Click
        Dim i As Integer = BBA_Question_view.CurrentRow.Index
        command.Connection = connection
        command.CommandText = "update tbl_bba_question set question = '" & BBA_Question_view.Item(1, i).Value & "',
option_1 ='" & BBA_Question_view.Item(2, i).Value & "',option_2 ='" & BBA_Question_view.Item(3, i).Value & "',
option_3 ='" & BBA_Question_view.Item(4, i).Value & "',option_4='" & BBA_Question_view.Item(5, i).Value & "',
answer='" & BBA_Question_view.Item(6, i).Value & "' where question_id ='" & BBA_Question_view.Item(0, i).Value & "'"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command.ExecuteNonQuery()
        connection.Close()
        BBA_view_questions_Load(sender, e)
    End Sub
End Class