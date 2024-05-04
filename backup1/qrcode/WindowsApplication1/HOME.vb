Public Class HOME

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim scanner As New qrscanning
        qrscanning.Show()
        Me.Hide()
    End Sub
End Class