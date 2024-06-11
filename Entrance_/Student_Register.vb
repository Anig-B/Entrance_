Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Threading

Public Class Student_Register
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    Sub Reset()
        firstname_textbox.Text = ""
        midname_textbox.Text = ""
        lastname_textbox.Text = ""
        address_textbox.Text = ""
        contact_textbox.Text = ""
    End Sub
    Private Sub Submit_button_Click(sender As Object, e As EventArgs) Handles Submit_button.Click


        Dim command As New SqlCommand With {
        .Connection = connection}
        Dim gender As String = "others"

        If Male_RadioButton.Checked = True Then
            gender = "Male"
        ElseIf Female_RadioButton.Checked = True Then
            gender = "Female"
        End If
        command.CommandText = "Insert into student_record values('" & firstname_textbox.Text & "','" & midname_textbox.Text & "','" & lastname_textbox.Text & "','" & contact_textbox.Text & "','" & address_textbox.Text & "','" & faculty_dropbox.Text & "','" & gender & "','" & DateTimePicker.Text & "')"
        connection.Open()
        If firstname_textbox.Text = "" Or lastname_textbox.Text = "" Or contact_textbox.Text = "" Or address_textbox.Text = "" Or gender = "" Then
            MessageBox.Show("Student Data Not Registered! Please Fill the designated Area!!")

        ElseIf command.ExecuteNonQuery = 1 Then
            MessageBox.Show("Student Registered")
            Me.Hide()
            Admit_card.Show()
            Reset()
        Else
            MessageBox.Show("Student Data Not Registered!")
        End If
        connection.Close()
    End Sub

    Private Sub Reset_button_Click(sender As Object, e As EventArgs) Handles Reset_button.Click
        Reset()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Admin_Panel.Show()
    End Sub


End Class

'Dim firstname, middlename, lastname, contact, address, faculty, gender As String
'firstname = firstname_textbox.Text
'middlename = midname_textbox.Text
'lastname = lastname_textbox.Text
'contact = contact_textbox.Text
'address = address_textbox.Text

'Assigning Gender

