Imports System.Data.SqlClient

Public Class Admin_Change_password
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")

    Private Sub Submit_button_Click(sender As Object, e As EventArgs) Handles Submit_button.Click

        Dim command As New SqlCommand With {
        .Connection = connection,
        .CommandText = "update tbl_admin set admin_password = '" & Reenter_TextBox.Text & "' "}
        connection.Open()
        If Reenter_TextBox.Text.Length < 4 Or Reenter_TextBox.Text.Length > 8 Then
            MessageBox.Show("Password must be between 4 to 8 characters !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            connection.Close()
            Exit Sub
        End If
        If newpass_textbox.Text <> Reenter_TextBox.Text Then
            MessageBox.Show("Password Donot Match !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf command.ExecuteNonQuery = 1 Then
            MessageBox.Show("Password changed!")
            connection.Close()
            Me.Hide()
            Admin_Login_Panel.Show()
        End If
        connection.Close()

    End Sub

    Private Sub Passkey_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Passkey_checkbox.CheckedChanged
        If newpass_textbox.UseSystemPasswordChar = True Then
            'hide password
            newpass_textbox.UseSystemPasswordChar = False
            Reenter_TextBox.UseSystemPasswordChar = False
        Else
            'show password
            newpass_textbox.UseSystemPasswordChar = True
            Reenter_TextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        Admin_Login_Panel.Show()
        Me.Close()
    End Sub
End Class