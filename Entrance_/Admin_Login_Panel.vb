
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes


Public Class Admin_Login_Panel
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    ReadOnly adapter As New SqlDataAdapter(command)
    ReadOnly table As New DataTable()

    Sub reset()
        UserID_box.Text = ""
        pass_box.Text = ""
    End Sub
    Private Sub Passkey_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Passkey_checkbox.CheckedChanged
        If pass_box.UseSystemPasswordChar = True Then
            'hide password
            pass_box.UseSystemPasswordChar = False
        Else
            'show password
            pass_box.UseSystemPasswordChar = True
        End If
    End Sub

    'Login Button
    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles Login_button.Click

        command.Connection = connection
            command.CommandText = "Select admin_userid, admin_password from tbl_admin where admin_userid = '" & UserID_box.Text & "'and admin_password = '" & pass_box.Text & "' "
        adapter.Fill(table)
        If table.Rows.Count <> 0 Then
            MessageBox.Show("Logged In", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim newForm As New Admin_Panel
            newForm.Show()
            Me.Close()

        Else
            MessageBox.Show("Invalid Username Or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Button_changepass.Visible = True
                End If


    End Sub

    Private Sub Button_changepass_Click(sender As Object, e As EventArgs) Handles Button_changepass.Click

        Security_Question.Show()
        Me.Close()
    End Sub


    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        Me.Hide()
        Select_mode.Show()
    End Sub

    Private Sub Admin_Login_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub


End Class