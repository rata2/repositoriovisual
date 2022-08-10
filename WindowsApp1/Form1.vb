Public Class Form1
    Private Sub texto1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub salir1_Click(sender As Object, e As EventArgs) Handles salir1.Click
        End
    End Sub

    Private Sub texto2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub salir2_Click(sender As Object, e As EventArgs) Handles salir2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles texto1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles texto2.Click

    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub
End Class
