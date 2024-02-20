Public Class NewCutterSet_Form
    Private Sub txtNewCutSet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewCutSet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Form1.txtCutterSet.Text = txtNewCutSet.Text
        Me.Close()
        Function_Module.PurgeAfterOCAP()
    End Sub

    Private Sub NewCutterSet_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewCutSet.Focus()
        Dim txtCenter As Point = txtNewCutSet.PointToScreen(New Point(txtNewCutSet.Width \ 2, txtNewCutSet.Height \ 2))

        Cursor.Position = txtCenter
    End Sub
End Class