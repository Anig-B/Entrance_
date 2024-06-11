Imports System.Data.SqlClient

Public Class Fail_form
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Sub Reset()
        command.Connection = connection
        command.CommandText = "Truncate table tbl_answer"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        Reset()
        Main_Panel.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        History.Show()
        Me.Close()
    End Sub
End Class