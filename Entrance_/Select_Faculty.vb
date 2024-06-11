Public Class Select_Faculty
    Private Sub Bca_PictureBox_Click(sender As Object, e As EventArgs) Handles Bca_PictureBox.Click
        Me.Hide()
        BCA_Question_Panel.Show()
    End Sub

    Private Sub Bph_PictureBox_Click(sender As Object, e As EventArgs) Handles bph_PictureBox.Click
        Me.Hide()
        BPH_Question_Panel.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        BBA_Question_Panel.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Admin_Panel.Show()
    End Sub
End Class