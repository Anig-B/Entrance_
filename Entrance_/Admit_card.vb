Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Admit_card
    ReadOnly connection As New SqlConnection("Data Source =RYU\SQLEXPRESS ; Initial catalog = Entrance_test; Integrated Security = True")
    ReadOnly command As New SqlCommand
    Dim datareader As SqlDataReader
    ' Dim g, mg As Graphics
    ' Dim bmp As Bitmap

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click

        Student_Register.Show()
        Me.Close()
    End Sub

    Private Sub Admit_card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        command.Connection = connection
        command.CommandText = "SELECT * FROM student_record WHERE student_id=(SELECT max(student_id) FROM student_record);"
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        datareader = Command.ExecuteReader
        If datareader.Read() Then
            Id_textbox.Text = datareader("student_id").ToString()
            Name_textbox.Text = (datareader("student_firstname") + " " + datareader("student_middlename") + " " + datareader("student_lastname")).ToString()
            Faculty_textbox.Text = datareader("student_faculty").ToString()
            Contact_Textbox.Text = datareader("student_contact").ToString()
        End If
        connection.Close()
    End Sub

    Private Sub Print_button_Click(sender As Object, e As EventArgs) Handles Print_button.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Entrance Card", 500, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Show()
        '  PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Entrance Card", New Font("Rockwell", 14, FontStyle.Bold), Brushes.Black, New PointF(170, 50))
        e.Graphics.DrawString("Applicant ID :" + Id_textbox.Text, New Font("Rockwell", 12), Brushes.Black, New PointF(140, 100))
        e.Graphics.DrawString("Applicant Name :" + Name_textbox.Text, New Font("Rockwell", 12), Brushes.Black, New PointF(140, 120))
        e.Graphics.DrawString("Applicant Contact :" + Contact_Textbox.Text, New Font("Rockwell", 12), Brushes.Black, New PointF(140, 140))
        e.Graphics.DrawString("Applicant Faculty :" + Faculty_textbox.Text, New Font("Rockwell", 12), Brushes.Black, New PointF(140, 160))
        e.Graphics.DrawString("Entrance Date: July 13, 2023 ", New Font("Rockwell", 14, FontStyle.Bold), Brushes.Black, New PointF(140, 180))
    End Sub
End Class