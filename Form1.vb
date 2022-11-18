Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim fg As Integer
    Dim richtextbox12 As String
    Dim lengthg As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox1.Location = New Point(6, 4)
        PictureBox3.Location = New Point(Me.Width - 50, 4)
        PictureBox2.Width = Me.Width - 70
        Panel1.Width = Me.Width - 18
        Panel1.Height = Me.Height - 105
        FlowLayoutPanel1.Width = Me.Width - 18
        FlowLayoutPanel1.Height = 35
        RichTextBox1.Height = Panel1.Height - 80
        RichTextBox1.Width = Panel1.Width - 438
        RichTextBox1.Location = New Point(245, 90)
        Panel2.Height = 72
        Panel2.Width = PictureBox2.Width
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("this word pad is a test version, max length just 2147483647!", vbOKOnly, "warning!")
        length_text.Text = RichTextBox1.TextLength()
        fg = 0
        Timer1.Start()
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        Dim a As String
        a = RichTextBox1.TextLength()
        length_text.Text = a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If fg = 0 Then
            fg = 1
            Panel3.Visible = True
            Panel3.Location = New Point(6, 298)
            Dim s As Integer
            Dim d As Integer
            d = 298
            For s = 1 To 414
                s = s + 1
                d = d - 1
                Panel3.Location = New Point(6, d)
            Next s
        Else
            fg = 0
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        End
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
        End If
    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply
        RichTextBox1.Font = FontDialog1.Font
        RichTextBox1.ForeColor = FontDialog1.Color
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text = Nothing
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim filename As String
        Dim f As System.IO.FileStream
        Dim mystream As System.IO.StreamReader
        filename = OpenFileDialog1.FileName
        If Not (filename Is Nothing) Then
            f = New System.IO.FileStream(filename, IO.FileMode.Open, IO.FileAccess.Read)
            mystream = New System.IO.StreamReader(f)
            RichTextBox1.Text = mystream.ReadToEnd()
            mystream.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        about.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim filename As String
        Dim f As System.IO.File
        Dim w As System.IO.StreamWriter
        filename = SaveFileDialog1.FileName
        If Not (filename Is Nothing) Then
            w = f.CreateText(filename)
            w.Write(RichTextBox1.Text)
            w.Close()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RichTextBox1.SelectedText = Nothing Then

        Else
            Clipboard.Clear()
            Clipboard.SetText(RichTextBox1.SelectedText)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.SelectedText = Clipboard.GetText
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RichTextBox1.SelectedText = Nothing Then

        Else
            Clipboard.Clear()
            Clipboard.SetText(RichTextBox1.SelectedText)
            RichTextBox1.SelectedText = ""
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '.---
        RichTextBox1.SelectedText = "•" + RichTextBox1.SelectedText
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '*---
        RichTextBox1.SelectedText = "※" + RichTextBox1.SelectedText
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '#---
        RichTextBox1.SelectedText = "#" + RichTextBox1.SelectedText
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'addtime
        Form2.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        length_text.Text = RichTextBox1.TextLength()
        lengthg = RichTextBox1.TextLength()
    End Sub
End Class
