Public Class HomePage
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Hide()
            PlayervsComputer.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Hide()
            PlayervsPlayer.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Chr(153) & "Created by Mornante' Basson"
    End Sub
End Class
