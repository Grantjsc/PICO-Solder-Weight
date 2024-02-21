Public Class askInterruption_Form
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        InterruptionYes()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        InterruptionNo()
    End Sub
End Class