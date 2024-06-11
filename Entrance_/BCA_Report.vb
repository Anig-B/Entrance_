Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class BCA_Report
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Report_Select_Faculty.Show()
        Me.Close()
    End Sub

    Private Sub Bca_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter(" select tbl_login_student.login_id,tbl_login_student.student_name,tbl_report.result
                                            from tbl_login_student
                                            inner join tbl_report on tbl_login_student.login_id = tbl_report.login_id where tbl_report.faculty = 'BCA'  ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        BCA_view.DataSource = table
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.BCA_view.Width, Me.BCA_view.Height)
        BCA_view.DrawToBitmap(bm, New Rectangle(0, 0, Me.BCA_view.Width, Me.BCA_view.Height))
        e.Graphics.DrawImage(bm, 0, 10)
    End Sub

    Private Sub Print_button_Click(sender As Object, e As EventArgs) Handles Print_button.Click
        'PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Show()
    End Sub

    'Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
    '    command.Connection = connection
    '    command.CommandText = "Delete tbl_report where faculty = 'BCA'"
    '    If connection.State = ConnectionState.Closed Then
    '        connection.Open()
    '    End If
    '    Dim result As DialogResult = MessageBox.Show("All Result data will be deleted. Do you want to delete all ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    '    If (result = DialogResult.Yes) Then
    '        command.ExecuteNonQuery()
    '        Bca_report_Load(sender, e)
    '    End If
    'End Sub
End Class
