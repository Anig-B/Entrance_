Imports System.Data.SqlClient

Public Class BBA_Report
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Report_Select_Faculty.Show()
        Me.Close()
    End Sub

    Private Sub Bba_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter(" select tbl_login_student.login_id,tbl_login_student.student_name,tbl_report.result
                                            from tbl_login_student
                                            inner join tbl_report on tbl_login_student.login_id = tbl_report.login_id where tbl_report.faculty = 'BBA'  ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        BBA_view.DataSource = table
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs)
        command.Connection = connection
        command.CommandText = "Delete tbl_report where faculty = 'BBA' "
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim result As DialogResult = MessageBox.Show("All Result data will be deleted. Do you want to delete all ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (result = DialogResult.Yes) Then
            command.ExecuteNonQuery()
            Bba_report_Load(sender, e)
        End If
    End Sub
End Class