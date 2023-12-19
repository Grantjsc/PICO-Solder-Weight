Public Class SolderCutter_Form
    Private Sub btnC1Start_Click(sender As Object, e As EventArgs) Handles btnC1Start.Click
        Cutter1_Module.C1_ButtonStart()
    End Sub

    Private Sub btnC2Start_Click(sender As Object, e As EventArgs) Handles btnC2Start.Click
        Cutter2_Module.C2_ButtonStart()
    End Sub

    Private Sub btnC3Start_Click(sender As Object, e As EventArgs) Handles btnC3Start.Click
        Cutter3_Module.C3_ButtonStart()
    End Sub

    Private Sub btnC4Start_Click(sender As Object, e As EventArgs) Handles btnC4Start.Click
        Cutter4_Module.C4_ButtonStart()
    End Sub
End Class