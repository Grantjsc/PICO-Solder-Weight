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

    Private Sub txtNewCutSet_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub
End Class