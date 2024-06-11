Imports System.Data.SqlClient

Public Class Bph_report
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Report_Select_Faculty.Show()
        Me.Close()
    End Sub

    Private Sub Bph_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter(" select tbl_login_student.login_id,tbl_login_student.student_name,tbl_report.result
                                            from tbl_login_student
                                            inner join tbl_report on tbl_login_student.login_id = tbl_report.login_id where tbl_report.faculty = 'BPH'  ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        BPH_view.DataSource = table
    End Sub

End Class