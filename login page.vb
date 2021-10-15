Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "system" And TextBox2.Text = "system" Then
            MsgBox("log in successfully!", MsgBoxStyle.OkOnly, "log in form")


        Else
            MsgBox("sorry incorect username and password", MsgBoxStyle.OkOnly, "invalid")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ad
    End Sub
End Class
