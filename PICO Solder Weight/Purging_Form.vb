Imports System.Threading

Public Class Purging_Form
    Private Sub TimerPurging_Tick(sender As Object, e As EventArgs) Handles TimerPurgingAndSamples.Tick
        Function_Module.PurgeAndCutSamples()
    End Sub

    Private Sub TimerCutSamples_Tick(sender As Object, e As EventArgs) Handles TimerCutSamples.Tick
        Function_Module.CutSamples()
    End Sub

    Private Sub btnStartCut_Click(sender As Object, e As EventArgs) Handles btnStartCut.Click
        SolderCutter_Form.to_PLC("@00WD00050000")
        Thread.Sleep(500)
        SolderCutter_Form.to_PLC("@00WD00050010")
    End Sub

    Private Sub btnCutSample_Click(sender As Object, e As EventArgs) Handles btnCutSample.Click
        SolderCutter_Form.to_PLC("@00WD00060000")
        Thread.Sleep(500)
        SolderCutter_Form.to_PLC("@00WD00060010")
    End Sub
End Class