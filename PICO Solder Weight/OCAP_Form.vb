Public Class OCAP_Form
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        OCAP_Module.OCAPForm_Condition()
    End Sub

    Private Sub cboRootCause_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRootCause.SelectedIndexChanged
        OCAP_Module.RootCauseSelect()
    End Sub

    Private Sub cboAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAction.SelectedIndexChanged
        OCAP_Module.ActionSelect()
    End Sub
End Class