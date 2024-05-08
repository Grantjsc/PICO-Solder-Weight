Public Class SameLot_Form
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        SamelotNo()
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        SamelotYes()
        Me.Close()
    End Sub
End Class