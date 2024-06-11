Imports System.Data.SqlClient
Public Class Admin_Panel
    Private Sub Set_qn_Click(sender As Object, e As EventArgs) Handles Set_qn.Click
        Me.Hide()
        Select_Faculty.Show()

    End Sub

    Private Sub Register_button_Click(sender As Object, e As EventArgs) Handles Register_button.Click
        Me.Hide()
        Student_Register.Show()
    End Sub

    Private Sub Student_info_Click(sender As Object, e As EventArgs) Handles Student_info.Click
        Me.Hide()
        Student_view.Show()

    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Me.Hide()
        Select_mode.Show()
    End Sub

    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        Me.Hide()
        Report_Select_Faculty.Show()
    End Sub
End Class