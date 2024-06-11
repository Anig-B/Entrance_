Public Class Select_mode
    Private Sub Admin_PictureBox_Click(sender As Object, e As EventArgs) Handles Admin_PictureBox.Click
        Me.Hide()
        Admin_Login_Panel.Show()
    End Sub

    Private Sub Student_PictureBox_Click(sender As Object, e As EventArgs) Handles Student_PictureBox.Click
        Me.Hide()
        Student_login_panel.Show()

    End Sub
End Class