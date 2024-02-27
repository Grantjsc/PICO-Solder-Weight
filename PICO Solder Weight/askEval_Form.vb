Public Class askEval_Form
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        ButtonEval()
        Eval_Form.txtWeight.Visible = True
        Eval_Form.lblWeight.Visible = True
        Eval_Form.Label2.Visible = True
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        ButtonEval()
        Eval_Form.txtWeight.Visible = False
        Eval_Form.lblWeight.Visible = False
        Eval_Form.Label2.Visible = False
    End Sub
End Class