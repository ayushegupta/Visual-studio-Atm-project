Imports System.Data.SqlClient
Public Class Form4
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Dim ds As New DataSet
    Dim maxrows As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Form for showing Balance will be added soon.")
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source = DESKTOP-2MC5PLE; Initial Catalog = atm;Integrated Security=True")
        'MsgBox("Connection Established")
        con.Open()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Form for changing pin will be added soon .")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub

 
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
        Application.Exit()

    End Sub


 

End Class