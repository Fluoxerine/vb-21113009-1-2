Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim s As String = "Hello,World!"
    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        Label1.Text = Mid(s, 1, i) & "_"
        If i = Len(s) Then i = 0
    End Sub
End Class
