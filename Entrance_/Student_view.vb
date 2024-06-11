Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Student_view
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub Student_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT * from student_record", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        Applicant_view.DataSource = table
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Admin_Panel.Show()
        Me.Close()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        command.Connection = connection
        command.CommandText = "Delete student_record"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim result As DialogResult = MessageBox.Show("All Applicant Records will be deleted. Do you want to delete all ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (result = DialogResult.Yes) Then
            command.ExecuteNonQuery()
            Student_view_Load(sender, e)
        End If
    End Sub


    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim i As Integer = Applicant_view.CurrentRow.Index
        command.Connection = connection
        command.CommandText = "delete student_record where student_id ='" & Applicant_view.Item(0, i).Value & "' "
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim result As DialogResult = MessageBox.Show("Selected Applicant Records will be deleted. Do you want to delete it ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (result = DialogResult.Yes) Then
            command.ExecuteNonQuery()
            Student_view_Load(sender, e)
        End If
    End Sub
End Class

