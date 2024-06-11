Imports System.Data.SqlClient
Imports System.Threading
Imports System.Collections.ObjectModel
Imports System.Data.Common

Public Class BPH_Exam_Panel
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Dim datareader As SqlDataReader
    Dim count, h, m, s As Integer
    Dim answer(10) As Char

    Public Sub Next_question(ByVal i As Integer) 'prcedure to display questions from database
        command.Connection = connection
        command.CommandText = "Select * from tbl_bph_question where question_id = " & i & ""
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        datareader = command.ExecuteReader
        If datareader.Read() Then
            Qn_nobox.Text = datareader("question_id").ToString()
            Question_box.Text = datareader("question").ToString()
            Opt_box1.Text = datareader("option_1").ToString()
            Opt_box2.Text = datareader("option_2").ToString()
            Opt_box3.Text = datareader("option_3").ToString()
            Opt_box4.Text = datareader("option_4").ToString()
        End If
        connection.Close()
    End Sub
    Private Sub bph_Exam_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Previous_button.Visible = False
        Next_question(count + 1)
        Timer.Start()
    End Sub

    Private Sub Get_answer(ByVal get_answer) 'procedure to assign checked radio button value 
        If get_answer = "A" Then
            RadioButton1.Checked = True
        ElseIf get_answer = "B" Then
            RadioButton2.Checked = True
        ElseIf get_answer = "C" Then
            RadioButton3.Checked = True
        ElseIf get_answer = "D" Then
            RadioButton4.Checked = True
        End If
    End Sub

    Private Sub Next_button_Click(sender As Object, e As EventArgs) Handles Next_button.Click
        Previous_button.Visible = True
        Dim selected_answer As String = ""
        If RadioButton1.Checked = True Then selected_answer = "A"
        If RadioButton2.Checked = True Then selected_answer = "B"
        If RadioButton3.Checked = True Then selected_answer = "C"
        If RadioButton4.Checked = True Then selected_answer = "D"

        If answer(count + 1) = vbNullChar Then
            answer(count) = selected_answer
            If count <= 9 Then
                count += 1
                If count = 10 Then
                    GoTo Label
                End If
                Next_question(count + 1)
            Else
Label:
                Next_button.Visible = False
                Previous_button.Visible = False

                Submit.Visible = True

            End If
        Else
            answer(count) = selected_answer
            count += 1
            Next_question(count + 1)
            Get_answer(answer(count))
        End If
    End Sub


    Private Sub Previous_button_Click(sender As Object, e As EventArgs) Handles Previous_button.Click
        Dim selected_answer As String = ""
        If RadioButton1.Checked = True Then selected_answer = "A"
        If RadioButton2.Checked = True Then selected_answer = "B"
        If RadioButton3.Checked = True Then selected_answer = "C"
        If RadioButton4.Checked = True Then selected_answer = "D"

        If count = 0 Then
            Previous_button.Visible = False
            Exit Sub
        End If

        If count <= 9 Then
            answer(count) = selected_answer
            Next_question(count)
            Get_answer(answer(count - 1))
            count -= 1
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Timer.Stop()
        command.Connection = connection
        For i = 0 To 9
            connection.Open()
            command.CommandText = "Insert into tbl_answer values('" & answer(i) & "','" & 1 & "')"
            command.ExecuteNonQuery()
            connection.Close()
        Next
        Calculate_marks()
        count = 0
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        TimerBox.Text = Format(h, "00:") & Format(m, "00:") & Format(s, "00")
        s += 1
        If s > 59 Then
            s = 0
            m += 1
            If m = 10 Then
                Timer.Stop()
                MessageBox.Show("Time Ended !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Submit_Click(sender, e)
            End If
        End If
    End Sub

    Sub Calculate_marks() ' procedure to calculate marks and insert into result table in databse
        Dim marks As Integer
        Dim login_id As Integer

        command.CommandText = "select sum(marks) from tbl_answer
                               inner join tbl_bph_question on tbl_answer.answer_id = tbl_bph_question.question_id 
                               where tbl_answer.selected_answer = tbl_bph_question.answer "
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        If command.ExecuteScalar Is DBNull.Value Then
            marks = 0
        Else
            marks = CInt(command.ExecuteScalar)
            connection.Close()
        End If

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command.CommandText = "select top 1 login_id from tbl_login_student order by id desc"
        login_id = CInt(command.ExecuteScalar)

        'command.CommandText = "Insert into tbl_result values(login_id,marks,faculty)('" & marks & "')"
        'command.ExecuteNonQuery()

        If marks > 5 Then
            command.CommandText = "insert into tbl_report values('" & login_id & "','Pass','BPH')"
            command.ExecuteNonQuery()
            MessageBox.Show("Calculating Result!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Thread.Sleep(500)
            Pass_form.Show()
            Me.Close()

        Else
            command.CommandText = "insert into tbl_report values('" & login_id & "','Fail','BPH')"
            command.ExecuteNonQuery()
            MessageBox.Show("Calculating Result!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Thread.Sleep(500)
            Fail_form.Show()
            Me.Close()
        End If
        ' Reset()
        connection.Close()
    End Sub

    'Sub Reset()
    '    command.CommandText = "Truncate table tbl_answer"
    '    command.ExecuteNonQuery()
    'End Sub

End Class



' Dim last_question As Integer
'command.CommandText = "Select max(question_id) from tbl_bca_question"
'connection.Open()
'If command.ExecuteScalar Is DBNull.Value Then
'    last_question = 1
'Else
'    last_question = CInt(command.ExecuteScalar)
'    connection.Close()
'End If


