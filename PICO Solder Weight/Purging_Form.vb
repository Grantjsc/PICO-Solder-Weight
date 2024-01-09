Public Class Purging_Form
    Private Sub TimerPurging_Tick(sender As Object, e As EventArgs) Handles TimerPurgingAndSamples.Tick
        Function_Module.PurgeAndCutSamples()
    End Sub

    Private Sub TimerCutSamples_Tick(sender As Object, e As EventArgs) Handles TimerCutSamples.Tick
        Function_Module.CutSamples()
    End Sub
End Class