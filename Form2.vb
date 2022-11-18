Public Class Form2
    Dim year As String
    Dim month As String
    Dim day As String
    Dim hour As String
    Dim minutes As String
    Dim second As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "yyyy/mm/dd" Then
            Form1.RichTextBox1.Text = Form1.RichTextBox1.Text + year(Int(Now())) + "/" + month(Int(Now())) + "/" + day(Int(Now()))
        Else

        End If
    End Sub
End Class