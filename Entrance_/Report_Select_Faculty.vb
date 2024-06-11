Imports System.Data.SqlClient

Public Class Report_Select_Faculty
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub BCA_PictureBox_Click(sender As Object, e As EventArgs) Handles BCA_PictureBox.Click
        Me.Hide()
        Bca_report.Show()
    End Sub

    Private Sub BBA_PictureBox_Click(sender As Object, e As EventArgs) Handles BBA_PictureBox.Click
        Me.Hide()
        Bba_report.Show()
    End Sub

    Private Sub BPH_PictureBox_Click(sender As Object, e As EventArgs) Handles BPH_PictureBox.Click
        Me.Hide()
        Bph_report.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Admin_Panel.Show()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        command.Connection = connection
        command.CommandText = "truncate table tbl_report"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim result As DialogResult = MessageBox.Show("All Result data will be deleted. Do you want to delete all ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (result = DialogResult.Yes) Then
            Command.ExecuteNonQuery()
            connection.Close()
        End If
    End Sub


End Class