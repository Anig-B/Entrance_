Imports System.Data.SqlClient

Public Class BCA_set_question
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand


    Sub Reset()
        Question_textbox.Text = ""
        Opt_box1.Text = ""
        Opt_box2.Text = ""
        Opt_box3.Text = ""
        Opt_box4.Text = ""
    End Sub
    Private Sub Setquestion_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim question_id As Integer
        Dim command As New SqlCommand With {
       .Connection = connection,
       .CommandText = "Select max(question_id) from tbl_bca_question"}
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If command.ExecuteScalar Is DBNull.Value Then
            question_id = 0
            Qn_no_textbox.Text = CInt(question_id + 1)
        Else
            question_id = CInt(command.ExecuteScalar)
            If question_id = 10 Then
                MessageBox.Show("Questions has been set!! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BCA_Question_Panel.Show()
                Me.Close()
            End If
            Qn_no_textbox.Text = CInt(question_id + 1)
            connection.Close()
        End If
    End Sub

    Private Sub Submit_button_Click(sender As Object, e As EventArgs) Handles Submit_button.Click
        command.Connection = connection
        Dim correct_answer As String = "A"
        If Opt1_RadioButton.Checked = True Then
            correct_answer = "A"
        ElseIf Opt2_RadioButton.Checked = True Then
            correct_answer = "B"
        ElseIf Opt3_RadioButton.Checked = True Then
            correct_answer = "C"
        ElseIf Opt2_RadioButton.Checked = True Then
            correct_answer = "D"
        End If
        command.CommandText = "insert into tbl_bca_question values('" & Question_textbox.Text & "','" & Opt_box1.Text & "','" & Opt_box2.Text & "','" & Opt_box3.Text & "','" & Opt_box4.Text & "','" & correct_answer & "')"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If Question_textbox.Text = "" Or Opt_box1.Text = "" Or Opt_box2.Text = "" Or Opt_box3.Text = "" Or Opt_box4.Text = "" Or correct_answer = "" Then
            MessageBox.Show("Please Fill the Designated Area!! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf command.ExecuteNonQuery = 1 Then
            ' MessageBox.Show("Question has been set!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
            connection.Close()
            Setquestion_Panel_Load(sender, e)
        Else
            MessageBox.Show("Question has not been set! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        connection.Close()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        BCA_Question_Panel.Show()
    End Sub

    Private Sub Question_textbox_TextChanged(sender As Object, e As EventArgs) Handles Question_textbox.TextChanged

    End Sub
End Class