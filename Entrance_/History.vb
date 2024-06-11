Imports System.Data.SqlClient

Public Class History
    ReadOnly connection As New SqlConnection("Data Source = RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Dim datareader As SqlDataReader
    Dim table As New DataTable
    Sub Reset()
        command.CommandText = "Truncate table tbl_answer"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Reset()
        Main_Panel.Show()
        Me.Close()
    End Sub
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim faculty As String = ""
        command.Connection = connection
        'command.CommandText = "select faculty from tbl_report where login_id = (select top 1 login_id from tbl_report )"
        command.CommandText = "SELECT faculty FROM tbl_report WHERE login_id not in (SELECT TOP (SELECT COUNT(1)-1  FROM tbl_report)  login_id FROM tbl_report)"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        datareader = command.ExecuteReader
        If datareader.Read() Then
            faculty = datareader("faculty").ToString()
        End If
        connection.Close()
        TextBox.Text = faculty

        Select Case faculty

            Case "BCA"
                Dim adapter As New SqlDataAdapter(" select  tbl_bca_question.question ,tbl_bca_question.answer,tbl_answer.selected_answer from tbl_bca_question
                         inner join tbl_answer on tbl_answer.answer_id = tbl_bca_question.question_id ", connection)
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                adapter.Fill(table)
                BCA_History.DataSource = table
                connection.Close()

            Case "BBA"
                Dim adapter As New SqlDataAdapter(" select tbl_bba_question.question,tbl_bba_question.answer,tbl_answer.selected_answer from tbl_bba_question
                         inner join tbl_answer on tbl_answer.answer_id = tbl_bba_question.question_id ", connection)
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                adapter.Fill(table)
                BCA_History.DataSource = table
                connection.Close()

            Case "BPH"
                Dim adapter As New SqlDataAdapter(" select  tbl_bph_question.question ,tbl_bph_question.answer,tbl_answer.selected_answer from tbl_bph_question
                         inner join tbl_answer on tbl_answer.answer_id = tbl_bph_question.question_id ", connection)
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                adapter.Fill(table)
                BCA_History.DataSource = table
                connection.Close()
        End Select
    End Sub


End Class