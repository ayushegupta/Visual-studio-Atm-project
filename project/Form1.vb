Imports System.Data.SqlClient
Public Class Form1
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim maxrows As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source = DESKTOP-2MC5PLE; Initial Catalog = atm;Integrated Security=True")
        'MsgBox("Connection Established")
        con.Open()
        sql = "Select * from Login"
        da = New SqlDataAdapter(sql, con)
        da.Fill(ds, "atm")
        maxrows = ds.Tables("atm").Rows.Count
    End Sub
    Private Sub Button_clear_Click_1(sender As Object, e As EventArgs) Handles Button_clear.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button_cancel_Click(sender As Object, e As EventArgs) Handles Button_cancel.Click
        Form3.Show()
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Button_ok_Click(sender As Object, e As EventArgs) Handles Button_ok.Click
        Dim searchID, i, currentrow As Integer
        searchID = TextBox1.Text
        i = 0
        While i <> maxrows
            If searchID = ds.Tables("atm").Rows(i)("pin_no") Then
                Me.Close()
                Form4.Label4.Text = ds.Tables("atm").Rows(i)("acc_no")
                Form4.Label5.Text = ds.Tables("atm").Rows(i)("name")
                Form5.Label7.Text = ds.Tables("atm").Rows(i)("acc_no")
                Form5.Label6.Text = ds.Tables("atm").Rows(i)("name")
                Form6.Label4.Text = ds.Tables("atm").Rows(i)("acc_no")
                Form6.Label5.Text = ds.Tables("atm").Rows(i)("name")
                Form4.Show()
                Exit While

            ElseIf i = maxrows - 1 Then
                MsgBox("INVALID PIN Number !!")
                Exit While

            End If
            i += 1
        End While
        currentrow = i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click
        MsgBox("Contact @999***9999")
    End Sub

End Class